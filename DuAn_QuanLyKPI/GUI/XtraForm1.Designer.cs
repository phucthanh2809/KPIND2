
namespace DuAn_QuanLyKPI.GUI
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoaPhong = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btnCap = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv_CapKPI = new System.Windows.Forms.DataGridView();
            this.kPIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCongViecCaNhan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenTieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapKPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(545, 454);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(506, 135);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // cboKhoaPhong
            // 
            this.cboKhoaPhong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaPhong.FormattingEnabled = true;
            this.cboKhoaPhong.Location = new System.Drawing.Point(139, 9);
            this.cboKhoaPhong.Name = "cboKhoaPhong";
            this.cboKhoaPhong.Size = new System.Drawing.Size(595, 31);
            this.cboKhoaPhong.TabIndex = 75;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(807, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 27);
            this.labelControl2.TabIndex = 76;
            this.labelControl2.Text = "Chức Danh:";
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Location = new System.Drawing.Point(924, 9);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(428, 31);
            this.cboChucDanh.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Controls.Add(this.btnCap);
            this.panel2.Controls.Add(this.cboChucDanh);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.cboKhoaPhong);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 105);
            this.panel2.TabIndex = 9;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(711, 58);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(105, 42);
            this.btn_TimKiem.TabIndex = 79;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btnCap
            // 
            this.btnCap.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.Appearance.Options.UseFont = true;
            this.btnCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.Image")));
            this.btnCap.Location = new System.Drawing.Point(845, 57);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(105, 42);
            this.btnCap.TabIndex = 78;
            this.btnCap.Text = "Cấp";
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(474, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẤP DANH SÁCH KPI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 73);
            this.panel1.TabIndex = 8;
            // 
            // dtgv_CapKPI
            // 
            this.dtgv_CapKPI.AutoGenerateColumns = false;
            this.dtgv_CapKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CapKPI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChon,
            this.cMaKPI,
            this.cNoiDung,
            this.cDonViTinh,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.cTieuChiID,
            this.cTenTieuChi});
            this.dtgv_CapKPI.DataSource = this.kPIBindingSource;
            this.dtgv_CapKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_CapKPI.Location = new System.Drawing.Point(0, 178);
            this.dtgv_CapKPI.Name = "dtgv_CapKPI";
            this.dtgv_CapKPI.RowHeadersWidth = 30;
            this.dtgv_CapKPI.Size = new System.Drawing.Size(1364, 558);
            this.dtgv_CapKPI.TabIndex = 10;
            this.dtgv_CapKPI.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CapKPI_CellValueChanged);
            // 
            // kPIBindingSource
            // 
            // 
            // quanLyKPIDataSet2
            // 
            // 
            // kPITableAdapter
            // 

            // 
            // cChon
            // 
            this.cChon.HeaderText = "Chọn";
            this.cChon.Name = "cChon";
            this.cChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cChon.Width = 150;
            // 
            // cMaKPI
            // 
            this.cMaKPI.DataPropertyName = "MaKPI";
            this.cMaKPI.HeaderText = " Mã KPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.ReadOnly = true;
            // 
            // cNoiDung
            // 
            this.cNoiDung.DataPropertyName = "NoiDung";
            this.cNoiDung.HeaderText = "Nội dung";
            this.cNoiDung.Name = "cNoiDung";
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.DataPropertyName = "DonViTinh";
            this.cDonViTinh.HeaderText = "Đơn vị tính";
            this.cDonViTinh.Name = "cDonViTinh";
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            this.cPhuongPhapDo.HeaderText = "Phương pháp đo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.DataPropertyName = "CongViecCaNhan";
            this.cCongViecCaNhan.HeaderText = "Công việc cá nhân";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            // 
            // cChiTieu
            // 
            this.cChiTieu.DataPropertyName = "ChiTieu";
            this.cChiTieu.HeaderText = "Chỉ tiêu";
            this.cChiTieu.Name = "cChiTieu";
            // 
            // cTieuChiID
            // 
            this.cTieuChiID.DataPropertyName = "TieuChiID";
            this.cTieuChiID.HeaderText = "Tiêu chí ID";
            this.cTieuChiID.Name = "cTieuChiID";
            this.cTieuChiID.ReadOnly = true;
            // 
            // cTenTieuChi
            // 
            this.cTenTieuChi.DataPropertyName = "TenTieuChi";
            this.cTenTieuChi.HeaderText = "Tên tiêu chí";
            this.cTenTieuChi.Name = "cTenTieuChi";
            this.cTenTieuChi.ReadOnly = true;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.dtgv_CapKPI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapKPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboKhoaPhong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cboChucDanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_CapKPI;
        private DevExpress.XtraEditors.SimpleButton btnCap;
        private System.Windows.Forms.BindingSource kPIBindingSource;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhuongPhapDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCongViecCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTieuChiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenTieuChi;
    }
}