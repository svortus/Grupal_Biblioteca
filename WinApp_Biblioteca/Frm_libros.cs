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
    public partial class Frm_libros : Form
    {
        public Frm_libros(DataGridView NuevoDgw)
        {
            InitializeComponent();

            if (NuevoDgw != null)
            {
                foreach (DataGridViewRow row in NuevoDgw.Rows)
                {
                    Dgw2.Rows.Add();
                    Dgw2.Rows[row.Index].Cells["Código"].Value = row.Cells[0].Value;
                    Dgw2.Rows[row.Index].Cells["Nombre"].Value = row.Cells[1].Value;
                    Dgw2.Rows[row.Index].Cells["Autor"].Value = row.Cells[2].Value;
                    Dgw2.Rows[row.Index].Cells["Editorial"].Value = row.Cells[3].Value;
                    Dgw2.Rows[row.Index].Cells["Edición"].Value = row.Cells[4].Value;
                }
            }
        }

        private void Dgw2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
