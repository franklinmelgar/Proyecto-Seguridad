namespace Matriz_Riesgo_Politica
{
    partial class fmrMenu
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
            this.tabContenedorPrincipal = new System.Windows.Forms.TabControl();
            this.tabActivos = new System.Windows.Forms.TabPage();
            this.gridActivos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarActivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAmenazas = new System.Windows.Forms.TabPage();
            this.gridAmenzas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarAmenaza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPosibilidad = new System.Windows.Forms.TabPage();
            this.tabImpacto = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btEliminarActivo = new System.Windows.Forms.Button();
            this.btModificarActivo = new System.Windows.Forms.Button();
            this.btAgregarActivos = new System.Windows.Forms.Button();
            this.btEliminarAmenaza = new System.Windows.Forms.Button();
            this.btModificarAmenaza = new System.Windows.Forms.Button();
            this.btAgregarAmenaza = new System.Windows.Forms.Button();
            this.btImpacto = new System.Windows.Forms.Button();
            this.btPosibilidad = new System.Windows.Forms.Button();
            this.btAmenazas = new System.Windows.Forms.Button();
            this.btActivos = new System.Windows.Forms.Button();
            this.tabContenedorPrincipal.SuspendLayout();
            this.tabActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActivos)).BeginInit();
            this.tabAmenazas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAmenzas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContenedorPrincipal
            // 
            this.tabContenedorPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabContenedorPrincipal.Controls.Add(this.tabActivos);
            this.tabContenedorPrincipal.Controls.Add(this.tabAmenazas);
            this.tabContenedorPrincipal.Controls.Add(this.tabPosibilidad);
            this.tabContenedorPrincipal.Controls.Add(this.tabImpacto);
            this.tabContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContenedorPrincipal.Location = new System.Drawing.Point(242, 0);
            this.tabContenedorPrincipal.Multiline = true;
            this.tabContenedorPrincipal.Name = "tabContenedorPrincipal";
            this.tabContenedorPrincipal.SelectedIndex = 0;
            this.tabContenedorPrincipal.Size = new System.Drawing.Size(1285, 751);
            this.tabContenedorPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabContenedorPrincipal.TabIndex = 1;
            // 
            // tabActivos
            // 
            this.tabActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabActivos.Controls.Add(this.btEliminarActivo);
            this.tabActivos.Controls.Add(this.btModificarActivo);
            this.tabActivos.Controls.Add(this.btAgregarActivos);
            this.tabActivos.Controls.Add(this.gridActivos);
            this.tabActivos.Controls.Add(this.label3);
            this.tabActivos.Controls.Add(this.txtBuscarActivo);
            this.tabActivos.Controls.Add(this.label2);
            this.tabActivos.Controls.Add(this.panel3);
            this.tabActivos.Controls.Add(this.label1);
            this.tabActivos.Location = new System.Drawing.Point(4, 4);
            this.tabActivos.Name = "tabActivos";
            this.tabActivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivos.Size = new System.Drawing.Size(1277, 722);
            this.tabActivos.TabIndex = 0;
            this.tabActivos.Text = "Activos";
            // 
            // gridActivos
            // 
            this.gridActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActivos.Location = new System.Drawing.Point(30, 206);
            this.gridActivos.Name = "gridActivos";
            this.gridActivos.ReadOnly = true;
            this.gridActivos.RowHeadersWidth = 51;
            this.gridActivos.RowTemplate.Height = 24;
            this.gridActivos.Size = new System.Drawing.Size(927, 484);
            this.gridActivos.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Listado de activos";
            // 
            // txtBuscarActivo
            // 
            this.txtBuscarActivo.Location = new System.Drawing.Point(39, 121);
            this.txtBuscarActivo.Name = "txtBuscarActivo";
            this.txtBuscarActivo.Size = new System.Drawing.Size(927, 22);
            this.txtBuscarActivo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar Activo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(30, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 2);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Activos";
            // 
            // tabAmenazas
            // 
            this.tabAmenazas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabAmenazas.Controls.Add(this.btEliminarAmenaza);
            this.tabAmenazas.Controls.Add(this.btModificarAmenaza);
            this.tabAmenazas.Controls.Add(this.btAgregarAmenaza);
            this.tabAmenazas.Controls.Add(this.gridAmenzas);
            this.tabAmenazas.Controls.Add(this.label4);
            this.tabAmenazas.Controls.Add(this.txtBuscarAmenaza);
            this.tabAmenazas.Controls.Add(this.label5);
            this.tabAmenazas.Controls.Add(this.panel4);
            this.tabAmenazas.Controls.Add(this.label6);
            this.tabAmenazas.Location = new System.Drawing.Point(4, 4);
            this.tabAmenazas.Name = "tabAmenazas";
            this.tabAmenazas.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmenazas.Size = new System.Drawing.Size(1350, 722);
            this.tabAmenazas.TabIndex = 1;
            this.tabAmenazas.Text = "Amenzas";
            // 
            // gridAmenzas
            // 
            this.gridAmenzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAmenzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAmenzas.Location = new System.Drawing.Point(35, 206);
            this.gridAmenzas.Name = "gridAmenzas";
            this.gridAmenzas.ReadOnly = true;
            this.gridAmenzas.RowHeadersWidth = 51;
            this.gridAmenzas.RowTemplate.Height = 24;
            this.gridAmenzas.Size = new System.Drawing.Size(927, 484);
            this.gridAmenzas.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Listado de amenazas";
            // 
            // txtBuscarAmenaza
            // 
            this.txtBuscarAmenaza.Location = new System.Drawing.Point(35, 121);
            this.txtBuscarAmenaza.Name = "txtBuscarAmenaza";
            this.txtBuscarAmenaza.Size = new System.Drawing.Size(927, 22);
            this.txtBuscarAmenaza.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Buscar Amenaza";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(26, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1305, 2);
            this.panel4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mantenimiento Amenzas";
            // 
            // tabPosibilidad
            // 
            this.tabPosibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPosibilidad.Location = new System.Drawing.Point(4, 4);
            this.tabPosibilidad.Name = "tabPosibilidad";
            this.tabPosibilidad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosibilidad.Size = new System.Drawing.Size(1350, 722);
            this.tabPosibilidad.TabIndex = 2;
            this.tabPosibilidad.Text = "Posibilidad";
            // 
            // tabImpacto
            // 
            this.tabImpacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabImpacto.Location = new System.Drawing.Point(4, 4);
            this.tabImpacto.Name = "tabImpacto";
            this.tabImpacto.Padding = new System.Windows.Forms.Padding(3);
            this.tabImpacto.Size = new System.Drawing.Size(1350, 722);
            this.tabImpacto.TabIndex = 3;
            this.tabImpacto.Text = "Impacto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btImpacto);
            this.panel1.Controls.Add(this.btPosibilidad);
            this.panel1.Controls.Add(this.btAmenazas);
            this.panel1.Controls.Add(this.btActivos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 751);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 4);
            this.panel2.TabIndex = 4;
            // 
            // btEliminarActivo
            // 
            this.btEliminarActivo.Image = global::Matriz_Riesgo_Politica.Properties.Resources.delete;
            this.btEliminarActivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminarActivo.Location = new System.Drawing.Point(994, 319);
            this.btEliminarActivo.Name = "btEliminarActivo";
            this.btEliminarActivo.Size = new System.Drawing.Size(259, 40);
            this.btEliminarActivo.TabIndex = 12;
            this.btEliminarActivo.Text = "Eliminar Activo";
            this.btEliminarActivo.UseVisualStyleBackColor = true;
            // 
            // btModificarActivo
            // 
            this.btModificarActivo.Image = global::Matriz_Riesgo_Politica.Properties.Resources.edit;
            this.btModificarActivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificarActivo.Location = new System.Drawing.Point(994, 271);
            this.btModificarActivo.Name = "btModificarActivo";
            this.btModificarActivo.Size = new System.Drawing.Size(259, 40);
            this.btModificarActivo.TabIndex = 11;
            this.btModificarActivo.Text = "Modificar Activo";
            this.btModificarActivo.UseVisualStyleBackColor = true;
            this.btModificarActivo.Click += new System.EventHandler(this.btModificarActivo_Click);
            // 
            // btAgregarActivos
            // 
            this.btAgregarActivos.Image = global::Matriz_Riesgo_Politica.Properties.Resources.add;
            this.btAgregarActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregarActivos.Location = new System.Drawing.Point(994, 218);
            this.btAgregarActivos.Name = "btAgregarActivos";
            this.btAgregarActivos.Size = new System.Drawing.Size(259, 40);
            this.btAgregarActivos.TabIndex = 10;
            this.btAgregarActivos.Text = "Agregar nuevo activo";
            this.btAgregarActivos.UseVisualStyleBackColor = true;
            this.btAgregarActivos.Click += new System.EventHandler(this.btAgregarActivos_Click);
            // 
            // btEliminarAmenaza
            // 
            this.btEliminarAmenaza.Image = global::Matriz_Riesgo_Politica.Properties.Resources.delete;
            this.btEliminarAmenaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminarAmenaza.Location = new System.Drawing.Point(990, 319);
            this.btEliminarAmenaza.Name = "btEliminarAmenaza";
            this.btEliminarAmenaza.Size = new System.Drawing.Size(322, 40);
            this.btEliminarAmenaza.TabIndex = 21;
            this.btEliminarAmenaza.Text = "Eliminar Amenaza";
            this.btEliminarAmenaza.UseVisualStyleBackColor = true;
            // 
            // btModificarAmenaza
            // 
            this.btModificarAmenaza.Image = global::Matriz_Riesgo_Politica.Properties.Resources.edit;
            this.btModificarAmenaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificarAmenaza.Location = new System.Drawing.Point(990, 271);
            this.btModificarAmenaza.Name = "btModificarAmenaza";
            this.btModificarAmenaza.Size = new System.Drawing.Size(322, 40);
            this.btModificarAmenaza.TabIndex = 20;
            this.btModificarAmenaza.Text = "Modificar Amenaza";
            this.btModificarAmenaza.UseVisualStyleBackColor = true;
            // 
            // btAgregarAmenaza
            // 
            this.btAgregarAmenaza.Image = global::Matriz_Riesgo_Politica.Properties.Resources.add;
            this.btAgregarAmenaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregarAmenaza.Location = new System.Drawing.Point(990, 218);
            this.btAgregarAmenaza.Name = "btAgregarAmenaza";
            this.btAgregarAmenaza.Size = new System.Drawing.Size(322, 40);
            this.btAgregarAmenaza.TabIndex = 19;
            this.btAgregarAmenaza.Text = "Agregar nueva amenaza";
            this.btAgregarAmenaza.UseVisualStyleBackColor = true;
            // 
            // btImpacto
            // 
            this.btImpacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btImpacto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btImpacto.FlatAppearance.BorderSize = 0;
            this.btImpacto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btImpacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btImpacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImpacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImpacto.ForeColor = System.Drawing.Color.White;
            this.btImpacto.Image = global::Matriz_Riesgo_Politica.Properties.Resources.Impacto;
            this.btImpacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImpacto.Location = new System.Drawing.Point(0, 323);
            this.btImpacto.Name = "btImpacto";
            this.btImpacto.Size = new System.Drawing.Size(242, 60);
            this.btImpacto.TabIndex = 3;
            this.btImpacto.Text = "Impacto";
            this.btImpacto.UseVisualStyleBackColor = false;
            this.btImpacto.Click += new System.EventHandler(this.btImpacto_Click);
            // 
            // btPosibilidad
            // 
            this.btPosibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btPosibilidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btPosibilidad.FlatAppearance.BorderSize = 0;
            this.btPosibilidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btPosibilidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btPosibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPosibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPosibilidad.ForeColor = System.Drawing.Color.White;
            this.btPosibilidad.Image = global::Matriz_Riesgo_Politica.Properties.Resources.Posibilidad;
            this.btPosibilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPosibilidad.Location = new System.Drawing.Point(0, 257);
            this.btPosibilidad.Name = "btPosibilidad";
            this.btPosibilidad.Size = new System.Drawing.Size(242, 60);
            this.btPosibilidad.TabIndex = 2;
            this.btPosibilidad.Text = "Posibilidad";
            this.btPosibilidad.UseVisualStyleBackColor = false;
            this.btPosibilidad.Click += new System.EventHandler(this.btPosibilidad_Click);
            // 
            // btAmenazas
            // 
            this.btAmenazas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btAmenazas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btAmenazas.FlatAppearance.BorderSize = 0;
            this.btAmenazas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btAmenazas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btAmenazas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAmenazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAmenazas.ForeColor = System.Drawing.Color.White;
            this.btAmenazas.Image = global::Matriz_Riesgo_Politica.Properties.Resources.Amenazas;
            this.btAmenazas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAmenazas.Location = new System.Drawing.Point(0, 191);
            this.btAmenazas.Name = "btAmenazas";
            this.btAmenazas.Size = new System.Drawing.Size(242, 60);
            this.btAmenazas.TabIndex = 1;
            this.btAmenazas.Text = "Amenazas";
            this.btAmenazas.UseVisualStyleBackColor = false;
            this.btAmenazas.Click += new System.EventHandler(this.btAmenazas_Click);
            // 
            // btActivos
            // 
            this.btActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btActivos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btActivos.FlatAppearance.BorderSize = 0;
            this.btActivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActivos.ForeColor = System.Drawing.Color.White;
            this.btActivos.Image = global::Matriz_Riesgo_Politica.Properties.Resources.Activos;
            this.btActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btActivos.Location = new System.Drawing.Point(0, 125);
            this.btActivos.Name = "btActivos";
            this.btActivos.Size = new System.Drawing.Size(242, 60);
            this.btActivos.TabIndex = 0;
            this.btActivos.Text = "Activos";
            this.btActivos.UseVisualStyleBackColor = false;
            this.btActivos.Click += new System.EventHandler(this.btActivos_Click);
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1527, 751);
            this.Controls.Add(this.tabContenedorPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "fmrMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabContenedorPrincipal.ResumeLayout(false);
            this.tabActivos.ResumeLayout(false);
            this.tabActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActivos)).EndInit();
            this.tabAmenazas.ResumeLayout(false);
            this.tabAmenazas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAmenzas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContenedorPrincipal;
        private System.Windows.Forms.TabPage tabActivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAmenazas;
        private System.Windows.Forms.TabPage tabPosibilidad;
        private System.Windows.Forms.Button btActivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btImpacto;
        private System.Windows.Forms.Button btPosibilidad;
        private System.Windows.Forms.Button btAmenazas;
        private System.Windows.Forms.TabPage tabImpacto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridActivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btEliminarActivo;
        private System.Windows.Forms.Button btModificarActivo;
        private System.Windows.Forms.Button btAgregarActivos;
        private System.Windows.Forms.Button btEliminarAmenaza;
        private System.Windows.Forms.Button btModificarAmenaza;
        private System.Windows.Forms.Button btAgregarAmenaza;
        private System.Windows.Forms.DataGridView gridAmenzas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarAmenaza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
    }
}

