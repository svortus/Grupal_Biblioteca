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
    public partial class Frm_editar_2 : Form
    {
        public Frm_editar_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ultimosLibros ultimos_libros = new Frm_ultimosLibros(Dgw_Editar_2);
            ultimos_libros.ShowDialog();
        }
    }
}
