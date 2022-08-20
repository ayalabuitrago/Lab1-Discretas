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
    public partial class FEqn : Form
    {
        public FEqn()
        {
            InitializeComponent();
            LbR.Items.Add("Las ecuaciones son equivalentes");
        }
        //int OpcControl;

        private void BTNeq1_CheckedChanged(object sender, EventArgs e)
        {

            // OpcControl = 1;
            LbR.Items.Clear();
            LbR.Items.Add("Para que x sea equivalente en esta ecuacion debe de tomar los siguientes valores");
            for (int i = 0; i < 10; i += 2)
            {
                LbR.Items.Add(i.ToString() + "\t " + (i + 1).ToString() + "\t");

            }

            for (int j = 21; j < 100; j += 2)
            {
                LbR.Items.Add(j.ToString() + "\t " + (j + 1).ToString() + "\t");
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //OpcControl = 2;
            LbR.Items.Clear();

                LbR.Items.Add("Para que x sea equivalente en esta ecuacion su valor no debe ser ninguno de estos");
                for (int k = 10; k < 20; k++)
                {
                    LbR.Items.Add(k.ToString() + "\t" + (k + 1).ToString() + "\t");
                }

            
        }
    }
}
