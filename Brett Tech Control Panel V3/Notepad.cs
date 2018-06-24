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
    public partial class Notepad : MetroFramework.Forms.MetroForm
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Process.Start ("http://www.brett-techrepair.com/moradi-notepad.html");
        }
    }
}
