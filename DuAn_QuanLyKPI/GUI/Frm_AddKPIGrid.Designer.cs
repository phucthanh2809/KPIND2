
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_AddKPIGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddKPIGrid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrKPICaNhan = new System.Windows.Forms.DataGridView();
            this.cChonNHCN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaKPICaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDungKPICaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cChiTieuCaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrKPIBenhVien = new System.Windows.Forms.DataGridView();
            this.cChonTatCaBVTC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCongViecCaNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkCongViecCaNhanCaNhan = new System.Windows.Forms.CheckBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.chkCongViecCaNhanNganHangKPI = new System.Windows.Forms.CheckBox();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.btnTaoMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnNganHangCaNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnNganHangKPI = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKPICaNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKPIBenhVien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 754);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrKPICaNhan);
            this.panel3.Controls.Add(this.dgrKPIBenhVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1371, 704);
            this.panel3.TabIndex = 1;
            // 
            // dgrKPICaNhan
            // 
            this.dgrKPICaNhan.AllowUserToAddRows = false;
            this.dgrKPICaNhan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrKPICaNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrKPICaNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrKPICaNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrKPICaNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKPICaNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChonNHCN,
            this.cMaKPICaNhan,
            this.cNoiDungKPICaNhan,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn2,
            this.cChiTieuCaNhan,
            this.dataGridViewTextBoxColumn6});
            this.dgrKPICaNhan.Location = new System.Drawing.Point(125, 68);
            this.dgrKPICaNhan.Name = "dgrKPICaNhan";
            this.dgrKPICaNhan.ReadOnly = true;
            this.dgrKPICaNhan.RowHeadersWidth = 40;
            this.dgrKPICaNhan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrKPICaNhan.RowTemplate.Height = 40;
            this.dgrKPICaNhan.Size = new System.Drawing.Size(1189, 564);
            this.dgrKPICaNhan.TabIndex = 17;
            this.dgrKPICaNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNganHangCaNhan_CellContentClick);
            this.dgrKPICaNhan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrNganHangCaNhan_CellMouseClick);
            // 
            // cChonNHCN
            // 
            this.cChonNHCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cChonNHCN.HeaderText = "Chọn ";
            this.cChonNHCN.Name = "cChonNHCN";
            this.cChonNHCN.ReadOnly = true;
            this.cChonNHCN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cChonNHCN.Width = 60;
            // 
            // cMaKPICaNhan
            // 
            this.cMaKPICaNhan.DataPropertyName = "MaKPI";
            this.cMaKPICaNhan.HeaderText = "Mã KPI";
            this.cMaKPICaNhan.Name = "cMaKPICaNhan";
            this.cMaKPICaNhan.ReadOnly = true;
            // 
            // cNoiDungKPICaNhan
            // 
            this.cNoiDungKPICaNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNoiDungKPICaNhan.DataPropertyName = "NoiDung";
            this.cNoiDungKPICaNhan.HeaderText = "Nội dung";
            this.cNoiDungKPICaNhan.Name = "cNoiDungKPICaNhan";
            this.cNoiDungKPICaNhan.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonViTinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn vị tính ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhuongPhapDo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phương pháp đo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 91;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "CongViecCaNhan";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Công việc cá nhân";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.Width = 88;
            // 
            // cChiTieuCaNhan
            // 
            this.cChiTieuCaNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cChiTieuCaNhan.DataPropertyName = "ChiTieu";
            this.cChiTieuCaNhan.HeaderText = "Chỉ tiêu";
            this.cChiTieuCaNhan.Name = "cChiTieuCaNhan";
            this.cChiTieuCaNhan.ReadOnly = true;
            this.cChiTieuCaNhan.Width = 63;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TieuChiID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phương diện ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 87;
            // 
            // dgrKPIBenhVien
            // 
            this.dgrKPIBenhVien.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrKPIBenhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrKPIBenhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrKPIBenhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrKPIBenhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKPIBenhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChonTatCaBVTC,
            this.CMaKPI,
            this.cNoiDung,
            this.cDVT,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.cTieuChiID});
            this.dgrKPIBenhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrKPIBenhVien.Location = new System.Drawing.Point(0, 0);
            this.dgrKPIBenhVien.Name = "dgrKPIBenhVien";
            this.dgrKPIBenhVien.RowHeadersWidth = 40;
            this.dgrKPIBenhVien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrKPIBenhVien.RowTemplate.Height = 40;
            this.dgrKPIBenhVien.Size = new System.Drawing.Size(1371, 704);
            this.dgrKPIBenhVien.TabIndex = 16;
            this.dgrKPIBenhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrKPIBenhVien_CellClick);
            // 
            // cChonTatCaBVTC
            // 
            this.cChonTatCaBVTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cChonTatCaBVTC.HeaderText = "Chọn ";
            this.cChonTatCaBVTC.Name = "cChonTatCaBVTC";
            this.cChonTatCaBVTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cChonTatCaBVTC.Width = 60;
            // 
            // CMaKPI
            // 
            this.CMaKPI.DataPropertyName = "MaKPI";
            this.CMaKPI.HeaderText = "Mã KPI";
            this.CMaKPI.Name = "CMaKPI";
            // 
            // cNoiDung
            // 
            this.cNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNoiDung.DataPropertyName = "NoiDung";
            this.cNoiDung.HeaderText = "Nội dung";
            this.cNoiDung.Name = "cNoiDung";
            // 
            // cDVT
            // 
            this.cDVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cDVT.DataPropertyName = "DonViTinh";
            this.cDVT.HeaderText = "Đơn vị tính ";
            this.cDVT.Name = "cDVT";
            this.cDVT.Width = 61;
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            this.cPhuongPhapDo.HeaderText = "Phương pháp đo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Width = 91;
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCongViecCaNhan.DataPropertyName = "CongViecCaNhan";
            this.cCongViecCaNhan.HeaderText = "Công việc cá nhân";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            this.cCongViecCaNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cCongViecCaNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cCongViecCaNhan.Width = 88;
            // 
            // cChiTieu
            // 
            this.cChiTieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cChiTieu.DataPropertyName = "ChiTieu";
            this.cChiTieu.HeaderText = "Chỉ tiêu";
            this.cChiTieu.Name = "cChiTieu";
            this.cChiTieu.Width = 63;
            // 
            // cTieuChiID
            // 
            this.cTieuChiID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cTieuChiID.DataPropertyName = "TieuChiID";
            this.cTieuChiID.HeaderText = "Phương diện ";
            this.cTieuChiID.Name = "cTieuChiID";
            this.cTieuChiID.Width = 87;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chkCongViecCaNhanCaNhan);
            this.panel2.Controls.Add(this.lbTenNV);
            this.panel2.Controls.Add(this.chkCongViecCaNhanNganHangKPI);
            this.panel2.Controls.Add(this.nmYear);
            this.panel2.Controls.Add(this.btnTaoMoi);
            this.panel2.Controls.Add(this.btnNganHangCaNhan);
            this.panel2.Controls.Add(this.btnNganHangKPI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 50);
            this.panel2.TabIndex = 0;
            // 
            // chkCongViecCaNhanCaNhan
            // 
            this.chkCongViecCaNhanCaNhan.AutoSize = true;
            this.chkCongViecCaNhanCaNhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCongViecCaNhanCaNhan.Location = new System.Drawing.Point(1071, 11);
            this.chkCongViecCaNhanCaNhan.Name = "chkCongViecCaNhanCaNhan";
            this.chkCongViecCaNhanCaNhan.Size = new System.Drawing.Size(194, 28);
            this.chkCongViecCaNhanCaNhan.TabIndex = 15;
            this.chkCongViecCaNhanCaNhan.Text = "Công viện cá nhân";
            this.chkCongViecCaNhanCaNhan.UseVisualStyleBackColor = true;
            this.chkCongViecCaNhanCaNhan.Visible = false;
            this.chkCongViecCaNhanCaNhan.CheckedChanged += new System.EventHandler(this.chkCongViecCaNhanCaNhan_CheckedChanged);
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTenNV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(785, 10);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(81, 26);
            this.lbTenNV.TabIndex = 14;
            this.lbTenNV.Text = "Tên NV";
            // 
            // chkCongViecCaNhanNganHangKPI
            // 
            this.chkCongViecCaNhanNganHangKPI.AutoSize = true;
            this.chkCongViecCaNhanNganHangKPI.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCongViecCaNhanNganHangKPI.Location = new System.Drawing.Point(1071, 9);
            this.chkCongViecCaNhanNganHangKPI.Name = "chkCongViecCaNhanNganHangKPI";
            this.chkCongViecCaNhanNganHangKPI.Size = new System.Drawing.Size(194, 28);
            this.chkCongViecCaNhanNganHangKPI.TabIndex = 13;
            this.chkCongViecCaNhanNganHangKPI.Text = "Công viện cá nhân";
            this.chkCongViecCaNhanNganHangKPI.UseVisualStyleBackColor = true;
            this.chkCongViecCaNhanNganHangKPI.CheckedChanged += new System.EventHandler(this.chkCongViecCaNhanNganHangKPI_CheckedChanged);
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(1271, 7);
            this.nmYear.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(79, 32);
            this.nmYear.TabIndex = 3;
            this.nmYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.Appearance.Options.UseFont = true;
            this.btnTaoMoi.Location = new System.Drawing.Point(433, 3);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(135, 40);
            this.btnTaoMoi.TabIndex = 2;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnNganHangCaNhan
            // 
            this.btnNganHangCaNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNganHangCaNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganHangCaNhan.Appearance.Options.UseFont = true;
            this.btnNganHangCaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNganHangCaNhan.ImageOptions.Image")));
            this.btnNganHangCaNhan.Location = new System.Drawing.Point(202, 3);
            this.btnNganHangCaNhan.Name = "btnNganHangCaNhan";
            this.btnNganHangCaNhan.Size = new System.Drawing.Size(225, 40);
            this.btnNganHangCaNhan.TabIndex = 1;
            this.btnNganHangCaNhan.Text = "Ngân hàng Cá nhân ";
            this.btnNganHangCaNhan.Click += new System.EventHandler(this.btnNganHangCaNhan_Click);
            // 
            // btnNganHangKPI
            // 
            this.btnNganHangKPI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNganHangKPI.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganHangKPI.Appearance.Options.UseFont = true;
            this.btnNganHangKPI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNganHangKPI.ImageOptions.Image")));
            this.btnNganHangKPI.Location = new System.Drawing.Point(10, 3);
            this.btnNganHangKPI.Name = "btnNganHangKPI";
            this.btnNganHangKPI.Size = new System.Drawing.Size(186, 40);
            this.btnNganHangKPI.TabIndex = 0;
            this.btnNganHangKPI.Text = "Ngân hàng KPI ";
            this.btnNganHangKPI.Click += new System.EventHandler(this.btnNganHangKPI_Click);
            // 
            // Frm_AddKPIGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 754);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_AddKPIGrid.IconOptions.Image")));
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Frm_AddKPIGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Xóa Sửa KPI ";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrKPICaNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKPIBenhVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnTaoMoi;
        private DevExpress.XtraEditors.SimpleButton btnNganHangCaNhan;
        private DevExpress.XtraEditors.SimpleButton btnNganHangKPI;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.CheckBox chkCongViecCaNhanNganHangKPI;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.CheckBox chkCongViecCaNhanCaNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrKPIBenhVien;
        private System.Windows.Forms.DataGridView dgrKPICaNhan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChonNHCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKPICaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDungKPICaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChiTieuCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChonTatCaBVTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhuongPhapDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCongViecCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTieuChiID;
    }
}