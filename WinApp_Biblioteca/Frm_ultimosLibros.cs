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
            int indiceInicio = Math.Max(0, NuevoDgw.Rows.Count - 6);

            if (NuevoDgw != null)
            {
                // Iterar solo sobre las últimas 5 filas del DataGridView original
                for (int i = indiceInicio; i < NuevoDgw.Rows.Count; i++)
                {
                    // Obtener el índice de la nueva fila en Dgw4
                    int nuevoIndice = Dgw4.Rows.Add();

                    // Copiar los valores de las celdas del DataGridView original a Dgw4
                    Dgw4.Rows[nuevoIndice].Cells["Código"].Value = NuevoDgw.Rows[i].Cells[0].Value;
                    Dgw4.Rows[nuevoIndice].Cells["Nombre"].Value = NuevoDgw.Rows[i].Cells[1].Value;
                    Dgw4.Rows[nuevoIndice].Cells["Autor"].Value = NuevoDgw.Rows[i].Cells[2].Value;
                    // Continuar con las demás columnas según sea necesario
                }
            }
        }
    }
}
