using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinApp_Biblioteca.Frm_Agregar;

namespace WinApp_Biblioteca
{
    public partial class Frm_editar : Form
    {
       DataGridView n1;

        public Frm_editar(DataGridView n)
        {
            InitializeComponent();
           this.n1 = n;

            // Clonar la estructura del DataGridView original
            foreach (DataGridViewColumn col in n1.Columns)
            {
                Dgw_Editar.Columns.Add((DataGridViewColumn)col.Clone());
            }

            // Copiar los datos al DataGridView en Frm_editar
            foreach (DataGridViewRow row in n1.Rows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                Dgw_Editar.Rows.Add(rowData);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si al menos una fila está seleccionada
            if (Dgw_Editar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una fila para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no hay filas seleccionadas
            }

            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = Dgw_Editar.SelectedRows[0];

            txtcodigo.Text = selectedRow.Cells["Código"].Value.ToString();
            txtnombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            txtautor.Text = selectedRow.Cells["Autor"].Value.ToString();
            txtedicion.Text = selectedRow.Cells["Edición"].Value.ToString();
            txteditorial.Text = selectedRow.Cells["Editorial"].Value.ToString();


        }

        private void Frm_editar_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarEditar_Click(object sender, EventArgs e)
        {
            if (Dgw_Editar.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = Dgw_Editar.SelectedRows[0];

                // Actualizar los valores de las celdas con los valores de TextBox
                row.Cells["Código"].Value = txtcodigo.Text;
                row.Cells["Nombre"].Value = txtnombre.Text;
                row.Cells["Autor"].Value = txtautor.Text;
                row.Cells["Edición"].Value = txtedicion.Text;
                row.Cells["Editorial"].Value = txteditorial.Text;


                // Confirmar la edición
                MessageBox.Show("Edición confirmada");

                n1 = Dgw_Editar;
                Frm_Menu objFM = new Frm_Menu(n1);
                
                objFM.Show();

                // Limpiar los TextBox después de confirmar

            }
            this.Close();
        }

      
    }
}