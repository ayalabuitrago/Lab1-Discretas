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
           
            LbR.Items.Clear();
            LbR.Items.Add("Para que x sea equivalente en un intervalo de 0 a 100  debe de tomar los siguientes valores");
            for (int i = 0; i <= 100; i ++ )
            {
                if (i < 10 || i >= 21)
                {
                    LbR.Items.Add(i.ToString() + "\t ");
                }
                
            }
            



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LbR.Items.Clear();
            LbR.Items.Add("Para que x sea equivalente en un intervalo de 0 a 100  debe de tomar los siguientes valores");
            for (int i = 0; i <= 100; i++)
            {
                if (!(i >= 10 && i <=20))
                {
                    LbR.Items.Add(i.ToString() + "\t ");
                }

            }
            LbR.Items.Add("Ambas ecuaciones deben tomar los mismos valores por tanto son equivalentes");
        }
    }
}
