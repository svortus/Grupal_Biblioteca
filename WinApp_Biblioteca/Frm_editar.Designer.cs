﻿namespace WinApp_Biblioteca
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
            // Frm_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEditar);
            this.Name = "Frm_editar";
            this.Text = "Frm_editar";
            this.Load += new System.EventHandler(this.Frm_editar_Load);
            this.grpEditar.ResumeLayout(false);
            this.grpEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Editar)).EndInit();
            this.ResumeLayout(false);

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
    }
}