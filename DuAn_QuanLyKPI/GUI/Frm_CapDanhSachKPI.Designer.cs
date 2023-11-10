
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoaPhong = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            this.btnCap = new DevExpress.XtraEditors.SimpleButton();
            this.dgvkpidc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhuongPhapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCongViecCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cChiTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẤP DANH SÁCH KPI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboChucDanh);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.cboKhoaPhong);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 50);
            this.panel2.TabIndex = 1;
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Location = new System.Drawing.Point(799, 6);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(376, 35);
            this.cboChucDanh.TabIndex = 77;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(678, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 27);
            this.labelControl2.TabIndex = 76;
            this.labelControl2.Text = "Chức Danh:";
            // 
            // cboKhoaPhong
            // 
            this.cboKhoaPhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaPhong.FormattingEnabled = true;
            this.cboKhoaPhong.Location = new System.Drawing.Point(281, 6);
            this.cboKhoaPhong.Name = "cboKhoaPhong";
            this.cboKhoaPhong.Size = new System.Drawing.Size(391, 35);
            this.cboKhoaPhong.TabIndex = 75;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(149, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 27);
            this.labelControl4.TabIndex = 74;
            this.labelControl4.Text = "Khoa/Phòng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvkpidc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 635);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBoQua);
            this.panel4.Controls.Add(this.btnCap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 663);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1364, 73);
            this.panel4.TabIndex = 3;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Appearance.Options.UseFont = true;
            this.btnBoQua.Location = new System.Drawing.Point(1247, 7);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(105, 59);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnCap
            // 
            this.btnCap.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.Appearance.Options.UseFont = true;
            this.btnCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.Image")));
            this.btnCap.Location = new System.Drawing.Point(1136, 7);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(105, 59);
            this.btnCap.TabIndex = 2;
            this.btnCap.Text = "Cấp";
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // dgvkpidc
            // 
            this.dgvkpidc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvkpidc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dgvkpidc.Location = new System.Drawing.Point(8, 8);
            this.dgvkpidc.MainView = this.gridView1;
            this.dgvkpidc.Name = "dgvkpidc";
            this.dgvkpidc.Size = new System.Drawing.Size(1364, 265);
            this.dgvkpidc.TabIndex = 3;
            this.dgvkpidc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.dgvkpidc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // cNoiDung
            // 
            this.cNoiDung.Caption = "Nội dung";
            this.cNoiDung.FieldName = "NoiDung";
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Visible = true;
            this.cNoiDung.VisibleIndex = 2;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.Caption = "Đơn vị tính";
            this.cDonViTinh.FieldName = "DonViTinh";
            this.cDonViTinh.Name = "cDonViTinh";
            this.cDonViTinh.Visible = true;
            this.cDonViTinh.VisibleIndex = 3;
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.Caption = "Phương pháp đo";
            this.cPhuongPhapDo.FieldName = "PhuongPhapDo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Visible = true;
            this.cPhuongPhapDo.VisibleIndex = 4;
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.Caption = "Công việc cá nhân";
            this.cCongViecCaNhan.FieldName = "CongViecCanhan";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            this.cCongViecCaNhan.Visible = true;
            this.cCongViecCaNhan.VisibleIndex = 5;
            // 
            // cChiTieu
            // 
            this.cChiTieu.Caption = "Chỉ tiêu";
            this.cChiTieu.FieldName = "ChiTieu";
            this.cChiTieu.Name = "cChiTieu";
            this.cChiTieu.Visible = true;
            this.cChiTieu.VisibleIndex = 6;
            // 
            // cMaKPI
            // 
            this.cMaKPI.Caption = "Mã KPI";
            this.cMaKPI.FieldName = "MaKPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.Visible = true;
            this.cMaKPI.VisibleIndex = 1;
            // 
            // Frm_CapDanhSachKPI
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private DevExpress.XtraEditors.SimpleButton btnCap;
        private DevExpress.XtraGrid.GridControl dgvkpidc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cPhuongPhapDo;
        private DevExpress.XtraGrid.Columns.GridColumn cCongViecCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn cChiTieu;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKPI;
    }
}