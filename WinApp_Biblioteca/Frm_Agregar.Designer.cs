namespace WinApp_Biblioteca
{
    partial class Frm_Agregar
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
            this.Dgw1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.Txt_Edt = new System.Windows.Forms.TextBox();
            this.Txt_Edi = new System.Windows.Forms.TextBox();
            this.Txt_Aut = new System.Windows.Forms.TextBox();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgw1
            // 
            this.Dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Autor,
            this.Edición,
            this.Editorial});
            this.Dgw1.Location = new System.Drawing.Point(49, 269);
            this.Dgw1.Name = "Dgw1";
            this.Dgw1.RowHeadersWidth = 51;
            this.Dgw1.RowTemplate.Height = 24;
            this.Dgw1.Size = new System.Drawing.Size(718, 107);
            this.Dgw1.TabIndex = 26;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.Width = 125;
            // 
            // Edición
            // 
            this.Edición.HeaderText = "Edición";
            this.Edición.MinimumWidth = 6;
            this.Edición.Name = "Edición";
            this.Edición.Width = 125;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.MinimumWidth = 6;
            this.Editorial.Name = "Editorial";
            this.Editorial.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Editorial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Edición:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Código:";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cod.Location = new System.Drawing.Point(74, 118);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(100, 25);
            this.Txt_Cod.TabIndex = 32;
            this.Txt_Cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cod_KeyPress);
            // 
            // Txt_Edt
            // 
            this.Txt_Edt.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Edt.Location = new System.Drawing.Point(617, 118);
            this.Txt_Edt.Name = "Txt_Edt";
            this.Txt_Edt.Size = new System.Drawing.Size(100, 25);
            this.Txt_Edt.TabIndex = 33;
            this.Txt_Edt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Edt_KeyPress);
            // 
            // Txt_Edi
            // 
            this.Txt_Edi.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Edi.Location = new System.Drawing.Point(482, 118);
            this.Txt_Edi.Name = "Txt_Edi";
            this.Txt_Edi.Size = new System.Drawing.Size(100, 25);
            this.Txt_Edi.TabIndex = 34;
            this.Txt_Edi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Edi_KeyPress);
            // 
            // Txt_Aut
            // 
            this.Txt_Aut.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Aut.Location = new System.Drawing.Point(344, 118);
            this.Txt_Aut.Name = "Txt_Aut";
            this.Txt_Aut.Size = new System.Drawing.Size(100, 25);
            this.Txt_Aut.TabIndex = 35;
            this.Txt_Aut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Aut_KeyPress);
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nom.Location = new System.Drawing.Point(207, 118);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(100, 25);
            this.Txt_Nom.TabIndex = 36;
            this.Txt_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nom_KeyPress);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(355, 193);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(89, 34);
            this.Btn_Agregar.TabIndex = 37;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            this.Btn_Agregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_Agregar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 30);
            this.label6.TabIndex = 38;
            this.label6.Text = "Agregar un libro";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(319, 393);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(173, 34);
            this.Btn_Salir.TabIndex = 39;
            this.Btn_Salir.Text = "Guardar y Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Txt_Nom);
            this.Controls.Add(this.Txt_Aut);
            this.Controls.Add(this.Txt_Edi);
            this.Controls.Add(this.Txt_Edt);
            this.Controls.Add(this.Txt_Cod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgw1);
            this.Name = "Frm_Agregar";
            this.Text = "Frm_Agregar";
            this.Load += new System.EventHandler(this.Frm_Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgw1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.TextBox Txt_Edt;
        private System.Windows.Forms.TextBox Txt_Edi;
        private System.Windows.Forms.TextBox Txt_Aut;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Salir;
    }
}