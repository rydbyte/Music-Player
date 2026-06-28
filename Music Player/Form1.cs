using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using TagLib;
using WMPLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        //variables set
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public static string exeDirectory = Directory.GetCurrentDirectory().ToString();
        public static string debugDirectory = Directory.GetParent(exeDirectory).ToString();
        public static string binDirectory = Directory.GetParent(debugDirectory).ToString();
        public static string baseDirectory = Directory.GetParent(binDirectory).ToString();
        string localFiles = Path.GetFullPath(
              baseDirectory + "\\Music\\"
           );
        string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

        public class SongInfo
        {
            public string Folder { get; set; }
            public string Title { get; set; }
            public string Writer { get; set; }
            public Image Art { get; set; }
            public int Length { get; set; }

            public override string ToString() => Title;
        }

        private void Load_Songs(string path)
        {

            // Load songs from the local files
            foreach (var mp3 in Directory.GetFiles(path, "*.mp3"))
            {

                // Read metadata using TagLib#
                var file = TagLib.File.Create(mp3);

                // Length in seconds
                int length = (int)file.Properties.Duration.TotalSeconds;

                // Writer
                string writer = file.Tag.Composers.Length > 0
                    ? file.Tag.Composers[0]
                    : "Unknown Artist";

                if (listBox1.Items.Cast<SongInfo>().Any(s => s.Title == Path.GetFileNameWithoutExtension(mp3)) && listBox1.Items.Cast<SongInfo>().Any(s => s.Writer == writer) || file.MimeType != "taglib/mp3")
                {
                    // Skip if the song is already in the list
                    continue;
                }

                // Album art
                Image? art = null;
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = file.Tag.Pictures[0].Data.Data;
                    using (var ms = new MemoryStream(bin))
                        art = Image.FromStream(ms);
                }

                // Add the song info to the ListBox
                listBox1.Items.Add(new SongInfo
                {
                    Folder = path,
                    Length = length,
                    Title = Path.GetFileNameWithoutExtension(mp3),
                    Writer = writer,
                    Art = art,
                });
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            var song = (SongInfo)listBox1.Items[e.Index];

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

            // Set up the ListBox for custom drawing
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.ItemHeight = 50;
            listBox1.DrawItem += listBox1_DrawItem;
            listBox1.ForeColor = SystemColors.Control;

            wplayer.PlayStateChange += wplayer_PlayStateChange;

            //HOPEFULLY STOPS THE FUCKING TEXTBOXES FROM REZISING
            Titlee.AutoSize = false;
            Artistt.AutoSize = false;

            Load_Songs(musicFolder);
            Load_Songs(localFiles);

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is SongInfo selectedSong)
            {

                string audio = Path.Combine(selectedSong.Folder, selectedSong.Title + ".mp3");

                wplayer.URL = audio;
                wplayer.controls.play();

                Titlee.Text = selectedSong.Title;
                Artistt.Text = selectedSong.Writer;

                // Handle the selected song
                if (selectedSong.Art != null)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = selectedSong.Art;
                }
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Image = System.Drawing.Image.FromFile(
                        baseDirectory + "\\Images\\empty.png"
                    );
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            metroLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            metroLabel2.Text = DateTime.Now.ToString("HH:mm:ss");

            if (wplayer.playState == WMPPlayState.wmppsPlaying)
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
            if (NewState == (int)WMPPlayState.wmppsPlaying)
            {
                // Update the progress bar and time labels
                metroProgressBar1.Maximum = (int)wplayer.currentMedia.duration;
                metroProgressBar1.Value = (int)wplayer.controls.currentPosition;
                TimeSpan currentTime = TimeSpan.FromSeconds(wplayer.controls.currentPosition);
                TimeSpan totalTime = TimeSpan.FromSeconds(wplayer.currentMedia.duration);
                //labelCurrentTime.Text = currentTime.ToString(@"mm\:ss");
                //labelTotalTime.Text = totalTime.ToString(@"mm\:ss");
            }
            if (NewState == (int)WMPPlayState.wmppsMediaEnded)
            {
                this.Invoke((Delegate)(() =>
                {
                    metroProgressBar1.Value = 0;

                    if (listBox1.SelectedIndex + 1 < listBox1.Items.Count) 
                    {
                        listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    }
                    else
                        listBox1.SelectedIndex = 0;

                    Task.Delay(500).ContinueWith(_ =>
                    {
                        this.Invoke(() =>
                        {
                            wplayer.controls.play();
                        });
                    });
                }));
            }
        }
    }
}
