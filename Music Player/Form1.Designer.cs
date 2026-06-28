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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            groupBox3 = new GroupBox();
            metroProgressBar1 = new ReaLTaiizor.Controls.PoisonProgressBar();
            Artistt = new TextBox();
            Titlee = new TextBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Castellar", 10.2F);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 645);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Songs";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(532, 43);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 20, 0);
            panel1.Size = new Size(43, 575);
            panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaptionText;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Castellar", 10.2F);
            listBox1.ForeColor = SystemColors.ActiveCaptionText;
            listBox1.FormattingEnabled = true;
            listBox1.IntegralHeight = false;
            listBox1.Location = new Point(12, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(563, 575);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(metroLabel2);
            groupBox2.Controls.Add(metroLabel1);
            groupBox2.Font = new Font("Castellar", 10.2F);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(12, 656);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1900, 410);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "System";
            // 
            // metroLabel2
            // 
            metroLabel2.Anchor = AnchorStyles.None;
            metroLabel2.Font = new Font("Castellar", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            metroLabel2.ImageAlign = ContentAlignment.BottomRight;
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new Point(1741, 352);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.RightToLeft = RightToLeft.No;
            metroLabel2.Size = new Size(159, 29);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 1;
            metroLabel2.Text = "14:45:01";
            metroLabel2.TextAlign = ContentAlignment.BottomRight;
            metroLabel2.ThemeAuthor = "Taiizor";
            metroLabel2.ThemeName = "MetroDark";
            // 
            // metroLabel1
            // 
            metroLabel1.Anchor = AnchorStyles.None;
            metroLabel1.Font = new Font("Castellar", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            metroLabel1.ImageAlign = ContentAlignment.MiddleRight;
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(1741, 381);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(159, 29);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "28/05/2026";
            metroLabel1.TextAlign = ContentAlignment.MiddleRight;
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroDark";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(metroProgressBar1);
            groupBox3.Controls.Add(Artistt);
            groupBox3.Controls.Add(Titlee);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Font = new Font("Castellar", 10.2F);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(593, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1319, 645);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Control";
            // 
            // metroProgressBar1
            // 
            metroProgressBar1.ForeColor = Color.IndianRed;
            metroProgressBar1.Location = new Point(11, 508);
            metroProgressBar1.MarqueeAnimationSpeed = 1000;
            metroProgressBar1.Name = "metroProgressBar1";
            metroProgressBar1.ProgressBarMarqueeWidth = 434;
            metroProgressBar1.Size = new Size(1302, 10);
            metroProgressBar1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Red;
            metroProgressBar1.TabIndex = 4;
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
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(533, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Font = new Font("Castellar", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox Titlee;
        private TextBox Artistt;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.PoisonProgressBar metroProgressBar1;
    }
}
