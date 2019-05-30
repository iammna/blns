using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FirebirdSql.Data.FirebirdClient;

namespace blns
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

            FbConnection c = new FbConnection(@"Server=localhost;User=SYSDBA;Password=classic;Database=C:\gdb\test.gdb");

            c.Open();

            label1.Text = "mna2";




        }

        private void MenuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }
    }
}
