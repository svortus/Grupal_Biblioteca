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
    public partial class Frm_autores : Form
    {
        public Frm_autores(DataGridView NuevoDgw)
        {
            InitializeComponent();

            foreach (DataGridViewRow row in NuevoDgw.Rows)
            {
                Dgw3.Rows.Add();
                Dgw3.Rows[row.Index].Cells["Código"].Value = row.Cells[0].Value;
                Dgw3.Rows[row.Index].Cells["Nombre"].Value = row.Cells[1].Value;
                Dgw3.Rows[row.Index].Cells["Autor"].Value = row.Cells[2].Value;
            }
        }

        private void Dgw3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgw3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
