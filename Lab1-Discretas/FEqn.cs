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
            LbR.Text=("Las ecuaciones son equivalentes");
        }
        //int OpcControl;

        private void BTNeq1_CheckedChanged(object sender, EventArgs e)
        {
            string s;
            s="";
            s+=String.Format("Para que x sea equivalente en un intervalo de 0 a 100  debe de tomar los siguientes valores\r\n");
            for (int i = 0; i <= 100; i ++ )
            {
                if (i < 10 || i >= 21)
                {
                    s+=(i.ToString() + ", ");
                }
                
            }
            s += String.Format("\r\nAmbas ecuaciones deben tomar los mismos valores por tanto son equivalentes");
            LbR.Text = s;



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            String s;
            s="";
            s +=String.Format("Para que x sea equivalente en un intervalo de 0 a 100  debe de tomar los siguientes valores:\r\n");
            for (int i = 0; i <= 100; i++)
            {
                if (!(i >= 10 && i <=20))
                {
                    s+=(i.ToString() + ", ");
                }

            }
            s +=String.Format("\r\nAmbas ecuaciones deben tomar los mismos valores por tanto son equivalentes");
            LbR.Text=s;
        }

        
    }
}
