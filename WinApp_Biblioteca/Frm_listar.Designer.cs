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
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_listaUltimosInsertados = new System.Windows.Forms.Button();
            this.Btn_listaAutores = new System.Windows.Forms.Button();
            this.Btn_listaTotalLibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listas para usuario";
            // 
            // Btn_listaUltimosInsertados
            // 
            this.Btn_listaUltimosInsertados.Location = new System.Drawing.Point(472, 142);
            this.Btn_listaUltimosInsertados.Name = "Btn_listaUltimosInsertados";
            this.Btn_listaUltimosInsertados.Size = new System.Drawing.Size(108, 50);
            this.Btn_listaUltimosInsertados.TabIndex = 27;
            this.Btn_listaUltimosInsertados.Text = "Ultimos Agregados";
            this.Btn_listaUltimosInsertados.UseVisualStyleBackColor = true;
            // 
            // Btn_listaAutores
            // 
            this.Btn_listaAutores.Location = new System.Drawing.Point(292, 142);
            this.Btn_listaAutores.Name = "Btn_listaAutores";
            this.Btn_listaAutores.Size = new System.Drawing.Size(108, 50);
            this.Btn_listaAutores.TabIndex = 25;
            this.Btn_listaAutores.Text = "Autores";
            this.Btn_listaAutores.UseVisualStyleBackColor = true;
            this.Btn_listaAutores.Click += new System.EventHandler(this.Btn_listaAutores_Click);
            // 
            // Btn_listaTotalLibros
            // 
            this.Btn_listaTotalLibros.Location = new System.Drawing.Point(106, 142);
            this.Btn_listaTotalLibros.Name = "Btn_listaTotalLibros";
            this.Btn_listaTotalLibros.Size = new System.Drawing.Size(108, 50);
            this.Btn_listaTotalLibros.TabIndex = 24;
            this.Btn_listaTotalLibros.Text = "Todos los libros";
            this.Btn_listaTotalLibros.UseVisualStyleBackColor = true;
            // 
            // Frm_listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.Btn_listaUltimosInsertados);
            this.Controls.Add(this.Btn_listaAutores);
            this.Controls.Add(this.Btn_listaTotalLibros);
            this.Controls.Add(this.label2);
            this.Name = "Frm_listar";
            this.Text = "Frm_listar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_listaUltimosInsertados;
        private System.Windows.Forms.Button Btn_listaAutores;
        private System.Windows.Forms.Button Btn_listaTotalLibros;
    }
}