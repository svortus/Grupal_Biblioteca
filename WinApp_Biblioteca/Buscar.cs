using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Biblioteca
{
    public partial class Buscar : Form
    {
        private readonly DataGridView dgwTodoLibros;
        public Buscar(DataGridView dgwLibros)
        {
            InitializeComponent();

            this.dgwTodoLibros = dgwLibros;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreLibro = Limpiatexto(txtBusqueda.Text).ToLowerInvariant();

            if (!string.IsNullOrEmpty(nombreLibro))
            {
                BuscarLibro(nombreLibro);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre del libro para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarLibro(string nombreLibro)
        {
            DataTable dtResultados = new DataTable();
            dtResultados.Columns.Add("Código");
            dtResultados.Columns.Add("Nombre");
            dtResultados.Columns.Add("Autor");
            dtResultados.Columns.Add("Editorial");
            dtResultados.Columns.Add("Edición");

            foreach (DataGridViewRow row in dgwTodoLibros.Rows)
            {
                string nombre = Convert.ToString(row.Cells["Nombre"].Value);
                string nombreNormalizado = Limpiatexto(nombre);
                if (nombre.IndexOf(nombreLibro, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    dtResultados.Rows.Add(
                        row.Cells["Código"].Value,
                        row.Cells["Nombre"].Value,
                        row.Cells["Autor"].Value,
                        row.Cells["Editorial"].Value,
                        row.Cells["Edición"].Value
                    );
                }
            }

            if (dtResultados.Rows.Count > 0)
            {
                DgwBuscar.DataSource = dtResultados;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para el nombre del libro proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgwBuscar.DataSource = null;
            }
        }

        private string Limpiatexto(string texto)
        {
            string eliminarT = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in eliminarT)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().ToLowerInvariant();
        }
    }
}
