using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

using FirebirdSql.Data.FirebirdClient;

namespace blns
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

            using (FbConnection c = new FbConnection(@"Server=192.168.77.102;User=SYSDBA;Password=classic;Database=C:\gdb\test.gdb"))
            {
                c.Open();

                label1.Text = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\iammna\"+Program.argM).GetValue("adress").ToString();
                label2.Text = Program.argM;
            }

        }

        private void TwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "two";
            MessageBox.Show("two two");
        }

        private void FmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
