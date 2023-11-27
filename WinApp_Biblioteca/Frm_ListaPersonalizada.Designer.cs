namespace WinApp_Listado
{
    partial class Frm_ListaPersonalizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaPersonalizada));
            this.label2 = new System.Windows.Forms.Label();
            this.Dgw5 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grBx_opciones = new System.Windows.Forms.GroupBox();
            this.chBx_editorial = new System.Windows.Forms.CheckBox();
            this.chBx_edicion = new System.Windows.Forms.CheckBox();
            this.chBx_autor = new System.Windows.Forms.CheckBox();
            this.chBx_nombre = new System.Windows.Forms.CheckBox();
            this.chBx_codigo = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw5)).BeginInit();
            this.grBx_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "Lista Personalizada";
            // 
            // Dgw5
            // 
            this.Dgw5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Autor,
            this.Edición,
            this.Editorial});
            this.Dgw5.Location = new System.Drawing.Point(26, 123);
            this.Dgw5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgw5.Name = "Dgw5";
            this.Dgw5.RowHeadersWidth = 51;
            this.Dgw5.RowTemplate.Height = 24;
            this.Dgw5.Size = new System.Drawing.Size(674, 183);
            this.Dgw5.TabIndex = 27;
            this.Dgw5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgw5_CellContentClick);
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
            // grBx_opciones
            // 
            this.grBx_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(218)))), ((int)(((byte)(241)))));
            this.grBx_opciones.Controls.Add(this.chBx_editorial);
            this.grBx_opciones.Controls.Add(this.chBx_edicion);
            this.grBx_opciones.Controls.Add(this.chBx_autor);
            this.grBx_opciones.Controls.Add(this.chBx_nombre);
            this.grBx_opciones.Controls.Add(this.chBx_codigo);
            this.grBx_opciones.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBx_opciones.Location = new System.Drawing.Point(218, 348);
            this.grBx_opciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBx_opciones.Name = "grBx_opciones";
            this.grBx_opciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBx_opciones.Size = new System.Drawing.Size(271, 113);
            this.grBx_opciones.TabIndex = 28;
            this.grBx_opciones.TabStop = false;
            this.grBx_opciones.Text = "Opciones de campos a escoger";
            // 
            // chBx_editorial
            // 
            this.chBx_editorial.AutoSize = true;
            this.chBx_editorial.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBx_editorial.Location = new System.Drawing.Point(143, 76);
            this.chBx_editorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBx_editorial.Name = "chBx_editorial";
            this.chBx_editorial.Size = new System.Drawing.Size(80, 19);
            this.chBx_editorial.TabIndex = 33;
            this.chBx_editorial.Text = "Editorial";
            this.chBx_editorial.UseVisualStyleBackColor = true;
            // 
            // chBx_edicion
            // 
            this.chBx_edicion.AutoSize = true;
            this.chBx_edicion.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBx_edicion.Location = new System.Drawing.Point(67, 76);
            this.chBx_edicion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBx_edicion.Name = "chBx_edicion";
            this.chBx_edicion.Size = new System.Drawing.Size(68, 19);
            this.chBx_edicion.TabIndex = 32;
            this.chBx_edicion.Text = "Edición";
            this.chBx_edicion.UseVisualStyleBackColor = true;
            // 
            // chBx_autor
            // 
            this.chBx_autor.AutoSize = true;
            this.chBx_autor.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBx_autor.Location = new System.Drawing.Point(196, 35);
            this.chBx_autor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBx_autor.Name = "chBx_autor";
            this.chBx_autor.Size = new System.Drawing.Size(56, 19);
            this.chBx_autor.TabIndex = 31;
            this.chBx_autor.Text = "Autor";
            this.chBx_autor.UseVisualStyleBackColor = true;
            // 
            // chBx_nombre
            // 
            this.chBx_nombre.AutoSize = true;
            this.chBx_nombre.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBx_nombre.Location = new System.Drawing.Point(112, 35);
            this.chBx_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBx_nombre.Name = "chBx_nombre";
            this.chBx_nombre.Size = new System.Drawing.Size(62, 19);
            this.chBx_nombre.TabIndex = 30;
            this.chBx_nombre.Text = "Nombre";
            this.chBx_nombre.UseVisualStyleBackColor = true;
            // 
            // chBx_codigo
            // 
            this.chBx_codigo.AutoSize = true;
            this.chBx_codigo.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBx_codigo.Location = new System.Drawing.Point(26, 35);
            this.chBx_codigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBx_codigo.Name = "chBx_codigo";
            this.chBx_codigo.Size = new System.Drawing.Size(62, 19);
            this.chBx_codigo.TabIndex = 29;
            this.chBx_codigo.Text = "Código";
            this.chBx_codigo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinApp_Biblioteca.Properties.Resources.Imagen_de_WhatsApp_2023_11_26_a_las_22_471;
            this.pictureBox2.Location = new System.Drawing.Point(644, 457);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_ListaPersonalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgw5);
            this.Controls.Add(this.grBx_opciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_ListaPersonalizada";
            this.Text = "Frm_ListaPersonalizada";
            ((System.ComponentModel.ISupportInitialize)(this.Dgw5)).EndInit();
            this.grBx_opciones.ResumeLayout(false);
            this.grBx_opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgw5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.GroupBox grBx_opciones;
        private System.Windows.Forms.CheckBox chBx_editorial;
        private System.Windows.Forms.CheckBox chBx_edicion;
        private System.Windows.Forms.CheckBox chBx_autor;
        private System.Windows.Forms.CheckBox chBx_nombre;
        private System.Windows.Forms.CheckBox chBx_codigo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}