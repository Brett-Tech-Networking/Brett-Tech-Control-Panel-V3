namespace Brett_Tech_Control_Panel_V3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Time = new MetroFramework.Controls.MetroLabel();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.PowerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ShutdownOptionsLabel = new MetroFramework.Controls.MetroLabel();
            this.PowerOptions = new System.Windows.Forms.Timer(this.components);
            this.TabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Main = new MetroFramework.Controls.MetroTabPage();
            this.CPURAM = new MetroFramework.Controls.MetroTabPage();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.UpdateChecker = new MetroFramework.Controls.MetroButton();
            this.aboiutinfo = new MetroFramework.Controls.MetroLabel();
            this.TaskManager = new MetroFramework.Controls.MetroTabPage();
            this.VirusScanner = new MetroFramework.Controls.MetroTabPage();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.DriveCombo = new MetroFramework.Controls.MetroComboBox();
            this.ScanButton = new MetroFramework.Controls.MetroButton();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.DriveScanTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshdrives = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Diagnostics.PerformanceCounter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CPULabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ram = new System.Diagnostics.PerformanceCounter();
            this.cpuRamTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.CPURAM.SuspendLayout();
            this.About.SuspendLayout();
            this.VirusScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshdrives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Time.AutoSize = true;
            this.Time.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Time.Location = new System.Drawing.Point(3, 640);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(93, 20);
            this.Time.Style = MetroFramework.MetroColorStyle.Red;
            this.Time.TabIndex = 1;
            this.Time.Text = "00:00:00:00";
            this.Time.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Time.UseStyleColors = true;
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // PowerComboBox
            // 
            this.PowerComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PowerComboBox.FormattingEnabled = true;
            this.PowerComboBox.ItemHeight = 24;
            this.PowerComboBox.Items.AddRange(new object[] {
            "Shutdown",
            "Shutdown (abort)",
            "Hibernate",
            "Restart",
            "Logout"});
            this.PowerComboBox.Location = new System.Drawing.Point(252, 479);
            this.PowerComboBox.Name = "PowerComboBox";
            this.PowerComboBox.PromptText = "Please Make A Selection";
            this.PowerComboBox.Size = new System.Drawing.Size(526, 30);
            this.PowerComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PowerComboBox.TabIndex = 2;
            this.PowerComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PowerComboBox.UseSelectable = true;
            this.PowerComboBox.UseStyleColors = true;
            // 
            // ShutdownOptionsLabel
            // 
            this.ShutdownOptionsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ShutdownOptionsLabel.AutoSize = true;
            this.ShutdownOptionsLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ShutdownOptionsLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ShutdownOptionsLabel.Location = new System.Drawing.Point(428, 440);
            this.ShutdownOptionsLabel.Name = "ShutdownOptionsLabel";
            this.ShutdownOptionsLabel.Size = new System.Drawing.Size(135, 25);
            this.ShutdownOptionsLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ShutdownOptionsLabel.TabIndex = 3;
            this.ShutdownOptionsLabel.Text = "Power Options";
            this.ShutdownOptionsLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShutdownOptionsLabel.UseStyleColors = true;
            // 
            // PowerOptions
            // 
            this.PowerOptions.Enabled = true;
            this.PowerOptions.Interval = 1000;
            this.PowerOptions.Tick += new System.EventHandler(this.PowerOptions_Tick);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.Main);
            this.TabControl1.Controls.Add(this.CPURAM);
            this.TabControl1.Controls.Add(this.TaskManager);
            this.TabControl1.Controls.Add(this.VirusScanner);
            this.TabControl1.Controls.Add(this.About);
            this.TabControl1.Location = new System.Drawing.Point(3, 63);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 1;
            this.TabControl1.Size = new System.Drawing.Size(1062, 564);
            this.TabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TabControl1.TabIndex = 4;
            this.TabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl1.UseSelectable = true;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.ShutdownOptionsLabel);
            this.Main.Controls.Add(this.PowerComboBox);
            this.Main.HorizontalScrollbarBarColor = true;
            this.Main.HorizontalScrollbarHighlightOnWheel = false;
            this.Main.HorizontalScrollbarSize = 10;
            this.Main.Location = new System.Drawing.Point(4, 38);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1054, 522);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Main.VerticalScrollbarBarColor = true;
            this.Main.VerticalScrollbarHighlightOnWheel = false;
            this.Main.VerticalScrollbarSize = 10;
            // 
            // CPURAM
            // 
            this.CPURAM.Controls.Add(this.MemoryLabel);
            this.CPURAM.Controls.Add(this.CPULabel);
            this.CPURAM.Controls.Add(this.pictureBox2);
            this.CPURAM.Controls.Add(this.pictureBox1);
            this.CPURAM.HorizontalScrollbarBarColor = true;
            this.CPURAM.HorizontalScrollbarHighlightOnWheel = false;
            this.CPURAM.HorizontalScrollbarSize = 10;
            this.CPURAM.Location = new System.Drawing.Point(4, 38);
            this.CPURAM.Name = "CPURAM";
            this.CPURAM.Size = new System.Drawing.Size(1054, 522);
            this.CPURAM.TabIndex = 1;
            this.CPURAM.Text = "CPU/RAM";
            this.CPURAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CPURAM.VerticalScrollbarBarColor = true;
            this.CPURAM.VerticalScrollbarHighlightOnWheel = false;
            this.CPURAM.VerticalScrollbarSize = 10;
            // 
            // About
            // 
            this.About.Controls.Add(this.UpdateChecker);
            this.About.Controls.Add(this.aboiutinfo);
            this.About.HorizontalScrollbarBarColor = true;
            this.About.HorizontalScrollbarHighlightOnWheel = false;
            this.About.HorizontalScrollbarSize = 10;
            this.About.Location = new System.Drawing.Point(4, 38);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(1054, 522);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.About.VerticalScrollbarBarColor = true;
            this.About.VerticalScrollbarHighlightOnWheel = false;
            this.About.VerticalScrollbarSize = 10;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // UpdateChecker
            // 
            this.UpdateChecker.DisplayFocus = true;
            this.UpdateChecker.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UpdateChecker.Location = new System.Drawing.Point(883, 10);
            this.UpdateChecker.Name = "UpdateChecker";
            this.UpdateChecker.Size = new System.Drawing.Size(163, 43);
            this.UpdateChecker.Style = MetroFramework.MetroColorStyle.Yellow;
            this.UpdateChecker.TabIndex = 3;
            this.UpdateChecker.Text = "Check For Updates";
            this.UpdateChecker.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdateChecker.UseSelectable = true;
            this.UpdateChecker.UseStyleColors = true;
            this.UpdateChecker.Click += new System.EventHandler(this.UpdateChecker_Click);
            // 
            // aboiutinfo
            // 
            this.aboiutinfo.AutoSize = true;
            this.aboiutinfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.aboiutinfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.aboiutinfo.Location = new System.Drawing.Point(0, 10);
            this.aboiutinfo.Name = "aboiutinfo";
            this.aboiutinfo.Size = new System.Drawing.Size(639, 225);
            this.aboiutinfo.Style = MetroFramework.MetroColorStyle.Red;
            this.aboiutinfo.TabIndex = 2;
            this.aboiutinfo.Text = resources.GetString("aboiutinfo.Text");
            this.aboiutinfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aboiutinfo.UseStyleColors = true;
            // 
            // TaskManager
            // 
            this.TaskManager.HorizontalScrollbarBarColor = true;
            this.TaskManager.HorizontalScrollbarHighlightOnWheel = false;
            this.TaskManager.HorizontalScrollbarSize = 10;
            this.TaskManager.Location = new System.Drawing.Point(4, 38);
            this.TaskManager.Name = "TaskManager";
            this.TaskManager.Size = new System.Drawing.Size(1054, 522);
            this.TaskManager.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TaskManager.TabIndex = 3;
            this.TaskManager.Text = "Task Manager";
            this.TaskManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TaskManager.VerticalScrollbarBarColor = true;
            this.TaskManager.VerticalScrollbarHighlightOnWheel = false;
            this.TaskManager.VerticalScrollbarSize = 10;
            // 
            // VirusScanner
            // 
            this.VirusScanner.Controls.Add(this.refreshdrives);
            this.VirusScanner.Controls.Add(this.metroListView2);
            this.VirusScanner.Controls.Add(this.metroListView1);
            this.VirusScanner.Controls.Add(this.ScanButton);
            this.VirusScanner.Controls.Add(this.DriveCombo);
            this.VirusScanner.Controls.Add(this.metroProgressBar1);
            this.VirusScanner.HorizontalScrollbarBarColor = true;
            this.VirusScanner.HorizontalScrollbarHighlightOnWheel = false;
            this.VirusScanner.HorizontalScrollbarSize = 10;
            this.VirusScanner.Location = new System.Drawing.Point(4, 38);
            this.VirusScanner.Name = "VirusScanner";
            this.VirusScanner.Size = new System.Drawing.Size(1054, 522);
            this.VirusScanner.Style = MetroFramework.MetroColorStyle.Yellow;
            this.VirusScanner.TabIndex = 4;
            this.VirusScanner.Text = "Virus Scanner";
            this.VirusScanner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VirusScanner.VerticalScrollbarBarColor = true;
            this.VirusScanner.VerticalScrollbarHighlightOnWheel = false;
            this.VirusScanner.VerticalScrollbarSize = 10;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(-4, 496);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(1062, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroProgressBar1.TabIndex = 2;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DriveCombo
            // 
            this.DriveCombo.FormattingEnabled = true;
            this.DriveCombo.ItemHeight = 24;
            this.DriveCombo.Location = new System.Drawing.Point(199, 423);
            this.DriveCombo.Name = "DriveCombo";
            this.DriveCombo.PromptText = "Select A Drive To Scan";
            this.DriveCombo.Size = new System.Drawing.Size(660, 30);
            this.DriveCombo.Style = MetroFramework.MetroColorStyle.Red;
            this.DriveCombo.TabIndex = 3;
            this.DriveCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DriveCombo.UseSelectable = true;
            // 
            // ScanButton
            // 
            this.ScanButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ScanButton.Highlight = true;
            this.ScanButton.Location = new System.Drawing.Point(55, 443);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(112, 47);
            this.ScanButton.Style = MetroFramework.MetroColorStyle.Red;
            this.ScanButton.TabIndex = 4;
            this.ScanButton.Text = "Scan";
            this.ScanButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ScanButton.UseSelectable = true;
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.Black;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.ForeColor = System.Drawing.Color.Yellow;
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(37, 61);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(487, 357);
            this.metroListView1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroListView1.TabIndex = 5;
            this.metroListView1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseCustomBackColor = true;
            this.metroListView1.UseCustomForeColor = true;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.UseStyleColors = true;
            this.metroListView1.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // metroListView2
            // 
            this.metroListView2.BackColor = System.Drawing.Color.Black;
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.ForeColor = System.Drawing.Color.Yellow;
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(530, 61);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(487, 357);
            this.metroListView2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroListView2.TabIndex = 5;
            this.metroListView2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseCustomBackColor = true;
            this.metroListView2.UseCustomForeColor = true;
            this.metroListView2.UseSelectable = true;
            this.metroListView2.UseStyleColors = true;
            // 
            // DriveScanTimer
            // 
            this.DriveScanTimer.Enabled = true;
            this.DriveScanTimer.Interval = 1000;
            this.DriveScanTimer.Tick += new System.EventHandler(this.DriveScanComboBox_Tick);
            // 
            // refreshdrives
            // 
            this.refreshdrives.BackColor = System.Drawing.Color.Transparent;
            this.refreshdrives.BackgroundImage = global::Brett_Tech_Control_Panel_V3.Properties.Resources.refresh1;
            this.refreshdrives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshdrives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshdrives.Location = new System.Drawing.Point(867, 425);
            this.refreshdrives.Name = "refreshdrives";
            this.refreshdrives.Size = new System.Drawing.Size(35, 28);
            this.refreshdrives.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshdrives.TabIndex = 6;
            this.refreshdrives.TabStop = false;
            this.refreshdrives.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cpu
            // 
            this.cpu.CategoryName = "Processor";
            this.cpu.CounterName = "% Processor Time";
            this.cpu.InstanceName = "_Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(16, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 193);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(16, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1035, 193);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.BackColor = System.Drawing.Color.Black;
            this.CPULabel.ForeColor = System.Drawing.Color.Lime;
            this.CPULabel.Location = new System.Drawing.Point(16, 36);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(81, 17);
            this.CPULabel.TabIndex = 4;
            this.CPULabel.Text = "CPU Usage";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.BackColor = System.Drawing.Color.Black;
            this.MemoryLabel.ForeColor = System.Drawing.Color.Lime;
            this.MemoryLabel.Location = new System.Drawing.Point(16, 282);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(103, 17);
            this.MemoryLabel.TabIndex = 4;
            this.MemoryLabel.Text = "Memory Usage";
            // 
            // ram
            // 
            this.ram.CategoryName = "Memory";
            this.ram.CounterName = "% Committed bytes in use";
            // 
            // cpuRamTimer
            // 
            this.cpuRamTimer.Enabled = true;
            this.cpuRamTimer.Interval = 500;
            this.cpuRamTimer.Tick += new System.EventHandler(this.CPUTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 668);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Time);
            this.Name = "Form1";
            this.Text = "Brett Tech Control Panel V3";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.CPURAM.ResumeLayout(false);
            this.CPURAM.PerformLayout();
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.VirusScanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshdrives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel Time;
        private System.Windows.Forms.Timer Clock;
        private MetroFramework.Controls.MetroComboBox PowerComboBox;
        private MetroFramework.Controls.MetroLabel ShutdownOptionsLabel;
        private System.Windows.Forms.Timer PowerOptions;
        private MetroFramework.Controls.MetroTabControl TabControl1;
        private MetroFramework.Controls.MetroTabPage Main;
        private MetroFramework.Controls.MetroTabPage CPURAM;
        private MetroFramework.Controls.MetroTabPage About;
        private MetroFramework.Controls.MetroLabel aboiutinfo;
        private MetroFramework.Controls.MetroButton UpdateChecker;
        private MetroFramework.Controls.MetroTabPage TaskManager;
        private MetroFramework.Controls.MetroTabPage VirusScanner;
        private MetroFramework.Controls.MetroListView metroListView2;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroButton ScanButton;
        private MetroFramework.Controls.MetroComboBox DriveCombo;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer DriveScanTimer;
        private System.Windows.Forms.PictureBox refreshdrives;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.PerformanceCounter cpu;
        private System.Diagnostics.PerformanceCounter ram;
        private System.Windows.Forms.Timer cpuRamTimer;
    }
}

