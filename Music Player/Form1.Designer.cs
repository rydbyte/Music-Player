namespace Music_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            songBox1 = new GroupBox();
            scrollbarHider = new Panel();
            searchList = new ListBox();
            searchBox = new ReaLTaiizor.Controls.ForeverTextBox();
            songList = new ListBox();
            systemBox = new GroupBox();
            panel1 = new Panel();
            lyricsBox = new TextBox();
            timeLabel = new ReaLTaiizor.Controls.MetroLabel();
            dateLabel = new ReaLTaiizor.Controls.MetroLabel();
            controlBox = new GroupBox();
            metroProgressBar1 = new ReaLTaiizor.Controls.DungeonTrackBar();
            previousButton = new PictureBox();
            skipButton = new PictureBox();
            playButton = new PictureBox();
            Artistt = new TextBox();
            Titlee = new TextBox();
            artBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            songBox1.SuspendLayout();
            systemBox.SuspendLayout();
            controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previousButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skipButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)artBox).BeginInit();
            SuspendLayout();
            // 
            // songBox1
            // 
            songBox1.AutoSize = true;
            songBox1.Controls.Add(scrollbarHider);
            songBox1.Controls.Add(searchList);
            songBox1.Controls.Add(searchBox);
            songBox1.Controls.Add(songList);
            songBox1.Font = new Font("Castellar", 10.2F);
            songBox1.ForeColor = SystemColors.Control;
            songBox1.Location = new Point(12, 12);
            songBox1.Name = "songBox1";
            songBox1.Size = new Size(586, 645);
            songBox1.TabIndex = 3;
            songBox1.TabStop = false;
            songBox1.Text = "Songs";
            // 
            // scrollbarHider
            // 
            scrollbarHider.BackColor = Color.Transparent;
            scrollbarHider.Location = new Point(553, 49);
            scrollbarHider.Name = "scrollbarHider";
            scrollbarHider.Padding = new Padding(0, 0, 20, 0);
            scrollbarHider.Size = new Size(22, 569);
            scrollbarHider.TabIndex = 1;
            // 
            // searchList
            // 
            searchList.BackColor = SystemColors.InactiveCaptionText;
            searchList.BorderStyle = BorderStyle.None;
            searchList.DrawMode = DrawMode.OwnerDrawFixed;
            searchList.ForeColor = SystemColors.Control;
            searchList.FormattingEnabled = true;
            searchList.IntegralHeight = false;
            searchList.ItemHeight = 50;
            searchList.Location = new Point(12, 49);
            searchList.Name = "searchList";
            searchList.Size = new Size(563, 569);
            searchList.TabIndex = 3;
            searchList.Visible = false;
            searchList.DrawItem += Songs_DrawItem;
            searchList.SelectedIndexChanged += searchList_SelectedIndexChanged_1;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Transparent;
            searchBox.BaseColor = SystemColors.ActiveCaptionText;
            searchBox.BorderColor = SystemColors.Control;
            searchBox.FocusOnHover = false;
            searchBox.Font = new Font("Castellar", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBox.ForeColor = SystemColors.Control;
            searchBox.Location = new Point(434, 16);
            searchBox.MaxLength = 32767;
            searchBox.Multiline = false;
            searchBox.Name = "searchBox";
            searchBox.ReadOnly = false;
            searchBox.Size = new Size(141, 27);
            searchBox.TabIndex = 2;
            searchBox.Text = "Search";
            searchBox.TextAlign = HorizontalAlignment.Left;
            searchBox.UseSystemPasswordChar = false;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.Click += searchBox_Click;
            searchBox.Enter += searchBox_Click;
            searchBox.GotFocus += searchBox_Click;
            // 
            // songList
            // 
            songList.BackColor = SystemColors.InactiveCaptionText;
            songList.BorderStyle = BorderStyle.None;
            songList.DrawMode = DrawMode.OwnerDrawFixed;
            songList.ForeColor = SystemColors.Control;
            songList.FormattingEnabled = true;
            songList.IntegralHeight = false;
            songList.ItemHeight = 50;
            songList.Location = new Point(12, 49);
            songList.Name = "songList";
            songList.Size = new Size(563, 569);
            songList.TabIndex = 0;
            songList.DrawItem += Songs_DrawItem;
            songList.SelectedIndexChanged += songList_SelectedIndexChanged_1;
            // 
            // systemBox
            // 
            systemBox.Controls.Add(panel1);
            systemBox.Controls.Add(lyricsBox);
            systemBox.Controls.Add(timeLabel);
            systemBox.Controls.Add(dateLabel);
            systemBox.Font = new Font("Castellar", 10.2F);
            systemBox.ForeColor = SystemColors.Control;
            systemBox.Location = new Point(12, 656);
            systemBox.Name = "systemBox";
            systemBox.Size = new Size(1900, 410);
            systemBox.TabIndex = 4;
            systemBox.TabStop = false;
            systemBox.Text = "System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(503, 27);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 20, 0);
            panel1.Size = new Size(24, 367);
            panel1.TabIndex = 3;
            // 
            // lyricsBox
            // 
            lyricsBox.AcceptsReturn = true;
            lyricsBox.AcceptsTab = true;
            lyricsBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lyricsBox.BackColor = SystemColors.ActiveCaptionText;
            lyricsBox.BorderStyle = BorderStyle.None;
            lyricsBox.Font = new Font("Castellar", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lyricsBox.ForeColor = SystemColors.Control;
            lyricsBox.Location = new Point(85, 27);
            lyricsBox.Multiline = true;
            lyricsBox.Name = "lyricsBox";
            lyricsBox.ReadOnly = true;
            lyricsBox.ScrollBars = ScrollBars.Vertical;
            lyricsBox.Size = new Size(442, 367);
            lyricsBox.TabIndex = 2;
            lyricsBox.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            lyricsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.None;
            timeLabel.Font = new Font("Castellar", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.ImageAlign = ContentAlignment.BottomRight;
            timeLabel.IsDerivedStyle = true;
            timeLabel.Location = new Point(1741, 352);
            timeLabel.Name = "timeLabel";
            timeLabel.RightToLeft = RightToLeft.No;
            timeLabel.Size = new Size(159, 29);
            timeLabel.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            timeLabel.StyleManager = null;
            timeLabel.TabIndex = 1;
            timeLabel.Text = "14:45:01";
            timeLabel.TextAlign = ContentAlignment.BottomRight;
            timeLabel.ThemeAuthor = "Taiizor";
            timeLabel.ThemeName = "MetroDark";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.None;
            dateLabel.Font = new Font("Castellar", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.ImageAlign = ContentAlignment.MiddleRight;
            dateLabel.IsDerivedStyle = true;
            dateLabel.Location = new Point(1741, 381);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(159, 29);
            dateLabel.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            dateLabel.StyleManager = null;
            dateLabel.TabIndex = 0;
            dateLabel.Text = "28/05/2026";
            dateLabel.TextAlign = ContentAlignment.MiddleRight;
            dateLabel.ThemeAuthor = "Taiizor";
            dateLabel.ThemeName = "MetroDark";
            // 
            // controlBox
            // 
            controlBox.Controls.Add(metroProgressBar1);
            controlBox.Controls.Add(previousButton);
            controlBox.Controls.Add(skipButton);
            controlBox.Controls.Add(playButton);
            controlBox.Controls.Add(Artistt);
            controlBox.Controls.Add(Titlee);
            controlBox.Controls.Add(artBox);
            controlBox.Font = new Font("Castellar", 10.2F);
            controlBox.ForeColor = SystemColors.Control;
            controlBox.Location = new Point(593, 12);
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(1319, 645);
            controlBox.TabIndex = 5;
            controlBox.TabStop = false;
            controlBox.Text = "Control";
            // 
            // metroProgressBar1
            // 
            metroProgressBar1.BorderColor = Color.FromArgb(200, 200, 200);
            metroProgressBar1.DrawValueString = false;
            metroProgressBar1.EmptyBackColor = Color.FromArgb(221, 221, 221);
            metroProgressBar1.FillBackColor = Color.Red;
            metroProgressBar1.JumpToMouse = true;
            metroProgressBar1.Location = new Point(100, 531);
            metroProgressBar1.Maximum = 10;
            metroProgressBar1.Minimum = 0;
            metroProgressBar1.MinimumSize = new Size(47, 22);
            metroProgressBar1.Name = "metroProgressBar1";
            metroProgressBar1.Size = new Size(1100, 22);
            metroProgressBar1.TabIndex = 10;
            metroProgressBar1.Text = "dungeonTrackBar1";
            metroProgressBar1.ThumbBackColor = Color.FromArgb(244, 244, 244);
            metroProgressBar1.ThumbBorderColor = Color.FromArgb(180, 180, 180);
            metroProgressBar1.Value = 0;
            metroProgressBar1.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            metroProgressBar1.ValueToSet = 0F;
            metroProgressBar1.MouseDown += metroProgressBar1_MouseDown;
            metroProgressBar1.MouseUp += metroProgressBar1_MouseUp;
            // 
            // previousButton
            // 
            previousButton.BackgroundImageLayout = ImageLayout.Center;
            previousButton.Location = new Point(548, 446);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(53, 53);
            previousButton.SizeMode = PictureBoxSizeMode.StretchImage;
            previousButton.TabIndex = 9;
            previousButton.TabStop = false;
            previousButton.Click += previousButton_Click;
            // 
            // skipButton
            // 
            skipButton.BackgroundImageLayout = ImageLayout.Center;
            skipButton.Location = new Point(735, 446);
            skipButton.Name = "skipButton";
            skipButton.Size = new Size(53, 53);
            skipButton.SizeMode = PictureBoxSizeMode.StretchImage;
            skipButton.TabIndex = 8;
            skipButton.TabStop = false;
            skipButton.Click += skipButton_Click;
            // 
            // playButton
            // 
            playButton.BackgroundImageLayout = ImageLayout.Center;
            playButton.Location = new Point(640, 446);
            playButton.Name = "playButton";
            playButton.Size = new Size(53, 53);
            playButton.SizeMode = PictureBoxSizeMode.StretchImage;
            playButton.TabIndex = 7;
            playButton.TabStop = false;
            playButton.Click += playButton_Click;
            // 
            // Artistt
            // 
            Artistt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Artistt.BackColor = Color.Black;
            Artistt.BorderStyle = BorderStyle.None;
            Artistt.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Artistt.ForeColor = SystemColors.Control;
            Artistt.Location = new Point(11, 344);
            Artistt.Name = "Artistt";
            Artistt.ReadOnly = true;
            Artistt.ScrollBars = ScrollBars.Horizontal;
            Artistt.Size = new Size(1302, 25);
            Artistt.TabIndex = 3;
            Artistt.TextAlign = HorizontalAlignment.Center;
            // 
            // Titlee
            // 
            Titlee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlee.BackColor = Color.Black;
            Titlee.BorderStyle = BorderStyle.None;
            Titlee.Font = new Font("Castellar", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Titlee.ForeColor = SystemColors.Control;
            Titlee.Location = new Point(11, 307);
            Titlee.Name = "Titlee";
            Titlee.ReadOnly = true;
            Titlee.Size = new Size(1302, 31);
            Titlee.TabIndex = 2;
            Titlee.TextAlign = HorizontalAlignment.Center;
            // 
            // artBox
            // 
            artBox.BorderStyle = BorderStyle.FixedSingle;
            artBox.Location = new Point(548, 49);
            artBox.Name = "artBox";
            artBox.Size = new Size(240, 240);
            artBox.SizeMode = PictureBoxSizeMode.StretchImage;
            artBox.TabIndex = 1;
            artBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1918, 1078);
            ControlBox = false;
            Controls.Add(systemBox);
            Controls.Add(songBox1);
            Controls.Add(controlBox);
            Font = new Font("Castellar", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            songBox1.ResumeLayout(false);
            systemBox.ResumeLayout(false);
            systemBox.PerformLayout();
            controlBox.ResumeLayout(false);
            controlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previousButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)skipButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)playButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)artBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox songBox1;
        private GroupBox systemBox;
        private GroupBox controlBox;
        private ListBox songList;
        private Panel scrollbarHider;
        private PictureBox artBox;
        private TextBox Titlee;
        private TextBox Artistt;
        private ReaLTaiizor.Controls.MetroLabel dateLabel;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.MetroLabel timeLabel;
        private ReaLTaiizor.Controls.ForeverTextBox searchBox;
        private PictureBox playButton;
        private TextBox lyricsBox;
        private Panel panel1;
        private PictureBox previousButton;
        private PictureBox skipButton;
        private ReaLTaiizor.Controls.DungeonTrackBar metroProgressBar1;
        private ListBox searchList;
    }
}
