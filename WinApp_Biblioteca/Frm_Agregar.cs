using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinApp_Biblioteca
{
    public partial class Frm_Agregar : Form
    {
        string codigo, nombre, autor, editorial;
        int edicion;
        DataGridView n1;
        private void Txt_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEspacios(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                    if (Txt_Nom.Text == string.Empty)
                    {
                        Txt_Nom.Focus();
                    }
                    else
                    {
                        nombre = Txt_Nom.Text;
                        Txt_Aut.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void Txt_Aut_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEspacios(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (Txt_Aut.Text == string.Empty)
                    {
                        Txt_Aut.Focus();
                    }
                    else
                    {
                        autor = Txt_Aut.Text;
                        Txt_Edi.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void Txt_Edi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEspacios(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    edicion = int.Parse(Txt_Edi.Text);
                    if (edicion <= 0)
                    {
                        MessageBox.Show("No exiten ediciónes negativas  ");
                    }
                    else
                    {
                        Txt_Edt.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Ingrese enteros ");
                }
            }
        }

        private void Txt_Edt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEspacios(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (Txt_Edt.Text == string.Empty)
                    {
                        Txt_Edt.Focus();
                    }
                    else
                    {
                        editorial = Txt_Edt.Text;
                        Btn_Agregar.Enabled = true;
                        Btn_Agregar.Focus();
                    }
  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                int index = Dgw1.Rows.Add();

                // Agregar los datos a la fila recién creada
                Dgw1.Rows[index].Cells["Código"].Value = codigo;
                Dgw1.Rows[index].Cells["Nombre"].Value = nombre;
                Dgw1.Rows[index].Cells["Autor"].Value = autor;
                Dgw1.Rows[index].Cells["Edición"].Value = edicion;
                Dgw1.Rows[index].Cells["Editorial"].Value = editorial;


                Txt_Cod.Clear();
                Txt_Nom.Clear();
                Txt_Edt.Clear();
                Txt_Aut.Clear();
                Txt_Edi.Clear();
                Txt_Cod.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void Btn_Agregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {
                Btn_Agregar_Click(sender, e);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            n1 = Dgw1;
            Frm_Menu objFM = new Frm_Menu(n1);
            objFM.Show();
            this.Close();
        }

        public Frm_Agregar(DataGridView n)
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
                    Dgw1.Rows[row.Index].Cells["Código"].Value = row.Cells[0].Value;
                    Dgw1.Rows[row.Index].Cells["Nombre"].Value = row.Cells[1].Value;
                    Dgw1.Rows[row.Index].Cells["Autor"].Value = row.Cells[2].Value;
                    Dgw1.Rows[row.Index].Cells["Edición"].Value = row.Cells[3].Value;
                    Dgw1.Rows[row.Index].Cells["Editorial"].Value = row.Cells[4].Value;
                }
            }

        }

        private void Frm_Agregar_Load(object sender, EventArgs e)
        {
            Btn_Agregar.Enabled = false;
            if (n1 != null)
            {
                //work in progress
                Frm_Menu objFM = new Frm_Menu(n1); objFM.Close();
            }
            Dgw1.AllowUserToAddRows = false;
        }

        private void Txt_Cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEspacios(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if(Txt_Cod.Text == string.Empty)
                    {
                        Txt_Cod.Focus();
                    }
                    else
                    {
                        codigo = Txt_Cod.Text;
                        Txt_Nom.Focus();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        //enviar informacion by jermin
        public class Libro
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Autor { get; set; }
            public string Editorial { get; set; }
            public int Edicion { get; set; }
        }

        public static class DatosCompartidos
        {
            public static Libro InformacionLibro { get; set; }
        }

        public class TuFormulario
        {
            // Método no estático
            public void EnviarInformacion()
            {
                // Crear una instancia del formulario o usar la instancia existente
                TuFormulario instanciaFormulario = new TuFormulario();

                // Acceder a los TextBoxes a través de la instancia del formulario
                DatosCompartidos.InformacionLibro = new Libro
                {
                    Codigo = instanciaFormulario.Txt_Cod.Text,
                    Nombre = instanciaFormulario.Txt_Nom.Text,
                    Autor = instanciaFormulario.Txt_Aut.Text,
                    Editorial = instanciaFormulario.Txt_Edi.Text,
                    Edicion = int.Parse(instanciaFormulario.Txt_Edt.Text)
                };


            }

            // Declaración de los TextBoxes (asegúrate de que sean públicos o internos)
            public TextBox Txt_Cod = new TextBox();
            public TextBox Txt_Nom = new TextBox();
            public TextBox Txt_Aut = new TextBox();
            public TextBox Txt_Edi = new TextBox();
            public TextBox Txt_Edt = new TextBox();
        }
        public void ControlEspacios(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

    }
}