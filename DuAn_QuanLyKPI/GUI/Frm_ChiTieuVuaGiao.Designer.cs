
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_ChiTieuVuaGiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChiTieuVuaGiao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(1364, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT KPI ĐÃ CHỌN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 63);
            this.panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(836, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(513, 32);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 32);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chức danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khoa/ Phòng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvkpidc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 609);
            this.panel3.TabIndex = 2;
            // 
            // dgvkpidc
            // 
            this.dgvkpidc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkpidc.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgvkpidc.Location = new System.Drawing.Point(0, 0);
            this.dgvkpidc.MainView = this.gridView1;
            this.dgvkpidc.Name = "dgvkpidc";
            this.dgvkpidc.Size = new System.Drawing.Size(1364, 609);
            this.dgvkpidc.TabIndex = 3;
            this.dgvkpidc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cNoiDung,
            this.cDonViTinh,
            this.cPhuongPhapDo,
            this.cCongViecCaNhan,
            this.cChiTieu,
            this.cMaKPI});
            this.gridView1.GridControl = this.dgvkpidc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowHeight = 30;
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
            // Frm_ChiTieuVuaGiao
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_ChiTieuVuaGiao.IconOptions.Image")));
            this.Name = "Frm_ChiTieuVuaGiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉ tiêu vừa giao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkpidc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
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