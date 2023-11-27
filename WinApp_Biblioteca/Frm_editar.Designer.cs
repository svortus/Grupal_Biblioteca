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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_editar));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEditar
            // 
            this.grpEditar.Controls.Add(this.btnEditar);
            this.grpEditar.Controls.Add(this.label1);
            this.grpEditar.Controls.Add(this.Dgw_Editar);
            this.grpEditar.Location = new System.Drawing.Point(25, 11);
            this.grpEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEditar.Name = "grpEditar";
            this.grpEditar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEditar.Size = new System.Drawing.Size(671, 301);
            this.grpEditar.TabIndex = 0;
            this.grpEditar.TabStop = false;
            this.grpEditar.Text = "Editar";
            this.grpEditar.Enter += new System.EventHandler(this.grpEditar_Enter);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(287, 257);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 29);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
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
            this.Dgw_Editar.Location = new System.Drawing.Point(15, 43);
            this.Dgw_Editar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgw_Editar.Name = "Dgw_Editar";
            this.Dgw_Editar.RowHeadersWidth = 51;
            this.Dgw_Editar.RowTemplate.Height = 24;
            this.Dgw_Editar.Size = new System.Drawing.Size(639, 165);
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
            this.btnConfirmarEditar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEditar.Location = new System.Drawing.Point(463, 423);
            this.btnConfirmarEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmarEditar.Name = "btnConfirmarEditar";
            this.btnConfirmarEditar.Size = new System.Drawing.Size(95, 32);
            this.btnConfirmarEditar.TabIndex = 50;
            this.btnConfirmarEditar.Text = "Confirmar";
            this.btnConfirmarEditar.UseVisualStyleBackColor = true;
            this.btnConfirmarEditar.Click += new System.EventHandler(this.btnConfirmarEditar_Click);
            // 
            // txteditorial
            // 
            this.txteditorial.Location = new System.Drawing.Point(483, 387);
            this.txteditorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(139, 20);
            this.txteditorial.TabIndex = 49;
            // 
            // txtedicion
            // 
            this.txtedicion.Location = new System.Drawing.Point(483, 337);
            this.txtedicion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtedicion.Name = "txtedicion";
            this.txtedicion.Size = new System.Drawing.Size(139, 20);
            this.txtedicion.TabIndex = 48;
            this.txtedicion.TextChanged += new System.EventHandler(this.txtedicion_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(147, 337);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(139, 20);
            this.txtcodigo.TabIndex = 47;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(147, 379);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(139, 20);
            this.txtnombre.TabIndex = 46;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(147, 435);
            this.txtautor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(139, 20);
            this.txtautor.TabIndex = 45;
            // 
            // lblAutorEditar
            // 
            this.lblAutorEditar.AutoSize = true;
            this.lblAutorEditar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorEditar.Location = new System.Drawing.Point(79, 434);
            this.lblAutorEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutorEditar.Name = "lblAutorEditar";
            this.lblAutorEditar.Size = new System.Drawing.Size(56, 17);
            this.lblAutorEditar.TabIndex = 44;
            this.lblAutorEditar.Text = "Autor:";
            // 
            // lblEditorialEditar
            // 
            this.lblEditorialEditar.AutoSize = true;
            this.lblEditorialEditar.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorialEditar.Location = new System.Drawing.Point(402, 390);
            this.lblEditorialEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditorialEditar.Name = "lblEditorialEditar";
            this.lblEditorialEditar.Size = new System.Drawing.Size(77, 16);
            this.lblEditorialEditar.TabIndex = 43;
            this.lblEditorialEditar.Text = "Editorial:";
            // 
            // lblEdicionEditar
            // 
            this.lblEdicionEditar.AutoSize = true;
            this.lblEdicionEditar.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicionEditar.Location = new System.Drawing.Point(402, 341);
            this.lblEdicionEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdicionEditar.Name = "lblEdicionEditar";
            this.lblEdicionEditar.Size = new System.Drawing.Size(63, 16);
            this.lblEdicionEditar.TabIndex = 42;
            this.lblEdicionEditar.Text = "Edición:";
            // 
            // lblNombreEditar
            // 
            this.lblNombreEditar.AutoSize = true;
            this.lblNombreEditar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEditar.Location = new System.Drawing.Point(79, 381);
            this.lblNombreEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEditar.Name = "lblNombreEditar";
            this.lblNombreEditar.Size = new System.Drawing.Size(64, 17);
            this.lblNombreEditar.TabIndex = 41;
            this.lblNombreEditar.Text = "Nombre:";
            // 
            // lblCodigoEditar
            // 
            this.lblCodigoEditar.AutoSize = true;
            this.lblCodigoEditar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEditar.Location = new System.Drawing.Point(79, 339);
            this.lblCodigoEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoEditar.Name = "lblCodigoEditar";
            this.lblCodigoEditar.Size = new System.Drawing.Size(64, 17);
            this.lblCodigoEditar.TabIndex = 40;
            this.lblCodigoEditar.Text = "Código:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinApp_Biblioteca.Properties.Resources.Imagen_de_WhatsApp_2023_11_26_a_las_22_471;
            this.pictureBox2.Location = new System.Drawing.Point(635, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.pictureBox2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Frm_editar_Load);
            this.grpEditar.ResumeLayout(false);
            this.grpEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}