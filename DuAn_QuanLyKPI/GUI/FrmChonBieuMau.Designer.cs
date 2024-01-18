
namespace DuAn_QuanLyKPI.GUI
{
    partial class FrmChonBieuMau
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonBieuMau));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNam = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuy = new DevExpress.XtraEditors.SimpleButton();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.dgrChonBieuMauQuy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrChonBieuMauNam = new System.Windows.Forms.DataGridView();
            this.cMaBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuy1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cQuy2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cQuy3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cQuy4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cNam = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMauQuy)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMauNam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnNam);
            this.panel2.Controls.Add(this.btnQuy);
            this.panel2.Controls.Add(this.txtTest);
            this.panel2.Controls.Add(this.nmYear);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbYear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 60);
            this.panel2.TabIndex = 0;
            // 
            // btnNam
            // 
            this.btnNam.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Appearance.Options.UseFont = true;
            this.btnNam.ImageOptions.Image = global::DuAn_QuanLyKPI.Properties.Resources.barofpie_32x32;
            this.btnNam.Location = new System.Drawing.Point(516, 14);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(109, 32);
            this.btnNam.TabIndex = 12;
            this.btnNam.Text = "Năm";
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnQuy
            // 
            this.btnQuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuy.Appearance.Options.UseFont = true;
            this.btnQuy.ImageOptions.Image = global::DuAn_QuanLyKPI.Properties.Resources.pieseries_32x32;
            this.btnQuy.Location = new System.Drawing.Point(401, 14);
            this.btnQuy.Name = "btnQuy";
            this.btnQuy.Size = new System.Drawing.Size(109, 32);
            this.btnQuy.TabIndex = 11;
            this.btnQuy.Text = "Quý";
            this.btnQuy.Click += new System.EventHandler(this.btnQuy_Click);
            // 
            // nmYear
            // 
            this.nmYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmYear.Location = new System.Drawing.Point(1230, 14);
            this.nmYear.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(120, 32);
            this.nmYear.TabIndex = 9;
            this.nmYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nmYear.ValueChanged += new System.EventHandler(this.nmYear_ValueChanged);
            this.nmYear.Click += new System.EventHandler(this.nmYear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "HỆ THỐNG BIỂU MẪU";
            // 
            // lbYear
            // 
            this.lbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(1156, 17);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(68, 26);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "Năm:";
            // 
            // dgrChonBieuMauQuy
            // 
            this.dgrChonBieuMauQuy.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrChonBieuMauQuy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrChonBieuMauQuy.BackgroundColor = System.Drawing.Color.White;
            this.dgrChonBieuMauQuy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMauQuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrChonBieuMauQuy.ColumnHeadersHeight = 50;
            this.dgrChonBieuMauQuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn2,
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4,
            this.dataGridViewImageColumn5});
            this.dgrChonBieuMauQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrChonBieuMauQuy.EnableHeadersVisualStyles = false;
            this.dgrChonBieuMauQuy.Location = new System.Drawing.Point(0, 0);
            this.dgrChonBieuMauQuy.Name = "dgrChonBieuMauQuy";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMauQuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrChonBieuMauQuy.RowHeadersWidth = 75;
            this.dgrChonBieuMauQuy.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrChonBieuMauQuy.RowTemplate.Height = 50;
            this.dgrChonBieuMauQuy.Size = new System.Drawing.Size(1364, 676);
            this.dgrChonBieuMauQuy.TabIndex = 3;
            this.dgrChonBieuMauQuy.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaBieuMau";
            this.dataGridViewTextBoxColumn1.HeaderText = "Biểu mẫu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDBieuMau";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Biểu Mẫu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 149;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenBieuMau";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Biểu Mẫu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Quý 1";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Quý 2";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Quý 3";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "Quý 4";
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 736);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrChonBieuMauQuy);
            this.panel3.Controls.Add(this.dgrChonBieuMauNam);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 676);
            this.panel3.TabIndex = 1;
            // 
            // dgrChonBieuMauNam
            // 
            this.dgrChonBieuMauNam.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrChonBieuMauNam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrChonBieuMauNam.BackgroundColor = System.Drawing.Color.White;
            this.dgrChonBieuMauNam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMauNam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrChonBieuMauNam.ColumnHeadersHeight = 50;
            this.dgrChonBieuMauNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaBieuMau,
            this.cIDBieuMau,
            this.cTenBieuMau,
            this.cQuy1,
            this.cQuy2,
            this.cQuy3,
            this.cQuy4,
            this.cNam});
            this.dgrChonBieuMauNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrChonBieuMauNam.EnableHeadersVisualStyles = false;
            this.dgrChonBieuMauNam.Location = new System.Drawing.Point(0, 0);
            this.dgrChonBieuMauNam.Name = "dgrChonBieuMauNam";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMauNam.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgrChonBieuMauNam.RowHeadersWidth = 75;
            this.dgrChonBieuMauNam.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrChonBieuMauNam.RowTemplate.Height = 50;
            this.dgrChonBieuMauNam.Size = new System.Drawing.Size(1364, 676);
            this.dgrChonBieuMauNam.TabIndex = 2;
            this.dgrChonBieuMauNam.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrChonBieuMau_CellMouseClick);
            this.dgrChonBieuMauNam.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrChonBieuMau_RowPostPaint);
            // 
            // cMaBieuMau
            // 
            this.cMaBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cMaBieuMau.DataPropertyName = "MaBieuMau";
            this.cMaBieuMau.HeaderText = "Biểu mẫu";
            this.cMaBieuMau.Name = "cMaBieuMau";
            this.cMaBieuMau.ReadOnly = true;
            this.cMaBieuMau.Width = 120;
            // 
            // cIDBieuMau
            // 
            this.cIDBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cIDBieuMau.DataPropertyName = "IDBieuMau";
            this.cIDBieuMau.HeaderText = "ID Biểu Mẫu";
            this.cIDBieuMau.Name = "cIDBieuMau";
            this.cIDBieuMau.ReadOnly = true;
            this.cIDBieuMau.Visible = false;
            this.cIDBieuMau.Width = 149;
            // 
            // cTenBieuMau
            // 
            this.cTenBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenBieuMau.DataPropertyName = "TenBieuMau";
            this.cTenBieuMau.HeaderText = "Tên Biểu Mẫu";
            this.cTenBieuMau.Name = "cTenBieuMau";
            this.cTenBieuMau.ReadOnly = true;
            // 
            // cQuy1
            // 
            this.cQuy1.HeaderText = "Quý 1";
            this.cQuy1.Image = ((System.Drawing.Image)(resources.GetObject("cQuy1.Image")));
            this.cQuy1.Name = "cQuy1";
            this.cQuy1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cQuy1.Visible = false;
            // 
            // cQuy2
            // 
            this.cQuy2.HeaderText = "Quý 2";
            this.cQuy2.Name = "cQuy2";
            this.cQuy2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cQuy2.Visible = false;
            // 
            // cQuy3
            // 
            this.cQuy3.HeaderText = "Quý 3";
            this.cQuy3.Name = "cQuy3";
            this.cQuy3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cQuy3.Visible = false;
            // 
            // cQuy4
            // 
            this.cQuy4.HeaderText = "Quý 4";
            this.cQuy4.Name = "cQuy4";
            this.cQuy4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cQuy4.Visible = false;
            // 
            // cNam
            // 
            this.cNam.HeaderText = "Năm";
            this.cNam.Image = ((System.Drawing.Image)(resources.GetObject("cNam.Image")));
            this.cNam.Name = "cNam";
            this.cNam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cNam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Chọn";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "Quý 4";
            this.dataGridViewImageColumn6.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn6.Image")));
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtTest
            // 
            this.txtTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTest.Location = new System.Drawing.Point(1050, 14);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 32);
            this.txtTest.TabIndex = 10;
            this.txtTest.Text = "2025";
            // 
            // FrmChonBieuMau
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmChonBieuMau.IconOptions.Image")));
            this.Name = "FrmChonBieuMau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Biểu mẫu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChonBieuMau_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMauQuy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMauNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnNam;
        private DevExpress.XtraEditors.SimpleButton btnQuy;
        private System.Windows.Forms.DataGridView dgrChonBieuMauQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrChonBieuMauNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenBieuMau;
        private System.Windows.Forms.DataGridViewImageColumn cQuy1;
        private System.Windows.Forms.DataGridViewImageColumn cQuy2;
        private System.Windows.Forms.DataGridViewImageColumn cQuy3;
        private System.Windows.Forms.DataGridViewImageColumn cQuy4;
        private System.Windows.Forms.DataGridViewImageColumn cNam;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.TextBox txtTest;
    }
}