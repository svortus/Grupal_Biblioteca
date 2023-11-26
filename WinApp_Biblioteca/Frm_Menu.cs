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
                    Dgw1.Rows.Add();
                    /*int filas = Dgw1.Rows.Count - 1;
                    Dgw1[0, filas - 1].Value = row.Cells[0].Value;
                    Dgw1[1, filas - 1].Value = row.Cells[1].Value;
                    Dgw1[2, filas - 1].Value = row.Cells[2].Value;
                    Dgw1[3, filas - 1].Value = row.Cells[3].Value;
                    Dgw1[4, filas - 1].Value = row.Cells[4].Value;*/
                    
                    Dgw1.Rows[row.Index].Cells["Código"].Value = row.Cells[0].Value;
                    Dgw1.Rows[row.Index].Cells["Nombre"].Value = row.Cells[1].Value;
                    Dgw1.Rows[row.Index].Cells["Autor"].Value = row.Cells[2].Value;
                    Dgw1.Rows[row.Index].Cells["Edición"].Value = row.Cells[3].Value;
                    Dgw1.Rows[row.Index].Cells["Editorial"].Value = row.Cells[4].Value;
                    n1 = Dgw1;
                }
            }

        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

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
//puto el que lee