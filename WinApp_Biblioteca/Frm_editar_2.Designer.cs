namespace WinApp_Biblioteca
{
    partial class Frm_editar_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarEditar = new System.Windows.Forms.Button();
            this.btnConfirmarEditar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAutorEditar = new System.Windows.Forms.Label();
            this.lblEditorialEditar = new System.Windows.Forms.Label();
            this.lblEdicionEditar = new System.Windows.Forms.Label();
            this.lblNombreEditar = new System.Windows.Forms.Label();
            this.lblCodigoEditar = new System.Windows.Forms.Label();
            this.Dgw_Editar_2 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Editar_2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLimpiarEditar);
            this.groupBox1.Controls.Add(this.btnConfirmarEditar);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblAutorEditar);
            this.groupBox1.Controls.Add(this.lblEditorialEditar);
            this.groupBox1.Controls.Add(this.lblEdicionEditar);
            this.groupBox1.Controls.Add(this.lblNombreEditar);
            this.groupBox1.Controls.Add(this.lblCodigoEditar);
            this.groupBox1.Controls.Add(this.Dgw_Editar_2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnLimpiarEditar
            // 
            this.btnLimpiarEditar.Location = new System.Drawing.Point(497, 350);
            this.btnLimpiarEditar.Name = "btnLimpiarEditar";
            this.btnLimpiarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarEditar.TabIndex = 38;
            this.btnLimpiarEditar.Text = "Limpiar";
            this.btnLimpiarEditar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEditar
            // 
            this.btnConfirmarEditar.Location = new System.Drawing.Point(635, 350);
            this.btnConfirmarEditar.Name = "btnConfirmarEditar";
            this.btnConfirmarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarEditar.TabIndex = 37;
            this.btnConfirmarEditar.Text = "Confirmar";
            this.btnConfirmarEditar.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(497, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 22);
            this.textBox5.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(497, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 22);
            this.textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 22);
            this.textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 32;
            // 
            // lblAutorEditar
            // 
            this.lblAutorEditar.AutoSize = true;
            this.lblAutorEditar.Location = new System.Drawing.Point(83, 338);
            this.lblAutorEditar.Name = "lblAutorEditar";
            this.lblAutorEditar.Size = new System.Drawing.Size(41, 16);
            this.lblAutorEditar.TabIndex = 31;
            this.lblAutorEditar.Text = "Autor:";
            // 
            // lblEditorialEditar
            // 
            this.lblEditorialEditar.AutoSize = true;
            this.lblEditorialEditar.Location = new System.Drawing.Point(414, 273);
            this.lblEditorialEditar.Name = "lblEditorialEditar";
            this.lblEditorialEditar.Size = new System.Drawing.Size(59, 16);
            this.lblEditorialEditar.TabIndex = 30;
            this.lblEditorialEditar.Text = "Editorial:";
            // 
            // lblEdicionEditar
            // 
            this.lblEdicionEditar.AutoSize = true;
            this.lblEdicionEditar.Location = new System.Drawing.Point(414, 212);
            this.lblEdicionEditar.Name = "lblEdicionEditar";
            this.lblEdicionEditar.Size = new System.Drawing.Size(55, 16);
            this.lblEdicionEditar.TabIndex = 29;
            this.lblEdicionEditar.Text = "Edición:";
            // 
            // lblNombreEditar
            // 
            this.lblNombreEditar.AutoSize = true;
            this.lblNombreEditar.Location = new System.Drawing.Point(83, 273);
            this.lblNombreEditar.Name = "lblNombreEditar";
            this.lblNombreEditar.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEditar.TabIndex = 28;
            this.lblNombreEditar.Text = "Nombre:";
            // 
            // lblCodigoEditar
            // 
            this.lblCodigoEditar.AutoSize = true;
            this.lblCodigoEditar.Location = new System.Drawing.Point(83, 212);
            this.lblCodigoEditar.Name = "lblCodigoEditar";
            this.lblCodigoEditar.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEditar.TabIndex = 27;
            this.lblCodigoEditar.Text = "Código:";
            // 
            // Dgw_Editar_2
            // 
            this.Dgw_Editar_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Editar_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Autor,
            this.Edición,
            this.Editorial});
            this.Dgw_Editar_2.Location = new System.Drawing.Point(31, 49);
            this.Dgw_Editar_2.Name = "Dgw_Editar_2";
            this.Dgw_Editar_2.RowHeadersWidth = 51;
            this.Dgw_Editar_2.RowTemplate.Height = 24;
            this.Dgw_Editar_2.Size = new System.Drawing.Size(697, 84);
            this.Dgw_Editar_2.TabIndex = 26;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_editar_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 783);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_editar_2";
            this.Text = "Frm_editar_2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Editar_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgw_Editar_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnConfirmarEditar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAutorEditar;
        private System.Windows.Forms.Label lblEditorialEditar;
        private System.Windows.Forms.Label lblEdicionEditar;
        private System.Windows.Forms.Label lblNombreEditar;
        private System.Windows.Forms.Label lblCodigoEditar;
        private System.Windows.Forms.Button btnLimpiarEditar;
        private System.Windows.Forms.Button button1;
    }
}