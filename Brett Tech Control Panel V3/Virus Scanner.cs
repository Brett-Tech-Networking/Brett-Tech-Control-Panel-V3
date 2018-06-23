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
    public partial class VirusScanner : MetroFramework.Forms.MetroForm
    {
        public VirusScanner()
        {
            InitializeComponent();
        }

        private void Virus_Scanner_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cant Scan Yet, Please Wait For A New Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What Do You Want Me To Stop??", "No Scan In Progress",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing Is Selected To Remove/Delete", "Please Select An Item First", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
