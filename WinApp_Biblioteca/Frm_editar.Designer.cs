namespace WinApp_Biblioteca
{
    partial class Frm_editar
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
            this.grpEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgw_Editar = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmarEditar = new System.Windows.Forms.Button();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.txtedicion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.lblAutorEditar = new System.Windows.Forms.Label();
            this.lblEditorialEditar = new System.Windows.Forms.Label();
            this.lblEdicionEditar = new System.Windows.Forms.Label();
            this.lblNombreEditar = new System.Windows.Forms.Label();
            this.lblCodigoEditar = new System.Windows.Forms.Label();
            this.grpEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Editar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEditar
            // 
            this.grpEditar.Controls.Add(this.btnEditar);
            this.grpEditar.Controls.Add(this.label1);
            this.grpEditar.Controls.Add(this.Dgw_Editar);
            this.grpEditar.Location = new System.Drawing.Point(12, 12);
            this.grpEditar.Name = "grpEditar";
            this.grpEditar.Size = new System.Drawing.Size(776, 426);
            this.grpEditar.TabIndex = 0;
            this.grpEditar.TabStop = false;
            this.grpEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(345, 365);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "* Por favor, selecione el libro a editar";
            // 
            // Dgw_Editar
            // 
            this.Dgw_Editar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Editar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Autor,
            this.Edición,
            this.Editorial});
            this.Dgw_Editar.Location = new System.Drawing.Point(31, 53);
            this.Dgw_Editar.Name = "Dgw_Editar";
            this.Dgw_Editar.RowHeadersWidth = 51;
            this.Dgw_Editar.RowTemplate.Height = 24;
            this.Dgw_Editar.Size = new System.Drawing.Size(718, 206);
            this.Dgw_Editar.TabIndex = 25;
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
            // btnConfirmarEditar
            // 
            this.btnConfirmarEditar.Location = new System.Drawing.Point(587, 591);
            this.btnConfirmarEditar.Name = "btnConfirmarEditar";
            this.btnConfirmarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarEditar.TabIndex = 50;
            this.btnConfirmarEditar.Text = "Confirmar";
            this.btnConfirmarEditar.UseVisualStyleBackColor = true;
            this.btnConfirmarEditar.Click += new System.EventHandler(this.btnConfirmarEditar_Click);
            // 
            // txteditorial
            // 
            this.txteditorial.Location = new System.Drawing.Point(565, 514);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(184, 22);
            this.txteditorial.TabIndex = 49;
            // 
            // txtedicion
            // 
            this.txtedicion.Location = new System.Drawing.Point(565, 453);
            this.txtedicion.Name = "txtedicion";
            this.txtedicion.Size = new System.Drawing.Size(184, 22);
            this.txtedicion.TabIndex = 48;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(118, 453);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(184, 22);
            this.txtcodigo.TabIndex = 47;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(118, 505);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(184, 22);
            this.txtnombre.TabIndex = 46;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(118, 573);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(184, 22);
            this.txtautor.TabIndex = 45;
            // 
            // lblAutorEditar
            // 
            this.lblAutorEditar.AutoSize = true;
            this.lblAutorEditar.Location = new System.Drawing.Point(46, 576);
            this.lblAutorEditar.Name = "lblAutorEditar";
            this.lblAutorEditar.Size = new System.Drawing.Size(41, 16);
            this.lblAutorEditar.TabIndex = 44;
            this.lblAutorEditar.Text = "Autor:";
            // 
            // lblEditorialEditar
            // 
            this.lblEditorialEditar.AutoSize = true;
            this.lblEditorialEditar.Location = new System.Drawing.Point(482, 520);
            this.lblEditorialEditar.Name = "lblEditorialEditar";
            this.lblEditorialEditar.Size = new System.Drawing.Size(59, 16);
            this.lblEditorialEditar.TabIndex = 43;
            this.lblEditorialEditar.Text = "Editorial:";
            // 
            // lblEdicionEditar
            // 
            this.lblEdicionEditar.AutoSize = true;
            this.lblEdicionEditar.Location = new System.Drawing.Point(482, 459);
            this.lblEdicionEditar.Name = "lblEdicionEditar";
            this.lblEdicionEditar.Size = new System.Drawing.Size(55, 16);
            this.lblEdicionEditar.TabIndex = 42;
            this.lblEdicionEditar.Text = "Edición:";
            // 
            // lblNombreEditar
            // 
            this.lblNombreEditar.AutoSize = true;
            this.lblNombreEditar.Location = new System.Drawing.Point(46, 511);
            this.lblNombreEditar.Name = "lblNombreEditar";
            this.lblNombreEditar.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEditar.TabIndex = 41;
            this.lblNombreEditar.Text = "Nombre:";
            // 
            // lblCodigoEditar
            // 
            this.lblCodigoEditar.AutoSize = true;
            this.lblCodigoEditar.Location = new System.Drawing.Point(46, 459);
            this.lblCodigoEditar.Name = "lblCodigoEditar";
            this.lblCodigoEditar.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEditar.TabIndex = 40;
            this.lblCodigoEditar.Text = "Código:";
            // 
            // Frm_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 686);
            this.Controls.Add(this.btnConfirmarEditar);
            this.Controls.Add(this.txteditorial);
            this.Controls.Add(this.txtedicion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.lblAutorEditar);
            this.Controls.Add(this.lblEditorialEditar);
            this.Controls.Add(this.lblEdicionEditar);
            this.Controls.Add(this.lblNombreEditar);
            this.Controls.Add(this.lblCodigoEditar);
            this.Controls.Add(this.grpEditar);
            this.Name = "Frm_editar";
            this.Text = "Frm_editar";
            this.Load += new System.EventHandler(this.Frm_editar_Load);
            this.grpEditar.ResumeLayout(false);
            this.grpEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Editar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgw_Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConfirmarEditar;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.TextBox txtedicion;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label lblAutorEditar;
        private System.Windows.Forms.Label lblEditorialEditar;
        private System.Windows.Forms.Label lblEdicionEditar;
        private System.Windows.Forms.Label lblNombreEditar;
        private System.Windows.Forms.Label lblCodigoEditar;
    }
}