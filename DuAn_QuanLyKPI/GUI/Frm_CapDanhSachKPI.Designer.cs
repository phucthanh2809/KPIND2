
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_CapDanhSachKPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CapDanhSachKPI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.btnCap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoaPhong = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhuongPhapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCongViecCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cChiTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvkpidc = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMauPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cLoaiPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Appearance.Options.UseFont = true;
            this.btnBoQua.Location = new System.Drawing.Point(1203, 23);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(105, 35);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ Qua";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(494, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẤP DANH SÁCH KPI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboChucDanh);
            this.panel2.Controls.Add(this.btnCap);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.cboKhoaPhong);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 50);
            this.panel2.TabIndex = 1;
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Location = new System.Drawing.Point(751, 9);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(469, 31);
            this.cboChucDanh.TabIndex = 77;
            // 
            // btnCap
            // 
            this.btnCap.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.Appearance.Options.UseFont = true;
            this.btnCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.Image")));
            this.btnCap.Location = new System.Drawing.Point(1246, 3);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(105, 42);
            this.btnCap.TabIndex = 2;
            this.btnCap.Text = "Cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(634, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 27);
            this.labelControl2.TabIndex = 76;
            this.labelControl2.Text = "Chức Danh:";
            // 
            // cboKhoaPhong
            // 
            this.cboKhoaPhong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaPhong.FormattingEnabled = true;
            this.cboKhoaPhong.Location = new System.Drawing.Point(139, 9);
            this.cboKhoaPhong.Name = "cboKhoaPhong";
            this.cboKhoaPhong.Size = new System.Drawing.Size(469, 31);
            this.cboKhoaPhong.TabIndex = 75;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 24);
            this.labelControl4.TabIndex = 74;
            this.labelControl4.Text = "Khoa/Phòng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 622);
            this.panel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1364, 622);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cNoiDung,
            this.cDonViTinh,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.cMaKPI,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 30;
            // 
            // cNoiDung
            // 
            this.cNoiDung.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNoiDung.AppearanceCell.Options.UseFont = true;
            this.cNoiDung.AppearanceCell.Options.UseTextOptions = true;
            this.cNoiDung.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNoiDung.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNoiDung.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cNoiDung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNoiDung.AppearanceHeader.Options.UseBackColor = true;
            this.cNoiDung.AppearanceHeader.Options.UseFont = true;
            this.cNoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.cNoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNoiDung.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNoiDung.Caption = "Nội dung";
            this.cNoiDung.FieldName = "NoiDung";
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Visible = true;
            this.cNoiDung.VisibleIndex = 0;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cDonViTinh.AppearanceCell.Options.UseFont = true;
            this.cDonViTinh.AppearanceCell.Options.UseTextOptions = true;
            this.cDonViTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cDonViTinh.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cDonViTinh.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cDonViTinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cDonViTinh.AppearanceHeader.Options.UseBackColor = true;
            this.cDonViTinh.AppearanceHeader.Options.UseFont = true;
            this.cDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.cDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cDonViTinh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cDonViTinh.Caption = "Đơn vị tính";
            this.cDonViTinh.FieldName = "DonViTinh";
            this.cDonViTinh.Name = "cDonViTinh";
            this.cDonViTinh.Visible = true;
            this.cDonViTinh.VisibleIndex = 1;
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cPhuongPhapDo.AppearanceCell.Options.UseFont = true;
            this.cPhuongPhapDo.AppearanceCell.Options.UseTextOptions = true;
            this.cPhuongPhapDo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cPhuongPhapDo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cPhuongPhapDo.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cPhuongPhapDo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cPhuongPhapDo.AppearanceHeader.Options.UseBackColor = true;
            this.cPhuongPhapDo.AppearanceHeader.Options.UseFont = true;
            this.cPhuongPhapDo.AppearanceHeader.Options.UseTextOptions = true;
            this.cPhuongPhapDo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cPhuongPhapDo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cPhuongPhapDo.Caption = "Phương pháp đo";
            this.cPhuongPhapDo.FieldName = "PhuongPhapDo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Visible = true;
            this.cPhuongPhapDo.VisibleIndex = 2;
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cCongViecCaNhan.AppearanceCell.Options.UseFont = true;
            this.cCongViecCaNhan.AppearanceCell.Options.UseTextOptions = true;
            this.cCongViecCaNhan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cCongViecCaNhan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cCongViecCaNhan.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cCongViecCaNhan.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cCongViecCaNhan.AppearanceHeader.Options.UseBackColor = true;
            this.cCongViecCaNhan.AppearanceHeader.Options.UseFont = true;
            this.cCongViecCaNhan.AppearanceHeader.Options.UseTextOptions = true;
            this.cCongViecCaNhan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cCongViecCaNhan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cCongViecCaNhan.Caption = "Công việc cá nhân";
            this.cCongViecCaNhan.FieldName = "CongViecCanhan";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            this.cCongViecCaNhan.Visible = true;
            this.cCongViecCaNhan.VisibleIndex = 3;
            // 
            // cChiTieu
            // 
            this.cChiTieu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cChiTieu.AppearanceCell.Options.UseFont = true;
            this.cChiTieu.AppearanceCell.Options.UseTextOptions = true;
            this.cChiTieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cChiTieu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cChiTieu.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cChiTieu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cChiTieu.AppearanceHeader.Options.UseBackColor = true;
            this.cChiTieu.AppearanceHeader.Options.UseFont = true;
            this.cChiTieu.AppearanceHeader.Options.UseTextOptions = true;
            this.cChiTieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cChiTieu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cChiTieu.Caption = "Chỉ tiêu";
            this.cChiTieu.FieldName = "ChiTieu";
            this.cChiTieu.Name = "cChiTieu";
            this.cChiTieu.Visible = true;
            this.cChiTieu.VisibleIndex = 4;
            // 
            // cMaKPI
            // 
            this.cMaKPI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cMaKPI.AppearanceCell.Options.UseFont = true;
            this.cMaKPI.AppearanceCell.Options.UseTextOptions = true;
            this.cMaKPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaKPI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaKPI.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cMaKPI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cMaKPI.AppearanceHeader.Options.UseBackColor = true;
            this.cMaKPI.AppearanceHeader.Options.UseFont = true;
            this.cMaKPI.AppearanceHeader.Options.UseTextOptions = true;
            this.cMaKPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaKPI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaKPI.Caption = "Mã KPI";
            this.cMaKPI.FieldName = "MaKPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.Visible = true;
            this.cMaKPI.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Loại phiếu";
            this.gridColumn1.FieldName = "LoaiPhieu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Mẫu phiếu";
            this.gridColumn2.FieldName = "MauPhieu";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "Trạng thái";
            this.gridColumn3.FieldName = "TrangThai";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvkpidc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1364, 622);
            this.panel5.TabIndex = 0;
            // 
            // dgvkpidc
            // 
            this.dgvkpidc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkpidc.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgvkpidc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvkpidc.Location = new System.Drawing.Point(0, 0);
            this.dgvkpidc.MainView = this.gridView2;
            this.dgvkpidc.Name = "dgvkpidc";
            this.dgvkpidc.Size = new System.Drawing.Size(1364, 622);
            this.dgvkpidc.TabIndex = 5;
            this.dgvkpidc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgvkpidc;
            this.gridView2.Name = "gridView2";
            // 
            // cTrangThai
            // 
            this.cTrangThai.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cTrangThai.AppearanceCell.Options.UseFont = true;
            this.cTrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.cTrangThai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cTrangThai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTrangThai.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cTrangThai.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cTrangThai.AppearanceHeader.Options.UseBackColor = true;
            this.cTrangThai.AppearanceHeader.Options.UseFont = true;
            this.cTrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.cTrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cTrangThai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTrangThai.Caption = "Trạng thái";
            this.cTrangThai.FieldName = "TrangThai";
            this.cTrangThai.Name = "cTrangThai";
            // 
            // cMauPhieu
            // 
            this.cMauPhieu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cMauPhieu.AppearanceCell.Options.UseFont = true;
            this.cMauPhieu.AppearanceCell.Options.UseTextOptions = true;
            this.cMauPhieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMauPhieu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMauPhieu.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cMauPhieu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cMauPhieu.AppearanceHeader.Options.UseBackColor = true;
            this.cMauPhieu.AppearanceHeader.Options.UseFont = true;
            this.cMauPhieu.AppearanceHeader.Options.UseTextOptions = true;
            this.cMauPhieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMauPhieu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMauPhieu.Caption = "Mẫu phiếu";
            this.cMauPhieu.FieldName = "MauPhieu";
            this.cMauPhieu.Name = "cMauPhieu";
            // 
            // cLoaiPhieu
            // 
            this.cLoaiPhieu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cLoaiPhieu.AppearanceCell.Options.UseFont = true;
            this.cLoaiPhieu.AppearanceCell.Options.UseTextOptions = true;
            this.cLoaiPhieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cLoaiPhieu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cLoaiPhieu.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cLoaiPhieu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cLoaiPhieu.AppearanceHeader.Options.UseBackColor = true;
            this.cLoaiPhieu.AppearanceHeader.Options.UseFont = true;
            this.cLoaiPhieu.AppearanceHeader.Options.UseTextOptions = true;
            this.cLoaiPhieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cLoaiPhieu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cLoaiPhieu.Caption = "Loại phiếu";
            this.cLoaiPhieu.FieldName = "LoaiPhieu";
            this.cLoaiPhieu.Name = "cLoaiPhieu";
            // 
            // Frm_CapDanhSachKPI
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_CapDanhSachKPI.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_CapDanhSachKPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp danh sách ngân hàng KPI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboChucDanh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cboKhoaPhong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private DevExpress.XtraEditors.SimpleButton btnCap;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.Columns.GridColumn cTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn cMauPhieu;
        private DevExpress.XtraGrid.GridControl dgvkpidc;
        private DevExpress.XtraGrid.Columns.GridColumn cLoaiPhieu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cPhuongPhapDo;
        private DevExpress.XtraGrid.Columns.GridColumn cCongViecCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn cChiTieu;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKPI;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}