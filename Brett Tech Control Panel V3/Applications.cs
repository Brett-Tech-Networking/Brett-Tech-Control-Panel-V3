using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brett_Tech_Control_Panel_V3
{
    public partial class Applications : MetroFramework.Forms.MetroForm
    {
        public Applications()
        {
            InitializeComponent();
        }

        private void Applications_Load(object sender, EventArgs e)
        {
            // List Programs
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            listBox1.Items.Add(sk.GetValue("DisplayName"));
                        }
                        catch (Exception)
                        { }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = textBox1.Text;
                p.StartInfo.Arguments = "/x \"C:\\Application.msi\"/qn";
                p.Start();
            }
            catch
            {
                MessageBox.Show("Cannot Uninstall At This Time", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textboxIssSelectItem_Tick(object sender, EventArgs e)
        {
          //  textBox1.Text = listBox1.GetSelected.ToString;
        }
    }
}
