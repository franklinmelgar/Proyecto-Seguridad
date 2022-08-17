namespace Matriz_Riesgo_Politica
{
    partial class CrearActivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreActivo = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Activo";
            // 
            // txtNombreActivo
            // 
            this.txtNombreActivo.Location = new System.Drawing.Point(47, 55);
            this.txtNombreActivo.Name = "txtNombreActivo";
            this.txtNombreActivo.Size = new System.Drawing.Size(435, 22);
            this.txtNombreActivo.TabIndex = 1;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(47, 121);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(435, 22);
            this.txtCosto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo";
            // 
            // btCrear
            // 
            this.btCrear.Image = global::Matriz_Riesgo_Politica.Properties.Resources.add;
            this.btCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrear.Location = new System.Drawing.Point(313, 165);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(169, 42);
            this.btCrear.TabIndex = 4;
            this.btCrear.Text = "Crear Activo";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // CrearActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 219);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreActivo);
            this.Controls.Add(this.label1);
            this.Name = "CrearActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearActivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreActivo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCrear;
    }
}