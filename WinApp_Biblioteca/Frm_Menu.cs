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

            int index = Dgw1.Rows.Add();

            // Agregar los datos a la fila recién creada
            Dgw1.Rows[index].Cells["Código"].Value = "978-84-339-0405-2";
            Dgw1.Rows[index].Cells["Nombre"].Value = "El Quijote";
            Dgw1.Rows[index].Cells["Autor"].Value = "Miguel de Cervantes";
            Dgw1.Rows[index].Cells["Edición"].Value = 1;
            Dgw1.Rows[index].Cells["Editorial"].Value = "Editorial Planeta";

            int index2 = Dgw1.Rows.Add();

            Dgw1.Rows[index2].Cells["Código"].Value = "978-84-663-5034-9";
            Dgw1.Rows[index2].Cells["Nombre"].Value = "Cien años de soledad";
            Dgw1.Rows[index2].Cells["Autor"].Value = "Gabriel García Márquez";
            Dgw1.Rows[index2].Cells["Edición"].Value = 1;
            Dgw1.Rows[index2].Cells["Editorial"].Value = "Editorial Sudamericana";

            int index3 = Dgw1.Rows.Add();

            Dgw1.Rows[index3].Cells["Código"].Value = "978-84-376-0494-6";
            Dgw1.Rows[index3].Cells["Nombre"].Value = "La metamorfosis";
            Dgw1.Rows[index3].Cells["Autor"].Value = "Franz Kafka";
            Dgw1.Rows[index3].Cells["Edición"].Value = 1;
            Dgw1.Rows[index3].Cells["Editorial"].Value = "Editorial Alfaguara";

            int index4 = Dgw1.Rows.Add();

            Dgw1.Rows[index4].Cells["Código"].Value = "978-84-663-4086-7";
            Dgw1.Rows[index4].Cells["Nombre"].Value = "El señor de los anillos";
            Dgw1.Rows[index4].Cells["Autor"].Value = "J.R.R. Tolkien";
            Dgw1.Rows[index4].Cells["Edición"].Value = 1;
            Dgw1.Rows[index4].Cells["Editorial"].Value = "Editorial Minotauro";


            int index5 = Dgw1.Rows.Add();

            Dgw1.Rows[index5].Cells["Código"].Value = "978-84-376-2411-8";
            Dgw1.Rows[index5].Cells["Nombre"].Value = "Crimen y castigo";
            Dgw1.Rows[index5].Cells["Autor"].Value = "Fiódor Dostoyevski";
            Dgw1.Rows[index5].Cells["Edición"].Value = 1;
            Dgw1.Rows[index5].Cells["Editorial"].Value = "Editorial Alianza";

            int index6 = Dgw1.Rows.Add();

            Dgw1.Rows[index6].Cells["Código"].Value = "978-84-339-0404-5";
            Dgw1.Rows[index6].Cells["Nombre"].Value = "Don Quijote de la Mancha";
            Dgw1.Rows[index6].Cells["Autor"].Value = "Miguel de Cervantes";
            Dgw1.Rows[index6].Cells["Edición"].Value = 2;
            Dgw1.Rows[index6].Cells["Editorial"].Value = "Editorial Planeta";

            int index7 = Dgw1.Rows.Add();

            Dgw1.Rows[index7].Cells["Código"].Value = "978-84-322-0963-9";
            Dgw1.Rows[index7].Cells["Nombre"].Value = "La casa de los espíritus";
            Dgw1.Rows[index7].Cells["Autor"].Value = "Isabel Allende";
            Dgw1.Rows[index7].Cells["Edición"].Value = 1;
            Dgw1.Rows[index7].Cells["Editorial"].Value = "Editorial Plaza & Janés";

            int index8 = Dgw1.Rows.Add();

            Dgw1.Rows[index8].Cells["Código"].Value = "978-84-376-0495-3";
            Dgw1.Rows[index8].Cells["Nombre"].Value = "El pequeño príncipe";
            Dgw1.Rows[index8].Cells["Autor"].Value = "Antoine de Saint-Exupéry";
            Dgw1.Rows[index8].Cells["Edición"].Value = 1;
            Dgw1.Rows[index8].Cells["Editorial"].Value = "Editorial Alfaguara";

            int index9 = Dgw1.Rows.Add();

            Dgw1.Rows[index9].Cells["Código"].Value = "978-84-663-4087-4";
            Dgw1.Rows[index9].Cells["Nombre"].Value = "El señor de los anillos: Las dos torres";
            Dgw1.Rows[index9].Cells["Autor"].Value = "J.R.R. Tolkien";
            Dgw1.Rows[index9].Cells["Edición"].Value = 1;
            Dgw1.Rows[index9].Cells["Editorial"].Value = "Editorial Minotauro";

            int index10 = Dgw1.Rows.Add();

            Dgw1.Rows[index10].Cells["Código"].Value = "978-84-376-2412-5";
            Dgw1.Rows[index10].Cells["Nombre"].Value = "El idiota";
            Dgw1.Rows[index10].Cells["Autor"].Value = "Fiódor Dostoyevski";
            Dgw1.Rows[index10].Cells["Edición"].Value = 1;
            Dgw1.Rows[index10].Cells["Editorial"].Value = "Editorial Alianza";

            int index11 = Dgw1.Rows.Add();

            Dgw1.Rows[index11].Cells["Código"].Value = "978-84-339-0403-8";
            Dgw1.Rows[index11].Cells["Nombre"].Value = "La Celestina";
            Dgw1.Rows[index11].Cells["Autor"].Value = "Fernando de Rojas";
            Dgw1.Rows[index11].Cells["Edición"].Value = 1;
            Dgw1.Rows[index11].Cells["Editorial"].Value = "Editorial Planeta";


            int index12 = Dgw1.Rows.Add();

            Dgw1.Rows[index12].Cells["Código"].Value = "978-84-322-0964-6";
            Dgw1.Rows[index12].Cells["Nombre"].Value = "Eva Luna";
            Dgw1.Rows[index12].Cells["Autor"].Value = "Isabel Allende";
            Dgw1.Rows[index12].Cells["Edición"].Value = 1;
            Dgw1.Rows[index12].Cells["Editorial"].Value = "Editorial Plaza & Janés";

            int index13 = Dgw1.Rows.Add();

            Dgw1.Rows[index13].Cells["Código"].Value = "978-84-663-4088-1";
            Dgw1.Rows[index13].Cells["Nombre"].Value = "El señor de los anillos: El retorno del rey";
            Dgw1.Rows[index13].Cells["Autor"].Value = "J.R.R. Tolkien";
            Dgw1.Rows[index13].Cells["Edición"].Value = 1;
            Dgw1.Rows[index13].Cells["Editorial"].Value = "Editorial Minotauro";

            int index14 = Dgw1.Rows.Add();

            Dgw1.Rows[index14].Cells["Código"].Value = "978-84-663-5035-6";
            Dgw1.Rows[index14].Cells["Nombre"].Value = "Crónica de una muerte anunciada";
            Dgw1.Rows[index14].Cells["Autor"].Value = "Gabriel García Márquez";
            Dgw1.Rows[index14].Cells["Edición"].Value = 1;
            Dgw1.Rows[index14].Cells["Editorial"].Value = "Editorial Planeta";


            int index15 = Dgw1.Rows.Add();

            Dgw1.Rows[index15].Cells["Código"].Value = "978-84-376-0496-0";
            Dgw1.Rows[index15].Cells["Nombre"].Value = "El castillo";
            Dgw1.Rows[index15].Cells["Autor"].Value = "Franz Kafka";
            Dgw1.Rows[index15].Cells["Edición"].Value = 1;
            Dgw1.Rows[index15].Cells["Editorial"].Value = "Editorial Alfaguara";

            int index16 = Dgw1.Rows.Add();

            Dgw1.Rows[index16].Cells["Código"].Value = "978-84-339-0406-9";
            Dgw1.Rows[index16].Cells["Nombre"].Value = "La Regenta";
            Dgw1.Rows[index16].Cells["Autor"].Value = "Leopoldo Alas";
            Dgw1.Rows[index16].Cells["Edición"].Value = 1;
            Dgw1.Rows[index16].Cells["Editorial"].Value = "Editorial Planeta";
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
            Frm_listar objListados = new Frm_listar(Dgw1);
            objListados.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_editar objeEditar = new Frm_editar(Dgw1);
            objeEditar.Show();
            Close();
        }

        private void Dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1 = Dgw1;
            Buscar objB = new Buscar(n1);
            objB.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar formularioEliminar = new FormEliminar();
            formularioEliminar.Owner = this; // Establece el formulario principal como propietario
            formularioEliminar.Show();
        }

        public void EliminarFila(string nombreColumna, string valorCelda)
        {
            // Encuentra la columna con el nombre especificado
            DataGridViewColumn columna = Dgw1.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(col => col.Name == nombreColumna);

            if (columna != null)
            {
                // Busca la fila con el valor especificado en la columna
                DataGridViewRow fila = Dgw1.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(row =>
                        row.Cells[columna.Index].Value != null &&
                        row.Cells[columna.Index].Value.ToString() == valorCelda);

                if (fila != null)
                {
                    // Elimina la fila especificada
                    Dgw1.Rows.Remove(fila);
                }
                else
                {
                    // Muestra un mensaje o realiza alguna acción en caso de que el valor no exista
                    MessageBox.Show("El elemento a eliminar aparentemente no existe.\n" +
                        "Asegurese de ingresar de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Muestra un mensaje o realiza alguna acción en caso de que la columna no exista
                MessageBox.Show("La categoria no existe en el menu.\n" +
                    "Asegurese de seleccionar las disponibles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cierra la aplicación completamente
                Application.Exit();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe objA = new AcercaDe();
            objA.ShowDialog();
        }
    }
}
