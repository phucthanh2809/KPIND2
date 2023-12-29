
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_CapKPISau
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CapKPISau));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTong = new System.Windows.Forms.Panel();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.ck_ChonAll = new DevExpress.XtraEditors.CheckEdit();
            this.dtgv_CapKPI = new System.Windows.Forms.DataGridView();
            this.pnTimKiem = new System.Windows.Forms.Panel();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.txt_maPhieu = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTieu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenTieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTong.SuspendLayout();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_ChonAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapKPI)).BeginInit();
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
            this.pnTong.Size = new System.Drawing.Size(1389, 736);
            this.pnTong.TabIndex = 0;
            // 
            // pnGrid
            // 
            this.pnGrid.Controls.Add(this.ck_ChonAll);
            this.pnGrid.Controls.Add(this.dtgv_CapKPI);
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrid.Location = new System.Drawing.Point(0, 172);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(1389, 564);
            this.pnGrid.TabIndex = 2;
            // 
            // ck_ChonAll
            // 
            this.ck_ChonAll.Location = new System.Drawing.Point(65, 15);
            this.ck_ChonAll.Name = "ck_ChonAll";
            this.ck_ChonAll.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_ChonAll.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ck_ChonAll.Properties.Appearance.Options.UseFont = true;
            this.ck_ChonAll.Properties.Appearance.Options.UseForeColor = true;
            this.ck_ChonAll.Properties.Caption = "Chọn";
            this.ck_ChonAll.Size = new System.Drawing.Size(68, 25);
            this.ck_ChonAll.TabIndex = 82;
            this.ck_ChonAll.CheckedChanged += new System.EventHandler(this.ck_ChonAll_CheckedChanged_1);
            // 
            // dtgv_CapKPI
            // 
            this.dtgv_CapKPI.AllowUserToAddRows = false;
            this.dtgv_CapKPI.AllowUserToDeleteRows = false;
            this.dtgv_CapKPI.AllowUserToOrderColumns = true;
            this.dtgv_CapKPI.AllowUserToResizeColumns = false;
            this.dtgv_CapKPI.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_CapKPI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_CapKPI.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_CapKPI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgv_CapKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CapKPI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChon,
            this.clMaKPI,
            this.clNoiDung,
            this.clDonViTinh,
            this.clPhuongPhapDo,
            this.clChiTieu,
            this.colChiTieu,
            this.clTieuChiID,
            this.cTenTieuChi});
            this.dtgv_CapKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_CapKPI.Location = new System.Drawing.Point(0, 0);
            this.dtgv_CapKPI.Name = "dtgv_CapKPI";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_CapKPI.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgv_CapKPI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgv_CapKPI.RowTemplate.Height = 40;
            this.dtgv_CapKPI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_CapKPI.Size = new System.Drawing.Size(1389, 564);
            this.dtgv_CapKPI.TabIndex = 11;
            this.dtgv_CapKPI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CapKPI_CellContentClick);
            this.dtgv_CapKPI.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CapKPI_CellValueChanged);
            this.dtgv_CapKPI.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgv_CapKPI_RowPostPaint);
            // 
            // pnTimKiem
            // 
            this.pnTimKiem.Controls.Add(this.txt_Nam);
            this.pnTimKiem.Controls.Add(this.txt_maPhieu);
            this.pnTimKiem.Controls.Add(this.labelControl3);
            this.pnTimKiem.Controls.Add(this.labelControl2);
            this.pnTimKiem.Controls.Add(this.btnCap);
            this.pnTimKiem.Controls.Add(this.txt_TimKiem);
            this.pnTimKiem.Controls.Add(this.labelControl1);
            this.pnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimKiem.Location = new System.Drawing.Point(0, 62);
            this.pnTimKiem.Name = "pnTimKiem";
            this.pnTimKiem.Size = new System.Drawing.Size(1389, 110);
            this.pnTimKiem.TabIndex = 1;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(593, 62);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(146, 32);
            this.txt_Nam.TabIndex = 88;
            // 
            // txt_maPhieu
            // 
            this.txt_maPhieu.Location = new System.Drawing.Point(939, 62);
            this.txt_maPhieu.Name = "txt_maPhieu";
            this.txt_maPhieu.Size = new System.Drawing.Size(146, 32);
            this.txt_maPhieu.TabIndex = 87;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(824, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 23);
            this.labelControl3.TabIndex = 86;
            this.labelControl3.Text = "Mã phiếu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(541, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 23);
            this.labelControl2.TabIndex = 85;
            this.labelControl2.Text = "Năm:";
            // 
            // btnCap
            // 
            this.btnCap.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.Appearance.Options.UseFont = true;
            this.btnCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.Image")));
            this.btnCap.Location = new System.Drawing.Point(1223, 14);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(105, 42);
            this.btnCap.TabIndex = 84;
            this.btnCap.Text = "Cấp";
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(155, 22);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(310, 32);
            this.txt_TimKiem.TabIndex = 83;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 23);
            this.labelControl1.TabIndex = 82;
            this.labelControl1.Text = "Tìm kiếm : ";
            // 
            // pn
            // 
            this.pn.Controls.Add(this.label1);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(1389, 62);
            this.pn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(506, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "CẤP DANH SÁCH KPI";
            // 
            // cChon
            // 
            this.cChon.HeaderText = "";
            this.cChon.Name = "cChon";
            this.cChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cChon.Width = 150;
            // 
            // clMaKPI
            // 
            this.clMaKPI.DataPropertyName = "MaKPI";
            this.clMaKPI.HeaderText = "Mã KPI";
            this.clMaKPI.Name = "clMaKPI";
            this.clMaKPI.Visible = false;
            // 
            // clNoiDung
            // 
            this.clNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNoiDung.DataPropertyName = "NoiDung";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clNoiDung.DefaultCellStyle = dataGridViewCellStyle11;
            this.clNoiDung.HeaderText = "Nội dung";
            this.clNoiDung.Name = "clNoiDung";
            this.clNoiDung.ReadOnly = true;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clDonViTinh.DefaultCellStyle = dataGridViewCellStyle12;
            this.clDonViTinh.HeaderText = "Đơn vị tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.ReadOnly = true;
            // 
            // clPhuongPhapDo
            // 
            this.clPhuongPhapDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clPhuongPhapDo.DefaultCellStyle = dataGridViewCellStyle13;
            this.clPhuongPhapDo.HeaderText = "Phương pháp đo";
            this.clPhuongPhapDo.Name = "clPhuongPhapDo";
            this.clPhuongPhapDo.ReadOnly = true;
            // 
            // clChiTieu
            // 
            this.clChiTieu.DataPropertyName = "CongViecCaNhan";
            this.clChiTieu.HeaderText = "Công việc cá nhân";
            this.clChiTieu.Name = "clChiTieu";
            this.clChiTieu.ReadOnly = true;
            this.clChiTieu.Width = 150;
            // 
            // colChiTieu
            // 
            this.colChiTieu.DataPropertyName = "ChiTieu";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colChiTieu.DefaultCellStyle = dataGridViewCellStyle14;
            this.colChiTieu.HeaderText = "Chỉ tiêu";
            this.colChiTieu.Name = "colChiTieu";
            this.colChiTieu.ReadOnly = true;
            // 
            // clTieuChiID
            // 
            this.clTieuChiID.DataPropertyName = "TieuChiID";
            this.clTieuChiID.HeaderText = "Tiêu chí ID";
            this.clTieuChiID.Name = "clTieuChiID";
            this.clTieuChiID.ReadOnly = true;
            this.clTieuChiID.Visible = false;
            // 
            // cTenTieuChi
            // 
            this.cTenTieuChi.DataPropertyName = "TenTieuChi";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTenTieuChi.DefaultCellStyle = dataGridViewCellStyle15;
            this.cTenTieuChi.HeaderText = "Tên tiêu chí";
            this.cTenTieuChi.Name = "cTenTieuChi";
            this.cTenTieuChi.ReadOnly = true;
            // 
            // Frm_CapKPISau
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1389, 736);
            this.Controls.Add(this.pnTong);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_CapKPISau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp KPI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_CapKPISau_Load);
            this.pnTong.ResumeLayout(false);
            this.pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ck_ChonAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapKPI)).EndInit();
            this.pnTimKiem.ResumeLayout(false);
            this.pnTimKiem.PerformLayout();
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.Panel pnTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btnCap;
        private System.Windows.Forms.DataGridView dtgv_CapKPI;
        private DevExpress.XtraEditors.CheckEdit ck_ChonAll;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.TextBox txt_maPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhuongPhapDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTieuChiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenTieuChi;
    }
}