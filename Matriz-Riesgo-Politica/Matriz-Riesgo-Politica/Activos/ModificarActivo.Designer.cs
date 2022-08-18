namespace Matriz_Riesgo_Politica.Activos
{
    partial class ModificarActivo
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
            this.btCrear = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreActivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCrear
            // 
            this.btCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrear.Location = new System.Drawing.Point(228, 126);
            this.btCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(127, 34);
            this.btCrear.TabIndex = 9;
            this.btCrear.Text = "Actualizar Activo";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(28, 90);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(327, 20);
            this.txtCosto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Costo";
            // 
            // txtNombreActivo
            // 
            this.txtNombreActivo.Location = new System.Drawing.Point(28, 37);
            this.txtNombreActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreActivo.Name = "txtNombreActivo";
            this.txtNombreActivo.Size = new System.Drawing.Size(327, 20);
            this.txtNombreActivo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Activo";
            // 
            // ModificarActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 176);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreActivo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Activo";
            this.Load += new System.EventHandler(this.ModificarActivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreActivo;
        private System.Windows.Forms.Label label1;
    }
}