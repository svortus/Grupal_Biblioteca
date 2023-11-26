using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp_Biblioteca.Properties;

namespace WinApp_Biblioteca
{
    public partial class Form1 : Form
    {
        string usuario, clave, usc, clc;
        public Form1(string us, string cl)
        {
            InitializeComponent();
            this.usc = us;
            this.clc = cl;
        }
        DataGridView n;


        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                    clave = Txt_Clave.Text;
                    Btn_Ingresar.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void Cbx_Mc_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_Mc.Checked)
            {
                Txt_Clave.PasswordChar = '\0';
            }
            else
            {
                Txt_Clave.PasswordChar = '*';
            }
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(usuario == "Master" &&  clave == "1234")
            {
                
                Frm_Menu objFM = new Frm_Menu(n);
                objFM.ShowDialog();
                this.Visible = false;
                
            }else if (usuario==usc && clave==clc)
            {
                
                Frm_Menu objFM = new Frm_Menu(n);
                objFM.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_Usuario.Focus();
        }

        private void Btn_Ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {
                Btn_Ingresar_Click(sender, e);
            }
            
        }

        private void LkL_Rsgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Registrar objFR = new Frm_Registrar(usc, clc);
            objFR.Show();
            
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    
                    usuario = Txt_Usuario.Text;
                    Txt_Clave.Focus();

                }catch (Exception ex)
                {
                    MessageBox.Show("ERROR: "+ex);
                }
            }
        }
    }
}
