namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_QuanLyNganHangKPI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyNganHangKPI));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txt_TenTieuChi = new System.Windows.Forms.TextBox();
            this.cbx_TieuChiID = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkCongViecCaNhan = new DevExpress.XtraEditors.CheckEdit();
            this.txtChiTieu = new DevExpress.XtraEditors.TextEdit();
            this.txtPhuongPhapDo = new DevExpress.XtraEditors.TextEdit();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtgv_QLNganHangKPI = new System.Windows.Forms.DataGridView();
            this.cbChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCongViecCaNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenTieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemAllMucTieu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCongViecCaNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiTieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhuongPhapDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QLNganHangKPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 712);
            this.panel1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_TenTieuChi);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbx_TieuChiID);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.chkCongViecCaNhan);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtChiTieu);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPhuongPhapDo);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtDonViTinh);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl11);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl13);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.dtgv_QLNganHangKPI);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            this.splitContainerControl1.Size = new System.Drawing.Size(1364, 712);
            this.splitContainerControl1.SplitterPosition = 132;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // txt_TenTieuChi
            // 
            this.txt_TenTieuChi.Location = new System.Drawing.Point(830, 87);
            this.txt_TenTieuChi.Name = "txt_TenTieuChi";
            this.txt_TenTieuChi.Size = new System.Drawing.Size(95, 21);
            this.txt_TenTieuChi.TabIndex = 56;
            // 
            // cbx_TieuChiID
            // 
            this.cbx_TieuChiID.FormattingEnabled = true;
            this.cbx_TieuChiID.Location = new System.Drawing.Point(711, 87);
            this.cbx_TieuChiID.Name = "cbx_TieuChiID";
            this.cbx_TieuChiID.Size = new System.Drawing.Size(100, 21);
            this.cbx_TieuChiID.TabIndex = 55;
            this.cbx_TieuChiID.SelectedIndexChanged += new System.EventHandler(this.cbx_TieuChiID_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(541, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 27);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "Tiêu chí ID:";
            // 
            // chkCongViecCaNhan
            // 
            this.chkCongViecCaNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCongViecCaNhan.Location = new System.Drawing.Point(-1400, 84);
            this.chkCongViecCaNhan.Name = "chkCongViecCaNhan";
            this.chkCongViecCaNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCongViecCaNhan.Properties.Appearance.Options.UseFont = true;
            this.chkCongViecCaNhan.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCongViecCaNhan.Properties.AppearanceDisabled.Options.UseFont = true;
            this.chkCongViecCaNhan.Properties.Caption = "Công việc cá nhân";
            this.chkCongViecCaNhan.Properties.Tag = true;
            this.chkCongViecCaNhan.Size = new System.Drawing.Size(220, 31);
            this.chkCongViecCaNhan.TabIndex = 53;
            // 
            // txtChiTieu
            // 
            this.txtChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiTieu.Location = new System.Drawing.Point(711, 47);
            this.txtChiTieu.Name = "txtChiTieu";
            this.txtChiTieu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiTieu.Properties.Appearance.Options.UseFont = true;
            this.txtChiTieu.Size = new System.Drawing.Size(0, 34);
            this.txtChiTieu.TabIndex = 3;
            // 
            // txtPhuongPhapDo
            // 
            this.txtPhuongPhapDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhuongPhapDo.Location = new System.Drawing.Point(711, 7);
            this.txtPhuongPhapDo.Name = "txtPhuongPhapDo";
            this.txtPhuongPhapDo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuongPhapDo.Properties.Appearance.Options.UseFont = true;
            this.txtPhuongPhapDo.Size = new System.Drawing.Size(0, 34);
            this.txtPhuongPhapDo.TabIndex = 2;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(144, 47);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Properties.Appearance.Options.UseFont = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(391, 34);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.EditValue = "";
            this.txtNoiDung.Location = new System.Drawing.Point(144, 7);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Properties.Appearance.Options.UseFont = true;
            this.txtNoiDung.Size = new System.Drawing.Size(391, 34);
            this.txtNoiDung.TabIndex = 0;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(541, 51);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(164, 27);
            this.labelControl11.TabIndex = 42;
            this.labelControl11.Text = "Chỉ tiêu:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(541, 11);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(164, 27);
            this.labelControl13.TabIndex = 41;
            this.labelControl13.Text = "Phương pháp đo:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(12, 51);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(126, 27);
            this.labelControl10.TabIndex = 40;
            this.labelControl10.Text = "Đơn vị tính:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(12, 11);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(126, 27);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "Nội dung:";
            // 
            // dtgv_QLNganHangKPI
            // 
            this.dtgv_QLNganHangKPI.AutoGenerateColumns = false;
            this.dtgv_QLNganHangKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_QLNganHangKPI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbChon,
            this.cMaKPI,
            this.cNoiDung,
            this.cDonViTinh,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.cTieuChiID,
            this.cTenTieuChi});
            this.dtgv_QLNganHangKPI.DataSource = this.kPIBindingSource;
            this.dtgv_QLNganHangKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_QLNganHangKPI.Location = new System.Drawing.Point(0, 0);
            this.dtgv_QLNganHangKPI.Name = "dtgv_QLNganHangKPI";
            this.dtgv_QLNganHangKPI.Size = new System.Drawing.Size(0, 0);
            this.dtgv_QLNganHangKPI.TabIndex = 0;
            this.dtgv_QLNganHangKPI.Click += new System.EventHandler(this.dtgv_QLNganHangKPI_Click);
            this.dtgv_QLNganHangKPI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgv_QLNganHangKPI_KeyDown);
            // 
            // cbChon
            // 
            this.cbChon.HeaderText = "Chọn";
            this.cbChon.Name = "cbChon";
            // 
            // cMaKPI
            // 
            this.cMaKPI.DataPropertyName = "MaKPI";
            this.cMaKPI.HeaderText = "Mã KPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.ReadOnly = true;
            this.cMaKPI.Width = 170;
            // 
            // cNoiDung
            // 
            this.cNoiDung.DataPropertyName = "NoiDung";
            this.cNoiDung.HeaderText = "Nội dung";
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Width = 250;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.DataPropertyName = "DonViTinh";
            this.cDonViTinh.HeaderText = "Đơn vị tính";
            this.cDonViTinh.Name = "cDonViTinh";
            this.cDonViTinh.Width = 200;
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            this.cPhuongPhapDo.HeaderText = "Phương pháp đo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Width = 150;
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.DataPropertyName = "CongViecCaNhan";
            this.cCongViecCaNhan.HeaderText = "Công việc cá nhân";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            this.cCongViecCaNhan.Width = 130;
            // 
            // cChiTieu
            // 
            this.cChiTieu.DataPropertyName = "ChiTieu";
            this.cChiTieu.HeaderText = "Chỉ tiêu";
            this.cChiTieu.Name = "cChiTieu";
            this.cChiTieu.Width = 150;
            // 
            // cTieuChiID
            // 
            this.cTieuChiID.DataPropertyName = "TieuChiID";
            this.cTieuChiID.HeaderText = "Tiêu chí ID";
            this.cTieuChiID.Name = "cTieuChiID";
            // 
            // cTenTieuChi
            // 
            this.cTenTieuChi.DataPropertyName = "TenTieuChi";
            this.cTenTieuChi.HeaderText = "Tên tiêu chí";
            this.cTenTieuChi.Name = "cTenTieuChi";
            this.cTenTieuChi.ReadOnly = true;
            // 
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnSave,
            this.btnCancel,
            this.btnClose,
            this.btnPrint,
            this.btnCap,
            this.btnXemAllMucTieu});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(59, 120);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXemAllMucTieu)});
            this.bar1.Offset = 42;
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Xóa";
            this.btnCancel.Id = 3;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 5;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 4;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // btnCap
            // 
            this.btnCap.Caption = "Cấp";
            this.btnCap.Id = 6;
            this.btnCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.Image")));
            this.btnCap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.LargeImage")));
            this.btnCap.Name = "btnCap";
            this.btnCap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCap_ItemClick);
            // 
            // btnXemAllMucTieu
            // 
            this.btnXemAllMucTieu.Caption = "Xem Tất Cả Mục Tiêu";
            this.btnXemAllMucTieu.Id = 7;
            this.btnXemAllMucTieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemAllMucTieu.ImageOptions.LargeImage")));
            this.btnXemAllMucTieu.Name = "btnXemAllMucTieu";
            this.btnXemAllMucTieu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.barDockControlTop.Appearance.BorderColor = System.Drawing.Color.White;
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.barDockControlTop.Appearance.ForeColor = System.Drawing.Color.White;
            this.barDockControlTop.Appearance.Options.UseBackColor = true;
            this.barDockControlTop.Appearance.Options.UseBorderColor = true;
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.Appearance.Options.UseForeColor = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1364, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1364, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 712);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1364, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 712);
            // 
            // kPITableAdapter
            // 
            // 
            // Frm_QuanLyNganHangKPI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_QuanLyNganHangKPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCongViecCaNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiTieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhuongPhapDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QLNganHangKPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txtChiTieu;
        private DevExpress.XtraEditors.TextEdit txtPhuongPhapDo;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CheckEdit chkCongViecCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnCap;
        private DevExpress.XtraBars.BarButtonItem btnXemAllMucTieu;
        private System.Windows.Forms.DataGridView dtgv_QLNganHangKPI;
        private System.Windows.Forms.BindingSource kPIBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbx_TieuChiID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhuongPhapDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCongViecCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTieuChiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenTieuChi;
        private System.Windows.Forms.TextBox txt_TenTieuChi;
    }
}