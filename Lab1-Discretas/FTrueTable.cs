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
                TBcant.SelectAll();
            }
        }

        private void BTNgen_Click(object sender, EventArgs e)
        {
            // validar formulario
            if (validateForm())
            {
                if(cantidadProposiciones == 1)
                {
                    MessageBox.Show("La cantidad de proposiciones debe ser mayor a 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBcant.SelectAll();
                    return;
                }

                if(cantidadProposiciones > 9)
                {
                    MessageBox.Show("La cantidad de proposiciones no puede exceder a ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBcant.SelectAll();
                    return;
                }
                generarTabla();
            }
            
        }

        private void generarTabla()
        {
            // Generar proposiciones
            genProposiciones();

            // llenar valores
            llenarValores();

            // llenar resultado
            llenarResultados();

        }

        private void genProposiciones()
        {
            // limpiar columnas y filas
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
        }

        private void llenarValores()
        {
            int cant = cantidadFilas; // cantidad de valores v o f

            for (int i = 0; i < cantidadProposiciones; i++)
            {
                int pos = 0; // control de posicion de fila

                for (int j = 0; j < cantidadFilas / cant; j++)
                {
                    for (int k = 0; k < cant / 2; k++) // añadir v
                    {
                        DGVtablaDeVerdad.Rows[pos].Cells[i].Value = "V";
                        pos++;
                    }

                    for (int k = 0; k < cant / 2; k++) //añadir f
                    {
                        DGVtablaDeVerdad.Rows[pos].Cells[i].Value = "F";
                        pos++;
                    }
                }

                cant /= 2;       
            }
        }

        private void llenarResultados()
        {
            // segun el operador seleccionado, llenar resultados
            switch (CBoperator.SelectedIndex)
            {
                case 0:
                    conjuncion();
                    break;

                case 1:
                    disyuncion();
                    break;

                case 2:
                    implicacion();
                    break;

                case 3:
                    dobleImplicacion();
                    break;
            }
        }

        private void conjuncion()
        {
            foreach (DataGridViewRow row in DGVtablaDeVerdad.Rows)
            {
                bool result = true;

                for (int i = 0; i < cantidadProposiciones; i++)
                {
                    if (row.Cells[i].Value.ToString() == "F")
                    {
                        result = false;
                        break;
                    }
                }
                row.Cells[cantidadProposiciones].Value = result ? "V" : "F";
            }
        }

        private void disyuncion()
        {
            foreach (DataGridViewRow row in DGVtablaDeVerdad.Rows)
            {
                bool result = false;

                for (int i = 0; i < cantidadProposiciones; i++)
                {
                    if (row.Cells[i].Value.ToString() == "V")
                    {
                        result = true;
                        break;
                    }
                }
                row.Cells[cantidadProposiciones].Value = result ? "V" : "F";
            }
        }

        private void implicacion()
        {
            foreach (DataGridViewRow row in DGVtablaDeVerdad.Rows)
            {
                bool result =
                    row.Cells[0].Value.ToString() == "V" &&
                    row.Cells[1].Value.ToString() == "F" ?
                    false : true;

                for (int i = 2; i < cantidadProposiciones; i++)
                {
                    result =
                        result &&
                        row.Cells[i].Value.ToString() == "F" ?
                        false : true;
                }
                row.Cells[cantidadProposiciones].Value = result ? "V" : "F";
            }
        }

        private void dobleImplicacion()
        {
            foreach (DataGridViewRow row in DGVtablaDeVerdad.Rows)
            {
                bool result =
                    (
                        row.Cells[0].Value.ToString() == "V" &&
                        row.Cells[1].Value.ToString() == "V" 
                    ) ||
                    (
                        row.Cells[0].Value.ToString() == "F" &&
                        row.Cells[1].Value.ToString() == "F"
                    ) 
                    ? true : false ;

                for (int i = 2; i < cantidadProposiciones; i++)
                {
                    result =
                        (
                            result &&
                            row.Cells[i].Value.ToString() == "V" 
                        ) ||
                        (
                            !result && 
                            row.Cells[i].Value.ToString() == "false"
                        ) 
                        ? true : false;
                }
                row.Cells[cantidadProposiciones].Value = result ? "V" : "F";
            }
        }

        private bool validateForm()
        {
            if (TBcant.Text == "" || CBoperator.Text == "")
            {
                MessageBox.Show("Llene todos los campos (cantidad de proposiciones y operador)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (CBoperator.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un operador válido", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void FTrueTable_Load(object sender, EventArgs e)
        {
            CBoperator.SelectedIndex = 0;
        }

    }
}
