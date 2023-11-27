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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();


            CategoriaCB.Items.AddRange(GetColumnNames().ToArray());



        }




        public List<string> GetColumnNames()
        {

            DataGridView n;

            n = new DataGridView();
            Frm_Menu objMenu = new Frm_Menu(n);


            // Obtener los nombres de las columnas del DataGridView
            List<string> columnNames = new List<string>();
            foreach (DataGridViewColumn columna in objMenu.Dgw1.Columns)
            {
                columnNames.Add(columna.Name);
            }
            return columnNames;
        }

        private void EliminarBt_Click(object sender, EventArgs e)
        {
           
        }

        private void EliminarTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EliminarBt.PerformClick();
            }
        }

        private void EliminarBt_Click_1(object sender, EventArgs e)
        {
            string columna = CategoriaCB.Text;
            string celda = EliminarTb.Text;

            // Llama a un método en el formulario principal para realizar la eliminación
            if (Owner is Frm_Menu formularioPrincipal)
            {
                formularioPrincipal.EliminarFila(columna, celda);
                Close(); // Cierra el formulario de eliminación después de realizar la eliminación
            }
        }
    }
}





