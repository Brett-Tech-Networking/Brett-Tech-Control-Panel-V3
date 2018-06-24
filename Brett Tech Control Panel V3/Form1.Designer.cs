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
            this.SystemInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.Notice = new MetroFramework.Controls.MetroLabel();
            this.sysInfo = new MetroFramework.Controls.MetroLabel();
            this.SSID = new MetroFramework.Controls.MetroLabel();
            this.PCName = new MetroFramework.Controls.MetroLabel();
            this.YourIP = new MetroFramework.Controls.MetroLabel();
            this.CPURAM = new MetroFramework.Controls.MetroTabPage();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VirusScanner = new MetroFramework.Controls.MetroTabPage();
            this.refreshdrives = new System.Windows.Forms.PictureBox();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.ScanButton = new MetroFramework.Controls.MetroButton();
            this.DriveCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.TaskManager = new MetroFramework.Controls.MetroTabPage();
            this.RefreshProcesses = new MetroFramework.Controls.MetroButton();
            this.KillProcess = new MetroFramework.Controls.MetroButton();
            this.StartTask = new MetroFramework.Controls.MetroButton();
            this.StartTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TaskManRighClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.aboiutinfo = new MetroFramework.Controls.MetroLabel();
            this.UpdateChecker = new MetroFramework.Controls.MetroButton();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.MouseSensitivity = new MetroFramework.Controls.MetroPanel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.MouseSpeedLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.TimePink = new MetroFramework.Controls.MetroRadioButton();
            this.TimeBrown = new MetroFramework.Controls.MetroRadioButton();
            this.TimeLime = new MetroFramework.Controls.MetroRadioButton();
            this.TimeOrange = new MetroFramework.Controls.MetroRadioButton();
            this.TimeBlue = new MetroFramework.Controls.MetroRadioButton();
            this.TimeRed = new MetroFramework.Controls.MetroRadioButton();
            this.SetTimeColor = new MetroFramework.Controls.MetroButton();
            this.TimeColor = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TopMostFalse = new MetroFramework.Controls.MetroRadioButton();
            this.TopMostTrue = new MetroFramework.Controls.MetroRadioButton();
            this.SetTopMost = new MetroFramework.Controls.MetroButton();
            this.DriveScanTimer = new System.Windows.Forms.Timer(this.components);
            this.cpu = new System.Diagnostics.PerformanceCounter();
            this.ram = new System.Diagnostics.PerformanceCounter();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Opacity = new System.Windows.Forms.Timer(this.components);
            this.Username = new MetroFramework.Controls.MetroLabel();
            this.TabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.SystemInfoPanel.SuspendLayout();
            this.CPURAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.VirusScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshdrives)).BeginInit();
            this.TaskManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.TaskManRighClick.SuspendLayout();
            this.About.SuspendLayout();
            this.Settings.SuspendLayout();
            this.MouseSensitivity.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Time.AutoSize = true;
            this.Time.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Time.ForeColor = System.Drawing.Color.Red;
            this.Time.Location = new System.Drawing.Point(3, 640);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(93, 20);
            this.Time.Style = MetroFramework.MetroColorStyle.Red;
            this.Time.TabIndex = 1;
            this.Time.Text = "00:00:00:00";
            this.Time.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Time.UseCustomForeColor = true;
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
            this.PowerComboBox.Location = new System.Drawing.Point(252, 474);
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
            this.TabControl1.Controls.Add(this.VirusScanner);
            this.TabControl1.Controls.Add(this.TaskManager);
            this.TabControl1.Controls.Add(this.About);
            this.TabControl1.Controls.Add(this.Settings);
            this.TabControl1.Location = new System.Drawing.Point(3, 63);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1062, 564);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TabControl1.TabIndex = 4;
            this.TabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl1.UseSelectable = true;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.SystemInfoPanel);
            this.Main.Controls.Add(this.ShutdownOptionsLabel);
            this.Main.Controls.Add(this.PowerComboBox);
            this.Main.HorizontalScrollbarBarColor = true;
            this.Main.HorizontalScrollbarHighlightOnWheel = false;
            this.Main.HorizontalScrollbarSize = 10;
            this.Main.Location = new System.Drawing.Point(4, 38);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1054, 522);
            this.Main.Style = MetroFramework.MetroColorStyle.Blue;
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Main.UseStyleColors = true;
            this.Main.VerticalScrollbarBarColor = true;
            this.Main.VerticalScrollbarHighlightOnWheel = false;
            this.Main.VerticalScrollbarSize = 10;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // SystemInfoPanel
            // 
            this.SystemInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SystemInfoPanel.Controls.Add(this.Notice);
            this.SystemInfoPanel.Controls.Add(this.sysInfo);
            this.SystemInfoPanel.Controls.Add(this.SSID);
            this.SystemInfoPanel.Controls.Add(this.Username);
            this.SystemInfoPanel.Controls.Add(this.PCName);
            this.SystemInfoPanel.Controls.Add(this.YourIP);
            this.SystemInfoPanel.HorizontalScrollbarBarColor = true;
            this.SystemInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SystemInfoPanel.HorizontalScrollbarSize = 10;
            this.SystemInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.SystemInfoPanel.Name = "SystemInfoPanel";
            this.SystemInfoPanel.Size = new System.Drawing.Size(505, 227);
            this.SystemInfoPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.SystemInfoPanel.TabIndex = 6;
            this.SystemInfoPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SystemInfoPanel.UseStyleColors = true;
            this.SystemInfoPanel.VerticalScrollbarBarColor = true;
            this.SystemInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SystemInfoPanel.VerticalScrollbarSize = 10;
            // 
            // Notice
            // 
            this.Notice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Notice.AutoSize = true;
            this.Notice.FontSize = MetroFramework.MetroLabelSize.Small;
            this.Notice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Notice.Location = new System.Drawing.Point(11, 198);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(392, 17);
            this.Notice.Style = MetroFramework.MetroColorStyle.Red;
            this.Notice.TabIndex = 6;
            this.Notice.Text = "Please Note: No Information Shown Here Is Logged Or Shared";
            this.Notice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Notice.UseStyleColors = true;
            // 
            // sysInfo
            // 
            this.sysInfo.AutoSize = true;
            this.sysInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.sysInfo.Location = new System.Drawing.Point(3, 10);
            this.sysInfo.Name = "sysInfo";
            this.sysInfo.Size = new System.Drawing.Size(149, 20);
            this.sysInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.sysInfo.TabIndex = 5;
            this.sysInfo.Text = "System Information";
            this.sysInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sysInfo.UseStyleColors = true;
            // 
            // SSID
            // 
            this.SSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SSID.AutoSize = true;
            this.SSID.Location = new System.Drawing.Point(20, 45);
            this.SSID.Name = "SSID";
            this.SSID.Size = new System.Drawing.Size(124, 20);
            this.SSID.Style = MetroFramework.MetroColorStyle.Lime;
            this.SSID.TabIndex = 4;
            this.SSID.Text = "Current WIFI SSID: ";
            this.SSID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SSID.UseStyleColors = true;
            // 
            // PCName
            // 
            this.PCName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PCName.AutoSize = true;
            this.PCName.Location = new System.Drawing.Point(20, 105);
            this.PCName.Name = "PCName";
            this.PCName.Size = new System.Drawing.Size(103, 20);
            this.PCName.Style = MetroFramework.MetroColorStyle.Lime;
            this.PCName.TabIndex = 4;
            this.PCName.Text = "Your PC Name:";
            this.PCName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PCName.UseStyleColors = true;
            // 
            // YourIP
            // 
            this.YourIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.YourIP.AutoSize = true;
            this.YourIP.Location = new System.Drawing.Point(20, 74);
            this.YourIP.Name = "YourIP";
            this.YourIP.Size = new System.Drawing.Size(55, 20);
            this.YourIP.Style = MetroFramework.MetroColorStyle.Lime;
            this.YourIP.TabIndex = 4;
            this.YourIP.Text = "Your IP:";
            this.YourIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.YourIP.UseStyleColors = true;
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
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.BackColor = System.Drawing.Color.Black;
            this.MemoryLabel.ForeColor = System.Drawing.Color.Lime;
            this.MemoryLabel.Location = new System.Drawing.Point(16, 282);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(103, 17);
            this.MemoryLabel.TabIndex = 4;
            this.MemoryLabel.Text = "Memory Usage";
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(16, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1035, 193);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(16, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 193);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
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
            // refreshdrives
            // 
            this.refreshdrives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // metroListView2
            // 
            this.metroListView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // metroListView1
            // 
            this.metroListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // ScanButton
            // 
            this.ScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // DriveCombo
            // 
            this.DriveCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(-4, 496);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(1062, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroProgressBar1.TabIndex = 2;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TaskManager
            // 
            this.TaskManager.Controls.Add(this.RefreshProcesses);
            this.TaskManager.Controls.Add(this.KillProcess);
            this.TaskManager.Controls.Add(this.StartTask);
            this.TaskManager.Controls.Add(this.StartTextBox);
            this.TaskManager.Controls.Add(this.pictureBox3);
            this.TaskManager.Controls.Add(this.listBox1);
            this.TaskManager.ForeColor = System.Drawing.Color.Lime;
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
            this.TaskManager.Click += new System.EventHandler(this.TaskManager_Click);
            // 
            // RefreshProcesses
            // 
            this.RefreshProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshProcesses.DisplayFocus = true;
            this.RefreshProcesses.Highlight = true;
            this.RefreshProcesses.Location = new System.Drawing.Point(892, 3);
            this.RefreshProcesses.Name = "RefreshProcesses";
            this.RefreshProcesses.Size = new System.Drawing.Size(159, 30);
            this.RefreshProcesses.Style = MetroFramework.MetroColorStyle.Red;
            this.RefreshProcesses.TabIndex = 7;
            this.RefreshProcesses.Text = "Refresh Process List";
            this.RefreshProcesses.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RefreshProcesses.UseSelectable = true;
            this.RefreshProcesses.UseStyleColors = true;
            this.RefreshProcesses.Click += new System.EventHandler(this.RefreshProcesses_Click);
            // 
            // KillProcess
            // 
            this.KillProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KillProcess.DisplayFocus = true;
            this.KillProcess.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.KillProcess.Highlight = true;
            this.KillProcess.Location = new System.Drawing.Point(777, 99);
            this.KillProcess.Name = "KillProcess";
            this.KillProcess.Size = new System.Drawing.Size(104, 32);
            this.KillProcess.Style = MetroFramework.MetroColorStyle.Red;
            this.KillProcess.TabIndex = 6;
            this.KillProcess.Text = "Kill Process";
            this.KillProcess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KillProcess.UseSelectable = true;
            this.KillProcess.UseStyleColors = true;
            this.KillProcess.Click += new System.EventHandler(this.KillProcess_Click);
            // 
            // StartTask
            // 
            this.StartTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTask.DisplayFocus = true;
            this.StartTask.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.StartTask.Highlight = true;
            this.StartTask.Location = new System.Drawing.Point(854, 481);
            this.StartTask.Name = "StartTask";
            this.StartTask.Size = new System.Drawing.Size(82, 30);
            this.StartTask.Style = MetroFramework.MetroColorStyle.Yellow;
            this.StartTask.TabIndex = 4;
            this.StartTask.Text = "Start";
            this.StartTask.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StartTask.UseSelectable = true;
            this.StartTask.Click += new System.EventHandler(this.StartTask_Click);
            // 
            // StartTextBox
            // 
            this.StartTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.StartTextBox.CustomButton.Image = null;
            this.StartTextBox.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.StartTextBox.CustomButton.Name = "";
            this.StartTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.StartTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StartTextBox.CustomButton.TabIndex = 1;
            this.StartTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StartTextBox.CustomButton.UseSelectable = true;
            this.StartTextBox.CustomButton.Visible = false;
            this.StartTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StartTextBox.Lines = new string[0];
            this.StartTextBox.Location = new System.Drawing.Point(777, 440);
            this.StartTextBox.MaxLength = 32767;
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.PasswordChar = '\0';
            this.StartTextBox.PromptText = "Enter A Program To Start";
            this.StartTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StartTextBox.SelectedText = "";
            this.StartTextBox.SelectionLength = 0;
            this.StartTextBox.SelectionStart = 0;
            this.StartTextBox.ShortcutsEnabled = true;
            this.StartTextBox.Size = new System.Drawing.Size(253, 35);
            this.StartTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.StartTextBox.TabIndex = 3;
            this.StartTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StartTextBox.UseSelectable = true;
            this.StartTextBox.UseStyleColors = true;
            this.StartTextBox.WaterMark = "Enter A Program To Start";
            this.StartTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StartTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Brett_Tech_Control_Panel_V3.Properties.Resources.task_manager;
            this.pictureBox3.Location = new System.Drawing.Point(777, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ContextMenuStrip = this.TaskManRighClick;
            this.listBox1.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(768, 472);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            // 
            // TaskManRighClick
            // 
            this.TaskManRighClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TaskManRighClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killProcessToolStripMenuItem});
            this.TaskManRighClick.Name = "TaskManRighClick";
            this.TaskManRighClick.Size = new System.Drawing.Size(153, 28);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.killProcessToolStripMenuItem.Text = "Kill Process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.killProcessToolStripMenuItem_Click);
            // 
            // About
            // 
            this.About.Controls.Add(this.aboiutinfo);
            this.About.Controls.Add(this.UpdateChecker);
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
            // aboiutinfo
            // 
            this.aboiutinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboiutinfo.AutoSize = true;
            this.aboiutinfo.BackColor = System.Drawing.Color.Transparent;
            this.aboiutinfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.aboiutinfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.aboiutinfo.Location = new System.Drawing.Point(-4, 10);
            this.aboiutinfo.Name = "aboiutinfo";
            this.aboiutinfo.Size = new System.Drawing.Size(816, 425);
            this.aboiutinfo.Style = MetroFramework.MetroColorStyle.Red;
            this.aboiutinfo.TabIndex = 2;
            this.aboiutinfo.Text = resources.GetString("aboiutinfo.Text");
            this.aboiutinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboiutinfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aboiutinfo.UseCustomBackColor = true;
            this.aboiutinfo.UseStyleColors = true;
            // 
            // UpdateChecker
            // 
            this.UpdateChecker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateChecker.DisplayFocus = true;
            this.UpdateChecker.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UpdateChecker.Location = new System.Drawing.Point(899, 10);
            this.UpdateChecker.Name = "UpdateChecker";
            this.UpdateChecker.Size = new System.Drawing.Size(147, 43);
            this.UpdateChecker.Style = MetroFramework.MetroColorStyle.Yellow;
            this.UpdateChecker.TabIndex = 3;
            this.UpdateChecker.Text = "Check For Updates";
            this.UpdateChecker.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdateChecker.UseSelectable = true;
            this.UpdateChecker.UseStyleColors = true;
            this.UpdateChecker.Click += new System.EventHandler(this.UpdateChecker_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.MouseSensitivity);
            this.Settings.Controls.Add(this.metroPanel2);
            this.Settings.Controls.Add(this.metroPanel1);
            this.Settings.ForeColor = System.Drawing.Color.Red;
            this.Settings.HorizontalScrollbarBarColor = true;
            this.Settings.HorizontalScrollbarHighlightOnWheel = false;
            this.Settings.HorizontalScrollbarSize = 10;
            this.Settings.Location = new System.Drawing.Point(4, 38);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1054, 522);
            this.Settings.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Settings";
            this.Settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings.VerticalScrollbarBarColor = true;
            this.Settings.VerticalScrollbarHighlightOnWheel = false;
            this.Settings.VerticalScrollbarSize = 10;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // MouseSensitivity
            // 
            this.MouseSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MouseSensitivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MouseSensitivity.Controls.Add(this.metroTrackBar1);
            this.MouseSensitivity.Controls.Add(this.MouseSpeedLabel);
            this.MouseSensitivity.HorizontalScrollbarBarColor = true;
            this.MouseSensitivity.HorizontalScrollbarHighlightOnWheel = false;
            this.MouseSensitivity.HorizontalScrollbarSize = 10;
            this.MouseSensitivity.Location = new System.Drawing.Point(499, 16);
            this.MouseSensitivity.Name = "MouseSensitivity";
            this.MouseSensitivity.Size = new System.Drawing.Size(392, 95);
            this.MouseSensitivity.Style = MetroFramework.MetroColorStyle.Red;
            this.MouseSensitivity.TabIndex = 10;
            this.MouseSensitivity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MouseSensitivity.UseStyleColors = true;
            this.MouseSensitivity.VerticalScrollbarBarColor = true;
            this.MouseSensitivity.VerticalScrollbarHighlightOnWheel = false;
            this.MouseSensitivity.VerticalScrollbarSize = 10;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.DisplayFocus = true;
            this.metroTrackBar1.Location = new System.Drawing.Point(8, 49);
            this.metroTrackBar1.Minimum = 20;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(366, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTrackBar1.TabIndex = 7;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.UseCustomBackColor = true;
            this.metroTrackBar1.Value = 100;
            // 
            // MouseSpeedLabel
            // 
            this.MouseSpeedLabel.AutoSize = true;
            this.MouseSpeedLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MouseSpeedLabel.Location = new System.Drawing.Point(16, 10);
            this.MouseSpeedLabel.Name = "MouseSpeedLabel";
            this.MouseSpeedLabel.Size = new System.Drawing.Size(95, 20);
            this.MouseSpeedLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.MouseSpeedLabel.TabIndex = 6;
            this.MouseSpeedLabel.Text = "App Opacity";
            this.MouseSpeedLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MouseSpeedLabel.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BackColor = System.Drawing.Color.Black;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.TimePink);
            this.metroPanel2.Controls.Add(this.TimeBrown);
            this.metroPanel2.Controls.Add(this.TimeLime);
            this.metroPanel2.Controls.Add(this.TimeOrange);
            this.metroPanel2.Controls.Add(this.TimeBlue);
            this.metroPanel2.Controls.Add(this.TimeRed);
            this.metroPanel2.Controls.Add(this.SetTimeColor);
            this.metroPanel2.Controls.Add(this.TimeColor);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(265, 16);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(212, 169);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // TimePink
            // 
            this.TimePink.AutoSize = true;
            this.TimePink.DisplayFocus = true;
            this.TimePink.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TimePink.Location = new System.Drawing.Point(107, 96);
            this.TimePink.Name = "TimePink";
            this.TimePink.Size = new System.Drawing.Size(52, 20);
            this.TimePink.Style = MetroFramework.MetroColorStyle.Pink;
            this.TimePink.TabIndex = 13;
            this.TimePink.Text = "Pink";
            this.TimePink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimePink.UseSelectable = true;
            this.TimePink.UseStyleColors = true;
            // 
            // TimeBrown
            // 
            this.TimeBrown.AutoSize = true;
            this.TimeBrown.DisplayFocus = true;
            this.TimeBrown.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TimeBrown.Location = new System.Drawing.Point(107, 73);
            this.TimeBrown.Name = "TimeBrown";
            this.TimeBrown.Size = new System.Drawing.Size(67, 20);
            this.TimeBrown.Style = MetroFramework.MetroColorStyle.Brown;
            this.TimeBrown.TabIndex = 12;
            this.TimeBrown.Text = "Brown";
            this.TimeBrown.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeBrown.UseSelectable = true;
            this.TimeBrown.UseStyleColors = true;
            // 
            // TimeLime
            // 
            this.TimeLime.AutoSize = true;
            this.TimeLime.DisplayFocus = true;
            this.TimeLime.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TimeLime.Location = new System.Drawing.Point(107, 49);
            this.TimeLime.Name = "TimeLime";
            this.TimeLime.Size = new System.Drawing.Size(57, 20);
            this.TimeLime.Style = MetroFramework.MetroColorStyle.Lime;
            this.TimeLime.TabIndex = 11;
            this.TimeLime.Text = "Lime";
            this.TimeLime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeLime.UseSelectable = true;
            this.TimeLime.UseStyleColors = true;
            // 
            // TimeOrange
            // 
            this.TimeOrange.AutoSize = true;
            this.TimeOrange.DisplayFocus = true;
            this.TimeOrange.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TimeOrange.Location = new System.Drawing.Point(11, 97);
            this.TimeOrange.Name = "TimeOrange";
            this.TimeOrange.Size = new System.Drawing.Size(74, 20);
            this.TimeOrange.Style = MetroFramework.MetroColorStyle.Orange;
            this.TimeOrange.TabIndex = 10;
            this.TimeOrange.Text = "Orange";
            this.TimeOrange.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeOrange.UseSelectable = true;
            this.TimeOrange.UseStyleColors = true;
            // 
            // TimeBlue
            // 
            this.TimeBlue.AutoSize = true;
            this.TimeBlue.DisplayFocus = true;
            this.TimeBlue.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TimeBlue.Location = new System.Drawing.Point(11, 73);
            this.TimeBlue.Name = "TimeBlue";
            this.TimeBlue.Size = new System.Drawing.Size(54, 20);
            this.TimeBlue.Style = MetroFramework.MetroColorStyle.Blue;
            this.TimeBlue.TabIndex = 9;
            this.TimeBlue.Text = "Blue";
            this.TimeBlue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeBlue.UseSelectable = true;
            this.TimeBlue.UseStyleColors = true;
            this.TimeBlue.CheckedChanged += new System.EventHandler(this.TimeBlue_CheckedChanged);
            // 
            // TimeRed
            // 
            this.TimeRed.AutoSize = true;
            this.TimeRed.DisplayFocus = true;
            this.TimeRed.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TimeRed.Location = new System.Drawing.Point(11, 49);
            this.TimeRed.Name = "TimeRed";
            this.TimeRed.Size = new System.Drawing.Size(51, 20);
            this.TimeRed.Style = MetroFramework.MetroColorStyle.Red;
            this.TimeRed.TabIndex = 8;
            this.TimeRed.Text = "Red";
            this.TimeRed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeRed.UseSelectable = true;
            this.TimeRed.UseStyleColors = true;
            // 
            // SetTimeColor
            // 
            this.SetTimeColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SetTimeColor.DisplayFocus = true;
            this.SetTimeColor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SetTimeColor.Highlight = true;
            this.SetTimeColor.Location = new System.Drawing.Point(29, 132);
            this.SetTimeColor.Name = "SetTimeColor";
            this.SetTimeColor.Size = new System.Drawing.Size(134, 30);
            this.SetTimeColor.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SetTimeColor.TabIndex = 7;
            this.SetTimeColor.Text = "Set Time Color";
            this.SetTimeColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetTimeColor.UseSelectable = true;
            this.SetTimeColor.UseStyleColors = true;
            this.SetTimeColor.Click += new System.EventHandler(this.SetTimeColor_Click);
            // 
            // TimeColor
            // 
            this.TimeColor.AutoSize = true;
            this.TimeColor.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TimeColor.Location = new System.Drawing.Point(11, 10);
            this.TimeColor.Name = "TimeColor";
            this.TimeColor.Size = new System.Drawing.Size(85, 20);
            this.TimeColor.Style = MetroFramework.MetroColorStyle.Blue;
            this.TimeColor.TabIndex = 6;
            this.TimeColor.Text = "Time Color";
            this.TimeColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeColor.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.TopMostFalse);
            this.metroPanel1.Controls.Add(this.TopMostTrue);
            this.metroPanel1.Controls.Add(this.SetTopMost);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(226, 169);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 17);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Keep Control Panel On Top";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // TopMostFalse
            // 
            this.TopMostFalse.AutoSize = true;
            this.TopMostFalse.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TopMostFalse.Location = new System.Drawing.Point(106, 47);
            this.TopMostFalse.Name = "TopMostFalse";
            this.TopMostFalse.Size = new System.Drawing.Size(84, 20);
            this.TopMostFalse.Style = MetroFramework.MetroColorStyle.Lime;
            this.TopMostFalse.TabIndex = 5;
            this.TopMostFalse.Text = "Disabled";
            this.TopMostFalse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMostFalse.UseSelectable = true;
            this.TopMostFalse.UseStyleColors = true;
            // 
            // TopMostTrue
            // 
            this.TopMostTrue.AutoSize = true;
            this.TopMostTrue.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.TopMostTrue.Location = new System.Drawing.Point(3, 47);
            this.TopMostTrue.Name = "TopMostTrue";
            this.TopMostTrue.Size = new System.Drawing.Size(79, 20);
            this.TopMostTrue.Style = MetroFramework.MetroColorStyle.Lime;
            this.TopMostTrue.TabIndex = 4;
            this.TopMostTrue.Text = "Enabled";
            this.TopMostTrue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMostTrue.UseSelectable = true;
            this.TopMostTrue.UseStyleColors = true;
            // 
            // SetTopMost
            // 
            this.SetTopMost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SetTopMost.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SetTopMost.Highlight = true;
            this.SetTopMost.Location = new System.Drawing.Point(35, 132);
            this.SetTopMost.Name = "SetTopMost";
            this.SetTopMost.Size = new System.Drawing.Size(134, 30);
            this.SetTopMost.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SetTopMost.TabIndex = 3;
            this.SetTopMost.Text = "Set TopMost";
            this.SetTopMost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetTopMost.UseSelectable = true;
            this.SetTopMost.UseStyleColors = true;
            this.SetTopMost.Click += new System.EventHandler(this.Set_Click);
            // 
            // DriveScanTimer
            // 
            this.DriveScanTimer.Enabled = true;
            this.DriveScanTimer.Interval = 1000;
            this.DriveScanTimer.Tick += new System.EventHandler(this.DriveScanComboBox_Tick);
            // 
            // cpu
            // 
            this.cpu.CategoryName = "Processor";
            this.cpu.CounterName = "% Processor Time";
            this.cpu.InstanceName = "_Total";
            // 
            // ram
            // 
            this.ram.CategoryName = "Memory";
            this.ram.CounterName = "% Committed bytes in use";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.CPUTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Opacity
            // 
            this.Opacity.Enabled = true;
            this.Opacity.Interval = 500;
            this.Opacity.Tick += new System.EventHandler(this.Opacity_Tick);
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(20, 138);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(80, 20);
            this.Username.Style = MetroFramework.MetroColorStyle.Lime;
            this.Username.TabIndex = 4;
            this.Username.Text = "Username: ";
            this.Username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Username.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 668);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Brett Tech Control Panel V3";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.SystemInfoPanel.ResumeLayout(false);
            this.SystemInfoPanel.PerformLayout();
            this.CPURAM.ResumeLayout(false);
            this.CPURAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.VirusScanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshdrives)).EndInit();
            this.TaskManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.TaskManRighClick.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.MouseSensitivity.ResumeLayout(false);
            this.MouseSensitivity.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Timer Timer1;
        private MetroFramework.Controls.MetroTabPage Settings;
        private MetroFramework.Controls.MetroButton SetTopMost;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton TopMostFalse;
        private MetroFramework.Controls.MetroRadioButton TopMostTrue;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel TimeColor;
        private MetroFramework.Controls.MetroButton SetTimeColor;
        private MetroFramework.Controls.MetroRadioButton TimePink;
        private MetroFramework.Controls.MetroRadioButton TimeBrown;
        private MetroFramework.Controls.MetroRadioButton TimeLime;
        private MetroFramework.Controls.MetroRadioButton TimeOrange;
        private MetroFramework.Controls.MetroRadioButton TimeBlue;
        private MetroFramework.Controls.MetroRadioButton TimeRed;
        private MetroFramework.Controls.MetroButton StartTask;
        private MetroFramework.Controls.MetroTextBox StartTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip TaskManRighClick;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private MetroFramework.Controls.MetroButton KillProcess;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroButton RefreshProcesses;
        public MetroFramework.Controls.MetroLabel Time;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroPanel MouseSensitivity;
        private MetroFramework.Controls.MetroLabel MouseSpeedLabel;
        private MetroFramework.Controls.MetroLabel YourIP;
        private MetroFramework.Controls.MetroLabel PCName;
        private MetroFramework.Controls.MetroLabel SSID;
        private MetroFramework.Controls.MetroLabel sysInfo;
        private MetroFramework.Controls.MetroPanel SystemInfoPanel;
        private MetroFramework.Controls.MetroLabel Notice;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private System.Windows.Forms.Timer Opacity;
        private MetroFramework.Controls.MetroLabel Username;
    }
}

