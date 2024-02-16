using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyNganHangKPI));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txt_MaKPI_Them = new System.Windows.Forms.TextBox();
            this.txt_MaKPI = new System.Windows.Forms.TextBox();
            this.ck_KPI = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbo_DonViTinh = new System.Windows.Forms.ComboBox();
            this.cbo_ChiTieu = new System.Windows.Forms.ComboBox();
            this.cbo_PhuongPhapDo = new System.Windows.Forms.ComboBox();
            this.txt_TenTieuChi = new System.Windows.Forms.TextBox();
            this.cbx_TieuChiID = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkCongViecCaNhan = new DevExpress.XtraEditors.CheckEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtgv_QLNganHangKPI = new System.Windows.Forms.DataGridView();
            this.clMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaKPI_DKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCongViecCaNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenTieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnCap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BenhVien = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu3 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_CaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRadioGroup3 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.btn_KhoTongHop = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TongHop = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_KPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCongViecCaNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QLNganHangKPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1595, 708);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_MaKPI_Them);
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_MaKPI);
            this.splitContainerControl1.Panel1.Controls.Add(this.ck_KPI);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Exit);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Luu);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbo_DonViTinh);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbo_ChiTieu);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbo_PhuongPhapDo);
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_TenTieuChi);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbx_TieuChiID);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.chkCongViecCaNhan);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1595, 708);
            this.splitContainerControl1.SplitterPosition = 132;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // txt_MaKPI_Them
            // 
            this.txt_MaKPI_Them.Location = new System.Drawing.Point(3, 133);
            this.txt_MaKPI_Them.Name = "txt_MaKPI_Them";
            this.txt_MaKPI_Them.Size = new System.Drawing.Size(37, 21);
            this.txt_MaKPI_Them.TabIndex = 67;
            this.txt_MaKPI_Them.Visible = false;
            // 
            // txt_MaKPI
            // 
            this.txt_MaKPI.Location = new System.Drawing.Point(3, 106);
            this.txt_MaKPI.Name = "txt_MaKPI";
            this.txt_MaKPI.Size = new System.Drawing.Size(37, 21);
            this.txt_MaKPI.TabIndex = 66;
            this.txt_MaKPI.Visible = false;
            // 
            // ck_KPI
            // 
            this.ck_KPI.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_KPI.Appearance.Options.UseFont = true;
            this.ck_KPI.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "KPI bệnh viện"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "KPI cá nhân")});
            this.ck_KPI.Location = new System.Drawing.Point(1387, 12);
            this.ck_KPI.Name = "ck_KPI";
            this.ck_KPI.Size = new System.Drawing.Size(177, 62);
            this.ck_KPI.TabIndex = 65;
            this.ck_KPI.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.ck_KPI_ItemCheck);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Exit.Location = new System.Drawing.Point(1505, 82);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(59, 52);
            this.btn_Exit.TabIndex = 64;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(1387, 82);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(112, 52);
            this.btn_Luu.TabIndex = 62;
            this.btn_Luu.Text = "Tạo mới";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Visible = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbo_DonViTinh
            // 
            this.cbo_DonViTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_DonViTinh.FormattingEnabled = true;
            this.cbo_DonViTinh.Items.AddRange(new object[] {
            "%",
            "Ngày",
            "thời gian",
            "Số lần",
            "Phút",
            "Kỳ thi",
            "Buổi",
            "Số lượng",
            "Giờ"});
            this.cbo_DonViTinh.Location = new System.Drawing.Point(144, 54);
            this.cbo_DonViTinh.Name = "cbo_DonViTinh";
            this.cbo_DonViTinh.Size = new System.Drawing.Size(471, 29);
            this.cbo_DonViTinh.TabIndex = 61;
            this.cbo_DonViTinh.SelectedIndexChanged += new System.EventHandler(this.cboDonViTinh_SelectedIndexChanged);
            this.cbo_DonViTinh.TextChanged += new System.EventHandler(this.cbo_DonViTinh_TextChanged);
            // 
            // cbo_ChiTieu
            // 
            this.cbo_ChiTieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ChiTieu.FormattingEnabled = true;
            this.cbo_ChiTieu.Location = new System.Drawing.Point(913, 10);
            this.cbo_ChiTieu.Name = "cbo_ChiTieu";
            this.cbo_ChiTieu.Size = new System.Drawing.Size(419, 29);
            this.cbo_ChiTieu.TabIndex = 60;
            this.cbo_ChiTieu.SelectedIndexChanged += new System.EventHandler(this.cbo_ChiTieu_SelectedIndexChanged);
            this.cbo_ChiTieu.TextChanged += new System.EventHandler(this.cbo_ChiTieu_TextChanged);
            this.cbo_ChiTieu.Leave += new System.EventHandler(this.cbo_ChiTieu_Leave);
            // 
            // cbo_PhuongPhapDo
            // 
            this.cbo_PhuongPhapDo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_PhuongPhapDo.FormattingEnabled = true;
            this.cbo_PhuongPhapDo.Location = new System.Drawing.Point(913, 54);
            this.cbo_PhuongPhapDo.Name = "cbo_PhuongPhapDo";
            this.cbo_PhuongPhapDo.Size = new System.Drawing.Size(419, 29);
            this.cbo_PhuongPhapDo.TabIndex = 59;
            this.cbo_PhuongPhapDo.TextChanged += new System.EventHandler(this.cbo_PhuongPhapDo_TextChanged);
            // 
            // txt_TenTieuChi
            // 
            this.txt_TenTieuChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTieuChi.Location = new System.Drawing.Point(1157, 101);
            this.txt_TenTieuChi.Name = "txt_TenTieuChi";
            this.txt_TenTieuChi.Size = new System.Drawing.Size(175, 29);
            this.txt_TenTieuChi.TabIndex = 56;
            // 
            // cbx_TieuChiID
            // 
            this.cbx_TieuChiID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TieuChiID.FormattingEnabled = true;
            this.cbx_TieuChiID.Location = new System.Drawing.Point(913, 101);
            this.cbx_TieuChiID.Name = "cbx_TieuChiID";
            this.cbx_TieuChiID.Size = new System.Drawing.Size(228, 29);
            this.cbx_TieuChiID.TabIndex = 55;
            this.cbx_TieuChiID.SelectedIndexChanged += new System.EventHandler(this.cbx_TieuChiID_SelectedIndexChanged);
            this.cbx_TieuChiID.TextChanged += new System.EventHandler(this.cbx_TieuChiID_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(743, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 27);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "Tiêu chí ID:";
            // 
            // chkCongViecCaNhan
            // 
            this.chkCongViecCaNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCongViecCaNhan.Location = new System.Drawing.Point(-1284, 95);
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
            // txtNoiDung
            // 
            this.txtNoiDung.EditValue = "";
            this.txtNoiDung.Location = new System.Drawing.Point(144, 11);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Properties.Appearance.Options.UseFont = true;
            this.txtNoiDung.Size = new System.Drawing.Size(471, 28);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(743, 12);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(164, 27);
            this.labelControl11.TabIndex = 42;
            this.labelControl11.Text = "Chỉ tiêu:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(743, 58);
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
            this.labelControl10.Location = new System.Drawing.Point(12, 58);
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
            this.labelControl9.Location = new System.Drawing.Point(12, 14);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(126, 27);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "Nội dung:";
            // 
            // dtgv_QLNganHangKPI
            // 
            this.dtgv_QLNganHangKPI.AllowUserToAddRows = false;
            this.dtgv_QLNganHangKPI.AllowUserToDeleteRows = false;
            this.dtgv_QLNganHangKPI.AllowUserToResizeColumns = false;
            this.dtgv_QLNganHangKPI.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_QLNganHangKPI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_QLNganHangKPI.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_QLNganHangKPI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_QLNganHangKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_QLNganHangKPI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaKPI,
            this.clMaKPI_DKT,
            this.clNoiDung,
            this.clDonViTinh,
            this.clPhuongPhapDo,
            this.clCongViecCaNhan,
            this.clChiTieu,
            this.cTenTieuChi,
            this.cTieuChiID});
            this.dtgv_QLNganHangKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_QLNganHangKPI.Location = new System.Drawing.Point(0, 0);
            this.dtgv_QLNganHangKPI.Name = "dtgv_QLNganHangKPI";
            this.dtgv_QLNganHangKPI.RowTemplate.Height = 40;
            this.dtgv_QLNganHangKPI.Size = new System.Drawing.Size(0, 0);
            this.dtgv_QLNganHangKPI.TabIndex = 0;
            this.dtgv_QLNganHangKPI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_QLNganHangKPI_CellClick);
            this.dtgv_QLNganHangKPI.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgv_QLNganHangKPI_RowPostPaint);
            // 
            // clMaKPI
            // 
            this.clMaKPI.DataPropertyName = "MaKPI";
            this.clMaKPI.FillWeight = 150F;
            this.clMaKPI.HeaderText = "Mã KPI";
            this.clMaKPI.Name = "clMaKPI";
            this.clMaKPI.ReadOnly = true;
            this.clMaKPI.Visible = false;
            this.clMaKPI.Width = 70;
            // 
            // clMaKPI_DKT
            // 
            this.clMaKPI_DKT.DataPropertyName = "MAKPI_DKT";
            this.clMaKPI_DKT.HeaderText = "Mã KPI";
            this.clMaKPI_DKT.Name = "clMaKPI_DKT";
            this.clMaKPI_DKT.Visible = false;
            // 
            // clNoiDung
            // 
            this.clNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNoiDung.DataPropertyName = "NoiDung";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clNoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.clNoiDung.HeaderText = "Nội dung";
            this.clNoiDung.Name = "clNoiDung";
            this.clNoiDung.ReadOnly = true;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            this.clDonViTinh.HeaderText = "Đơn vị tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.ReadOnly = true;
            // 
            // clPhuongPhapDo
            // 
            this.clPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            this.clPhuongPhapDo.HeaderText = "Phương pháp đo";
            this.clPhuongPhapDo.Name = "clPhuongPhapDo";
            this.clPhuongPhapDo.ReadOnly = true;
            this.clPhuongPhapDo.Width = 370;
            // 
            // clCongViecCaNhan
            // 
            this.clCongViecCaNhan.DataPropertyName = "CongViecCaNhan";
            this.clCongViecCaNhan.HeaderText = "Công việc cá nhân";
            this.clCongViecCaNhan.Name = "clCongViecCaNhan";
            this.clCongViecCaNhan.ReadOnly = true;
            this.clCongViecCaNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clCongViecCaNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clCongViecCaNhan.Width = 120;
            // 
            // clChiTieu
            // 
            this.clChiTieu.DataPropertyName = "ChiTieu";
            this.clChiTieu.HeaderText = "Chỉ tiêu";
            this.clChiTieu.Name = "clChiTieu";
            this.clChiTieu.ReadOnly = true;
            // 
            // cTenTieuChi
            // 
            this.cTenTieuChi.DataPropertyName = "TenTieuChi";
            this.cTenTieuChi.HeaderText = "Tên tiêu chí";
            this.cTenTieuChi.Name = "cTenTieuChi";
            this.cTenTieuChi.ReadOnly = true;
            // 
            // cTieuChiID
            // 
            this.cTieuChiID.DataPropertyName = "TieuChiID";
            this.cTieuChiID.HeaderText = "Tiêu chí ID";
            this.cTieuChiID.Name = "cTieuChiID";
            this.cTieuChiID.ReadOnly = true;
            this.cTieuChiID.Visible = false;
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
            this.barEditItem1,
            this.btn_KhoTongHop,
            this.btn_BenhVien,
            this.btn_CaNhan,
            this.btn_TongHop});
            this.barManager1.MaxItemId = 21;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemRadioGroup1,
            this.repositoryItemRadioGroup2,
            this.repositoryItemRadioGroup3});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(59, 120);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.btnClose, false),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_BenhVien),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CaNhan)});
            this.bar1.Offset = 42;
            this.bar1.Text = "Tools";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 4;
            this.btnClose.ItemAppearance.Normal.FontSizeDelta = 4;
            this.btnClose.ItemAppearance.Normal.Options.UseFont = true;
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
            this.btnCap.ItemAppearance.Normal.FontSizeDelta = 4;
            this.btnCap.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCap.Name = "btnCap";
            this.btnCap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCap_ItemClick);
            // 
            // btn_BenhVien
            // 
            this.btn_BenhVien.ActAsDropDown = true;
            this.btn_BenhVien.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btn_BenhVien.Caption = "Kho KPI bệnh viện";
            this.btn_BenhVien.DropDownControl = this.popupMenu3;
            this.btn_BenhVien.Id = 18;
            this.btn_BenhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_BenhVien.ImageOptions.SvgImage")));
            this.btn_BenhVien.Name = "btn_BenhVien";
            this.btn_BenhVien.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_BenhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BenhVien_ItemClick);
            // 
            // popupMenu3
            // 
            this.popupMenu3.Manager = this.barManager1;
            this.popupMenu3.Name = "popupMenu3";
            // 
            // btn_CaNhan
            // 
            this.btn_CaNhan.Caption = "Kho KPI cá nhân";
            this.btn_CaNhan.Id = 19;
            this.btn_CaNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CaNhan.ImageOptions.SvgImage")));
            this.btn_CaNhan.Name = "btn_CaNhan";
            this.btn_CaNhan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_CaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CaNhan_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
            this.barDockControlTop.Size = new System.Drawing.Size(1595, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1595, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 708);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1595, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 708);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.ItemAppearance.Normal.FontSizeDelta = 4;
            this.btnAdd.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.Size = new System.Drawing.Size(70, 20);
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.ItemAppearance.Normal.FontSizeDelta = 4;
            this.btnEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.ItemAppearance.Normal.FontSizeDelta = 4;
            this.btnSave.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Xóa";
            this.btnCancel.Id = 3;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.ItemAppearance.Normal.FontSizeDelta = 4;
            this.btnCancel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 5;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            this.btnPrint.ItemAppearance.Normal.FontSizeDelta = 4;
            this.btnPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemRadioGroup3;
            this.barEditItem1.Id = 16;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemRadioGroup3
            // 
            this.repositoryItemRadioGroup3.Name = "repositoryItemRadioGroup3";
            // 
            // btn_KhoTongHop
            // 
            this.btn_KhoTongHop.Caption = "Kho tổng hợp KPI";
            this.btn_KhoTongHop.Id = 17;
            this.btn_KhoTongHop.Name = "btn_KhoTongHop";
            // 
            // btn_TongHop
            // 
            this.btn_TongHop.Caption = "Kho KPI tổng hợp";
            this.btn_TongHop.Id = 20;
            this.btn_TongHop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_TongHop.ImageOptions.SvgImage")));
            this.btn_TongHop.Name = "btn_TongHop";
            this.btn_TongHop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // popupMenu2
            // 
            this.popupMenu2.Manager = this.barManager1;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // Frm_QuanLyNganHangKPI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1595, 736);
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
            this.Text = "Ngân hàng KPI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ck_KPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCongViecCaNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QLNganHangKPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CheckEdit chkCongViecCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnCap;
        private System.Windows.Forms.DataGridView dtgv_QLNganHangKPI;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbx_TieuChiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhuongPhapDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCongViecCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChiTieu;
        private System.Windows.Forms.TextBox txt_TenTieuChi;
        private System.Windows.Forms.ComboBox cbo_ChiTieu;
        private System.Windows.Forms.ComboBox cbo_PhuongPhapDo;
        private System.Windows.Forms.ComboBox cbo_DonViTinh;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem btn_KhoTongHop;
        private DevExpress.XtraBars.BarButtonItem btn_BenhVien;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_CaNhan;
        private DevExpress.XtraBars.BarButtonItem btn_TongHop;
        private DevExpress.XtraBars.PopupMenu popupMenu3;
        private Button btn_Luu;
        private Button btn_Exit;
        private DevExpress.XtraEditors.CheckedListBoxControl ck_KPI;
        private DataGridViewTextBoxColumn clMaKPI;
        private DataGridViewTextBoxColumn clMaKPI_DKT;
        private DataGridViewTextBoxColumn clNoiDung;
        private DataGridViewTextBoxColumn clDonViTinh;
        private DataGridViewTextBoxColumn clPhuongPhapDo;
        private DataGridViewCheckBoxColumn clCongViecCaNhan;
        private DataGridViewTextBoxColumn clChiTieu;
        private DataGridViewTextBoxColumn cTenTieuChi;
        private DataGridViewTextBoxColumn cTieuChiID;
        private TextBox txt_MaKPI_Them;
        private TextBox txt_MaKPI;
    }
}