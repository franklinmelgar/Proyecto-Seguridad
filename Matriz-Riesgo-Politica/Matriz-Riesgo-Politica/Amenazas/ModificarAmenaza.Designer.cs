namespace Matriz_Riesgo_Politica.Amenazas
{
    partial class ModificarAmenaza
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
            this.btModificar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAmenaza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btModificar
            // 
            this.btModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificar.Location = new System.Drawing.Point(228, 209);
            this.btModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(127, 33);
            this.btModificar.TabIndex = 14;
            this.btModificar.Text = "Modificar Amenaza";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(28, 91);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(327, 93);
            this.txtDescripcion.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion de la amenaza";
            // 
            // txtNombreAmenaza
            // 
            this.txtNombreAmenaza.Location = new System.Drawing.Point(28, 38);
            this.txtNombreAmenaza.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreAmenaza.Name = "txtNombreAmenaza";
            this.txtNombreAmenaza.Size = new System.Drawing.Size(327, 20);
            this.txtNombreAmenaza.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de la amenaza";
            // 
            // ModificarAmenaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 267);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreAmenaza);
            this.Controls.Add(this.label1);
            this.Name = "ModificarAmenaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Amenaza";
            this.Load += new System.EventHandler(this.ModificarAmenaza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAmenaza;
        private System.Windows.Forms.Label label1;
    }
}