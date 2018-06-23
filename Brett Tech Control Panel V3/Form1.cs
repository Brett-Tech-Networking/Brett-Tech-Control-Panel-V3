using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Brett_Tech_Control_Panel_V3
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void VirusScanner_Click(object sender, EventArgs e)
        {
            VirusScanner vs = new VirusScanner();   
                vs.Show();
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
    }
        }
 