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
        public Frm_editar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        // Método para llenar el formulario con la información del libro
        public void LlenarDataGridView(Libro libro)
        {
            Dgw_Editar.Rows.Add(libro.Codigo, libro.Nombre, libro.Autor, libro.Editorial, libro.Edicion);
        }

        private void Frm_editar_Load(object sender, EventArgs e)
        {
            // Llenar el DataGridView cuando el formulario se carga
            if (DatosCompartidos.InformacionLibro != null)
            {
                LlenarDataGridView(DatosCompartidos.InformacionLibro);
            }
        }
    }
}
