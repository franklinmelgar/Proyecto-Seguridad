namespace Matriz_Riesgo_Politica.Matriz
{
    partial class modificarMatriz
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.cmbNivelConfidencialidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxNombreAprobador = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.cmbActivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObjetivos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtNombreResponsable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Alcance";
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(40, 524);
            this.txtAlcance.Multiline = true;
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(494, 77);
            this.txtAlcance.TabIndex = 24;
            // 
            // cmbNivelConfidencialidad
            // 
            this.cmbNivelConfidencialidad.FormattingEnabled = true;
            this.cmbNivelConfidencialidad.Items.AddRange(new object[] {
            "Confidencial",
            "Restringida",
            "De uso interno",
            "Publico"});
            this.cmbNivelConfidencialidad.Location = new System.Drawing.Point(40, 340);
            this.cmbNivelConfidencialidad.Name = "cmbNivelConfidencialidad";
            this.cmbNivelConfidencialidad.Size = new System.Drawing.Size(494, 24);
            this.cmbNivelConfidencialidad.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nivel de confidencialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nombre del aprobador";
            // 
            // txtxNombreAprobador
            // 
            this.txtxNombreAprobador.Location = new System.Drawing.Point(40, 269);
            this.txtxNombreAprobador.Name = "txtxNombreAprobador";
            this.txtxNombreAprobador.Size = new System.Drawing.Size(494, 22);
            this.txtxNombreAprobador.TabIndex = 19;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(375, 626);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(159, 30);
            this.btGuardar.TabIndex = 26;
            this.btGuardar.Text = "Modificar Matriz";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // cmbActivo
            // 
            this.cmbActivo.FormattingEnabled = true;
            this.cmbActivo.Location = new System.Drawing.Point(40, 51);
            this.cmbActivo.Name = "cmbActivo";
            this.cmbActivo.Size = new System.Drawing.Size(494, 24);
            this.cmbActivo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Activo a evaluar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Objetivos";
            // 
            // txtObjetivos
            // 
            this.txtObjetivos.Location = new System.Drawing.Point(40, 405);
            this.txtObjetivos.Multiline = true;
            this.txtObjetivos.Name = "txtObjetivos";
            this.txtObjetivos.Size = new System.Drawing.Size(494, 77);
            this.txtObjetivos.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre del responsable";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(40, 130);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(494, 22);
            this.txtFechaCreacion.TabIndex = 17;
            // 
            // txtNombreResponsable
            // 
            this.txtNombreResponsable.Location = new System.Drawing.Point(40, 209);
            this.txtNombreResponsable.Name = "txtNombreResponsable";
            this.txtNombreResponsable.Size = new System.Drawing.Size(494, 22);
            this.txtNombreResponsable.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Creacion";
            // 
            // modificarMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 684);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.cmbNivelConfidencialidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtxNombreAprobador);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.cmbActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObjetivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtNombreResponsable);
            this.Controls.Add(this.label1);
            this.Name = "modificarMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Matriz";
            this.Load += new System.EventHandler(this.modificarMatriz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.ComboBox cmbNivelConfidencialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtxNombreAprobador;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.ComboBox cmbActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObjetivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtFechaCreacion;
        private System.Windows.Forms.TextBox txtNombreResponsable;
        private System.Windows.Forms.Label label1;
    }
}