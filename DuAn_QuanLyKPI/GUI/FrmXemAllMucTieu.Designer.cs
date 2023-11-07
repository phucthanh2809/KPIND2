namespace DuAn_QuanLyKPI.GUI
{
    partial class FrmXemAllMucTieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoaPhong = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboTìmKiem = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvXemAllMucTieu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhuongPhapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCongViecCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cChiTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemAllMucTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "XEM TẤT CẢ CÁC MỤC TIÊU";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(877, 56);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cboTìmKiem);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.cboChucDanh);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.cboKhoaPhong);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(877, 85);
            this.panelControl2.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dgvXemAllMucTieu);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 141);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(877, 344);
            this.panelControl3.TabIndex = 3;
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Location = new System.Drawing.Point(528, 7);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(344, 29);
            this.cboChucDanh.TabIndex = 77;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(423, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 27);
            this.labelControl2.TabIndex = 76;
            this.labelControl2.Text = "Chức Danh:";
            // 
            // cboKhoaPhong
            // 
            this.cboKhoaPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaPhong.FormattingEnabled = true;
            this.cboKhoaPhong.Location = new System.Drawing.Point(115, 7);
            this.cboKhoaPhong.Name = "cboKhoaPhong";
            this.cboKhoaPhong.Size = new System.Drawing.Size(302, 29);
            this.cboKhoaPhong.TabIndex = 75;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 21);
            this.labelControl4.TabIndex = 74;
            this.labelControl4.Text = "Khoa/Phòng:";
            // 
            // cboTìmKiem
            // 
            this.cboTìmKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTìmKiem.FormattingEnabled = true;
            this.cboTìmKiem.Items.AddRange(new object[] {
            "Không",
            "Khoa/Phòng",
            "Chức Danh",
            "Cả 2"});
            this.cboTìmKiem.Location = new System.Drawing.Point(349, 45);
            this.cboTìmKiem.Name = "cboTìmKiem";
            this.cboTìmKiem.Size = new System.Drawing.Size(302, 29);
            this.cboTìmKiem.TabIndex = 79;
            this.cboTìmKiem.SelectedIndexChanged += new System.EventHandler(this.cboTìmKiem_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(263, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 21);
            this.labelControl1.TabIndex = 78;
            this.labelControl1.Text = "Tìm Kiếm:";
            // 
            // dgvXemAllMucTieu
            // 
            this.dgvXemAllMucTieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXemAllMucTieu.Location = new System.Drawing.Point(2, 2);
            this.dgvXemAllMucTieu.MainView = this.gridView1;
            this.dgvXemAllMucTieu.Name = "dgvXemAllMucTieu";
            this.dgvXemAllMucTieu.Size = new System.Drawing.Size(873, 340);
            this.dgvXemAllMucTieu.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 68);
            this.panel1.TabIndex = 4;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Appearance.Options.UseFont = true;
            this.btnBoQua.Location = new System.Drawing.Point(736, 7);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(105, 55);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // FrmXemAllMucTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmXemAllMucTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmXemAllMucTieu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemAllMucTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.ComboBox cboChucDanh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cboKhoaPhong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboTìmKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvXemAllMucTieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cPhuongPhapDo;
        private DevExpress.XtraGrid.Columns.GridColumn cCongViecCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn cChiTieu;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKPI;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnBoQua;
    }
}