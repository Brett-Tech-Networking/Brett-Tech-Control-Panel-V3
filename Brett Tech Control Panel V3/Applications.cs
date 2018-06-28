using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
