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

namespace WinApp_Biblioteca
{
    public partial class Frm_Agregar : Form
    {
        string codigo, nombre, autor , editorial;
        int edicion;
        DataGridView n;
        private void Txt_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    nombre = Txt_Nom.Text;
                    Txt_Aut.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void Txt_Aut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    autor = Txt_Aut.Text;
                    Txt_Edi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void Txt_Edi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    edicion = int.Parse(Txt_Edi.Text);
                    if( edicion <= 0)
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
                    MessageBox.Show("Ingrese enteros " );
                }
            }
        }

        private void Txt_Edt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    editorial = Txt_Edt.Text;
                    Btn_Agregar.Focus();
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
                Dgw1.Rows.Add();
                int filas = Dgw1.Rows.Count - 1;
                Dgw1[0, filas - 1].Value = codigo;
                Dgw1[1, filas - 1].Value = nombre;
                Dgw1[2, filas - 1].Value = autor;
                Dgw1[3, filas - 1].Value = edicion;
                Dgw1[4, filas - 1].Value = editorial;
                Frm_Menu objFM = new Frm_Menu(Dgw1);
                objFM.Update();

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

        public Frm_Agregar(DataGridView n)
        {
            InitializeComponent();
            this.n = n;
            
        }

        private void Frm_Agregar_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    codigo = Txt_Cod.Text;
                    Txt_Nom.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }
    }
}
