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
    public partial class Frm_ultimosLibros : Form
    {
        public Frm_ultimosLibros(DataGridView NuevoDgw)
        {
            InitializeComponent();

            // Obtener el índice del primer elemento a copiar
            int indiceInicio = Math.Max(0, NuevoDgw.Rows.Count - 5);

            if (NuevoDgw != null)
            {
                // Limpiar Dgw4 antes de agregar nuevas filas
                Dgw4.Rows.Clear();

                // Iterar solo sobre las últimas 5 filas del DataGridView original
                for (int i = indiceInicio; i < NuevoDgw.Rows.Count; i++)
                {
                    // Agregar nueva fila a Dgw4
                    int nuevoIndice = Dgw4.Rows.Add();
                    Dgw4.Rows[nuevoIndice].Cells["Código"].Value = NuevoDgw.Rows[i].Cells[0].Value;
                    Dgw4.Rows[nuevoIndice].Cells["Nombre"].Value = NuevoDgw.Rows[i].Cells[1].Value;
                    Dgw4.Rows[nuevoIndice].Cells["Autor"].Value = NuevoDgw.Rows[i].Cells[2].Value;
                    Dgw4.Rows[nuevoIndice].Cells["Edición"].Value = NuevoDgw.Rows[i].Cells[3].Value;
                    Dgw4.Rows[nuevoIndice].Cells["Editorial"].Value = NuevoDgw.Rows[i].Cells[4].Value;
                    // Continuar con las demás columnas según sea necesario
                }
            }
        }

        private void Dgw4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ultimosLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
