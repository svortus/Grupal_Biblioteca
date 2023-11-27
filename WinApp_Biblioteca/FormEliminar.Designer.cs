namespace WinApp_Biblioteca
{
    partial class FormEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            this.EliminarBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EliminarTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriaCB = new System.Windows.Forms.ComboBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarBt
            // 
            this.EliminarBt.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBt.Location = new System.Drawing.Point(265, 312);
            this.EliminarBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EliminarBt.Name = "EliminarBt";
            this.EliminarBt.Size = new System.Drawing.Size(145, 43);
            this.EliminarBt.TabIndex = 13;
            this.EliminarBt.Text = "Eliminar";
            this.EliminarBt.UseVisualStyleBackColor = true;
            this.EliminarBt.Click += new System.EventHandler(this.EliminarBt_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese:";
            // 
            // EliminarTb
            // 
            this.EliminarTb.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarTb.Location = new System.Drawing.Point(339, 221);
            this.EliminarTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EliminarTb.Name = "EliminarTb";
            this.EliminarTb.Size = new System.Drawing.Size(126, 30);
            this.EliminarTb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Categoría";
            // 
            // CategoriaCB
            // 
            this.CategoriaCB.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaCB.FormattingEnabled = true;
            this.CategoriaCB.Location = new System.Drawing.Point(339, 124);
            this.CategoriaCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoriaCB.Name = "CategoriaCB";
            this.CategoriaCB.Size = new System.Drawing.Size(92, 33);
            this.CategoriaCB.TabIndex = 9;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(260, 55);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(195, 29);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "Eliminar libro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinApp_Biblioteca.Properties.Resources.Imagen_de_WhatsApp_2023_11_26_a_las_22_471;
            this.pictureBox2.Location = new System.Drawing.Point(641, 451);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EliminarBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriaCB);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EliminarBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EliminarTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoriaCB;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}