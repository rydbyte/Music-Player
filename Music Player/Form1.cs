using WMPLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        //variables set
        readonly private WMPLib.WindowsMediaPlayer wplayer = new();

        HttpClient client = new();

        private static string exeDirectory = Directory.GetCurrentDirectory().ToString();
        private static string debugDirectory = Directory.GetParent(exeDirectory).ToString();
        private static string binDirectory = Directory.GetParent(debugDirectory).ToString();
        private static string baseDirectory = Directory.GetParent(binDirectory).ToString();
        string localFiles = Path.GetFullPath(
              baseDirectory + "\\Music\\"
           );
        string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

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
                playButton.Image = System.Drawing.Image.FromFile(
                    baseDirectory + "\\Images\\pause.png"
                );

                Titlee.Text = selectedSong.Title;
                Artistt.Text = selectedSong.Writer;


                if (selectedSong.Art != null)
                {
                    artBox.Image = selectedSong.Art;
                }
                else
                {
                    artBox.Image = System.Drawing.Image.FromFile(
                         baseDirectory + "\\Images\\empty.png"
                     );
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
                if (selectedSong.Lyrics != null)
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

            // Load songs from the local files
            foreach (var mp3 in Directory.GetFiles(path, "*.mp3"))
            {

                // Read metadata using TagLib#
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

                // Length in seconds
                int length = (int)file.Properties.Duration.TotalSeconds;

                //Title
                string title = Path.GetFileNameWithoutExtension(mp3);

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

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)//I got no clue how the positioning works but i can understand the logic
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            var song = (SongInfo)songList.Items[e.Index];

            int padding = 6;
            int imgSize = 40;

            // Draw album art
            if (song.Art != null)
            {
                e.Graphics.DrawImage(song.Art,
                    new Rectangle(
                        e.Bounds.Left + padding,
                        e.Bounds.Top + padding,
                        imgSize,
                        imgSize
                    ));
            }

            int textLeft = e.Bounds.Left + imgSize + (padding * 2);

            // Title
            e.Graphics.DrawString(
                song.Title,
                new Font(e.Font, FontStyle.Bold),
                Brushes.White,
                textLeft,
                e.Bounds.Top + 5
            );

            // Writer
            e.Graphics.DrawString(
                song.Writer,
                e.Font,
                Brushes.Gray,
                textLeft,
                e.Bounds.Top + 25
            );

            e.DrawFocusRectangle();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wplayer.PlayStateChange += wplayer_PlayStateChange;
            // load songs from the music folder and local files
            Load_Songs(musicFolder);
            Load_Songs(localFiles);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Play_Song(songList);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            if (wplayer.playState == WMPPlayState.wmppsPlaying || wplayer.playState == WMPPlayState.wmppsPaused)
            {
                // Update the progress bar and time labels
                metroProgressBar1.Maximum = (int)wplayer.currentMedia.duration;
                metroProgressBar1.Value = (int)wplayer.controls.currentPosition;
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

            }
            else
            {
                foreach (var item in songList.Items.Cast<SongInfo>())
                {
                    if (item.Title.StartsWith(searchBox.Text, StringComparison.OrdinalIgnoreCase))
                    {

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
                playButton.Image = System.Drawing.Image.FromFile(
                    baseDirectory + "\\Images\\pause.png"
                );
            }
            else if (wplayer.playState == WMPPlayState.wmppsPlaying)
            {
                wplayer.controls.pause();
                playButton.Image = System.Drawing.Image.FromFile(
                    baseDirectory + "\\Images\\play.png"
                );
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
    }
}
