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
        string codigo, nombre, autor, editorial;
        int edicion;

        private DataGridView dgvMenu; // Agregar un campo para almacenar el DataGridView de Frm_Menu

        public Frm_editar_2(object[] rowData, DataGridView dgvMenu)
        {
            InitializeComponent();
            this.dgvMenu = dgvMenu; // Asigna el DataGridView de Frm_Menu

            // Llenar el DataGridView en Frm_Editar_2 con los datos de la fila seleccionada
            Dgw_Editar_2.Rows.Add(rowData);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    nombre = txtnombre.Text;
                    txtautor.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void txtautor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    autor = txtautor.Text;
                    txtedicion.Focus();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void txtedicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    edicion = int.Parse(txtedicion.Text);
                    if (edicion <= 0)
                    {
                        MessageBox.Show("No exiten ediciónes negativas  ");
                    }
                    else
                    {
                        txteditorial.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Ingrese enteros ");
                }
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    codigo = txtcodigo.Text;
                    txtnombre.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void txteditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnConfirmarEditar.Focus();
        }

        private void btnConfirmarEditar_Click(object sender, EventArgs e)
        {
            // Llenar el DataGridView en Frm_Editar_2 con los datos de la fila seleccionada
            dgvMenu.Rows.Clear();
            try
            {
                // Obtener los datos de los TextBoxes
                codigo = txtcodigo.Text;
                nombre = txtnombre.Text;
                autor = txtautor.Text;
                editorial = txteditorial.Text;
                edicion = int.Parse(txtedicion.Text);

                if (int.TryParse(txtedicion.Text, out edicion) && edicion > 0)
                {
                    editorial = txteditorial.Text;

                    // Agregar los datos a la fila recién creada en el DataGridView de Frm_Menu (dgvMenu)
                    int index = dgvMenu.Rows.Add();
                    dgvMenu.Rows[index].Cells["Código"].Value = codigo;
                    dgvMenu.Rows[index].Cells["Nombre"].Value = nombre;
                    dgvMenu.Rows[index].Cells["Autor"].Value = autor;
                    dgvMenu.Rows[index].Cells["Edición"].Value = edicion;
                    dgvMenu.Rows[index].Cells["Editorial"].Value = editorial;

                    // Limpiar los TextBoxes
                    txtcodigo.Clear();
                    txtnombre.Clear();
                    txtautor.Clear();
                    txtedicion.Clear();
                    txteditorial.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para la edición (debe ser un número entero positivo).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnLimpiarEditar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtautor.Clear();
            txtedicion.Clear();
            txteditorial.Clear();
        }


    }
}