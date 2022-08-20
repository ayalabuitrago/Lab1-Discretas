using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Discretas
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }


        private void BTNOpenEqn_Click(object sender, EventArgs e)
        {
            Form eqn = new FEqn();
            eqn.Show();
        }

        private void BTNopenTrueTable_Click(object sender, EventArgs e)
        {
            Form trueTable = new FTrueTable();
            trueTable.Show();

        }
    }
}
