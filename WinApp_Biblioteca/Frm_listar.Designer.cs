namespace WinApp_Biblioteca
{
    partial class Frm_listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_listar));
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_listaUltimosInsertados = new System.Windows.Forms.Button();
            this.Btn_listaAutores = new System.Windows.Forms.Button();
            this.Btn_listaTotalLibros = new System.Windows.Forms.Button();
            this.Btn_ListaPersonalizada = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listas ";
            // 
            // Btn_listaUltimosInsertados
            // 
            this.Btn_listaUltimosInsertados.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_listaUltimosInsertados.Location = new System.Drawing.Point(441, 213);
            this.Btn_listaUltimosInsertados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_listaUltimosInsertados.Name = "Btn_listaUltimosInsertados";
            this.Btn_listaUltimosInsertados.Size = new System.Drawing.Size(104, 50);
            this.Btn_listaUltimosInsertados.TabIndex = 27;
            this.Btn_listaUltimosInsertados.Text = "Ultimos Agregados";
            this.Btn_listaUltimosInsertados.UseVisualStyleBackColor = true;
            this.Btn_listaUltimosInsertados.Click += new System.EventHandler(this.Btn_listaUltimosInsertados_Click_1);
            // 
            // Btn_listaAutores
            // 
            this.Btn_listaAutores.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_listaAutores.Location = new System.Drawing.Point(294, 213);
            this.Btn_listaAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_listaAutores.Name = "Btn_listaAutores";
            this.Btn_listaAutores.Size = new System.Drawing.Size(104, 50);
            this.Btn_listaAutores.TabIndex = 25;
            this.Btn_listaAutores.Text = "Autores";
            this.Btn_listaAutores.UseVisualStyleBackColor = true;
            this.Btn_listaAutores.Click += new System.EventHandler(this.Btn_listaAutores_Click);
            // 
            // Btn_listaTotalLibros
            // 
            this.Btn_listaTotalLibros.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_listaTotalLibros.Location = new System.Drawing.Point(150, 213);
            this.Btn_listaTotalLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_listaTotalLibros.Name = "Btn_listaTotalLibros";
            this.Btn_listaTotalLibros.Size = new System.Drawing.Size(104, 50);
            this.Btn_listaTotalLibros.TabIndex = 24;
            this.Btn_listaTotalLibros.Text = "Todos los libros";
            this.Btn_listaTotalLibros.UseVisualStyleBackColor = true;
            this.Btn_listaTotalLibros.Click += new System.EventHandler(this.Btn_listaTotalLibros_Click_1);
            // 
            // Btn_ListaPersonalizada
            // 
            this.Btn_ListaPersonalizada.Location = new System.Drawing.Point(302, 302);
            this.Btn_ListaPersonalizada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ListaPersonalizada.Name = "Btn_ListaPersonalizada";
            this.Btn_ListaPersonalizada.Size = new System.Drawing.Size(81, 41);
            this.Btn_ListaPersonalizada.TabIndex = 28;
            this.Btn_ListaPersonalizada.Text = "Lista Personalizada";
            this.Btn_ListaPersonalizada.UseVisualStyleBackColor = true;
            this.Btn_ListaPersonalizada.Click += new System.EventHandler(this.Btn_ListaPersonalizada_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinApp_Biblioteca.Properties.Resources.Imagen_de_WhatsApp_2023_11_26_a_las_22_471;
            this.pictureBox2.Location = new System.Drawing.Point(645, 456);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_ListaPersonalizada);
            this.Controls.Add(this.Btn_listaUltimosInsertados);
            this.Controls.Add(this.Btn_listaAutores);
            this.Controls.Add(this.Btn_listaTotalLibros);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_listar";
            this.Text = "Listado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_listaUltimosInsertados;
        private System.Windows.Forms.Button Btn_listaAutores;
        private System.Windows.Forms.Button Btn_listaTotalLibros;
        private System.Windows.Forms.Button Btn_ListaPersonalizada;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}