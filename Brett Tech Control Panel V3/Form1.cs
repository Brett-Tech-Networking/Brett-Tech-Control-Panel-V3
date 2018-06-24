using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ComponentModel;

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

        Process[] proc;

        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process p in proc)
                listBox1.Items.Add(p.ProcessName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }



        private void PowerOptions_Tick(object sender, EventArgs e)
        {
            try
            {
                if (PowerComboBox.SelectedItem == "Shutdown")
                {
                    Process.Start("Shutdown", "-s -t 30");
                }
                if (PowerComboBox.SelectedItem == "Shutdown (abort)")
                {
                    Process.Start("Shutdown", "-a");

                }
                if (PowerComboBox.SelectedItem == "Hibernate")
                {
                    Process.Start("Shutdown", "-h");
                }
                if (PowerComboBox.SelectedItem == "Restart")
                {
                    Process.Start("Shutdown", "-r -t 30");
                }
                if (PowerComboBox.SelectedItem == "Logout")
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
            MessageBox.Show("Looks Like Your Up To Date", "UP TO DATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (TopMostTrue.Checked == true)
            {
                this.TopMost = true;
            }
            else
              if (TopMostFalse.Checked == true)
            {
                this.TopMost = false;

            }
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
                proc[listBox1.SelectedIndex].Kill();
                GetAllProcess();
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(listBox1.Tag));
                if (p != null)
                    p.Kill();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
             if(TimeLime.Checked == true)
            {
                Time.ForeColor = Color.Lime;
            }
             if (TimeBrown.Checked == true)
            {
                Time.ForeColor = Color.Brown;
            }
             if(TimePink.Checked == true)
            {
                Time.ForeColor = Color.Pink;
            }
        }

        private void TimeBlue_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

    
       
 