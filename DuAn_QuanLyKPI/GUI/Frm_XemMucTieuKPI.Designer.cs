
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_XemMucTieuKPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_XemMucTieuKPI));
            this.pnTong = new System.Windows.Forms.Panel();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.dgvXemAllMucTieu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhuongPhapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCongViecCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cChiTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnTimKiem = new System.Windows.Forms.Panel();
            this.cboTìmKiem = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoaPhong = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTong.SuspendLayout();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemAllMucTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnTimKiem.SuspendLayout();
            this.pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTong
            // 
            this.pnTong.Controls.Add(this.pnGrid);
            this.pnTong.Controls.Add(this.pnTimKiem);
            this.pnTong.Controls.Add(this.pn);
            this.pnTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTong.Location = new System.Drawing.Point(0, 0);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(1364, 736);
            this.pnTong.TabIndex = 0;
            // 
            // pnGrid
            // 
            this.pnGrid.Controls.Add(this.dgvXemAllMucTieu);
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrid.Location = new System.Drawing.Point(0, 162);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(1364, 574);
            this.pnGrid.TabIndex = 2;
            // 
            // dgvXemAllMucTieu
            // 
            this.dgvXemAllMucTieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXemAllMucTieu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXemAllMucTieu.Location = new System.Drawing.Point(0, 0);
            this.dgvXemAllMucTieu.MainView = this.gridView1;
            this.dgvXemAllMucTieu.Name = "dgvXemAllMucTieu";
            this.dgvXemAllMucTieu.Size = new System.Drawing.Size(1364, 574);
            this.dgvXemAllMucTieu.TabIndex = 2;
            this.dgvXemAllMucTieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cNoiDung,
            this.cDonViTinh,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.cMaKPI});
            this.gridView1.GridControl = this.dgvXemAllMucTieu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // cNoiDung
            // 
            this.cNoiDung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNoiDung.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.cNoiDung.AppearanceHeader.Options.UseFont = true;
            this.cNoiDung.AppearanceHeader.Options.UseForeColor = true;
            this.cNoiDung.Caption = "Nội dung";
            this.cNoiDung.FieldName = "NoiDung";
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Visible = true;
            this.cNoiDung.VisibleIndex = 1;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.cDonViTinh.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.cDonViTinh.AppearanceHeader.Options.UseFont = true;
            this.cDonViTinh.AppearanceHeader.Options.UseForeColor = true;
            this.cDonViTinh.Caption = "Đơn vị tính";
            this.cDonViTinh.FieldName = "DonViTinh";
            this.cDonViTinh.Name = "cDonViTinh";
            this.cDonViTinh.Visible = true;
            this.cDonViTinh.VisibleIndex = 2;
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.cPhuongPhapDo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.cPhuongPhapDo.AppearanceHeader.Options.UseFont = true;
            this.cPhuongPhapDo.AppearanceHeader.Options.UseForeColor = true;
            this.cPhuongPhapDo.Caption = "Phương pháp đo";
            this.cPhuongPhapDo.FieldName = "PhuongPhapDo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Visible = true;
            this.cPhuongPhapDo.VisibleIndex = 3;
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.cCongViecCaNhan.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.cCongViecCaNhan.AppearanceHeader.Options.UseFont = true;
            this.cCongViecCaNhan.AppearanceHeader.Options.UseForeColor = true;
            this.cCongViecCaNhan.Caption = "Công việc cá nhân";
            this.cCongViecCaNhan.FieldName = "CongViecCanhan";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            this.cCongViecCaNhan.Visible = true;
            this.cCongViecCaNhan.VisibleIndex = 4;
            // 
            // cChiTieu
            // 
            this.cChiTieu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.cChiTieu.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.cChiTieu.AppearanceHeader.Options.UseFont = true;
            this.cChiTieu.AppearanceHeader.Options.UseForeColor = true;
            this.cChiTieu.Caption = "Chỉ tiêu";
            this.cChiTieu.FieldName = "ChiTieu";
            this.cChiTieu.Name = "cChiTieu";
            this.cChiTieu.Visible = true;
            this.cChiTieu.VisibleIndex = 5;
            // 
            // cMaKPI
            // 
            this.cMaKPI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.cMaKPI.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.cMaKPI.AppearanceHeader.Options.UseFont = true;
            this.cMaKPI.AppearanceHeader.Options.UseForeColor = true;
            this.cMaKPI.Caption = "Mã KPI";
            this.cMaKPI.FieldName = "MaKPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.Visible = true;
            this.cMaKPI.VisibleIndex = 0;
            // 
            // pnTimKiem
            // 
            this.pnTimKiem.Controls.Add(this.cboTìmKiem);
            this.pnTimKiem.Controls.Add(this.labelControl1);
            this.pnTimKiem.Controls.Add(this.cboChucDanh);
            this.pnTimKiem.Controls.Add(this.labelControl2);
            this.pnTimKiem.Controls.Add(this.cboKhoaPhong);
            this.pnTimKiem.Controls.Add(this.labelControl4);
            this.pnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimKiem.Location = new System.Drawing.Point(0, 62);
            this.pnTimKiem.Name = "pnTimKiem";
            this.pnTimKiem.Size = new System.Drawing.Size(1364, 100);
            this.pnTimKiem.TabIndex = 1;
            // 
            // cboTìmKiem
            // 
            this.cboTìmKiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTìmKiem.FormattingEnabled = true;
            this.cboTìmKiem.Items.AddRange(new object[] {
            "Không",
            "Khoa/Phòng",
            "Chức Danh",
            "Cả 2"});
            this.cboTìmKiem.Location = new System.Drawing.Point(451, 63);
            this.cboTìmKiem.Name = "cboTìmKiem";
            this.cboTìmKiem.Size = new System.Drawing.Size(533, 31);
            this.cboTìmKiem.TabIndex = 85;
            this.cboTìmKiem.SelectedIndexChanged += new System.EventHandler(this.cboTìmKiem_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(354, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 23);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "Tìm Kiếm:";
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Location = new System.Drawing.Point(816, 18);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(533, 31);
            this.cboChucDanh.TabIndex = 83;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(711, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 27);
            this.labelControl2.TabIndex = 82;
            this.labelControl2.Text = "Chức Danh:";
            // 
            // cboKhoaPhong
            // 
            this.cboKhoaPhong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaPhong.FormattingEnabled = true;
            this.cboKhoaPhong.Location = new System.Drawing.Point(125, 18);
            this.cboKhoaPhong.Name = "cboKhoaPhong";
            this.cboKhoaPhong.Size = new System.Drawing.Size(533, 31);
            this.cboKhoaPhong.TabIndex = 81;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 23);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Khoa/Phòng:";
            // 
            // pn
            // 
            this.pn.Controls.Add(this.label1);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(1364, 62);
            this.pn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "XEM TẤT CẢ CÁC MỤC TIÊU";
            // 
            // Frm_XemMucTieuKPI
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.pnTong);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_XemMucTieuKPI.IconOptions.Image")));
            this.Name = "Frm_XemMucTieuKPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mục tiêu KPI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTong.ResumeLayout(false);
            this.pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemAllMucTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnTimKiem.ResumeLayout(false);
            this.pnTimKiem.PerformLayout();
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTimKiem;
        private System.Windows.Forms.ComboBox cboTìmKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cboChucDanh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cboKhoaPhong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel pnGrid;
        private DevExpress.XtraGrid.GridControl dgvXemAllMucTieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cPhuongPhapDo;
        private DevExpress.XtraGrid.Columns.GridColumn cCongViecCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn cChiTieu;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKPI;
    }
}