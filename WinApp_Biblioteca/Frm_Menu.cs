using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Biblioteca
{
    public partial class Frm_Menu : Form
    {
        DataGridView n1;
        public Frm_Menu(DataGridView n)
        {
            InitializeComponent();
            this.n1 = n;
            if (n1 != null)
            {
                //work in progress
                foreach (DataGridViewRow row in n1.Rows)
                {
                    // Agregar nueva fila a Dgw5
                    int index = Dgw1.Rows.Add(); // Agregar nueva fila a Dgw1 y obtener el índice de la fila

                    Dgw1.Rows[index].Cells["Código"].Value = row.Cells["Código"].Value;
                    Dgw1.Rows[index].Cells["Nombre"].Value = row.Cells["Nombre"].Value;
                    Dgw1.Rows[index].Cells["Autor"].Value = row.Cells["Autor"].Value;
                    Dgw1.Rows[index].Cells["Edición"].Value = row.Cells["Edición"].Value;
                    Dgw1.Rows[index].Cells["Editorial"].Value = row.Cells["Editorial"].Value;


                    /*Dgw1.Rows[row.Index].Cells["Código"].Value = 
                    Dgw1.Rows[row.Index].Cells["Nombre"].Value = 
                    Dgw1.Rows[row.Index].Cells["Autor"].Value = 
                    Dgw1.Rows[row.Index].Cells["Edición"].Value = 
                    Dgw1.Rows[row.Index].Cells["Editorial"].Value = */
                }
            }

        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Dgw1.AllowUserToAddRows = false;
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1 = Dgw1;
            Frm_Agregar objFA = new Frm_Agregar(n1);
            objFA.Show();
            Close();

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listar objListados = new Frm_listar();
            objListados.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_editar objeEditar = new Frm_editar();
            objeEditar.Show();
        }
    }
}
