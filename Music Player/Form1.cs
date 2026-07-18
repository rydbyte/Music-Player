using Music_Player.Properties;
using NAudio.Wave;
using NAudio.WaveFormRenderer;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        //variables set
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;

        HttpClient client = new();

        private static readonly Color accentColor = Color.FromArgb(138, 43, 226);
        private static readonly Color accentColorLight = Color.FromArgb(90, accentColor);

        string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

        private bool metroProgressBar1IsMouseDown;
        private bool looping;

        private static Font boldFont = new Font(new FontFamily("Castellar"), 10, FontStyle.Bold);

        private class SongInfo//Class songinfo that gets stored in the listbox
        {
            public string Folder { get; set; }
            public string Album { get; set; }
            public string Lyrics { get; set; }
            public string Title { get; set; }
            public string Artist { get; set; }
            public Image Art { get; set; }
            public int Length { get; set; }
            public string File { get; set; }
        }

        private Image GenerateWaveform(string filePath, int width, int height)
        {
            var renderer = new WaveFormRenderer();

            var settings = new StandardWaveFormRendererSettings
            {
                Width = width,
                TopHeight = height / 2,
                BottomHeight = height / 2,
                BackgroundColor = Color.Transparent,
                TopPeakPen = new Pen(accentColor),
                BottomPeakPen = new Pen(accentColor),
                TopSpacerPen = new Pen(Color.Transparent),
                BottomSpacerPen = new Pen(Color.Transparent),
                PixelsPerPeak = 1,
                SpacerPixels = 0,
            };

            // MaxPeakProvider (the implicit default) grabs the loudest sample per
            // column, which reads as a solid block on loud/normalized mp3s.
            // RmsPeakProvider averages energy per block, giving natural-looking peaks.
            var peakProvider = new RmsPeakProvider(400);

            using var reader = new AudioFileReader(filePath);
            return renderer.Render(reader, peakProvider, settings);
        }

        // ==================== Constructor / Form lifecycle ====================

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;

            await Load_Songs(musicFolder);
        }

        // ==================== Song library loading ====================

        private async Task Load_Songs(string path)
        {
            var songlist = new List<SongInfo>();

            await Task.Run(() =>
            {
                foreach (var file in Directory.EnumerateFiles(path, "*.mp3"))
                {
                    var tag = TagLib.File.Create(file);

                    // Artist
                    string artist = tag.Tag.FirstComposer ?? tag.Tag.FirstArtist ?? "Unknown Artist";

                    // Title
                    string title = Path.GetFileNameWithoutExtension(file);

                    if (tag.MimeType != "taglib/mp3")
                    {
                        continue;
                    }

                    if (songlist.Any(s => s.Title == title && s.Artist == artist))
                    {
                        continue;
                    }

                    // Length in seconds
                    int length = (int)tag.Properties.Duration.TotalSeconds;

                    //Album
                    string album = tag.Tag.Album;

                    // Album art
                    Image? art = null;
                    if (tag.Tag.Pictures.Length > 0)
                    {
                        var bin = tag.Tag.Pictures[0].Data.Data;
                        using (var ms = new MemoryStream(bin))
                            art = Image.FromStream(ms);
                    }

                    //Lyrics
                    string lyrics = tag.Tag.Lyrics;

                    songlist.Add(new SongInfo
                    {
                        Folder = path,
                        Length = length,
                        Title = title,
                        Artist = artist,
                        Art = art,
                        Album = album,
                        File = file,
                        Lyrics = lyrics
                    });
                }
            });

            foreach (var song in songlist)
            {
                songList.Items.Add(song);
            }
        }

        // ==================== Lyrics ====================

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

        // ==================== Playback control ====================

        private void Play_Song(ListBox list)
        {
            if (list.SelectedItem is SongInfo selectedSong)
            {
                // Handle the selected song
                playButton.Image = Resources.pause;
                Titlee.Text = selectedSong.Title;
                Artistt.Text = selectedSong.Artist;
                metroProgressBar1.Value = 0;
                lyricsBox.Text = selectedSong.Lyrics;

                if (selectedSong.Art != null)
                {
                    artBox.Image = selectedSong.Art;
                }
                else
                {
                    artBox.Image = Resources.empty;
                }

                // Audio
                string audio = Path.Combine(selectedSong.Folder, selectedSong.File);

                if (outputDevice.PlaybackState != PlaybackState.Stopped)
                {
                    outputDevice.Stop();
                }
                audioFile?.Dispose();

                audioFile = new AudioFileReader(audio);
                outputDevice.Init(audioFile);
                outputDevice.Play();

                audioFile.Volume = (float)volumeBar.Value / 100;
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

        // ==================== Media player events ====================

        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFile != null && audioFile.CurrentTime >= audioFile.TotalTime - TimeSpan.FromMilliseconds(200))
            {
                if (looping)
                {
                    audioFile.Position = 0;
                    outputDevice.Play();
                }
                else
                {
                    this.Invoke(() => Next_Song(songList));
                }
            }
        }

        private void timer33ms_Tick(object sender, EventArgs e)
        {

            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            if (audioFile != null && (outputDevice.PlaybackState == PlaybackState.Playing || outputDevice.PlaybackState == PlaybackState.Paused))
            {
                // Update the progress bar and time labels
                if (!metroProgressBar1IsMouseDown)
                {
                    metroProgressBar1.Maximum = (int)audioFile.TotalTime.TotalMilliseconds;

                    metroProgressBar1.Value = (int)audioFile.CurrentTime.TotalMilliseconds;
                }
                TimeSpan currentTime = audioFile.CurrentTime;
                TimeSpan totalTime = audioFile.TotalTime;
                //labelCurrentTime.Text = currentTime.ToString(@"mm\:ss");
                //labelTotalTime.Text = totalTime.ToString(@"mm\:ss");
            }
        }

        // ==================== List selection handlers ====================

        private void songList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Play_Song(songList);
        }

        private void searchList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (searchList.SelectedItem is SongInfo selectedSong)
            {
                // Find the index of the selected song in the main song list
                int index = songList.Items.Cast<SongInfo>().ToList().FindIndex(s => s.Title == selectedSong.Title && s.Artist == selectedSong.Artist);
                songList.SelectedIndex = index;
                //Play_Song(songList);
            }
        }

        // ==================== Search box ====================

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

        // ==================== Transport buttons ====================

        private void playButton_Click(object sender, EventArgs e)
        {
            if (outputDevice.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
                playButton.Image = Resources.pause;
            }
            else if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                playButton.Image = Resources.play;
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                Next_Song(songList);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (audioFile == null || audioFile.CurrentTime.TotalSeconds <= 5.0)
            {
                Previous_Song(songList);
            }
            else
            {
                audioFile.Position = 0;
            }
        }

        private void loopButton_Click(object sender, EventArgs e)
        {
            looping = !looping;
            loopButton.BackColor = looping ? accentColorLight : SystemColors.ActiveCaptionText;
        }

        // ==================== Progress bar (seek) ====================

        private void metroProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            metroProgressBar1IsMouseDown = true;
        }

        private void metroProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            metroProgressBar1IsMouseDown = false;

            if (audioFile != null)
            {
                audioFile.CurrentTime = TimeSpan.FromMilliseconds(metroProgressBar1.Value);
            }
        }

        private void volumeBar_ValueChanged(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Volume = volumeBar.Value / 100.0f;
            }
        }

        // ==================== Custom list drawing ====================

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
            e.Graphics.DrawString(song.Artist, e.Font, writerBrush, textLeft, e.Bounds.Top + 25);

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
    }
}