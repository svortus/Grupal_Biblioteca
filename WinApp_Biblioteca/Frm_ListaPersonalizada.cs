using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace WinApp_Listado
{
    public partial class Frm_ListaPersonalizada : Form
    {
        // Lista que almacenará las columnas seleccionadas por el usuario
        private List<string> columnasSeleccionadas = new List<string>();

        public Frm_ListaPersonalizada(DataGridView NuevoDgw)
        {
            InitializeComponent();

            // Asignar el evento de cambio de estado a cada CheckBox
            chBx_codigo.CheckedChanged += CheckBox_CheckedChanged;
            chBx_nombre.CheckedChanged += CheckBox_CheckedChanged;
            chBx_autor.CheckedChanged += CheckBox_CheckedChanged;
            chBx_edicion.CheckedChanged += CheckBox_CheckedChanged;
            chBx_editorial.CheckedChanged += CheckBox_CheckedChanged;

            // Copiar datos desde NuevoDgw a Dgw5
            CopiarDatos(NuevoDgw);
        }

        private void CopiarDatos(DataGridView origen)
        {
            foreach (DataGridViewRow fila in origen.Rows)
            {
                // Agregar nueva fila a Dgw5
                int indice = Dgw5.Rows.Add();

                // Copiar datos de la fila del DataGridView de origen a Dgw5
                Dgw5.Rows[indice].Cells["Código"].Value = fila.Cells[0].Value;
                Dgw5.Rows[indice].Cells["Nombre"].Value = fila.Cells[1].Value;
                Dgw5.Rows[indice].Cells["Autor"].Value = fila.Cells[2].Value;
                Dgw5.Rows[indice].Cells["Editorial"].Value = fila.Cells[3].Value;
                Dgw5.Rows[indice].Cells["Edición"].Value = fila.Cells[4].Value;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Limpiar la lista de columnas seleccionadas
            columnasSeleccionadas.Clear();

            // Agregar las columnas seleccionadas a la lista
            if (chBx_codigo.Checked) columnasSeleccionadas.Add("Código");
            if (chBx_nombre.Checked) columnasSeleccionadas.Add("Nombre");
            if (chBx_autor.Checked) columnasSeleccionadas.Add("Autor");
            if (chBx_edicion.Checked) columnasSeleccionadas.Add("Edición");
            if (chBx_editorial.Checked) columnasSeleccionadas.Add("Editorial");

            // Actualizar la visibilidad de las columnas en el DataGridView
            ActualizarVisibilidadColumnas();
        }

        private void ActualizarVisibilidadColumnas()
        {
            // Hacer todas las columnas invisibles
            foreach (DataGridViewColumn columna in Dgw5.Columns)
            {
                columna.Visible = false;
            }

            // Hacer visibles solo las columnas seleccionadas
            foreach (string columnaSeleccionada in columnasSeleccionadas)
            {
                if (Dgw5.Columns.Contains(columnaSeleccionada))
                {
                    Dgw5.Columns[columnaSeleccionada].Visible = true;
                }
            }
        }

        private void Dgw5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grBx_opciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
