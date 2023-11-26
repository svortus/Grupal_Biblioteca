using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp_Listado;

namespace WinApp_Biblioteca
{
    public partial class Frm_listar : Form
    {
        public Frm_listar()
        {
            InitializeComponent();
        }

        private void Btn_listaAutores_Click(object sender, EventArgs e)
        {
            Frm_autores todos_autores = new Frm_autores(Dgw1);
            todos_autores.ShowDialog();
        }

        private void Btn_listaTotalLibros_Click_1(object sender, EventArgs e)
        {
            Frm_libros todos_libros = new Frm_libros(Dgw1);
            todos_libros.ShowDialog();
        }

        private void Btn_listaUltimosInsertados_Click_1(object sender, EventArgs e)
        {
            Frm_ultimosLibros ultimos_libros = new Frm_ultimosLibros(Dgw1);
            ultimos_libros.ShowDialog();
        }

        private void Btn_ListaPersonalizada_Click(object sender, EventArgs e)
        {
            Frm_ListaPersonalizada lista_personalizada = new Frm_ListaPersonalizada(Dgw1);
            lista_personalizada.ShowDialog();
        }
    }
}
