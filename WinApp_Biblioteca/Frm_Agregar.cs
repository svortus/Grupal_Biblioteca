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
    public partial class Frm_Agregar : Form
    {
        string codigo, nombre, autor, editorial;
        int edicion;
        DataGridView n1Menu;

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
                    if (edicion <= 0)
                    {
                        MessageBox.Show("No existen ediciones negativas.");
                    }
                    else
                    {
                        Txt_Edt.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Ingrese enteros.");
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
                this.Dgw1.Rows.Add();
                int filas = this.Dgw1.Rows.Count - 1;
                this.Dgw1[0, filas - 1].Value = codigo;
                this.Dgw1[1, filas - 1].Value = nombre;
                this.Dgw1[2, filas - 1].Value = autor;
                this.Dgw1[3, filas - 1].Value = edicion;
                this.Dgw1[4, filas - 1].Value = editorial;

                // Agregar el nuevo libro al DataGridView proporcionado
                this.n1Menu.Rows.Add(
                    codigo,
                    nombre,
                    autor,
                    edicion,
                    editorial
                );

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

        public Frm_Agregar(DataGridView n)
        {
            InitializeComponent();
            this.n1Menu = n;
        }

        private void Frm_Agregar_Load(object sender, EventArgs e)
        {
            if (n1Menu != null)
            {
                foreach (DataGridViewRow row in n1Menu.Rows)
                {
                    Dgw1.Rows.Add(
                        row.Cells["Código"].Value,
                        row.Cells["Nombre"].Value,
                        row.Cells["Autor"].Value,
                        row.Cells["Edición"].Value,
                        row.Cells["Editorial"].Value
                    );
                }
            }
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