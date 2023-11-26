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
            n1 = n;
            if (n != null)
            {
                foreach (DataGridViewRow fila in n.Rows)
                {
                    int indice = DgwMenu.Rows.Add();

                    DgwMenu.Rows[indice].Cells["Código"].Value = fila.Cells[0].Value;
                    DgwMenu.Rows[indice].Cells["Nombre"].Value = fila.Cells[1].Value;
                    DgwMenu.Rows[indice].Cells["Autor"].Value = fila.Cells[2].Value;
                    DgwMenu.Rows[indice].Cells["Edición"].Value = fila.Cells[3].Value;
                    DgwMenu.Rows[indice].Cells["Editorial"].Value = fila.Cells[4].Value;
                }
            }
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Agregar objFA = new Frm_Agregar(DgwMenu);
            objFA.Show();
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