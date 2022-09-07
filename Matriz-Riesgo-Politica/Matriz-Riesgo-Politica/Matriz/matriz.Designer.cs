namespace Matriz_Riesgo_Politica.Matriz
{
    partial class matriz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btImprimirMatriz = new System.Windows.Forms.Button();
            this.btImprimirPoliticas = new System.Windows.Forms.Button();
            this.btAgregarAmenaza = new System.Windows.Forms.Button();
            this.saveFileDialogPoliticas = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lst11 = new System.Windows.Forms.ListBox();
            this.lst12 = new System.Windows.Forms.ListBox();
            this.lst13 = new System.Windows.Forms.ListBox();
            this.lst14 = new System.Windows.Forms.ListBox();
            this.lst15 = new System.Windows.Forms.ListBox();
            this.lst21 = new System.Windows.Forms.ListBox();
            this.lst22 = new System.Windows.Forms.ListBox();
            this.lst23 = new System.Windows.Forms.ListBox();
            this.lst24 = new System.Windows.Forms.ListBox();
            this.lst25 = new System.Windows.Forms.ListBox();
            this.lst31 = new System.Windows.Forms.ListBox();
            this.lst32 = new System.Windows.Forms.ListBox();
            this.lst33 = new System.Windows.Forms.ListBox();
            this.lst34 = new System.Windows.Forms.ListBox();
            this.lst35 = new System.Windows.Forms.ListBox();
            this.lst41 = new System.Windows.Forms.ListBox();
            this.lst42 = new System.Windows.Forms.ListBox();
            this.lst43 = new System.Windows.Forms.ListBox();
            this.lst44 = new System.Windows.Forms.ListBox();
            this.lst45 = new System.Windows.Forms.ListBox();
            this.lst51 = new System.Windows.Forms.ListBox();
            this.lst52 = new System.Windows.Forms.ListBox();
            this.lst53 = new System.Windows.Forms.ListBox();
            this.lst54 = new System.Windows.Forms.ListBox();
            this.lst55 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btImprimirMatriz);
            this.panel1.Controls.Add(this.btImprimirPoliticas);
            this.panel1.Controls.Add(this.btAgregarAmenaza);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 104);
            this.panel1.TabIndex = 2;
            // 
            // btImprimirMatriz
            // 
            this.btImprimirMatriz.Image = global::Matriz_Riesgo_Politica.Properties.Resources.printer;
            this.btImprimirMatriz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimirMatriz.Location = new System.Drawing.Point(537, 28);
            this.btImprimirMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.btImprimirMatriz.Name = "btImprimirMatriz";
            this.btImprimirMatriz.Size = new System.Drawing.Size(246, 49);
            this.btImprimirMatriz.TabIndex = 22;
            this.btImprimirMatriz.Text = "Imprimir Matriz";
            this.btImprimirMatriz.UseVisualStyleBackColor = true;
            // 
            // btImprimirPoliticas
            // 
            this.btImprimirPoliticas.Image = global::Matriz_Riesgo_Politica.Properties.Resources.printer;
            this.btImprimirPoliticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimirPoliticas.Location = new System.Drawing.Point(283, 28);
            this.btImprimirPoliticas.Margin = new System.Windows.Forms.Padding(4);
            this.btImprimirPoliticas.Name = "btImprimirPoliticas";
            this.btImprimirPoliticas.Size = new System.Drawing.Size(246, 49);
            this.btImprimirPoliticas.TabIndex = 21;
            this.btImprimirPoliticas.Text = "Imprimir Politicas";
            this.btImprimirPoliticas.UseVisualStyleBackColor = true;
            this.btImprimirPoliticas.Click += new System.EventHandler(this.btImprimirPoliticas_Click);
            // 
            // btAgregarAmenaza
            // 
            this.btAgregarAmenaza.Image = global::Matriz_Riesgo_Politica.Properties.Resources.add;
            this.btAgregarAmenaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregarAmenaza.Location = new System.Drawing.Point(29, 28);
            this.btAgregarAmenaza.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregarAmenaza.Name = "btAgregarAmenaza";
            this.btAgregarAmenaza.Size = new System.Drawing.Size(246, 49);
            this.btAgregarAmenaza.TabIndex = 20;
            this.btAgregarAmenaza.Text = "Agregar nueva amenaza";
            this.btAgregarAmenaza.UseVisualStyleBackColor = true;
            this.btAgregarAmenaza.Click += new System.EventHandler(this.btAgregarAmenaza_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lst11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst14, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst15, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lst22, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lst23, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lst24, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lst25, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lst31, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lst32, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lst33, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lst34, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lst35, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lst41, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lst42, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lst43, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lst44, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lst45, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.lst51, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lst52, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lst53, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lst54, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lst55, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1683, 692);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lst11
            // 
            this.lst11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst11.FormattingEnabled = true;
            this.lst11.ItemHeight = 16;
            this.lst11.Location = new System.Drawing.Point(283, 118);
            this.lst11.Name = "lst11";
            this.lst11.Size = new System.Drawing.Size(274, 109);
            this.lst11.TabIndex = 0;
            // 
            // lst12
            // 
            this.lst12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst12.FormattingEnabled = true;
            this.lst12.ItemHeight = 16;
            this.lst12.Location = new System.Drawing.Point(563, 118);
            this.lst12.Name = "lst12";
            this.lst12.Size = new System.Drawing.Size(274, 109);
            this.lst12.TabIndex = 1;
            // 
            // lst13
            // 
            this.lst13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst13.FormattingEnabled = true;
            this.lst13.ItemHeight = 16;
            this.lst13.Location = new System.Drawing.Point(843, 118);
            this.lst13.Name = "lst13";
            this.lst13.Size = new System.Drawing.Size(274, 109);
            this.lst13.TabIndex = 2;
            // 
            // lst14
            // 
            this.lst14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst14.FormattingEnabled = true;
            this.lst14.ItemHeight = 16;
            this.lst14.Location = new System.Drawing.Point(1123, 118);
            this.lst14.Name = "lst14";
            this.lst14.Size = new System.Drawing.Size(274, 109);
            this.lst14.TabIndex = 3;
            // 
            // lst15
            // 
            this.lst15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.lst15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst15.FormattingEnabled = true;
            this.lst15.ItemHeight = 16;
            this.lst15.Location = new System.Drawing.Point(1403, 118);
            this.lst15.Name = "lst15";
            this.lst15.Size = new System.Drawing.Size(277, 109);
            this.lst15.TabIndex = 4;
            // 
            // lst21
            // 
            this.lst21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst21.FormattingEnabled = true;
            this.lst21.ItemHeight = 16;
            this.lst21.Location = new System.Drawing.Point(283, 233);
            this.lst21.Name = "lst21";
            this.lst21.Size = new System.Drawing.Size(274, 109);
            this.lst21.TabIndex = 5;
            // 
            // lst22
            // 
            this.lst22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst22.FormattingEnabled = true;
            this.lst22.ItemHeight = 16;
            this.lst22.Location = new System.Drawing.Point(563, 233);
            this.lst22.Name = "lst22";
            this.lst22.Size = new System.Drawing.Size(274, 109);
            this.lst22.TabIndex = 6;
            // 
            // lst23
            // 
            this.lst23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.lst23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst23.FormattingEnabled = true;
            this.lst23.ItemHeight = 16;
            this.lst23.Location = new System.Drawing.Point(843, 233);
            this.lst23.Name = "lst23";
            this.lst23.Size = new System.Drawing.Size(274, 109);
            this.lst23.TabIndex = 7;
            // 
            // lst24
            // 
            this.lst24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.lst24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst24.FormattingEnabled = true;
            this.lst24.ItemHeight = 16;
            this.lst24.Location = new System.Drawing.Point(1123, 233);
            this.lst24.Name = "lst24";
            this.lst24.Size = new System.Drawing.Size(274, 109);
            this.lst24.TabIndex = 8;
            // 
            // lst25
            // 
            this.lst25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst25.FormattingEnabled = true;
            this.lst25.ItemHeight = 16;
            this.lst25.Location = new System.Drawing.Point(1403, 233);
            this.lst25.Name = "lst25";
            this.lst25.Size = new System.Drawing.Size(277, 109);
            this.lst25.TabIndex = 9;
            // 
            // lst31
            // 
            this.lst31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst31.FormattingEnabled = true;
            this.lst31.ItemHeight = 16;
            this.lst31.Location = new System.Drawing.Point(283, 348);
            this.lst31.Name = "lst31";
            this.lst31.Size = new System.Drawing.Size(274, 109);
            this.lst31.TabIndex = 10;
            // 
            // lst32
            // 
            this.lst32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.lst32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst32.FormattingEnabled = true;
            this.lst32.ItemHeight = 16;
            this.lst32.Location = new System.Drawing.Point(563, 348);
            this.lst32.Name = "lst32";
            this.lst32.Size = new System.Drawing.Size(274, 109);
            this.lst32.TabIndex = 11;
            // 
            // lst33
            // 
            this.lst33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.lst33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst33.FormattingEnabled = true;
            this.lst33.ItemHeight = 16;
            this.lst33.Location = new System.Drawing.Point(843, 348);
            this.lst33.Name = "lst33";
            this.lst33.Size = new System.Drawing.Size(274, 109);
            this.lst33.TabIndex = 12;
            // 
            // lst34
            // 
            this.lst34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst34.FormattingEnabled = true;
            this.lst34.ItemHeight = 16;
            this.lst34.Location = new System.Drawing.Point(1123, 348);
            this.lst34.Name = "lst34";
            this.lst34.Size = new System.Drawing.Size(274, 109);
            this.lst34.TabIndex = 13;
            // 
            // lst35
            // 
            this.lst35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst35.FormattingEnabled = true;
            this.lst35.ItemHeight = 16;
            this.lst35.Location = new System.Drawing.Point(1403, 348);
            this.lst35.Name = "lst35";
            this.lst35.Size = new System.Drawing.Size(277, 109);
            this.lst35.TabIndex = 14;
            // 
            // lst41
            // 
            this.lst41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(204)))), ((int)(((byte)(101)))));
            this.lst41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst41.FormattingEnabled = true;
            this.lst41.ItemHeight = 16;
            this.lst41.Location = new System.Drawing.Point(283, 463);
            this.lst41.Name = "lst41";
            this.lst41.Size = new System.Drawing.Size(274, 109);
            this.lst41.TabIndex = 15;
            // 
            // lst42
            // 
            this.lst42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.lst42.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst42.FormattingEnabled = true;
            this.lst42.ItemHeight = 16;
            this.lst42.Location = new System.Drawing.Point(563, 463);
            this.lst42.Name = "lst42";
            this.lst42.Size = new System.Drawing.Size(274, 109);
            this.lst42.TabIndex = 16;
            // 
            // lst43
            // 
            this.lst43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst43.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst43.FormattingEnabled = true;
            this.lst43.ItemHeight = 16;
            this.lst43.Location = new System.Drawing.Point(843, 463);
            this.lst43.Name = "lst43";
            this.lst43.Size = new System.Drawing.Size(274, 109);
            this.lst43.TabIndex = 17;
            // 
            // lst44
            // 
            this.lst44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst44.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst44.FormattingEnabled = true;
            this.lst44.ItemHeight = 16;
            this.lst44.Location = new System.Drawing.Point(1123, 463);
            this.lst44.Name = "lst44";
            this.lst44.Size = new System.Drawing.Size(274, 109);
            this.lst44.TabIndex = 18;
            // 
            // lst45
            // 
            this.lst45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst45.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst45.FormattingEnabled = true;
            this.lst45.ItemHeight = 16;
            this.lst45.Location = new System.Drawing.Point(1403, 463);
            this.lst45.Name = "lst45";
            this.lst45.Size = new System.Drawing.Size(277, 109);
            this.lst45.TabIndex = 19;
            // 
            // lst51
            // 
            this.lst51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.lst51.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst51.FormattingEnabled = true;
            this.lst51.ItemHeight = 16;
            this.lst51.Location = new System.Drawing.Point(283, 578);
            this.lst51.Name = "lst51";
            this.lst51.Size = new System.Drawing.Size(274, 111);
            this.lst51.TabIndex = 20;
            // 
            // lst52
            // 
            this.lst52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst52.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst52.FormattingEnabled = true;
            this.lst52.ItemHeight = 16;
            this.lst52.Location = new System.Drawing.Point(563, 578);
            this.lst52.Name = "lst52";
            this.lst52.Size = new System.Drawing.Size(274, 111);
            this.lst52.TabIndex = 21;
            // 
            // lst53
            // 
            this.lst53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst53.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst53.FormattingEnabled = true;
            this.lst53.ItemHeight = 16;
            this.lst53.Location = new System.Drawing.Point(843, 578);
            this.lst53.Name = "lst53";
            this.lst53.Size = new System.Drawing.Size(274, 111);
            this.lst53.TabIndex = 22;
            // 
            // lst54
            // 
            this.lst54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst54.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst54.FormattingEnabled = true;
            this.lst54.ItemHeight = 16;
            this.lst54.Location = new System.Drawing.Point(1123, 578);
            this.lst54.Name = "lst54";
            this.lst54.Size = new System.Drawing.Size(274, 111);
            this.lst54.TabIndex = 23;
            // 
            // lst55
            // 
            this.lst55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lst55.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst55.FormattingEnabled = true;
            this.lst55.ItemHeight = 16;
            this.lst55.Location = new System.Drawing.Point(1403, 578);
            this.lst55.Name = "lst55";
            this.lst55.Size = new System.Drawing.Size(277, 111);
            this.lst55.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 115);
            this.label1.TabIndex = 25;
            this.label1.Text = "Raro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 115);
            this.label2.TabIndex = 26;
            this.label2.Text = "Improbable";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 115);
            this.label3.TabIndex = 27;
            this.label3.Text = "Posible";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 115);
            this.label4.TabIndex = 28;
            this.label4.Text = "Probable";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 117);
            this.label6.TabIndex = 29;
            this.label6.Text = "Muy probable";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 115);
            this.label7.TabIndex = 30;
            this.label7.Text = "Insignificante";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 115);
            this.label8.TabIndex = 31;
            this.label8.Text = "Menor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(843, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 115);
            this.label9.TabIndex = 32;
            this.label9.Text = "Moderado";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1123, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 115);
            this.label10.TabIndex = 33;
            this.label10.Text = "Mayor";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1403, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 115);
            this.label11.TabIndex = 34;
            this.label11.Text = "Severo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 796);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "matriz";
            this.Text = "Crear Matriz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.matriz_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAgregarAmenaza;
        private System.Windows.Forms.Button btImprimirPoliticas;
        private System.Windows.Forms.Button btImprimirMatriz;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPoliticas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lst11;
        private System.Windows.Forms.ListBox lst12;
        private System.Windows.Forms.ListBox lst13;
        private System.Windows.Forms.ListBox lst14;
        private System.Windows.Forms.ListBox lst15;
        private System.Windows.Forms.ListBox lst21;
        private System.Windows.Forms.ListBox lst22;
        private System.Windows.Forms.ListBox lst23;
        private System.Windows.Forms.ListBox lst24;
        private System.Windows.Forms.ListBox lst25;
        private System.Windows.Forms.ListBox lst31;
        private System.Windows.Forms.ListBox lst32;
        private System.Windows.Forms.ListBox lst33;
        private System.Windows.Forms.ListBox lst34;
        private System.Windows.Forms.ListBox lst35;
        private System.Windows.Forms.ListBox lst41;
        private System.Windows.Forms.ListBox lst42;
        private System.Windows.Forms.ListBox lst43;
        private System.Windows.Forms.ListBox lst44;
        private System.Windows.Forms.ListBox lst45;
        private System.Windows.Forms.ListBox lst51;
        private System.Windows.Forms.ListBox lst52;
        private System.Windows.Forms.ListBox lst53;
        private System.Windows.Forms.ListBox lst54;
        private System.Windows.Forms.ListBox lst55;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}