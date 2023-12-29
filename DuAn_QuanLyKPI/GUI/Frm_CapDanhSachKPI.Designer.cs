
using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.lb_Nam = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCap = new DevExpress.XtraEditors.SimpleButton();
            this.dtgv_CapKPI = new System.Windows.Forms.DataGridView();
            this.cChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTieu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenTieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ck_ChonAll = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapKPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_ChonAll.Properties)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Nam);
            this.panel2.Controls.Add(this.lb_Nam);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.pn);
            this.panel2.Controls.Add(this.txt_TimKiem);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.btnCap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1454, 156);
            this.panel2.TabIndex = 9;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Enabled = false;
            this.txt_Nam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nam.Location = new System.Drawing.Point(679, 95);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.ReadOnly = true;
            this.txt_Nam.Size = new System.Drawing.Size(115, 29);
            this.txt_Nam.TabIndex = 86;
            // 
            // lb_Nam
            // 
            this.lb_Nam.AutoSize = true;
            this.lb_Nam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nam.Location = new System.Drawing.Point(624, 98);
            this.lb_Nam.Name = "lb_Nam";
            this.lb_Nam.Size = new System.Drawing.Size(49, 21);
            this.lb_Nam.TabIndex = 85;
            this.lb_Nam.Text = "Năm:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1172, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(172, 42);
            this.simpleButton1.TabIndex = 84;
            this.simpleButton1.Text = "Chỉnh sửa cấp";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pn
            // 
            this.pn.Controls.Add(this.label1);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(1454, 62);
            this.pn.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(470, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẤP DANH SÁCH KPI";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(252, 93);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(310, 32);
            this.txt_TimKiem.TabIndex = 82;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(101, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 23);
            this.labelControl1.TabIndex = 81;
            this.labelControl1.Text = "Tìm kiếm : ";
            // 
            // btnCap
            // 
            this.btnCap.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.Appearance.Options.UseFont = true;
            this.btnCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.Image")));
            this.btnCap.Location = new System.Drawing.Point(962, 85);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(105, 42);
            this.btnCap.TabIndex = 78;
            this.btnCap.Text = "Cấp";
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // dtgv_CapKPI
            // 
            this.dtgv_CapKPI.AllowUserToAddRows = false;
            this.dtgv_CapKPI.AllowUserToDeleteRows = false;
            this.dtgv_CapKPI.AllowUserToOrderColumns = true;
            this.dtgv_CapKPI.AllowUserToResizeColumns = false;
            this.dtgv_CapKPI.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtgv_CapKPI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_CapKPI.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_CapKPI.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14F);
            this.dtgv_CapKPI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dtgv_CapKPI.Location = new System.Drawing.Point(0, 156);
            this.dtgv_CapKPI.Name = "dtgv_CapKPI";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_CapKPI.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_CapKPI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgv_CapKPI.RowTemplate.Height = 40;
            this.dtgv_CapKPI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_CapKPI.Size = new System.Drawing.Size(1454, 580);
            this.dtgv_CapKPI.TabIndex = 10;
            this.dtgv_CapKPI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CapKPI_CellContentClick);
            this.dtgv_CapKPI.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CapKPI_CellValueChanged);
            this.dtgv_CapKPI.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgv_CapKPI_RowPostPaint);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clNoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.clNoiDung.HeaderText = "Nội dung";
            this.clNoiDung.Name = "clNoiDung";
            this.clNoiDung.ReadOnly = true;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clDonViTinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.clDonViTinh.HeaderText = "Đơn vị tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.ReadOnly = true;
            // 
            // clPhuongPhapDo
            // 
            this.clPhuongPhapDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clPhuongPhapDo.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colChiTieu.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTenTieuChi.DefaultCellStyle = dataGridViewCellStyle7;
            this.cTenTieuChi.HeaderText = "Tên tiêu chí";
            this.cTenTieuChi.Name = "cTenTieuChi";
            this.cTenTieuChi.ReadOnly = true;
            // 
            // ck_ChonAll
            // 
            this.ck_ChonAll.Location = new System.Drawing.Point(87, 171);
            this.ck_ChonAll.Name = "ck_ChonAll";
            this.ck_ChonAll.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_ChonAll.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ck_ChonAll.Properties.Appearance.Options.UseFont = true;
            this.ck_ChonAll.Properties.Appearance.Options.UseForeColor = true;
            this.ck_ChonAll.Properties.Caption = "Chọn";
            this.ck_ChonAll.Size = new System.Drawing.Size(68, 25);
            this.ck_ChonAll.TabIndex = 81;
            this.ck_ChonAll.CheckedChanged += new System.EventHandler(this.ck_ChonAll_CheckedChanged);
            // 
            // Frm_CapDanhSachKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 736);
            this.Controls.Add(this.ck_ChonAll);
            this.Controls.Add(this.dtgv_CapKPI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_CapDanhSachKPI";
            this.Text = "Cấp danh sách KPI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_CapDanhSachKPI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapKPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_ChonAll.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_CapKPI;
        private DevExpress.XtraEditors.SimpleButton btnCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhuongPhapDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCongViecCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChiTieu;
        private DevExpress.XtraEditors.CheckEdit ck_ChonAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhuongPhapDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTieuChiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenTieuChi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private TextBox txt_Nam;
        private Label lb_Nam;
    }
}