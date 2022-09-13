namespace Matriz_Riesgo_Politica.Impacto
{
    partial class eliminarImpacto
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNivelImpacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(35, 170);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(404, 98);
            this.txtDescripcion.TabIndex = 27;
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Location = new System.Drawing.Point(35, 107);
            this.txtPuntaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.ReadOnly = true;
            this.txtPuntaje.Size = new System.Drawing.Size(404, 22);
            this.txtPuntaje.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Puntaje";
            // 
            // txtNivelImpacto
            // 
            this.txtNivelImpacto.Location = new System.Drawing.Point(36, 47);
            this.txtNivelImpacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNivelImpacto.Name = "txtNivelImpacto";
            this.txtNivelImpacto.ReadOnly = true;
            this.txtNivelImpacto.Size = new System.Drawing.Size(404, 22);
            this.txtNivelImpacto.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nivel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Eliminar Impacto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarImpacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 333);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNivelImpacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "eliminarImpacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Impacto";
            this.Load += new System.EventHandler(this.eliminarImpacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNivelImpacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}