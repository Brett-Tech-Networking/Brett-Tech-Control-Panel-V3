using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Linq;
using Microsoft.Win32;

namespace Brett_Tech_Control_Panel_V3
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int x = 0;
        List<Point> cpu_pt = new List<Point>();
        List<Point> ram_pt = new List<Point>();
        public Form1()


        {
            InitializeComponent();
        }

        Process[] procs;

        private void GetAllProcess()
        {
            procs = Process.GetProcesses();
          
            listBox1.Items.Clear();
            for (int i = 0; i< procs.Length; i++)
            {
                listBox1.Items.Add(procs[i].ProcessName);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get All Proccess For Task Manager List
            GetAllProcess();

            // Print IP Address On Boot
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            YourIP.Text = ("Your IP:  " + externalip);

            // Print PC Name
            PCName.Text = "Your PC Name:  " + (System.Environment.MachineName);

            // get ssid
            try
            {
                var process = new Process
                {
                    StartInfo =
                          {
                              FileName = "netsh.exe",
                              Arguments = "wlan show interfaces",
                              UseShellExecute = false,
                              RedirectStandardOutput = true,
                              CreateNoWindow = true
                          }
                };
                process.Start();

                var output = process.StandardOutput.ReadToEnd();
                var line = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                 .FirstOrDefault(l => l.Contains("SSID") && !l.Contains("BSSID"));
                if (line == null)
                {
                    //
                }
                var ssid = line.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
                SSID.Text = "Current WIFI SSID: " + (ssid);
            }
            catch
            {
                SSID.Text = "Current WIFI SSID: Unavalible (are you hard wired?)";
            }

            // Print Username
            Username.Text = "Welcome: " + (System.Environment.UserName);

           

    }

        private void Clock_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }



        private void PowerOptions_Tick(object sender, EventArgs e)
        {
            try
            {
#pragma warning disable CS0252 
                if (PowerComboBox.SelectedItem == "Shutdown")
#pragma warning restore CS0252 
                {
                    Process.Start("Shutdown", "-s -t 30");
                }
#pragma warning disable CS0252 
                if (PowerComboBox.SelectedItem == "Shutdown (abort)")
#pragma warning restore CS0252 
                {
                    Process.Start("Shutdown", "-a");

                }
#pragma warning disable CS0252 
                if (PowerComboBox.SelectedItem == "Hibernate")
#pragma warning restore CS0252 
                {
                    Process.Start("Shutdown", "-h");
                }
#pragma warning disable CS0252 
                if (PowerComboBox.SelectedItem == "Restart")
#pragma warning restore CS0252 
                {
                    Process.Start("Shutdown", "-r -t 30");
                }
#pragma warning disable CS0252 
                if (PowerComboBox.SelectedItem == "Logout")
#pragma warning restore CS0252 
                {
                    Process.Start("Shutdown", "-l -t 30");
                }
            }
            catch
            {
                MessageBox.Show("oops, seems we cant run that option right now please contact support if issue continues", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void UpdateChecker_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(100, "Brett Tech Networking", "Looks Like You Have The Latest Version, Great!", ToolTipIcon.Info);

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DriveScanComboBox_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (var Drives in Environment.GetLogicalDrives())
                {
                    DriveInfo DriveInf = new DriveInfo(Drives);
                    if (DriveInf.IsReady == true)
                    {
                        DriveCombo.Items.Add(DriveInf.Name);
                        DriveScanTimer.Stop();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot Load Drives", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DriveCombo.Items.Clear();
                foreach (var Drives in Environment.GetLogicalDrives())
                {
                    DriveInfo DriveInf = new DriveInfo(Drives);
                    if (DriveInf.IsReady == true)
                    {
                        DriveCombo.Items.Add(DriveInf.Name);
                    }
                }
            }

            catch
            {
                MessageBox.Show("Cannot Refresh", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CPUTimer_Tick(object sender, EventArgs e)
        {
            x += 2;
            int cpu_val = (pictureBox1.Height + (int)Math.Round(cpu.NextValue())) / 100;
            int ram_val = (pictureBox2.Height + (int)Math.Round(ram.NextValue())) / 100;

            cpu_pt.Add(new Point(x, pictureBox1.Height - cpu_val));
            ram_pt.Add(new Point(x, pictureBox2.Height - ram_val));
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (x > pictureBox1.Width || x > pictureBox2.Width)
            {
                x = 0;
                cpu_pt.Clear();
                ram_pt.Clear();
            }
            g.FillRectangle(new HatchBrush(HatchStyle.Cross, Color.Green), pictureBox1.ClientRectangle);
            if (cpu_pt.Count > 1)
                g.DrawLines(new Pen(new SolidBrush(Color.FromArgb(255, 0, 255, 100))), cpu_pt.ToArray());
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new HatchBrush(HatchStyle.Cross, Color.Green), pictureBox1.ClientRectangle);
            if (ram_pt.Count > 1)
                g.DrawLines(new Pen(new SolidBrush(Color.FromArgb(255, 0, 255, 100))), ram_pt.ToArray());

        }

        private void Set_Click(object sender, EventArgs e)
        {
          
        }

        private void ShowNotifyIcon(string v1, bool v2, int v3)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void StartTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(StartTextBox.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = StartTextBox.Text;
                    proc.Start();
                    notifyIcon1.ShowBalloonTip(100, "Brett Tech Networking", (StartTextBox.Text + " Started"), ToolTipIcon.Info);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StartTextBox.Clear();
                }
            }
        }


        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                procs[listBox1.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KillProcess_Click(object sender, EventArgs e)
        {
                procs[listBox1.SelectedIndex].Kill();
                GetAllProcess();
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {

        }

        private void RefreshProcesses_Click(object sender, EventArgs e)
        {

            GetAllProcess();
        }

        private void SetTimeColor_Click(object sender, EventArgs e)
        {

            if (TimeRed.Checked == true)
            {
                Time.ForeColor = Color.Red;
            }

            if (TimeBlue.Checked == true)
            {
                Time.ForeColor = Color.Blue;
            }
            if (TimeOrange.Checked == true)
            {
                Time.ForeColor = Color.Orange;
            }
            if (TimeLime.Checked == true)
            {
                Time.ForeColor = Color.Lime;
            }
            if (TimeBrown.Checked == true)
            {
                Time.ForeColor = Color.Brown;
            }
            if (TimePink.Checked == true)
            {
                Time.ForeColor = Color.Pink;
            }
        }

        private void TimeBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

    

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void Opacity_Tick(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(metroTrackBar1.Value) / 100.0);
            }
            catch
            {
                //
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Enter Text Here")
            {
                richTextBox1.Clear();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            catch
            {
                saveFileDialog1.DefaultExt = ".txt";
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.Filter = "Text Files (*.txt) | *.txt";

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
               
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the current file?", "Whoa There!",
           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            //no
            if (result == DialogResult.No)
            {
                richTextBox1.Clear();
            }

            //yes
            if (result == DialogResult.Yes)
            {
                saveFileDialog1.DefaultExt = ".txt";
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.Filter = "Text Files (*.txt) | *.txt";

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == false)
            {
                // filters
                openFileDialog1.Title = "Open File";
                openFileDialog1.Filter = "Text Files (*.txt) | *.txt |All files (*.*)|*.*";
                openFileDialog1.FileName = "";
                openFileDialog1.FilterIndex = 3;
                openFileDialog1.InitialDirectory = "My Documents";


                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
            }

            //open if modified
            else if (richTextBox1.Modified == true)
            {
                DialogResult result = MessageBox.Show("Do you want to save the current file?", "Whoa There!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                //cancel
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                //yes
                if (result == DialogResult.Yes)
                {
                    saveFileDialog1.DefaultExt = ".txt";
                    saveFileDialog1.OverwritePrompt = true;
                    saveFileDialog1.Title = "Save File";
                    saveFileDialog1.Filter = "Text Files (*.txt) | *.txt";

                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }

                //no
                richTextBox1.Clear();
                {
                    openFileDialog1.Title = "Open File";
                    openFileDialog1.Filter = "Text Files (*.txt) | *.txt";
                    openFileDialog1.FileName = "";
                    openFileDialog1.FilterIndex = 0;

                    openFileDialog1.InitialDirectory = "My Documents";

                    openFileDialog1.CheckFileExists = true;
                    openFileDialog1.CheckPathExists = true;

                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName);
                    }
                }
            }
        }

        private void richTextBox1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Enter Text Here")
            {
                richTextBox1.Clear();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Notepad note = new Notepad();
            note.Show();
        }

        private void DownloadLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartSpeedTest_Click(object sender, EventArgs e)
        {
            try
            {
                UploadSpeed.Text = "TEST";
                DownloadSpeed.Text = "TEST";
            }
            catch { MessageBox.Show("Sorry We Can't Process That Right Now", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ToolSize_Tick(object sender, EventArgs e)
        {
            if (ResizableToggle.Checked == true)
            {
                this.Resizable = true;
                Resizablelabel.Text = "Tool Is Resizable";

            }
            if (ResizableToggle.Checked == false)
            {
                this.Resizable = false;
                Resizablelabel.Text = "Tool Is Not Resizable";
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Only Avalible In Moradi Notepad Please Download Full Notepad Software At: https://github.com/Brett-Tech-Networking/Moradi-Notepad/releases", "Speech To Text Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WIFISSIDLIST_Tick(object sender, EventArgs e)
        {
           
        }

        private void SetTheme_Click(object sender, EventArgs e)
        {
            if (redtheme.Checked == true)
            {
                this.BackColor = Color.Red;
            }
        }

        private void TopMostFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ResizableToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SoftwareTheme_Tick(object sender, EventArgs e)
        {
            if (TopAlwaysToggle.Checked == true)
            {
                this.TopMost = true;

            }
            if (TopAlwaysToggle.Checked == false)
            {
                this.TopMost = false;
            }
        }

        private void InstalledPrograms_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Applications apps = new Applications();
            apps.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/Program Files (x86)/Moradi Notepad V4/Moradi Notepad/bin/Debug/Moradi Notepad.exe");
            }
            catch
            {
                Process.Start("https://github.com/Brett-Tech-Networking/Moradi-Notepad/releases/download/V4/Moradi.Notepad.Advanced.Installer.exe");
            }
           
        }
    }
}