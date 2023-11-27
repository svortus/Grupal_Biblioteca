namespace WinApp_Biblioteca
{
    partial class Frm_Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registrar));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_Rsgt = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Clave2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btb_Cancelar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuario:";
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clave.Location = new System.Drawing.Point(294, 239);
            this.Txt_Clave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.PasswordChar = '*';
            this.Txt_Clave.Size = new System.Drawing.Size(128, 21);
            this.Txt_Clave.TabIndex = 11;
            this.Txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Clave_KeyPress);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Usuario.Location = new System.Drawing.Point(292, 192);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(128, 21);
            this.Txt_Usuario.TabIndex = 10;
            this.Txt_Usuario.TextChanged += new System.EventHandler(this.Txt_Usuario_TextChanged);
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // Btn_Rsgt
            // 
            this.Btn_Rsgt.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rsgt.Location = new System.Drawing.Point(254, 358);
            this.Btn_Rsgt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Rsgt.Name = "Btn_Rsgt";
            this.Btn_Rsgt.Size = new System.Drawing.Size(98, 30);
            this.Btn_Rsgt.TabIndex = 9;
            this.Btn_Rsgt.Text = "Registrarse";
            this.Btn_Rsgt.UseVisualStyleBackColor = true;
            this.Btn_Rsgt.Click += new System.EventHandler(this.Btn_Rsgt_Click);
            this.Btn_Rsgt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_Rsgt_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(294, 313);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Mostrar contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Confirmar Contraseña:";
            // 
            // Txt_Clave2
            // 
            this.Txt_Clave2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clave2.Location = new System.Drawing.Point(294, 287);
            this.Txt_Clave2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Clave2.Name = "Txt_Clave2";
            this.Txt_Clave2.PasswordChar = '*';
            this.Txt_Clave2.Size = new System.Drawing.Size(128, 21);
            this.Txt_Clave2.TabIndex = 15;
            this.Txt_Clave2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Clave2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Registro";
            // 
            // Btb_Cancelar
            // 
            this.Btb_Cancelar.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btb_Cancelar.Location = new System.Drawing.Point(364, 358);
            this.Btb_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btb_Cancelar.Name = "Btb_Cancelar";
            this.Btb_Cancelar.Size = new System.Drawing.Size(98, 30);
            this.Btb_Cancelar.TabIndex = 19;
            this.Btb_Cancelar.Text = "Cancelar";
            this.Btb_Cancelar.UseVisualStyleBackColor = true;
            this.Btb_Cancelar.Click += new System.EventHandler(this.Btb_Cancelar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinApp_Biblioteca.Properties.Resources.Imagen_de_WhatsApp_2023_11_26_a_las_23_10_46_3e1ff84a_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(592, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinApp_Biblioteca.Properties.Resources.Imagen_de_WhatsApp_2023_11_26_a_las_22_471;
            this.pictureBox2.Location = new System.Drawing.Point(33, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btb_Cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Clave2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Btn_Rsgt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Registrar";
            this.Text = "Frm_Registrar";
            this.Load += new System.EventHandler(this.Frm_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Button Btn_Rsgt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Clave2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btb_Cancelar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}