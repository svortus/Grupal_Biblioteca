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
            this.EliminarBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EliminarTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriaCB = new System.Windows.Forms.ComboBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EliminarBt
            // 
            this.EliminarBt.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBt.Location = new System.Drawing.Point(454, 208);
            this.EliminarBt.Name = "EliminarBt";
            this.EliminarBt.Size = new System.Drawing.Size(164, 52);
            this.EliminarBt.TabIndex = 13;
            this.EliminarBt.Text = "Eliminar";
            this.EliminarBt.UseVisualStyleBackColor = true;
            this.EliminarBt.Click += new System.EventHandler(this.EliminarBt_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese:";
            // 
            // EliminarTb
            // 
            this.EliminarTb.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarTb.Location = new System.Drawing.Point(166, 284);
            this.EliminarTb.Name = "EliminarTb";
            this.EliminarTb.Size = new System.Drawing.Size(166, 39);
            this.EliminarTb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Categoria";
            // 
            // CategoriaCB
            // 
            this.CategoriaCB.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaCB.FormattingEnabled = true;
            this.CategoriaCB.Location = new System.Drawing.Point(183, 176);
            this.CategoriaCB.Name = "CategoriaCB";
            this.CategoriaCB.Size = new System.Drawing.Size(121, 43);
            this.CategoriaCB.TabIndex = 9;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(262, 60);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(241, 37);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "Eliminar libro";
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EliminarBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriaCB);
            this.Controls.Add(this.Titulo);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
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
    }
}