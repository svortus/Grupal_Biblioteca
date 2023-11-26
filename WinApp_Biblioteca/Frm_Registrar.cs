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
    public partial class Frm_Registrar : Form
    {
        string usur,clv,auxcl,usc, clc;

        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    clv = Txt_Clave.Text;
                    Txt_Clave2.Focus();
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void Btb_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Rsgt_Click(object sender, EventArgs e)
        {

            if(clv == auxcl)
            {
                usc = usur;
                clc = clv;
                MessageBox.Show("Resgisto exitoso");
                Form1 objF1 = new Form1(usc,clv);
                objF1.Show();
                this.Close();
            }else
            {
                MessageBox.Show("La clave no es igual");
            }
        }

        private void Btn_Rsgt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Btn_Rsgt_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Txt_Clave.PasswordChar = '\0';
                Txt_Clave2.PasswordChar = '\0';
            }
            else
            {
                Txt_Clave.PasswordChar = '*';
                Txt_Clave2.PasswordChar = '*';
            }
        }

        private void Txt_Clave2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    auxcl = Txt_Clave2.Text;
                    Btn_Rsgt.Focus();
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        public Frm_Registrar(string us,string cl)
        {
            InitializeComponent();
            this.usc = us;
            this.clc = cl;
            
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    usur = Txt_Usuario.Text;
                    Txt_Clave2.Focus();
                }
                catch 
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void Frm_Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
