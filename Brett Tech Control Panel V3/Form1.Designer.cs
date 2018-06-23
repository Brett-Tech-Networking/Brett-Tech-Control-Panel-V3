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
            this.SuspendLayout();
            // 
            // VirusScanner
            // 
            this.VirusScanner.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.VirusScanner.Highlight = true;
            this.VirusScanner.Location = new System.Drawing.Point(23, 78);
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
            this.Time.Location = new System.Drawing.Point(3, 567);
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
            "Hibernate",
            "Restart",
            "Sleep",
            "Lock"});
            this.PowerComboBox.Location = new System.Drawing.Point(267, 557);
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
            this.ShutdownOptionsLabel.Location = new System.Drawing.Point(443, 525);
            this.ShutdownOptionsLabel.Name = "ShutdownOptionsLabel";
            this.ShutdownOptionsLabel.Size = new System.Drawing.Size(135, 25);
            this.ShutdownOptionsLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ShutdownOptionsLabel.TabIndex = 3;
            this.ShutdownOptionsLabel.Text = "Power Options";
            this.ShutdownOptionsLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShutdownOptionsLabel.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 595);
            this.Controls.Add(this.ShutdownOptionsLabel);
            this.Controls.Add(this.PowerComboBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.VirusScanner);
            this.Name = "Form1";
            this.Text = "Brett Tech Control Panel V3";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton VirusScanner;
        private MetroFramework.Controls.MetroLabel Time;
        private System.Windows.Forms.Timer Clock;
        private MetroFramework.Controls.MetroComboBox PowerComboBox;
        private MetroFramework.Controls.MetroLabel ShutdownOptionsLabel;
    }
}

