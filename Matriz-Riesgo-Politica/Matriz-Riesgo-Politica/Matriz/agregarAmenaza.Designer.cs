namespace Matriz_Riesgo_Politica.Matriz
{
    partial class agregarAmenaza
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
            this.cmbAmenaza = new System.Windows.Forms.ComboBox();
            this.cmbPosibilidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbImpacto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amenaza";
            // 
            // cmbAmenaza
            // 
            this.cmbAmenaza.FormattingEnabled = true;
            this.cmbAmenaza.Location = new System.Drawing.Point(45, 53);
            this.cmbAmenaza.Name = "cmbAmenaza";
            this.cmbAmenaza.Size = new System.Drawing.Size(545, 24);
            this.cmbAmenaza.TabIndex = 1;
            // 
            // cmbPosibilidad
            // 
            this.cmbPosibilidad.FormattingEnabled = true;
            this.cmbPosibilidad.Location = new System.Drawing.Point(45, 131);
            this.cmbPosibilidad.Name = "cmbPosibilidad";
            this.cmbPosibilidad.Size = new System.Drawing.Size(545, 24);
            this.cmbPosibilidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posibilidad";
            // 
            // cmbImpacto
            // 
            this.cmbImpacto.FormattingEnabled = true;
            this.cmbImpacto.Location = new System.Drawing.Point(45, 220);
            this.cmbImpacto.Name = "cmbImpacto";
            this.cmbImpacto.Size = new System.Drawing.Size(545, 24);
            this.cmbImpacto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Impacto";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(411, 281);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(178, 30);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // agregarAmenaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 336);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cmbImpacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPosibilidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAmenaza);
            this.Controls.Add(this.label1);
            this.Name = "agregarAmenaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Amenaza";
            this.Load += new System.EventHandler(this.agregarAmenaza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAmenaza;
        private System.Windows.Forms.ComboBox cmbPosibilidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbImpacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAgregar;
    }
}