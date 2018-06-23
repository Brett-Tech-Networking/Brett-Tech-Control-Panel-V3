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
            this.VirusScanner = new MetroFramework.Controls.MetroButton();
            this.Time = new MetroFramework.Controls.MetroLabel();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.PowerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ShutdownOptionsLabel = new MetroFramework.Controls.MetroLabel();
            this.PowerOptions = new System.Windows.Forms.Timer(this.components);
            this.TabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Main = new MetroFramework.Controls.MetroTabPage();
            this.CPURAM = new MetroFramework.Controls.MetroTabPage();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.aboiutinfo = new MetroFramework.Controls.MetroLabel();
            this.UpdateChecker = new MetroFramework.Controls.MetroButton();
            this.TabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.About.SuspendLayout();
            this.SuspendLayout();
            // 
            // VirusScanner
            // 
            this.VirusScanner.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.VirusScanner.Highlight = true;
            this.VirusScanner.Location = new System.Drawing.Point(3, 19);
            this.VirusScanner.Name = "VirusScanner";
            this.VirusScanner.Size = new System.Drawing.Size(118, 34);
            this.VirusScanner.Style = MetroFramework.MetroColorStyle.Yellow;
            this.VirusScanner.TabIndex = 0;
            this.VirusScanner.Text = "Virus Scanner";
            this.VirusScanner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VirusScanner.UseSelectable = true;
            this.VirusScanner.Click += new System.EventHandler(this.VirusScanner_Click);
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
            this.TabControl1.Controls.Add(this.About);
            this.TabControl1.Location = new System.Drawing.Point(3, 63);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
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
            this.Main.Controls.Add(this.VirusScanner);
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
            // aboiutinfo
            // 
            this.aboiutinfo.AutoSize = true;
            this.aboiutinfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.aboiutinfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.aboiutinfo.Location = new System.Drawing.Point(0, 10);
            this.aboiutinfo.Name = "aboiutinfo";
            this.aboiutinfo.Size = new System.Drawing.Size(434, 150);
            this.aboiutinfo.Style = MetroFramework.MetroColorStyle.Red;
            this.aboiutinfo.TabIndex = 2;
            this.aboiutinfo.Text = "Brett Tech Networking\r\nBrett Tech Control Panel V3\r\n\r\nDeveloper: Brett Hudson\r\nEm" +
    "ail: Support@Brett-TechRepair.Com\r\nGitHub: https://github.com/Brett-Tech-Network" +
    "ing";
            this.aboiutinfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aboiutinfo.UseStyleColors = true;
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
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton VirusScanner;
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
    }
}

