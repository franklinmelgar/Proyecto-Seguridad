namespace Matriz_Riesgo_Politica.Matriz
{
    partial class detalleAmenaza
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
            this.txtAmenaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionAmenaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAceptacion = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtPosibilidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImpacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Amenaza";
            // 
            // txtAmenaza
            // 
            this.txtAmenaza.Location = new System.Drawing.Point(40, 52);
            this.txtAmenaza.Name = "txtAmenaza";
            this.txtAmenaza.ReadOnly = true;
            this.txtAmenaza.Size = new System.Drawing.Size(419, 22);
            this.txtAmenaza.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion Amenaza";
            // 
            // txtDescripcionAmenaza
            // 
            this.txtDescripcionAmenaza.Location = new System.Drawing.Point(40, 127);
            this.txtDescripcionAmenaza.Multiline = true;
            this.txtDescripcionAmenaza.Name = "txtDescripcionAmenaza";
            this.txtDescripcionAmenaza.ReadOnly = true;
            this.txtDescripcionAmenaza.Size = new System.Drawing.Size(419, 87);
            this.txtDescripcionAmenaza.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de aceptacion de amenaza";
            // 
            // cmbAceptacion
            // 
            this.cmbAceptacion.FormattingEnabled = true;
            this.cmbAceptacion.Location = new System.Drawing.Point(40, 409);
            this.cmbAceptacion.Name = "cmbAceptacion";
            this.cmbAceptacion.Size = new System.Drawing.Size(419, 24);
            this.cmbAceptacion.TabIndex = 5;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(305, 460);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(154, 30);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtPosibilidad
            // 
            this.txtPosibilidad.Location = new System.Drawing.Point(40, 256);
            this.txtPosibilidad.Name = "txtPosibilidad";
            this.txtPosibilidad.ReadOnly = true;
            this.txtPosibilidad.Size = new System.Drawing.Size(419, 22);
            this.txtPosibilidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posibilidad";
            // 
            // txtImpacto
            // 
            this.txtImpacto.Location = new System.Drawing.Point(40, 323);
            this.txtImpacto.Name = "txtImpacto";
            this.txtImpacto.ReadOnly = true;
            this.txtImpacto.Size = new System.Drawing.Size(419, 22);
            this.txtImpacto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Impacto";
            // 
            // detalleAmenaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 519);
            this.Controls.Add(this.txtImpacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPosibilidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cmbAceptacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcionAmenaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmenaza);
            this.Controls.Add(this.label1);
            this.Name = "detalleAmenaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Amenaza";
            this.Load += new System.EventHandler(this.detalleAmenaza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmenaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionAmenaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAceptacion;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtPosibilidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImpacto;
        private System.Windows.Forms.Label label5;
    }
}