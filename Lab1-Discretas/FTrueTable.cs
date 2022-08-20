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
    public partial class FTrueTable : Form
    {
        // variables
        int cantidadProposiciones = 0;
        int cantidadFilas = 0;
        
        public FTrueTable()
        {
            InitializeComponent();
        }

        private void TBcant_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TBcant.Text != "")
                {
                    cantidadProposiciones = int.Parse(TBcant.Text);
                    cantidadFilas = (int) Math.Pow(2, cantidadProposiciones);
                }
                

            }
            catch
            {
                MessageBox.Show("Ingrese un número entero", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void BTNgen_Click(object sender, EventArgs e)
        {
            bool flag = validateForm();

            if (flag)
            {
                genProposiciones();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos (cantidad y operador)", "ERROR");
            }
        }

        private void genProposiciones()
        {
            if (DGVtablaDeVerdad.Columns.Count != 0)
            {
                DGVtablaDeVerdad.Columns.Clear();
                DGVtablaDeVerdad.Rows.Clear();
            }
            
            // Generar columnas
            for(int i = 0; i < cantidadProposiciones; i++)
            {
                DGVtablaDeVerdad.Columns.Add(i.ToString(), "P" + (i + 1).ToString());
            }

            // Generar columna de operación
            if(CBoperator.Text != "")
                DGVtablaDeVerdad.Columns.Add(CBoperator.Text, CBoperator.SelectedItem.ToString());
            

            // Generar filas
            for (int i = 0; i < cantidadFilas; i++)
            {
                DGVtablaDeVerdad.Rows.Add(new DataGridViewRow());
            }

            // llenar tabla
            fillValue();

        }

        private void fillValue()
        {

            int cant = cantidadFilas;

            for (int i = 0; i < cantidadProposiciones; i++)
            {
                int pos = 0;

                for (int j = 0; j < cantidadFilas / cant; j++)
                {
                    for (int k = 0; k < cant / 2; k++)
                    {
                        DGVtablaDeVerdad.Rows[pos].Cells[i].Value = "v";
                        pos++;
                    }

                    for (int k = 0; k < cant / 2; k++)
                    {
                        DGVtablaDeVerdad.Rows[pos].Cells[i].Value = "f";
                        pos++;
                    }
                }

                cant /= 2;
                
            }

        }

        private bool validateForm()
        {
            if (TBcant.Text == "" || CBoperator.Text == "") return false;
            else return true;
        }

        private void FTrueTable_Load(object sender, EventArgs e)
        {
            CBoperator.SelectedIndex = 0;
        }

    }
}
