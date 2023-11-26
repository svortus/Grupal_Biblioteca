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
        DataGridView n;
        public Frm_Menu(DataGridView n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Agregar objFA = new Frm_Agregar(n);
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
