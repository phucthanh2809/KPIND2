
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvkpidc = new DevExpress.XtraGrid.GridControl();
            this.dgrListKPI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhuongPhapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCongViecCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cChiTieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cLoaiPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMauPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrListKPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvkpidc);
            this.panel1.Location = new System.Drawing.Point(38, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 456);
            this.panel1.TabIndex = 0;
            // 
            // dgvkpidc
            // 
            this.dgvkpidc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkpidc.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgvkpidc.Location = new System.Drawing.Point(0, 0);
            this.dgvkpidc.MainView = this.dgrListKPI;
            this.dgvkpidc.Name = "dgvkpidc";
            this.dgvkpidc.Size = new System.Drawing.Size(1223, 456);
            this.dgvkpidc.TabIndex = 2;
            this.dgvkpidc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgrListKPI});
            // 
            // dgrListKPI
            // 
            this.dgrListKPI.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgrListKPI.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrListKPI.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgrListKPI.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgrListKPI.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgrListKPI.Appearance.Row.Options.UseBackColor = true;
            this.dgrListKPI.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgrListKPI.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgrListKPI.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrListKPI.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgrListKPI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cNoiDung,
            this.cDonViTinh,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.cMaKPI,
            this.cLoaiPhieu,
            this.cMauPhieu,
            this.cTrangThai});
            this.dgrListKPI.GridControl = this.dgvkpidc;
            this.dgrListKPI.Name = "dgrListKPI";
            this.dgrListKPI.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrListKPI.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrListKPI.OptionsBehavior.Editable = false;
            this.dgrListKPI.OptionsBehavior.ReadOnly = true;
            this.dgrListKPI.RowHeight = 30;
            // 
            // cNoiDung
            // 
            this.cNoiDung.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNoiDung.AppearanceCell.Options.UseFont = true;
            this.cNoiDung.AppearanceCell.Options.UseTextOptions = true;
            this.cNoiDung.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNoiDung.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNoiDung.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cNoiDung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNoiDung.AppearanceHeader.Options.UseBackColor = true;
            this.cNoiDung.AppearanceHeader.Options.UseFont = true;
            this.cNoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.cNoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cNoiDung.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cNoiDung.Caption = "Nội dung";
            this.cNoiDung.FieldName = "NoiDung";
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Visible = true;
            this.cNoiDung.VisibleIndex = 0;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cDonViTinh.AppearanceCell.Options.UseFont = true;
            this.cDonViTinh.AppearanceCell.Options.UseTextOptions = true;
            this.cDonViTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cDonViTinh.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cDonViTinh.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cDonViTinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cDonViTinh.AppearanceHeader.Options.UseBackColor = true;
            this.cDonViTinh.AppearanceHeader.Options.UseFont = true;
            this.cDonViTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.cDonViTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cDonViTinh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cDonViTinh.Caption = "Đơn vị tính";
            this.cDonViTinh.FieldName = "DonViTinh";
            this.cDonViTinh.Name = "cDonViTinh";
            this.cDonViTinh.Visible = true;
            this.cDonViTinh.VisibleIndex = 1;
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cPhuongPhapDo.AppearanceCell.Options.UseFont = true;
            this.cPhuongPhapDo.AppearanceCell.Options.UseTextOptions = true;
            this.cPhuongPhapDo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cPhuongPhapDo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cPhuongPhapDo.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cPhuongPhapDo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cPhuongPhapDo.AppearanceHeader.Options.UseBackColor = true;
            this.cPhuongPhapDo.AppearanceHeader.Options.UseFont = true;
            this.cPhuongPhapDo.AppearanceHeader.Options.UseTextOptions = true;
            this.cPhuongPhapDo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cPhuongPhapDo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cPhuongPhapDo.Caption = "Phương pháp đo";
            this.cPhuongPhapDo.FieldName = "PhuongPhapDo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Visible = true;
            this.cPhuongPhapDo.VisibleIndex = 2;
            // 
            // cCongViecCaNhan
            // 
            this.cCongViecCaNhan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cCongViecCaNhan.AppearanceCell.Options.UseFont = true;
            this.cCongViecCaNhan.AppearanceCell.Options.UseTextOptions = true;
            this.cCongViecCaNhan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cCongViecCaNhan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cCongViecCaNhan.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cCongViecCaNhan.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cCongViecCaNhan.AppearanceHeader.Options.UseBackColor = true;
            this.cCongViecCaNhan.AppearanceHeader.Options.UseFont = true;
            this.cCongViecCaNhan.AppearanceHeader.Options.UseTextOptions = true;
            this.cCongViecCaNhan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cCongViecCaNhan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cCongViecCaNhan.Caption = "Công việc cá nhân";
            this.cCongViecCaNhan.FieldName = "CongViecCanhan";
            this.cCongViecCaNhan.Name = "cCongViecCaNhan";
            this.cCongViecCaNhan.Visible = true;
            this.cCongViecCaNhan.VisibleIndex = 3;
            // 
            // cChiTieu
            // 
            this.cChiTieu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cChiTieu.AppearanceCell.Options.UseFont = true;
            this.cChiTieu.AppearanceCell.Options.UseTextOptions = true;
            this.cChiTieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cChiTieu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cChiTieu.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cChiTieu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cChiTieu.AppearanceHeader.Options.UseBackColor = true;
            this.cChiTieu.AppearanceHeader.Options.UseFont = true;
            this.cChiTieu.AppearanceHeader.Options.UseTextOptions = true;
            this.cChiTieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cChiTieu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cChiTieu.Caption = "Chỉ tiêu";
            this.cChiTieu.FieldName = "ChiTieu";
            this.cChiTieu.Name = "cChiTieu";
            this.cChiTieu.Visible = true;
            this.cChiTieu.VisibleIndex = 4;
            // 
            // cMaKPI
            // 
            this.cMaKPI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cMaKPI.AppearanceCell.Options.UseFont = true;
            this.cMaKPI.AppearanceCell.Options.UseTextOptions = true;
            this.cMaKPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaKPI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaKPI.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cMaKPI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cMaKPI.AppearanceHeader.Options.UseBackColor = true;
            this.cMaKPI.AppearanceHeader.Options.UseFont = true;
            this.cMaKPI.AppearanceHeader.Options.UseTextOptions = true;
            this.cMaKPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaKPI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaKPI.Caption = "Mã KPI";
            this.cMaKPI.FieldName = "MaKPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.Visible = true;
            this.cMaKPI.VisibleIndex = 5;
            // 
            // cLoaiPhieu
            // 
            this.cLoaiPhieu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cLoaiPhieu.AppearanceCell.Options.UseFont = true;
            this.cLoaiPhieu.AppearanceCell.Options.UseTextOptions = true;
            this.cLoaiPhieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cLoaiPhieu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cLoaiPhieu.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cLoaiPhieu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cLoaiPhieu.AppearanceHeader.Options.UseBackColor = true;
            this.cLoaiPhieu.AppearanceHeader.Options.UseFont = true;
            this.cLoaiPhieu.AppearanceHeader.Options.UseTextOptions = true;
            this.cLoaiPhieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cLoaiPhieu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cLoaiPhieu.Caption = "Loại phiếu";
            this.cLoaiPhieu.FieldName = "LoaiPhieu";
            this.cLoaiPhieu.Name = "cLoaiPhieu";
            this.cLoaiPhieu.Visible = true;
            this.cLoaiPhieu.VisibleIndex = 6;
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(253, 463);
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
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 610);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrListKPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgvkpidc;
        private DevExpress.XtraGrid.Views.Grid.GridView dgrListKPI;
        private DevExpress.XtraGrid.Columns.GridColumn cDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cPhuongPhapDo;
        private DevExpress.XtraGrid.Columns.GridColumn cNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn cCongViecCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn cChiTieu;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKPI;
        private DevExpress.XtraGrid.Columns.GridColumn cLoaiPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn cMauPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn cTrangThai;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}