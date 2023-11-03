
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_HoanThanhKhoaPhong
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
            this.pnTong = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gcBieuMau = new DevExpress.XtraGrid.GridControl();
            this.dgrBieuMau = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaPhieuKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaPhongKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTieuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMauPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuiDi = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTong.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBieuMau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBieuMau)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTong
            // 
            this.pnTong.Controls.Add(this.panel3);
            this.pnTong.Controls.Add(this.panel2);
            this.pnTong.Controls.Add(this.panel1);
            this.pnTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTong.Location = new System.Drawing.Point(0, 0);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(1364, 736);
            this.pnTong.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gcBieuMau);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 599);
            this.panel3.TabIndex = 2;
            // 
            // gcBieuMau
            // 
            this.gcBieuMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBieuMau.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcBieuMau.Location = new System.Drawing.Point(0, 0);
            this.gcBieuMau.MainView = this.dgrBieuMau;
            this.gcBieuMau.Name = "gcBieuMau";
            this.gcBieuMau.Size = new System.Drawing.Size(1364, 599);
            this.gcBieuMau.TabIndex = 2;
            this.gcBieuMau.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgrBieuMau});
            // 
            // dgrBieuMau
            // 
            this.dgrBieuMau.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgrBieuMau.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrBieuMau.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgrBieuMau.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgrBieuMau.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgrBieuMau.Appearance.Row.Options.UseBackColor = true;
            this.dgrBieuMau.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgrBieuMau.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgrBieuMau.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrBieuMau.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgrBieuMau.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaPhieuKPI,
            this.cMaPhongKhoa,
            this.cTieuDe,
            this.cNoiDung,
            this.cNgayTao,
            this.cQuy,
            this.cNam,
            this.cMauPhieu,
            this.cTrangThai});
            this.dgrBieuMau.GridControl = this.gcBieuMau;
            this.dgrBieuMau.Name = "dgrBieuMau";
            this.dgrBieuMau.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrBieuMau.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrBieuMau.OptionsBehavior.Editable = false;
            this.dgrBieuMau.OptionsBehavior.ReadOnly = true;
            this.dgrBieuMau.OptionsView.ShowGroupPanel = false;
            this.dgrBieuMau.RowHeight = 30;
            // 
            // cMaPhieuKPI
            // 
            this.cMaPhieuKPI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaPhieuKPI.AppearanceCell.Options.UseFont = true;
            this.cMaPhieuKPI.AppearanceCell.Options.UseTextOptions = true;
            this.cMaPhieuKPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaPhieuKPI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaPhieuKPI.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cMaPhieuKPI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaPhieuKPI.AppearanceHeader.Options.UseBackColor = true;
            this.cMaPhieuKPI.AppearanceHeader.Options.UseFont = true;
            this.cMaPhieuKPI.AppearanceHeader.Options.UseTextOptions = true;
            this.cMaPhieuKPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaPhieuKPI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaPhieuKPI.Caption = "Mã phiếu KPI";
            this.cMaPhieuKPI.FieldName = "MaKPI";
            this.cMaPhieuKPI.Name = "cMaPhieuKPI";
            this.cMaPhieuKPI.Visible = true;
            this.cMaPhieuKPI.VisibleIndex = 0;
            // 
            // cMaPhongKhoa
            // 
            this.cMaPhongKhoa.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cMaPhongKhoa.AppearanceCell.Options.UseFont = true;
            this.cMaPhongKhoa.AppearanceCell.Options.UseTextOptions = true;
            this.cMaPhongKhoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaPhongKhoa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaPhongKhoa.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cMaPhongKhoa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cMaPhongKhoa.AppearanceHeader.Options.UseBackColor = true;
            this.cMaPhongKhoa.AppearanceHeader.Options.UseFont = true;
            this.cMaPhongKhoa.AppearanceHeader.Options.UseTextOptions = true;
            this.cMaPhongKhoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaPhongKhoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaPhongKhoa.Caption = "Phòng/ Khoa";
            this.cMaPhongKhoa.FieldName = "MaPhongKhoa";
            this.cMaPhongKhoa.Name = "cMaPhongKhoa";
            this.cMaPhongKhoa.Visible = true;
            this.cMaPhongKhoa.VisibleIndex = 1;
            // 
            // cTieuDe
            // 
            this.cTieuDe.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cTieuDe.AppearanceCell.Options.UseFont = true;
            this.cTieuDe.AppearanceCell.Options.UseTextOptions = true;
            this.cTieuDe.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cTieuDe.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTieuDe.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cTieuDe.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cTieuDe.AppearanceHeader.Options.UseBackColor = true;
            this.cTieuDe.AppearanceHeader.Options.UseFont = true;
            this.cTieuDe.AppearanceHeader.Options.UseTextOptions = true;
            this.cTieuDe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cTieuDe.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTieuDe.Caption = "Tiêu đề";
            this.cTieuDe.FieldName = "TieuDe";
            this.cTieuDe.Name = "cTieuDe";
            this.cTieuDe.Visible = true;
            this.cTieuDe.VisibleIndex = 2;
            // 
            // cNoiDung
            // 
            this.cNoiDung.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cNoiDung.AppearanceCell.Options.UseFont = true;
            this.cNoiDung.AppearanceCell.Options.UseTextOptions = true;
            this.cNoiDung.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNoiDung.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNoiDung.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cNoiDung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cNoiDung.AppearanceHeader.Options.UseBackColor = true;
            this.cNoiDung.AppearanceHeader.Options.UseFont = true;
            this.cNoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.cNoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNoiDung.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNoiDung.Caption = "Nội dung";
            this.cNoiDung.FieldName = "NoiDung";
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Visible = true;
            this.cNoiDung.VisibleIndex = 3;
            // 
            // cNgayTao
            // 
            this.cNgayTao.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cNgayTao.AppearanceCell.Options.UseFont = true;
            this.cNgayTao.AppearanceCell.Options.UseTextOptions = true;
            this.cNgayTao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNgayTao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNgayTao.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cNgayTao.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cNgayTao.AppearanceHeader.Options.UseBackColor = true;
            this.cNgayTao.AppearanceHeader.Options.UseFont = true;
            this.cNgayTao.AppearanceHeader.Options.UseTextOptions = true;
            this.cNgayTao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNgayTao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNgayTao.Caption = "Ngày tạo";
            this.cNgayTao.FieldName = "NgayTao";
            this.cNgayTao.Name = "cNgayTao";
            this.cNgayTao.Visible = true;
            this.cNgayTao.VisibleIndex = 4;
            // 
            // cQuy
            // 
            this.cQuy.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cQuy.AppearanceCell.Options.UseFont = true;
            this.cQuy.AppearanceCell.Options.UseTextOptions = true;
            this.cQuy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cQuy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cQuy.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cQuy.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cQuy.AppearanceHeader.Options.UseBackColor = true;
            this.cQuy.AppearanceHeader.Options.UseFont = true;
            this.cQuy.AppearanceHeader.Options.UseTextOptions = true;
            this.cQuy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cQuy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cQuy.Caption = "Quý";
            this.cQuy.FieldName = "Quy";
            this.cQuy.Name = "cQuy";
            this.cQuy.Visible = true;
            this.cQuy.VisibleIndex = 5;
            // 
            // cNam
            // 
            this.cNam.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cNam.AppearanceCell.Options.UseFont = true;
            this.cNam.AppearanceCell.Options.UseTextOptions = true;
            this.cNam.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNam.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNam.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cNam.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cNam.AppearanceHeader.Options.UseBackColor = true;
            this.cNam.AppearanceHeader.Options.UseFont = true;
            this.cNam.AppearanceHeader.Options.UseTextOptions = true;
            this.cNam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNam.Caption = "Năm";
            this.cNam.FieldName = "Nam";
            this.cNam.Name = "cNam";
            this.cNam.Visible = true;
            this.cNam.VisibleIndex = 6;
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
            this.cMauPhieu.Visible = true;
            this.cMauPhieu.VisibleIndex = 7;
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
            this.cTrangThai.Visible = true;
            this.cTrangThai.VisibleIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChinhSua);
            this.panel2.Controls.Add(this.btnGuiDi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 662);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 74);
            this.panel2.TabIndex = 1;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChinhSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Appearance.Options.UseFont = true;
            this.btnChinhSua.ImageOptions.SvgImage = global::DuAn_QuanLyKPI.Properties.Resources.editnames;
            this.btnChinhSua.Location = new System.Drawing.Point(1060, 13);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(122, 49);
            this.btnChinhSua.TabIndex = 12;
            this.btnChinhSua.Text = "Chỉnh sửa";
            // 
            // btnGuiDi
            // 
            this.btnGuiDi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuiDi.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiDi.Appearance.Options.UseFont = true;
            this.btnGuiDi.ImageOptions.Image = global::DuAn_QuanLyKPI.Properties.Resources.apply_32x32;
            this.btnGuiDi.Location = new System.Drawing.Point(1188, 13);
            this.btnGuiDi.Name = "btnGuiDi";
            this.btnGuiDi.Size = new System.Drawing.Size(164, 49);
            this.btnGuiDi.TabIndex = 11;
            this.btnGuiDi.Text = "Xác nhận gửi đi ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng hợp thông tin Biểu mẫu ";
            // 
            // Frm_HoanThanhKhoaPhong
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.pnTong);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_HoanThanhKhoaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp thông tin biểu mẫu Khoa/ Phòng ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTong.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBieuMau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBieuMau)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnChinhSua;
        private DevExpress.XtraEditors.SimpleButton btnGuiDi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcBieuMau;
        private DevExpress.XtraGrid.Views.Grid.GridView dgrBieuMau;
        private DevExpress.XtraGrid.Columns.GridColumn cMaPhieuKPI;
        private DevExpress.XtraGrid.Columns.GridColumn cMaPhongKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn cTieuDe;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn cQuy;
        private DevExpress.XtraGrid.Columns.GridColumn cNam;
        private DevExpress.XtraGrid.Columns.GridColumn cMauPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn cTrangThai;
    }
}