
using System.Drawing;
using System.Windows.Forms;

namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_ChiTieuVuaGiao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Bieumau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTrongSo = new System.Windows.Forms.TextBox();
            this.Nam = new System.Windows.Forms.Label();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.dt_NgayTaoMaPhieu = new System.Windows.Forms.DateTimePicker();
            this.btn_TaoMaPhieu = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_ChiTietKPI = new System.Windows.Forms.DataGridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhuongPhapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCongViecCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cChiTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_LoaiPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_MauPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuKPIBV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrongSoTCBV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrongSoKPIBV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKeHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietKPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1564, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(470, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT KPI ĐÃ CHỌN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Bieumau);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTongTrongSo);
            this.panel2.Controls.Add(this.Nam);
            this.panel2.Controls.Add(this.txt_Nam);
            this.panel2.Controls.Add(this.txt_MaPhieu);
            this.panel2.Controls.Add(this.dt_NgayTaoMaPhieu);
            this.panel2.Controls.Add(this.btn_TaoMaPhieu);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1564, 117);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1063, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tổng trọng số : ";
            // 
            // txt_Bieumau
            // 
            this.txt_Bieumau.Location = new System.Drawing.Point(709, 71);
            this.txt_Bieumau.Name = "txt_Bieumau";
            this.txt_Bieumau.ReadOnly = true;
            this.txt_Bieumau.Size = new System.Drawing.Size(177, 32);
            this.txt_Bieumau.TabIndex = 86;
            this.txt_Bieumau.Text = "Mục tiêu Bệnh viện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 84;
            this.label3.Text = "Biểu mẫu: ";
            // 
            // txtTongTrongSo
            // 
            this.txtTongTrongSo.Location = new System.Drawing.Point(1225, 71);
            this.txtTongTrongSo.Name = "txtTongTrongSo";
            this.txtTongTrongSo.ReadOnly = true;
            this.txtTongTrongSo.Size = new System.Drawing.Size(134, 32);
            this.txtTongTrongSo.TabIndex = 81;
            this.txtTongTrongSo.TextChanged += new System.EventHandler(this.txtTongTrongSo_TextChanged);
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(601, 36);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(56, 23);
            this.Nam.TabIndex = 18;
            this.Nam.Text = "Năm:";
            // 
            // txt_Nam
            // 
            this.txt_Nam.Enabled = false;
            this.txt_Nam.Location = new System.Drawing.Point(709, 33);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.ReadOnly = true;
            this.txt_Nam.Size = new System.Drawing.Size(177, 32);
            this.txt_Nam.TabIndex = 15;
            this.txt_Nam.TextChanged += new System.EventHandler(this.txt_Nam_TextChanged);
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Enabled = false;
            this.txt_MaPhieu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhieu.Location = new System.Drawing.Point(148, 27);
            this.txt_MaPhieu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.ReadOnly = true;
            this.txt_MaPhieu.Size = new System.Drawing.Size(266, 32);
            this.txt_MaPhieu.TabIndex = 12;
            this.txt_MaPhieu.TextChanged += new System.EventHandler(this.txt_MaPhieu_TextChanged);
            // 
            // dt_NgayTaoMaPhieu
            // 
            this.dt_NgayTaoMaPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayTaoMaPhieu.Location = new System.Drawing.Point(148, 71);
            this.dt_NgayTaoMaPhieu.Name = "dt_NgayTaoMaPhieu";
            this.dt_NgayTaoMaPhieu.Size = new System.Drawing.Size(120, 32);
            this.dt_NgayTaoMaPhieu.TabIndex = 11;
            this.dt_NgayTaoMaPhieu.ValueChanged += new System.EventHandler(this.dt_NgayTaoMaPhieu_ValueChanged);
            // 
            // btn_TaoMaPhieu
            // 
            this.btn_TaoMaPhieu.Location = new System.Drawing.Point(279, 67);
            this.btn_TaoMaPhieu.Name = "btn_TaoMaPhieu";
            this.btn_TaoMaPhieu.Size = new System.Drawing.Size(135, 36);
            this.btn_TaoMaPhieu.TabIndex = 10;
            this.btn_TaoMaPhieu.Text = "Tạo mã phiếu";
            this.btn_TaoMaPhieu.UseVisualStyleBackColor = true;
            this.btn_TaoMaPhieu.Click += new System.EventHandler(this.btn_TaoMaPhieu_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(1408, 61);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(117, 48);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_ChiTietKPI);
            this.panel3.Controls.Add(this.gridControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1564, 555);
            this.panel3.TabIndex = 2;
            // 
            // dtgv_ChiTietKPI
            // 
            this.dtgv_ChiTietKPI.AllowUserToAddRows = false;
            this.dtgv_ChiTietKPI.AllowUserToDeleteRows = false;
            this.dtgv_ChiTietKPI.AllowUserToResizeColumns = false;
            this.dtgv_ChiTietKPI.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtgv_ChiTietKPI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_ChiTietKPI.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_ChiTietKPI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_ChiTietKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChiTietKPI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaKPI,
            this.MaPhieuKPIBV,
            this.clNoiDung,
            this.clDonViTinh,
            this.clPhuongPhapDo,
            this.clChiTieu,
            this.clTieuChiID,
            this.clTenTieuChi,
            this.clTrongSoTCBV,
            this.cTrongSoKPIBV,
            this.clKeHoach,
            this.btnDelete});
            this.dtgv_ChiTietKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_ChiTietKPI.Location = new System.Drawing.Point(0, 0);
            this.dtgv_ChiTietKPI.Name = "dtgv_ChiTietKPI";
            this.dtgv_ChiTietKPI.RowTemplate.Height = 40;
            this.dtgv_ChiTietKPI.Size = new System.Drawing.Size(1564, 555);
            this.dtgv_ChiTietKPI.TabIndex = 6;
            this.dtgv_ChiTietKPI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChiTietKPI_CellContentClick);
            this.dtgv_ChiTietKPI.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChiTietKPI_CellDoubleClick);
            this.dtgv_ChiTietKPI.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChiTietKPI_CellEndEdit);
            this.dtgv_ChiTietKPI.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgv_ChiTietKPI_CellValidating);
            this.dtgv_ChiTietKPI.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgv_ChiTietKPI_RowPostPaint);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1564, 555);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaKPI,
            this.cNoiDung,
            this.cDonViTinh,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.c_LoaiPhieu,
            this.c_MauPhieu,
            this.c_TrangThai});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 30;
            // 
            // cMaKPI
            // 
            this.cMaKPI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cMaKPI.AppearanceHeader.Options.UseBackColor = true;
            this.cMaKPI.Caption = "Mã KPI";
            this.cMaKPI.FieldName = "MaKPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.Visible = true;
            this.cMaKPI.VisibleIndex = 0;
            // 
            // cNoiDung
            // 
            this.cNoiDung.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cNoiDung.AppearanceHeader.Options.UseBackColor = true;
            this.cNoiDung.Caption = "Nội dung";
            this.cNoiDung.FieldName = "NoiDung";
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Visible = true;
            this.cNoiDung.VisibleIndex = 1;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cDonViTinh.AppearanceHeader.Options.UseBackColor = true;
            this.cDonViTinh.Caption = "Đơn vị tính";
            this.cDonViTinh.FieldName = "DonViTinh";
            this.cDonViTinh.Name = "cDonViTinh";
            this.cDonViTinh.Visible = true;
            this.cDonViTinh.VisibleIndex = 2;
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cPhuongPhapDo.AppearanceHeader.Options.UseBackColor = true;
            this.cPhuongPhapDo.Caption = "Phương pháp đo";
            this.cPhuongPhapDo.FieldName = "PhuongPhapDo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Visible = true;
            this.cPhuongPhapDo.VisibleIndex = 3;
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cCongViecCaNhan.AppearanceHeader.Options.UseBackColor = true;
            this.cCongViecCaNhan.Caption = "Công việc cá nhân";
            this.cCongViecCaNhan.FieldName = "CongViecCaNhan";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            this.cCongViecCaNhan.Visible = true;
            this.cCongViecCaNhan.VisibleIndex = 4;
            // 
            // cChiTieu
            // 
            this.cChiTieu.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cChiTieu.AppearanceHeader.Options.UseBackColor = true;
            this.cChiTieu.Caption = "Chỉ tiêu";
            this.cChiTieu.FieldName = "ChiTieu";
            this.cChiTieu.Name = "cChiTieu";
            this.cChiTieu.Visible = true;
            this.cChiTieu.VisibleIndex = 5;
            // 
            // c_LoaiPhieu
            // 
            this.c_LoaiPhieu.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.c_LoaiPhieu.AppearanceHeader.Options.UseBackColor = true;
            this.c_LoaiPhieu.Caption = "Loại phiếu";
            this.c_LoaiPhieu.FieldName = "LoaiPhieu";
            this.c_LoaiPhieu.Name = "c_LoaiPhieu";
            this.c_LoaiPhieu.Visible = true;
            this.c_LoaiPhieu.VisibleIndex = 6;
            // 
            // c_MauPhieu
            // 
            this.c_MauPhieu.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.c_MauPhieu.AppearanceHeader.Options.UseBackColor = true;
            this.c_MauPhieu.Caption = "Mẫu phiếu";
            this.c_MauPhieu.FieldName = "MauPhieu";
            this.c_MauPhieu.Name = "c_MauPhieu";
            this.c_MauPhieu.Visible = true;
            this.c_MauPhieu.VisibleIndex = 8;
            // 
            // c_TrangThai
            // 
            this.c_TrangThai.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.c_TrangThai.AppearanceHeader.Options.UseBackColor = true;
            this.c_TrangThai.Caption = "Trạng thái";
            this.c_TrangThai.FieldName = "Trangthai";
            this.c_TrangThai.Name = "c_TrangThai";
            this.c_TrangThai.Visible = true;
            this.c_TrangThai.VisibleIndex = 7;
            // 
            // clMaKPI
            // 
            this.clMaKPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaKPI.DataPropertyName = "MaKPI";
            this.clMaKPI.HeaderText = "Mã KPI";
            this.clMaKPI.Name = "clMaKPI";
            this.clMaKPI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clMaKPI.Visible = false;
            // 
            // MaPhieuKPIBV
            // 
            this.MaPhieuKPIBV.DataPropertyName = "MaPhieuKPIBV";
            this.MaPhieuKPIBV.HeaderText = "Mã phiếu KPIBV";
            this.MaPhieuKPIBV.Name = "MaPhieuKPIBV";
            this.MaPhieuKPIBV.Visible = false;
            // 
            // clNoiDung
            // 
            this.clNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNoiDung.DataPropertyName = "NoiDung";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clNoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.clNoiDung.HeaderText = "Nội dung";
            this.clNoiDung.Name = "clNoiDung";
            this.clNoiDung.ReadOnly = true;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clDonViTinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.clDonViTinh.HeaderText = "Đơn vị tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.ReadOnly = true;
            this.clDonViTinh.Width = 130;
            // 
            // clPhuongPhapDo
            // 
            this.clPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            this.clPhuongPhapDo.HeaderText = "Phương pháp đo";
            this.clPhuongPhapDo.Name = "clPhuongPhapDo";
            // 
            // clChiTieu
            // 
            this.clChiTieu.DataPropertyName = "ChiTieu";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clChiTieu.DefaultCellStyle = dataGridViewCellStyle5;
            this.clChiTieu.HeaderText = "Chỉ tiêu";
            this.clChiTieu.Name = "clChiTieu";
            this.clChiTieu.ReadOnly = true;
            this.clChiTieu.Width = 110;
            // 
            // clTieuChiID
            // 
            this.clTieuChiID.DataPropertyName = "TieuChiID";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clTieuChiID.DefaultCellStyle = dataGridViewCellStyle6;
            this.clTieuChiID.HeaderText = "Tiêu chí ID";
            this.clTieuChiID.Name = "clTieuChiID";
            this.clTieuChiID.Visible = false;
            this.clTieuChiID.Width = 120;
            // 
            // clTenTieuChi
            // 
            this.clTenTieuChi.DataPropertyName = "TenTieuChi";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clTenTieuChi.DefaultCellStyle = dataGridViewCellStyle7;
            this.clTenTieuChi.HeaderText = "Tên tiêu chí";
            this.clTenTieuChi.Name = "clTenTieuChi";
            this.clTenTieuChi.ReadOnly = true;
            this.clTenTieuChi.Width = 140;
            // 
            // clTrongSoTCBV
            // 
            this.clTrongSoTCBV.DataPropertyName = "TrongSoTCBV";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clTrongSoTCBV.DefaultCellStyle = dataGridViewCellStyle8;
            this.clTrongSoTCBV.HeaderText = "Trọng số tiêu chí BV (%)";
            this.clTrongSoTCBV.Name = "clTrongSoTCBV";
            this.clTrongSoTCBV.Width = 150;
            // 
            // cTrongSoKPIBV
            // 
            this.cTrongSoKPIBV.DataPropertyName = "TrongSoKPIBV";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cTrongSoKPIBV.DefaultCellStyle = dataGridViewCellStyle9;
            this.cTrongSoKPIBV.HeaderText = "Trọng số KPI BV (%)";
            this.cTrongSoKPIBV.Name = "cTrongSoKPIBV";
            this.cTrongSoKPIBV.Width = 150;
            // 
            // clKeHoach
            // 
            this.clKeHoach.DataPropertyName = "KeHoach";
            this.clKeHoach.HeaderText = "Kế hoạch";
            this.clKeHoach.Name = "clKeHoach";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.Width = 70;
            // 
            // Frm_ChiTieuVuaGiao
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1564, 736);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_ChiTieuVuaGiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉ tiêu vừa giao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ChiTieuVuaGiao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietKPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKPI;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cPhuongPhapDo;
        private DevExpress.XtraGrid.Columns.GridColumn cCongViecCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn cChiTieu;
        private DevExpress.XtraGrid.Columns.GridColumn c_LoaiPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn c_MauPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn c_TrangThai;
        private System.Windows.Forms.DataGridView dtgv_ChiTietKPI;
        private System.Windows.Forms.Button btn_TaoMaPhieu;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DateTimePicker dt_NgayTaoMaPhieu;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.TextBox txtTongTrongSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Bieumau;
        private System.Windows.Forms.Label label4;
        private DataGridViewTextBoxColumn clMaKPI;
        private DataGridViewTextBoxColumn MaPhieuKPIBV;
        private DataGridViewTextBoxColumn clNoiDung;
        private DataGridViewTextBoxColumn clDonViTinh;
        private DataGridViewTextBoxColumn clPhuongPhapDo;
        private DataGridViewTextBoxColumn clChiTieu;
        private DataGridViewTextBoxColumn clTieuChiID;
        private DataGridViewTextBoxColumn clTenTieuChi;
        private DataGridViewTextBoxColumn clTrongSoTCBV;
        private DataGridViewTextBoxColumn cTrongSoKPIBV;
        private DataGridViewTextBoxColumn clKeHoach;
        private DataGridViewImageColumn btnDelete;
    }
}