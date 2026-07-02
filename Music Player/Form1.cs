using ReaLTaiizor;
using WMPLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        //variables set
        readonly private WMPLib.WindowsMediaPlayer wplayer = new();

        HttpClient client = new();

        private static readonly Color accentColor = Color.FromArgb(138, 43, 226); // purple accent — change to taste
        private static readonly Color accentColorLight = Color.FromArgb(90, accentColor); // translucent version for a soft glow

        private static string exeDirectory = Directory.GetCurrentDirectory().ToString();
        private static string debugDirectory = Directory.GetParent(exeDirectory).ToString();
        private static string binDirectory = Directory.GetParent(debugDirectory).ToString();
        private static string baseDirectory = Directory.GetParent(binDirectory).ToString();
        string localFiles = Path.GetFullPath(
              baseDirectory + "\\Music\\"
           );
        string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        private bool metroProgressBar1IsMouseDown;

        private static Image pausePng = Image.FromFile(baseDirectory + "\\Images\\pause.png");

        private static Image playPng = Image.FromFile(baseDirectory + "\\Images\\play.png");

        private static Image emptyPng = Image.FromFile(baseDirectory + "\\Images\\empty.png");
      
        private static Font boldFont = new Font(new FontFamily("Castellar"), 10, FontStyle.Bold);

        public class SongInfo//Class songinfo that gets stored in the listbox
        {
            public string Folder { get; set; }
            public string Album { get; set; }
            public string Lyrics { get; set; }
            public string Title { get; set; }
            public string Writer { get; set; }
            public Image Art { get; set; }
            public int Length { get; set; }

        }

        private async Task<string> Get_Lyrics(string artist, string title)
        {

            string url = $"https://lrclib.net/api/search?track_name={Uri.EscapeDataString(title)}";
            if (artist != "Unknown Artist")
            {
                url += $"&artist_name={Uri.EscapeDataString(artist)}";
            }

            try
            {
                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                return "No Lyrics";
            }
            catch (Exception)
            {
                return "No Lyrics";
            }
        }

        private void Next_Song(ListBox list)
        {
            if (list.SelectedIndex == list.Items.Count - 1)
            {
                list.SelectedIndex = 0;
            }
            else
            {
                list.SelectedIndex += 1;
            }
        }
        private void Previous_Song(ListBox list)
        {
            if (list.SelectedIndex == 0)
            {
                list.SelectedIndex = 0;
            }
            else
            {
                list.SelectedIndex -= 1;
            }
        }

        private async void Play_Song(ListBox list)
        {
            if (list.SelectedItem is SongInfo selectedSong)
            {
                // Handle the selected song
                playButton.Image = pausePng;

                Titlee.Text = selectedSong.Title;
                Artistt.Text = selectedSong.Writer;

                if (selectedSong.Art != null)
                {
                    artBox.Image = selectedSong.Art;
                }
                else
                {
                    artBox.Image = emptyPng;
                }

                // Audio
                string audio = Path.Combine(selectedSong.Folder, selectedSong.Title + ".mp3");

                wplayer.URL = audio;
                await Task.Delay(500).ContinueWith(_ =>
                {
                    this.Invoke(() =>
                    {
                        wplayer.controls.play();
                    });
                });

                // Lyrics
                if (selectedSong.Lyrics != null || selectedSong.Lyrics != "[]")
                {
                    lyricsBox.Text = selectedSong.Lyrics;
                }
                else
                {
                    string lyrics = await Get_Lyrics(selectedSong.Writer, selectedSong.Title);
                    lyricsBox.Text = lyrics;
                    selectedSong.Lyrics = lyrics;
                }
            }
        }

        private void Load_Songs(string path)
        {
            foreach (var mp3 in Directory.EnumerateFiles(path, "*.mp3"))
            {
                var file = TagLib.File.Create(mp3);

                // Writer
                string writer = file.Tag.Composers.Length > 0
                    ? file.Tag.Composers[0]
                    : "Unknown Artist";

                if (songList.Items.Cast<SongInfo>().Any(s => s.Title == Path.GetFileNameWithoutExtension(mp3)) && songList.Items.Cast<SongInfo>().Any(s => s.Writer == writer) || file.MimeType != "taglib/mp3")
                {
                    // Skip if the song is already in the list
                    continue;
                }

                // Title
                string title = Path.GetFileNameWithoutExtension(mp3);

                // Length in seconds
                int length = (int)file.Properties.Duration.TotalSeconds;

                //Album
                string album = file.Tag.Album;

                // Album art
                Image? art = null;
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = file.Tag.Pictures[0].Data.Data;
                    using (var ms = new MemoryStream(bin))
                        art = Image.FromStream(ms);
                }

                // Add the song info to the ListBox
                songList.Items.Add(new SongInfo
                {
                    Folder = path,
                    Length = length,
                    Title = title,
                    Writer = writer,
                    Art = art,
                    Album = album,
                });
            }
        }

        private void Songs_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if (sender is not ListBox list) return;

            var song = (SongInfo)list.Items[e.Index];
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Background fill
            using (var bgBrush = new SolidBrush(list.BackColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

            if (selected)
            {
                // Rounded highlight rectangle, inset slightly from the edges
                Rectangle highlightRect = new Rectangle(
                    e.Bounds.Left + 2,
                    e.Bounds.Top + 2,
                    e.Bounds.Width - 4,
                    e.Bounds.Height - 4
                );
               
                using (var path = RoundedRect(highlightRect, 3))
                using (var fillBrush = new SolidBrush(accentColorLight))
                using (var borderPen = new Pen(accentColor, 1.5f))
                {
                    e.Graphics.FillPath(fillBrush, path);
                    e.Graphics.DrawPath(borderPen, path);
                }
            }

            int padding = 6;
            int imgSize = 40;

            if (song.Art != null)
            {
                e.Graphics.DrawImage(song.Art,
                    new Rectangle(e.Bounds.Left + padding, e.Bounds.Top + padding, imgSize, imgSize));
            }

            int textLeft = e.Bounds.Left + imgSize + (padding * 2);

            Brush titleBrush = selected ? new SolidBrush(Color.White) : Brushes.White;
            Brush writerBrush = selected ? new SolidBrush(Color.Gainsboro) : Brushes.Gray;

            e.Graphics.DrawString(song.Title, boldFont, titleBrush, textLeft, e.Bounds.Top + 5);
            e.Graphics.DrawString(song.Writer, e.Font, writerBrush, textLeft, e.Bounds.Top + 25);

            if (selected)
            {
                titleBrush.Dispose();
                writerBrush.Dispose();
            }
        }

        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            var arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wplayer.PlayStateChange += wplayer_PlayStateChange;
            playButton.Image = playPng;
            artBox.Image = emptyPng;
            // load songs from the music folder and local files
            Load_Songs(musicFolder);
            Load_Songs(localFiles);
        }

        private void songList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Play_Song(songList);
        }

        private void searchList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (searchList.SelectedItem is SongInfo selectedSong)
            {
                // Find the index of the selected song in the main song list
                int index = songList.Items.Cast<SongInfo>().ToList().FindIndex(s => s.Title == selectedSong.Title && s.Writer == selectedSong.Writer);
                if (index != -1)
                {
                    songList.SelectedIndex = index;
                    Play_Song(songList);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            if (wplayer.playState == WMPPlayState.wmppsPlaying || wplayer.playState == WMPPlayState.wmppsPaused)
            {
                // Update the progress bar and time labels
                if (!metroProgressBar1IsMouseDown)
                {
                    metroProgressBar1.Maximum = (int)wplayer.currentMedia.duration;
                    metroProgressBar1.Value = (int)wplayer.controls.currentPosition;
                }
                TimeSpan currentTime = TimeSpan.FromSeconds(wplayer.controls.currentPosition);
                TimeSpan totalTime = TimeSpan.FromSeconds(wplayer.currentMedia.duration);
                //labelCurrentTime.Text = currentTime.ToString(@"mm\:ss");
                //labelTotalTime.Text = totalTime.ToString(@"mm\:ss");
            }
        }

        private void wplayer_PlayStateChange(int NewState)
        {

            if (NewState == (int)WMPPlayState.wmppsMediaEnded)
            {
                Next_Song(songList);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "" || searchBox.Text == null)
            {
                searchList.Visible = false;
            }
            else
            {
                searchList.Visible = true;
                foreach (var item in songList.Items.Cast<SongInfo>())
                {
                    if (item.Title.StartsWith(searchBox.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        if (searchList.Items.Contains(item)) continue;
                        searchList.Items.Add(item);
                    }
                    else
                    {
                        searchList.Items.Remove(item);
                    }
                }
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (wplayer.playState == WMPPlayState.wmppsPaused)
            {
                wplayer.controls.play();
                playButton.Image = pausePng;
            }
            else if (wplayer.playState == WMPPlayState.wmppsPlaying)
            {
                wplayer.controls.pause();
                playButton.Image = playPng;
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            if (wplayer.URL != null || wplayer.URL != "")
            {
                Next_Song(songList);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (wplayer.controls.currentPosition <= 5.0)
            {
                Previous_Song(songList);
            }
            else
            {
                wplayer.controls.currentPosition = 0;
            }
        }

        private void metroProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            metroProgressBar1IsMouseDown = true;
        }

        private void metroProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            metroProgressBar1IsMouseDown = false;

            if (!string.IsNullOrEmpty(wplayer.URL))
            {
                wplayer.controls.currentPosition = metroProgressBar1.Value;
            }
        }
    }
}
