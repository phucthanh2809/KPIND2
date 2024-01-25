
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_AddKPIGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddKPIGrid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrNganHangCaNhan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrKPIBenhVien = new System.Windows.Forms.DataGridView();
            this.cChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDungKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhuongPhapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKeHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaoMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnNganHangCaNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnNganHangKPI = new DevExpress.XtraEditors.SimpleButton();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.chkCongViecCaNhan = new System.Windows.Forms.CheckBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNganHangCaNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKPIBenhVien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 736);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrNganHangCaNhan);
            this.panel3.Controls.Add(this.dgrKPIBenhVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 686);
            this.panel3.TabIndex = 1;
            // 
            // dgrNganHangCaNhan
            // 
            this.dgrNganHangCaNhan.AllowUserToAddRows = false;
            this.dgrNganHangCaNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrNganHangCaNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrNganHangCaNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNganHangCaNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgrNganHangCaNhan.Location = new System.Drawing.Point(193, 133);
            this.dgrNganHangCaNhan.Name = "dgrNganHangCaNhan";
            this.dgrNganHangCaNhan.Size = new System.Drawing.Size(870, 446);
            this.dgrNganHangCaNhan.TabIndex = 1;
            this.dgrNganHangCaNhan.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKPI";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã KPI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NoiDung";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nội dung KPI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhuongPhapDo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phương pháp đo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonViTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn vị tính ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChiTieu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Chỉ tiêu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 63;
            // 
            // dgrKPIBenhVien
            // 
            this.dgrKPIBenhVien.AllowUserToAddRows = false;
            this.dgrKPIBenhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrKPIBenhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrKPIBenhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrKPIBenhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKPIBenhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChon,
            this.cMaKPI,
            this.cNoiDungKPI,
            this.cPhuongPhapDo,
            this.cDVT,
            this.cKeHoach});
            this.dgrKPIBenhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrKPIBenhVien.Location = new System.Drawing.Point(0, 0);
            this.dgrKPIBenhVien.Name = "dgrKPIBenhVien";
            this.dgrKPIBenhVien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrKPIBenhVien.Size = new System.Drawing.Size(1364, 686);
            this.dgrKPIBenhVien.TabIndex = 0;
            this.dgrKPIBenhVien.Visible = false;
            this.dgrKPIBenhVien.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrKPIBenhVien_RowPostPaint);
            // 
            // cChon
            // 
            this.cChon.HeaderText = "Chọn";
            this.cChon.Name = "cChon";
            this.cChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cMaKPI
            // 
            this.cMaKPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cMaKPI.DataPropertyName = "MaKPI";
            this.cMaKPI.HeaderText = "Mã KPI";
            this.cMaKPI.Name = "cMaKPI";
            this.cMaKPI.Width = 60;
            // 
            // cNoiDungKPI
            // 
            this.cNoiDungKPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNoiDungKPI.DataPropertyName = "NoiDung";
            this.cNoiDungKPI.HeaderText = "Nội dung KPI";
            this.cNoiDungKPI.Name = "cNoiDungKPI";
            // 
            // cPhuongPhapDo
            // 
            this.cPhuongPhapDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPhuongPhapDo.DataPropertyName = "PhuongPhapDo";
            this.cPhuongPhapDo.HeaderText = "Phương pháp đo";
            this.cPhuongPhapDo.Name = "cPhuongPhapDo";
            this.cPhuongPhapDo.Width = 91;
            // 
            // cDVT
            // 
            this.cDVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cDVT.DataPropertyName = "DonViTinh";
            this.cDVT.HeaderText = "Đơn vị tính ";
            this.cDVT.Name = "cDVT";
            this.cDVT.Width = 61;
            // 
            // cKeHoach
            // 
            this.cKeHoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cKeHoach.DataPropertyName = "ChiTieu";
            this.cKeHoach.HeaderText = "Chỉ tiêu";
            this.cKeHoach.Name = "cKeHoach";
            this.cKeHoach.Width = 63;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbTenNV);
            this.panel2.Controls.Add(this.chkCongViecCaNhan);
            this.panel2.Controls.Add(this.nmYear);
            this.panel2.Controls.Add(this.btnTaoMoi);
            this.panel2.Controls.Add(this.btnNganHangCaNhan);
            this.panel2.Controls.Add(this.btnNganHangKPI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.Appearance.Options.UseFont = true;
            this.btnTaoMoi.ImageOptions.Image = global::DuAn_QuanLyKPI.Properties.Resources.additem_32x32;
            this.btnTaoMoi.Location = new System.Drawing.Point(433, 3);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(135, 40);
            this.btnTaoMoi.TabIndex = 2;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnNganHangCaNhan
            // 
            this.btnNganHangCaNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNganHangCaNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganHangCaNhan.Appearance.Options.UseFont = true;
            this.btnNganHangCaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNganHangCaNhan.ImageOptions.Image")));
            this.btnNganHangCaNhan.Location = new System.Drawing.Point(202, 3);
            this.btnNganHangCaNhan.Name = "btnNganHangCaNhan";
            this.btnNganHangCaNhan.Size = new System.Drawing.Size(225, 40);
            this.btnNganHangCaNhan.TabIndex = 1;
            this.btnNganHangCaNhan.Text = "Ngân hàng Cá nhân ";
            this.btnNganHangCaNhan.Click += new System.EventHandler(this.btnNganHangCaNhan_Click);
            // 
            // btnNganHangKPI
            // 
            this.btnNganHangKPI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNganHangKPI.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganHangKPI.Appearance.Options.UseFont = true;
            this.btnNganHangKPI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNganHangKPI.ImageOptions.Image")));
            this.btnNganHangKPI.Location = new System.Drawing.Point(10, 3);
            this.btnNganHangKPI.Name = "btnNganHangKPI";
            this.btnNganHangKPI.Size = new System.Drawing.Size(186, 40);
            this.btnNganHangKPI.TabIndex = 0;
            this.btnNganHangKPI.Text = "Ngân hàng KPI ";
            this.btnNganHangKPI.Click += new System.EventHandler(this.btnNganHangKPI_Click);
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(1271, 7);
            this.nmYear.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(79, 32);
            this.nmYear.TabIndex = 3;
            this.nmYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // chkCongViecCaNhan
            // 
            this.chkCongViecCaNhan.AutoSize = true;
            this.chkCongViecCaNhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCongViecCaNhan.Location = new System.Drawing.Point(1083, 10);
            this.chkCongViecCaNhan.Name = "chkCongViecCaNhan";
            this.chkCongViecCaNhan.Size = new System.Drawing.Size(181, 27);
            this.chkCongViecCaNhan.TabIndex = 13;
            this.chkCongViecCaNhan.Text = "Công viện cá nhân";
            this.chkCongViecCaNhan.UseVisualStyleBackColor = true;
            this.chkCongViecCaNhan.CheckedChanged += new System.EventHandler(this.chkCongViecCaNhan_CheckedChanged);
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(786, 11);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(79, 24);
            this.lbTenNV.TabIndex = 14;
            this.lbTenNV.Text = "Tên NV";
            // 
            // Frm_AddKPIGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_AddKPIGrid.IconOptions.Image")));
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Frm_AddKPIGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Xóa Sửa KPI ";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNganHangCaNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKPIBenhVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnTaoMoi;
        private DevExpress.XtraEditors.SimpleButton btnNganHangCaNhan;
        private DevExpress.XtraEditors.SimpleButton btnNganHangKPI;
        private System.Windows.Forms.DataGridView dgrKPIBenhVien;
        private System.Windows.Forms.DataGridView dgrNganHangCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDungKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhuongPhapDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKeHoach;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.CheckBox chkCongViecCaNhan;
        private System.Windows.Forms.Label lbTenNV;
    }
}