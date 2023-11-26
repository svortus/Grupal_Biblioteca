using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinApp_Biblioteca.Frm_Agregar;

namespace WinApp_Biblioteca
{
    public partial class Frm_editar : Form
    {
        private DataGridView dgvEditar;

        public Frm_editar(DataGridView dgv)
        {
            InitializeComponent();
            dgvEditar = dgv;

            // Clonar la estructura del DataGridView original
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                Dgw_Editar.Columns.Add((DataGridViewColumn)col.Clone());
            }

            // Copiar los datos al DataGridView en Frm_editar
            foreach (DataGridViewRow row in dgv.Rows)
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

            // Crear un array para almacenar los datos de la fila seleccionada
            object[] rowData = new object[selectedRow.Cells.Count];
            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                rowData[i] = selectedRow.Cells[i].Value;
            }

            // Abrir el formulario Frm_Editar_2 y pasarle los datos de la fila seleccionada
            Frm_editar_2 frmEditar_2 = new Frm_editar_2(rowData, dgvEditar);
            
            frmEditar_2.ShowDialog();
        }
    }
}