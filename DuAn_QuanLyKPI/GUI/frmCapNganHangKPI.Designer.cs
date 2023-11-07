namespace DuAn_QuanLyKPI.GUI
{
    partial class frmCapNganHangKPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNganHangKPI));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoaPhong = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dgvkpidc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhuongPhapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCongViecCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cChiTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            this.btnCap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1031, 75);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẤP DANH SÁCH KPI";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cboChucDanh);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.cboKhoaPhong);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 75);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1031, 61);
            this.panelControl2.TabIndex = 1;
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Location = new System.Drawing.Point(650, 10);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(376, 35);
            this.cboChucDanh.TabIndex = 73;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(529, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 27);
            this.labelControl2.TabIndex = 72;
            this.labelControl2.Text = "Chức Danh:";
            // 
            // cboKhoaPhong
            // 
            this.cboKhoaPhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaPhong.FormattingEnabled = true;
            this.cboKhoaPhong.Location = new System.Drawing.Point(132, 10);
            this.cboKhoaPhong.Name = "cboKhoaPhong";
            this.cboKhoaPhong.Size = new System.Drawing.Size(391, 35);
            this.cboKhoaPhong.TabIndex = 71;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(0, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 27);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Khoa/Phòng:";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dgvkpidc);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 136);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1031, 379);
            this.panelControl3.TabIndex = 2;
            // 
            // dgvkpidc
            // 
            this.dgvkpidc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkpidc.Location = new System.Drawing.Point(2, 2);
            this.dgvkpidc.MainView = this.gridView1;
            this.dgvkpidc.Name = "dgvkpidc";
            this.dgvkpidc.Size = new System.Drawing.Size(1027, 375);
            this.dgvkpidc.TabIndex = 0;
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
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnBoQua);
            this.panelControl4.Controls.Add(this.btnCap);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 511);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1031, 84);
            this.panelControl4.TabIndex = 3;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Appearance.Options.UseFont = true;
            this.btnBoQua.Location = new System.Drawing.Point(859, 13);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(105, 59);
            this.btnBoQua.TabIndex = 1;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnCap
            // 
            this.btnCap.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.Appearance.Options.UseFont = true;
            this.btnCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCap.ImageOptions.Image")));
            this.btnCap.Location = new System.Drawing.Point(748, 13);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(105, 59);
            this.btnCap.TabIndex = 0;
            this.btnCap.Text = "Cấp";
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // frmCapNganHangKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 595);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCapNganHangKPI";
            this.Text = "frmCapNganHangKPI";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboKhoaPhong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChucDanh;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl dgvkpidc;
        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private DevExpress.XtraEditors.SimpleButton btnCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cPhuongPhapDo;
        private DevExpress.XtraGrid.Columns.GridColumn cCongViecCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn cChiTieu;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKPI;
    }
}