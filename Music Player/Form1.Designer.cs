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
            onlineList = new ListBox();
            label2 = new Label();
            sortButton = new ReaLTaiizor.Controls.PoisonDropDownButton();
            onlineButton = new ReaLTaiizor.Controls.PoisonButton();
            localButton = new ReaLTaiizor.Controls.PoisonButton();
            searchBox = new ReaLTaiizor.Controls.ForeverTextBox();
            songList = new ListBox();
            systemBox = new GroupBox();
            label1 = new Label();
            metroDivider3 = new ReaLTaiizor.Controls.MetroDivider();
            metroDivider2 = new ReaLTaiizor.Controls.MetroDivider();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            volumeBar = new TrackBar();
            panel1 = new Panel();
            lyricsBox = new TextBox();
            timeLabel = new ReaLTaiizor.Controls.MetroLabel();
            dateLabel = new ReaLTaiizor.Controls.MetroLabel();
            sysTitleLabel = new Label();
            trackInfoTitle = new Label();
            formatLabel = new Label();
            formatValue = new Label();
            fileSizeLabel = new Label();
            fileSizeValue = new Label();
            bitrateLabel = new Label();
            bitrateValue = new Label();
            sampleRateLabel = new Label();
            sampleRateValue = new Label();
            albumLabel = new Label();
            albumValue = new Label();
            sourceLabel = new Label();
            sourceValue = new Label();
            volumeValueLabel = new Label();
            streamDotLabel = new Label();
            streamActiveLabel = new Label();
            controlBox = new GroupBox();
            totalTime = new Label();
            currentTime = new Label();
            textBox1 = new TextBox();
            metroProgressBar1 = new ReaLTaiizor.Controls.MetroTrackBar();
            label3 = new Label();
            loopButton = new PictureBox();
            previousButton = new PictureBox();
            skipButton = new PictureBox();
            playButton = new PictureBox();
            Artistt = new TextBox();
            Titlee = new TextBox();
            artBox = new PictureBox();
            timer33ms = new System.Windows.Forms.Timer(components);
            metroDivider4 = new ReaLTaiizor.Controls.MetroDivider();
            songBox1.SuspendLayout();
            systemBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).BeginInit();
            controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loopButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previousButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skipButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)artBox).BeginInit();
            SuspendLayout();
            // 
            // songBox1
            // 
            songBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            songBox1.BackColor = Color.FromArgb(12, 6, 18);
            songBox1.Controls.Add(scrollbarHider);
            songBox1.Controls.Add(onlineList);
            songBox1.Controls.Add(label2);
            songBox1.Controls.Add(sortButton);
            songBox1.Controls.Add(onlineButton);
            songBox1.Controls.Add(localButton);
            songBox1.Controls.Add(searchBox);
            songBox1.Controls.Add(songList);
            songBox1.Font = new Font("Castellar", 10.2F);
            songBox1.ForeColor = Color.FromArgb(0, 230, 210);
            songBox1.Location = new Point(24, 12);
            songBox1.Margin = new Padding(2, 3, 2, 3);
            songBox1.Name = "songBox1";
            songBox1.Padding = new Padding(2, 3, 2, 3);
            songBox1.Size = new Size(430, 824);
            songBox1.TabIndex = 3;
            songBox1.TabStop = false;
            // 
            // scrollbarHider
            // 
            scrollbarHider.BackColor = Color.FromArgb(9, 6, 13);
            scrollbarHider.Location = new Point(388, 106);
            scrollbarHider.Margin = new Padding(2, 3, 2, 3);
            scrollbarHider.Name = "scrollbarHider";
            scrollbarHider.Padding = new Padding(0, 0, 20, 0);
            scrollbarHider.Size = new Size(22, 692);
            scrollbarHider.TabIndex = 1;
            // 
            // onlineList
            // 
            onlineList.BackColor = Color.FromArgb(9, 6, 13);
            onlineList.BorderStyle = BorderStyle.None;
            onlineList.DrawMode = DrawMode.OwnerDrawFixed;
            onlineList.ForeColor = Color.FromArgb(220, 220, 220);
            onlineList.FormattingEnabled = true;
            onlineList.IntegralHeight = false;
            onlineList.ItemHeight = 50;
            onlineList.Location = new Point(26, 106);
            onlineList.Margin = new Padding(2, 3, 2, 3);
            onlineList.Name = "onlineList";
            onlineList.Size = new Size(383, 692);
            onlineList.TabIndex = 36;
            onlineList.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 230, 210);
            label2.Location = new Point(6, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 35;
            label2.Text = "// LIBRARY    ";
            // 
            // sortButton
            // 
            sortButton.AutoSize = true;
            sortButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sortButton.Location = new Point(323, 75);
            sortButton.Margin = new Padding(2, 3, 2, 3);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(87, 25);
            sortButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            sortButton.TabIndex = 6;
            sortButton.Text = "SORT: NONE";
            sortButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            sortButton.UseSelectable = true;
            // 
            // onlineButton
            // 
            onlineButton.Location = new Point(120, 75);
            onlineButton.Margin = new Padding(2, 3, 2, 3);
            onlineButton.Name = "onlineButton";
            onlineButton.Size = new Size(86, 25);
            onlineButton.TabIndex = 5;
            onlineButton.Text = "ONLINE";
            onlineButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            onlineButton.UseSelectable = true;
            onlineButton.Click += onlineButton_Click;
            // 
            // localButton
            // 
            localButton.Location = new Point(26, 75);
            localButton.Margin = new Padding(2, 3, 2, 3);
            localButton.Name = "localButton";
            localButton.Size = new Size(86, 25);
            localButton.TabIndex = 4;
            localButton.Text = "LOCAL";
            localButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            localButton.UseSelectable = true;
            localButton.Click += localButton_Click;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Transparent;
            searchBox.BaseColor = Color.FromArgb(8, 8, 12);
            searchBox.BorderColor = Color.White;
            searchBox.FocusOnHover = false;
            searchBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            searchBox.ForeColor = SystemColors.Control;
            searchBox.Location = new Point(26, 42);
            searchBox.Margin = new Padding(2, 3, 2, 3);
            searchBox.MaxLength = 32767;
            searchBox.Multiline = false;
            searchBox.Name = "searchBox";
            searchBox.ReadOnly = false;
            searchBox.Size = new Size(383, 29);
            searchBox.TabIndex = 2;
            searchBox.Text = "SEARCH:";
            searchBox.TextAlign = HorizontalAlignment.Left;
            searchBox.UseSystemPasswordChar = false;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.Click += searchBox_Click;
            searchBox.Enter += searchBox_Click;
            searchBox.GotFocus += searchBox_Click;
            // 
            // songList
            // 
            songList.BackColor = Color.FromArgb(10, 6, 14);
            songList.BorderStyle = BorderStyle.None;
            songList.DrawMode = DrawMode.OwnerDrawFixed;
            songList.ForeColor = Color.FromArgb(220, 220, 220);
            songList.FormattingEnabled = true;
            songList.IntegralHeight = false;
            songList.ItemHeight = 50;
            songList.Location = new Point(26, 109);
            songList.Margin = new Padding(2, 3, 2, 3);
            songList.Name = "songList";
            songList.Size = new Size(383, 689);
            songList.TabIndex = 0;
            songList.DrawItem += Songs_DrawItem;
            songList.SelectedIndexChanged += songList_SelectedIndexChanged_1;
            // 
            // systemBox
            // 
            systemBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            systemBox.BackColor = Color.FromArgb(12, 6, 18);
            systemBox.Controls.Add(label1);
            systemBox.Controls.Add(metroDivider3);
            systemBox.Controls.Add(metroDivider2);
            systemBox.Controls.Add(metroDivider1);
            systemBox.Controls.Add(formsPlot1);
            systemBox.Controls.Add(volumeBar);
            systemBox.Controls.Add(panel1);
            systemBox.Controls.Add(lyricsBox);
            systemBox.Controls.Add(timeLabel);
            systemBox.Controls.Add(dateLabel);
            systemBox.Controls.Add(sysTitleLabel);
            systemBox.Controls.Add(trackInfoTitle);
            systemBox.Controls.Add(formatLabel);
            systemBox.Controls.Add(formatValue);
            systemBox.Controls.Add(fileSizeLabel);
            systemBox.Controls.Add(fileSizeValue);
            systemBox.Controls.Add(bitrateLabel);
            systemBox.Controls.Add(bitrateValue);
            systemBox.Controls.Add(sampleRateLabel);
            systemBox.Controls.Add(sampleRateValue);
            systemBox.Controls.Add(albumLabel);
            systemBox.Controls.Add(albumValue);
            systemBox.Controls.Add(sourceLabel);
            systemBox.Controls.Add(sourceValue);
            systemBox.Controls.Add(volumeValueLabel);
            systemBox.Controls.Add(streamDotLabel);
            systemBox.Controls.Add(streamActiveLabel);
            systemBox.Font = new Font("Castellar", 10.2F);
            systemBox.ForeColor = Color.FromArgb(0, 230, 210);
            systemBox.Location = new Point(24, 816);
            systemBox.Margin = new Padding(2, 3, 2, 3);
            systemBox.Name = "systemBox";
            systemBox.Padding = new Padding(2, 3, 2, 3);
            systemBox.Size = new Size(1866, 250);
            systemBox.TabIndex = 4;
            systemBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(871, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 34;
            label1.Text = "LYRICS";
            // 
            // metroDivider3
            // 
            metroDivider3.IsDerivedStyle = true;
            metroDivider3.Location = new Point(862, 12);
            metroDivider3.Margin = new Padding(2, 3, 2, 3);
            metroDivider3.Name = "metroDivider3";
            metroDivider3.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Vertical;
            metroDivider3.Size = new Size(4, 231);
            metroDivider3.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            metroDivider3.StyleManager = null;
            metroDivider3.TabIndex = 33;
            metroDivider3.Text = "metroDivider3";
            metroDivider3.ThemeAuthor = "Taiizor";
            metroDivider3.ThemeName = "";
            metroDivider3.Thickness = 1;
            // 
            // metroDivider2
            // 
            metroDivider2.IsDerivedStyle = true;
            metroDivider2.Location = new Point(428, -19);
            metroDivider2.Margin = new Padding(2, 3, 2, 3);
            metroDivider2.Name = "metroDivider2";
            metroDivider2.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Vertical;
            metroDivider2.Size = new Size(4, 30);
            metroDivider2.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            metroDivider2.StyleManager = null;
            metroDivider2.TabIndex = 8;
            metroDivider2.Text = "metroDivider2";
            metroDivider2.ThemeAuthor = "Taiizor";
            metroDivider2.ThemeName = "";
            metroDivider2.Thickness = 1;
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(-1, -11);
            metroDivider1.Margin = new Padding(2, 3, 2, 3);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Vertical;
            metroDivider1.Size = new Size(4, 30);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 7;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "";
            metroDivider1.Thickness = 1;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.FromArgb(12, 6, 18);
            formsPlot1.ForeColor = Color.FromArgb(180, 180, 180);
            formsPlot1.Location = new Point(8, 25);
            formsPlot1.Margin = new Padding(5, 2, 5, 2);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(402, 220);
            formsPlot1.TabIndex = 15;
            // 
            // volumeBar
            // 
            volumeBar.BackColor = Color.FromArgb(12, 6, 18);
            volumeBar.Cursor = Cursors.HSplit;
            volumeBar.LargeChange = 1;
            volumeBar.Location = new Point(1466, 20);
            volumeBar.Margin = new Padding(2, 3, 2, 3);
            volumeBar.Maximum = 100;
            volumeBar.Name = "volumeBar";
            volumeBar.Orientation = Orientation.Vertical;
            volumeBar.Size = new Size(56, 187);
            volumeBar.TabIndex = 0;
            volumeBar.TickFrequency = 5;
            volumeBar.Value = 100;
            volumeBar.ValueChanged += volumeBar_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(1292, 30);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 20, 0);
            panel1.Size = new Size(22, 367);
            panel1.TabIndex = 3;
            // 
            // lyricsBox
            // 
            lyricsBox.AcceptsReturn = true;
            lyricsBox.AcceptsTab = true;
            lyricsBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lyricsBox.BackColor = Color.FromArgb(12, 6, 18);
            lyricsBox.BorderStyle = BorderStyle.None;
            lyricsBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lyricsBox.ForeColor = Color.FromArgb(0, 230, 210);
            lyricsBox.Location = new Point(871, 50);
            lyricsBox.Margin = new Padding(2, 3, 2, 3);
            lyricsBox.Multiline = true;
            lyricsBox.Name = "lyricsBox";
            lyricsBox.ReadOnly = true;
            lyricsBox.ScrollBars = ScrollBars.Vertical;
            lyricsBox.Size = new Size(442, 194);
            lyricsBox.TabIndex = 2;
            lyricsBox.Text = "-";
            lyricsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.None;
            timeLabel.Font = new Font("Segoe UI", 21.2F, FontStyle.Bold);
            timeLabel.ImageAlign = ContentAlignment.BottomRight;
            timeLabel.IsDerivedStyle = true;
            timeLabel.Location = new Point(1670, 20);
            timeLabel.Margin = new Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.RightToLeft = RightToLeft.No;
            timeLabel.Size = new Size(190, 46);
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
            dateLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dateLabel.ImageAlign = ContentAlignment.TopCenter;
            dateLabel.IsDerivedStyle = true;
            dateLabel.Location = new Point(1734, 66);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(118, 30);
            dateLabel.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            dateLabel.StyleManager = null;
            dateLabel.TabIndex = 0;
            dateLabel.Text = "28/05/2026";
            dateLabel.TextAlign = ContentAlignment.MiddleRight;
            dateLabel.ThemeAuthor = "Taiizor";
            dateLabel.ThemeName = "MetroDark";
            // 
            // sysTitleLabel
            // 
            sysTitleLabel.AutoSize = true;
            sysTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sysTitleLabel.ForeColor = Color.FromArgb(0, 230, 210);
            sysTitleLabel.Location = new Point(6, 0);
            sysTitleLabel.Margin = new Padding(2, 0, 2, 0);
            sysTitleLabel.Name = "sysTitleLabel";
            sysTitleLabel.Size = new Size(99, 20);
            sysTitleLabel.TabIndex = 16;
            sysTitleLabel.Text = "// SYSTEM    ";
            // 
            // trackInfoTitle
            // 
            trackInfoTitle.AutoSize = true;
            trackInfoTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            trackInfoTitle.ForeColor = Color.White;
            trackInfoTitle.Location = new Point(428, 25);
            trackInfoTitle.Margin = new Padding(2, 0, 2, 0);
            trackInfoTitle.Name = "trackInfoTitle";
            trackInfoTitle.Size = new Size(110, 23);
            trackInfoTitle.TabIndex = 17;
            trackInfoTitle.Text = "TRACK INFO";
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.Font = new Font("Segoe UI", 9F);
            formatLabel.ForeColor = Color.FromArgb(120, 120, 120);
            formatLabel.Location = new Point(428, 55);
            formatLabel.Margin = new Padding(2, 0, 2, 0);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(66, 20);
            formatLabel.TabIndex = 18;
            formatLabel.Text = "FORMAT";
            // 
            // formatValue
            // 
            formatValue.AutoSize = true;
            formatValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            formatValue.ForeColor = Color.FromArgb(0, 230, 210);
            formatValue.Location = new Point(428, 75);
            formatValue.Margin = new Padding(2, 0, 2, 0);
            formatValue.Name = "formatValue";
            formatValue.Size = new Size(17, 23);
            formatValue.TabIndex = 19;
            formatValue.Text = "-";
            // 
            // fileSizeLabel
            // 
            fileSizeLabel.AutoSize = true;
            fileSizeLabel.Font = new Font("Segoe UI", 9F);
            fileSizeLabel.ForeColor = Color.FromArgb(120, 120, 120);
            fileSizeLabel.Location = new Point(428, 100);
            fileSizeLabel.Margin = new Padding(2, 0, 2, 0);
            fileSizeLabel.Name = "fileSizeLabel";
            fileSizeLabel.Size = new Size(68, 20);
            fileSizeLabel.TabIndex = 20;
            fileSizeLabel.Text = "FILE SIZE";
            // 
            // fileSizeValue
            // 
            fileSizeValue.AutoSize = true;
            fileSizeValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            fileSizeValue.ForeColor = Color.FromArgb(0, 230, 210);
            fileSizeValue.Location = new Point(428, 120);
            fileSizeValue.Margin = new Padding(2, 0, 2, 0);
            fileSizeValue.Name = "fileSizeValue";
            fileSizeValue.Size = new Size(17, 23);
            fileSizeValue.TabIndex = 21;
            fileSizeValue.Text = "-";
            // 
            // bitrateLabel
            // 
            bitrateLabel.AutoSize = true;
            bitrateLabel.Font = new Font("Segoe UI", 9F);
            bitrateLabel.ForeColor = Color.FromArgb(120, 120, 120);
            bitrateLabel.Location = new Point(668, 55);
            bitrateLabel.Margin = new Padding(2, 0, 2, 0);
            bitrateLabel.Name = "bitrateLabel";
            bitrateLabel.Size = new Size(64, 20);
            bitrateLabel.TabIndex = 22;
            bitrateLabel.Text = "BITRATE";
            // 
            // bitrateValue
            // 
            bitrateValue.AutoSize = true;
            bitrateValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bitrateValue.ForeColor = Color.FromArgb(0, 230, 210);
            bitrateValue.Location = new Point(668, 75);
            bitrateValue.Margin = new Padding(2, 0, 2, 0);
            bitrateValue.Name = "bitrateValue";
            bitrateValue.Size = new Size(17, 23);
            bitrateValue.TabIndex = 23;
            bitrateValue.Text = "-";
            // 
            // sampleRateLabel
            // 
            sampleRateLabel.AutoSize = true;
            sampleRateLabel.Font = new Font("Segoe UI", 9F);
            sampleRateLabel.ForeColor = Color.FromArgb(120, 120, 120);
            sampleRateLabel.Location = new Point(1000, 50);
            sampleRateLabel.Margin = new Padding(2, 0, 2, 0);
            sampleRateLabel.Name = "sampleRateLabel";
            sampleRateLabel.Size = new Size(101, 20);
            sampleRateLabel.TabIndex = 24;
            sampleRateLabel.Text = "SAMPLE RATE";
            // 
            // sampleRateValue
            // 
            sampleRateValue.AutoSize = true;
            sampleRateValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            sampleRateValue.ForeColor = Color.FromArgb(0, 230, 210);
            sampleRateValue.Location = new Point(1000, 70);
            sampleRateValue.Margin = new Padding(2, 0, 2, 0);
            sampleRateValue.Name = "sampleRateValue";
            sampleRateValue.Size = new Size(81, 23);
            sampleRateValue.TabIndex = 25;
            sampleRateValue.Text = "44.1 kHz";
            // 
            // albumLabel
            // 
            albumLabel.AutoSize = true;
            albumLabel.Font = new Font("Segoe UI", 9F);
            albumLabel.ForeColor = Color.FromArgb(120, 120, 120);
            albumLabel.Location = new Point(668, 100);
            albumLabel.Margin = new Padding(2, 0, 2, 0);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new Size(58, 20);
            albumLabel.TabIndex = 26;
            albumLabel.Text = "ALBUM";
            // 
            // albumValue
            // 
            albumValue.AutoSize = true;
            albumValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            albumValue.ForeColor = Color.FromArgb(0, 230, 210);
            albumValue.Location = new Point(668, 120);
            albumValue.Margin = new Padding(2, 0, 2, 0);
            albumValue.Name = "albumValue";
            albumValue.Size = new Size(17, 23);
            albumValue.TabIndex = 27;
            albumValue.Text = "-";
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Font = new Font("Segoe UI", 9F);
            sourceLabel.ForeColor = Color.FromArgb(120, 120, 120);
            sourceLabel.Location = new Point(1000, 95);
            sourceLabel.Margin = new Padding(2, 0, 2, 0);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new Size(64, 20);
            sourceLabel.TabIndex = 28;
            sourceLabel.Text = "SOURCE";
            // 
            // sourceValue
            // 
            sourceValue.AutoSize = true;
            sourceValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            sourceValue.ForeColor = Color.FromArgb(0, 230, 210);
            sourceValue.Location = new Point(1000, 115);
            sourceValue.Margin = new Padding(2, 0, 2, 0);
            sourceValue.Name = "sourceValue";
            sourceValue.Size = new Size(51, 23);
            sourceValue.TabIndex = 29;
            sourceValue.Text = "Local";
            // 
            // volumeValueLabel
            // 
            volumeValueLabel.AutoSize = true;
            volumeValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            volumeValueLabel.ForeColor = Color.FromArgb(220, 220, 220);
            volumeValueLabel.Location = new Point(1477, 209);
            volumeValueLabel.Margin = new Padding(2, 0, 2, 0);
            volumeValueLabel.Name = "volumeValueLabel";
            volumeValueLabel.Size = new Size(27, 20);
            volumeValueLabel.TabIndex = 30;
            volumeValueLabel.Text = "70";
            // 
            // streamDotLabel
            // 
            streamDotLabel.AutoSize = true;
            streamDotLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            streamDotLabel.ForeColor = Color.FromArgb(0, 230, 210);
            streamDotLabel.Location = new Point(1722, 92);
            streamDotLabel.Margin = new Padding(2, 0, 2, 0);
            streamDotLabel.Name = "streamDotLabel";
            streamDotLabel.Size = new Size(17, 23);
            streamDotLabel.TabIndex = 31;
            streamDotLabel.Text = "•";
            // 
            // streamActiveLabel
            // 
            streamActiveLabel.AutoSize = true;
            streamActiveLabel.Font = new Font("Segoe UI", 9F);
            streamActiveLabel.ForeColor = Color.FromArgb(0, 230, 210);
            streamActiveLabel.Location = new Point(1734, 95);
            streamActiveLabel.Margin = new Padding(2, 0, 2, 0);
            streamActiveLabel.Name = "streamActiveLabel";
            streamActiveLabel.Size = new Size(117, 20);
            streamActiveLabel.TabIndex = 32;
            streamActiveLabel.Text = "STREAM ACTIVE";
            // 
            // controlBox
            // 
            controlBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            controlBox.BackColor = Color.FromArgb(12, 6, 18);
            controlBox.Controls.Add(totalTime);
            controlBox.Controls.Add(currentTime);
            controlBox.Controls.Add(textBox1);
            controlBox.Controls.Add(metroProgressBar1);
            controlBox.Controls.Add(label3);
            controlBox.Controls.Add(loopButton);
            controlBox.Controls.Add(previousButton);
            controlBox.Controls.Add(skipButton);
            controlBox.Controls.Add(playButton);
            controlBox.Controls.Add(Artistt);
            controlBox.Controls.Add(Titlee);
            controlBox.Controls.Add(artBox);
            controlBox.Font = new Font("Castellar", 10.2F);
            controlBox.ForeColor = Color.FromArgb(0, 230, 210);
            controlBox.Location = new Point(454, 12);
            controlBox.Margin = new Padding(2, 3, 2, 3);
            controlBox.Name = "controlBox";
            controlBox.Padding = new Padding(2, 3, 2, 3);
            controlBox.Size = new Size(1438, 818);
            controlBox.TabIndex = 5;
            controlBox.TabStop = false;
            // 
            // totalTime
            // 
            totalTime.AutoSize = true;
            totalTime.Font = new Font("Segoe UI", 8F);
            totalTime.ForeColor = Color.White;
            totalTime.Location = new Point(1109, 599);
            totalTime.Margin = new Padding(2, 0, 2, 0);
            totalTime.Name = "totalTime";
            totalTime.Size = new Size(44, 19);
            totalTime.TabIndex = 40;
            totalTime.Text = "00:00";
            totalTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // currentTime
            // 
            currentTime.AutoSize = true;
            currentTime.Font = new Font("Segoe UI", 8F);
            currentTime.ForeColor = Color.White;
            currentTime.Location = new Point(290, 599);
            currentTime.Margin = new Padding(2, 0, 2, 0);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(44, 19);
            currentTime.TabIndex = 39;
            currentTime.Text = "00:00";
            currentTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(12, 6, 18);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(0, 230, 210);
            textBox1.Location = new Point(14, 370);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1406, 27);
            textBox1.TabIndex = 38;
            textBox1.Text = "NOW PLAYING";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // metroProgressBar1
            // 
            metroProgressBar1.BackgroundColor = Color.FromArgb(205, 205, 205);
            metroProgressBar1.DisabledBackColor = Color.FromArgb(235, 235, 235);
            metroProgressBar1.DisabledBorderColor = Color.Empty;
            metroProgressBar1.DisabledHandlerColor = Color.FromArgb(196, 196, 196);
            metroProgressBar1.DisabledValueColor = Color.FromArgb(205, 205, 205);
            metroProgressBar1.HandlerColor = Color.FromArgb(180, 180, 180);
            metroProgressBar1.IsDerivedStyle = true;
            metroProgressBar1.Location = new Point(290, 580);
            metroProgressBar1.Margin = new Padding(2, 3, 2, 3);
            metroProgressBar1.Maximum = 100;
            metroProgressBar1.Minimum = 0;
            metroProgressBar1.Name = "metroProgressBar1";
            metroProgressBar1.Size = new Size(854, 16);
            metroProgressBar1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroProgressBar1.StyleManager = null;
            metroProgressBar1.TabIndex = 37;
            metroProgressBar1.Text = "metroTrackBar1";
            metroProgressBar1.ThemeAuthor = "Taiizor";
            metroProgressBar1.ThemeName = "MetroLight";
            metroProgressBar1.Value = 0;
            metroProgressBar1.ValueColor = Color.Cyan;
            metroProgressBar1.MouseDown += metroProgressBar1_MouseDown;
            metroProgressBar1.MouseUp += metroProgressBar1_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 230, 210);
            label3.Location = new Point(14, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 36;
            label3.Text = "// PLAYBACK    ";
            // 
            // loopButton
            // 
            loopButton.BackgroundImageLayout = ImageLayout.Center;
            loopButton.Cursor = Cursors.Hand;
            loopButton.Location = new Point(958, 471);
            loopButton.Margin = new Padding(2, 3, 2, 3);
            loopButton.Name = "loopButton";
            loopButton.Size = new Size(53, 53);
            loopButton.SizeMode = PictureBoxSizeMode.StretchImage;
            loopButton.TabIndex = 11;
            loopButton.TabStop = false;
            loopButton.Click += loopButton_Click;
            // 
            // previousButton
            // 
            previousButton.BackgroundImageLayout = ImageLayout.Center;
            previousButton.Cursor = Cursors.Hand;
            previousButton.Image = Properties.Resources.previous;
            previousButton.Location = new Point(626, 490);
            previousButton.Margin = new Padding(2, 3, 2, 3);
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
            skipButton.Cursor = Cursors.Hand;
            skipButton.Image = Properties.Resources.skip;
            skipButton.Location = new Point(758, 490);
            skipButton.Margin = new Padding(2, 3, 2, 3);
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
            playButton.Cursor = Cursors.Hand;
            playButton.Image = Properties.Resources.play;
            playButton.Location = new Point(692, 490);
            playButton.Margin = new Padding(2, 3, 2, 3);
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
            Artistt.BackColor = Color.FromArgb(12, 6, 18);
            Artistt.BorderStyle = BorderStyle.None;
            Artistt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Artistt.ForeColor = Color.FromArgb(120, 120, 120);
            Artistt.Location = new Point(14, 438);
            Artistt.Margin = new Padding(2, 3, 2, 3);
            Artistt.Name = "Artistt";
            Artistt.ReadOnly = true;
            Artistt.ScrollBars = ScrollBars.Horizontal;
            Artistt.Size = new Size(1406, 27);
            Artistt.TabIndex = 3;
            Artistt.Text = "-";
            Artistt.TextAlign = HorizontalAlignment.Center;
            // 
            // Titlee
            // 
            Titlee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titlee.BackColor = Color.FromArgb(12, 6, 18);
            Titlee.BorderStyle = BorderStyle.None;
            Titlee.Font = new Font("Segoe UI Black", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titlee.ForeColor = Color.White;
            Titlee.Location = new Point(14, 403);
            Titlee.Margin = new Padding(2, 3, 2, 3);
            Titlee.Name = "Titlee";
            Titlee.ReadOnly = true;
            Titlee.Size = new Size(1406, 38);
            Titlee.TabIndex = 2;
            Titlee.Text = "-";
            Titlee.TextAlign = HorizontalAlignment.Center;
            // 
            // artBox
            // 
            artBox.BorderStyle = BorderStyle.FixedSingle;
            artBox.Image = Properties.Resources.empty;
            artBox.Location = new Point(554, 44);
            artBox.Margin = new Padding(2, 3, 2, 3);
            artBox.Name = "artBox";
            artBox.Size = new Size(320, 320);
            artBox.SizeMode = PictureBoxSizeMode.StretchImage;
            artBox.TabIndex = 1;
            artBox.TabStop = false;
            // 
            // timer33ms
            // 
            timer33ms.Enabled = true;
            timer33ms.Interval = 33;
            timer33ms.Tick += timer33ms_Tick;
            // 
            // metroDivider4
            // 
            metroDivider4.IsDerivedStyle = true;
            metroDivider4.Location = new Point(1888, 797);
            metroDivider4.Margin = new Padding(2, 3, 2, 3);
            metroDivider4.Name = "metroDivider4";
            metroDivider4.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Vertical;
            metroDivider4.Size = new Size(4, 30);
            metroDivider4.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            metroDivider4.StyleManager = null;
            metroDivider4.TabIndex = 8;
            metroDivider4.Text = "metroDivider4";
            metroDivider4.ThemeAuthor = "Taiizor";
            metroDivider4.ThemeName = "";
            metroDivider4.Thickness = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 0, 20);
            ClientSize = new Size(1918, 1078);
            ControlBox = false;
            Controls.Add(metroDivider4);
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
            Load += Form1_LoadAsync;
            songBox1.ResumeLayout(false);
            songBox1.PerformLayout();
            systemBox.ResumeLayout(false);
            systemBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).EndInit();
            controlBox.ResumeLayout(false);
            controlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loopButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)previousButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)skipButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)playButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)artBox).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Timer timer33ms;
        private ReaLTaiizor.Controls.MetroLabel timeLabel;
        private ReaLTaiizor.Controls.ForeverTextBox searchBox;
        private PictureBox playButton;
        private TextBox lyricsBox;
        private PictureBox previousButton;
        private PictureBox skipButton;
        private PictureBox loopButton;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ReaLTaiizor.Controls.PoisonButton localButton;
        private ReaLTaiizor.Controls.PoisonButton onlineButton;
        private ReaLTaiizor.Controls.PoisonDropDownButton sortButton;
        private Panel panel1;
        // System info labels
        private Label sysTitleLabel;
        private Label trackInfoTitle;
        private Label formatLabel;
        private Label formatValue;
        private Label fileSizeLabel;
        private Label fileSizeValue;
        private Label bitrateLabel;
        private Label bitrateValue;
        private Label sampleRateLabel;
        private Label sampleRateValue;
        private Label albumLabel;
        private Label albumValue;
        private Label sourceLabel;
        private Label sourceValue;
        private Label volumeValueLabel;
        private Label streamActiveLabel;
        private Label streamDotLabel;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.MetroDivider metroDivider3;
        private ReaLTaiizor.Controls.MetroDivider metroDivider2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider4;
        private TrackBar volumeBar;
        private Label label2;
        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.MetroTrackBar metroProgressBar1;
        private TextBox textBox1;
        private ListBox onlineList;
        private Label currentTime;
        private Label totalTime;
    }
}
