
using System.Drawing;
using System.Windows.Forms;

namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_ChinhSuaCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TroLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Bieumau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTrongSo = new System.Windows.Forms.TextBox();
            this.Nam = new System.Windows.Forms.Label();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.dtgv_ChinhSuaChiTieu = new System.Windows.Forms.DataGridView();
            this.clMaKPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuKPIBV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTieuChiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrongSoTCBV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrongSoKPIBV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_Nam1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChinhSuaChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TroLai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1531, 91);
            this.panel1.TabIndex = 1;
            // 
            // btn_TroLai
            // 
            this.btn_TroLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TroLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TroLai.FlatAppearance.BorderSize = 0;
            this.btn_TroLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroLai.ForeColor = System.Drawing.Color.White;
            this.btn_TroLai.Location = new System.Drawing.Point(30, 28);
            this.btn_TroLai.Name = "btn_TroLai";
            this.btn_TroLai.Size = new System.Drawing.Size(49, 36);
            this.btn_TroLai.TabIndex = 89;
            this.btn_TroLai.UseVisualStyleBackColor = true;
            this.btn_TroLai.Click += new System.EventHandler(this.btn_TroLai_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(522, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỈNH SỬA CHỈ TIÊU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Nam1);
            this.panel2.Controls.Add(this.txt_MaPhieu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Bieumau);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTongTrongSo);
            this.panel2.Controls.Add(this.Nam);
            this.panel2.Controls.Add(this.txt_Nam);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 132);
            this.panel2.TabIndex = 2;
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhieu.Location = new System.Drawing.Point(1160, 22);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Size = new System.Drawing.Size(134, 29);
            this.txt_MaPhieu.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1023, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 89;
            this.label2.Text = "Mã phiếu:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(793, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 88;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1023, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tổng trọng số : ";
            // 
            // txt_Bieumau
            // 
            this.txt_Bieumau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bieumau.Location = new System.Drawing.Point(592, 17);
            this.txt_Bieumau.Name = "txt_Bieumau";
            this.txt_Bieumau.ReadOnly = true;
            this.txt_Bieumau.Size = new System.Drawing.Size(177, 29);
            this.txt_Bieumau.TabIndex = 86;
            this.txt_Bieumau.Text = "Mục tiêu Bệnh viện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 84;
            this.label3.Text = "Biểu mẫu: ";
            // 
            // txtTongTrongSo
            // 
            this.txtTongTrongSo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTrongSo.Location = new System.Drawing.Point(1160, 75);
            this.txtTongTrongSo.Name = "txtTongTrongSo";
            this.txtTongTrongSo.ReadOnly = true;
            this.txtTongTrongSo.Size = new System.Drawing.Size(134, 29);
            this.txtTongTrongSo.TabIndex = 81;
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.Location = new System.Drawing.Point(490, 83);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(49, 21);
            this.Nam.TabIndex = 18;
            this.Nam.Text = "Năm:";
            // 
            // txt_Nam
            // 
            this.txt_Nam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nam.Location = new System.Drawing.Point(592, 75);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(177, 29);
            this.txt_Nam.TabIndex = 15;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(62, 75);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(135, 36);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Chỉnh sửa";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(1361, 56);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(132, 48);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // dtgv_ChinhSuaChiTieu
            // 
            this.dtgv_ChinhSuaChiTieu.AllowUserToAddRows = false;
            this.dtgv_ChinhSuaChiTieu.AllowUserToDeleteRows = false;
            this.dtgv_ChinhSuaChiTieu.AllowUserToResizeColumns = false;
            this.dtgv_ChinhSuaChiTieu.AllowUserToResizeRows = false;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtgv_ChinhSuaChiTieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.dtgv_ChinhSuaChiTieu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgv_ChinhSuaChiTieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_ChinhSuaChiTieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dtgv_ChinhSuaChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChinhSuaChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaKPI,
            this.MaPhieuKPIBV,
            this.clNoiDung,
            this.clDonViTinh,
            this.clChiTieu,
            this.clTieuChiID,
            this.clTenTieuChi,
            this.clTrongSoTCBV,
            this.cTrongSoKPIBV,
            this.cXoa});
            this.dtgv_ChinhSuaChiTieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_ChinhSuaChiTieu.Location = new System.Drawing.Point(0, 223);
            this.dtgv_ChinhSuaChiTieu.Name = "dtgv_ChinhSuaChiTieu";
            this.dtgv_ChinhSuaChiTieu.RowTemplate.Height = 40;
            this.dtgv_ChinhSuaChiTieu.Size = new System.Drawing.Size(1531, 179);
            this.dtgv_ChinhSuaChiTieu.TabIndex = 7;
            this.dtgv_ChinhSuaChiTieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChinhSuaChiTieu_CellContentClick);
            // 
            // clMaKPI
            // 
            this.clMaKPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaKPI.DataPropertyName = "MaKPI";
            this.clMaKPI.HeaderText = "Mã KPI";
            this.clMaKPI.Name = "clMaKPI";
            this.clMaKPI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clMaKPI.Visible = false;
            // 
            // MaPhieuKPIBV
            // 
            this.MaPhieuKPIBV.DataPropertyName = "MaPhieuKPIBV";
            this.MaPhieuKPIBV.HeaderText = "Mã phiếu KPIBV";
            this.MaPhieuKPIBV.Name = "MaPhieuKPIBV";
            this.MaPhieuKPIBV.Visible = false;
            // 
            // clNoiDung
            // 
            this.clNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNoiDung.DataPropertyName = "NoiDung";
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clNoiDung.DefaultCellStyle = dataGridViewCellStyle48;
            this.clNoiDung.HeaderText = "Nội dung";
            this.clNoiDung.Name = "clNoiDung";
            this.clNoiDung.ReadOnly = true;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clDonViTinh.DefaultCellStyle = dataGridViewCellStyle49;
            this.clDonViTinh.HeaderText = "Đơn vị tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.ReadOnly = true;
            this.clDonViTinh.Width = 130;
            // 
            // clChiTieu
            // 
            this.clChiTieu.DataPropertyName = "ChiTieu";
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clChiTieu.DefaultCellStyle = dataGridViewCellStyle50;
            this.clChiTieu.HeaderText = "Chỉ tiêu";
            this.clChiTieu.Name = "clChiTieu";
            this.clChiTieu.ReadOnly = true;
            this.clChiTieu.Width = 110;
            // 
            // clTieuChiID
            // 
            this.clTieuChiID.DataPropertyName = "TieuChiID";
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clTieuChiID.DefaultCellStyle = dataGridViewCellStyle51;
            this.clTieuChiID.HeaderText = "Tiêu chí ID";
            this.clTieuChiID.Name = "clTieuChiID";
            this.clTieuChiID.Visible = false;
            this.clTieuChiID.Width = 120;
            // 
            // clTenTieuChi
            // 
            this.clTenTieuChi.DataPropertyName = "TenTieuChi";
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clTenTieuChi.DefaultCellStyle = dataGridViewCellStyle52;
            this.clTenTieuChi.HeaderText = "Tên tiêu chí";
            this.clTenTieuChi.Name = "clTenTieuChi";
            this.clTenTieuChi.ReadOnly = true;
            this.clTenTieuChi.Width = 140;
            // 
            // clTrongSoTCBV
            // 
            this.clTrongSoTCBV.DataPropertyName = "TrongSoTCBV";
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clTrongSoTCBV.DefaultCellStyle = dataGridViewCellStyle53;
            this.clTrongSoTCBV.HeaderText = "Trọng số tiêu chí BV (%)";
            this.clTrongSoTCBV.Name = "clTrongSoTCBV";
            this.clTrongSoTCBV.Width = 150;
            // 
            // cTrongSoKPIBV
            // 
            this.cTrongSoKPIBV.DataPropertyName = "TrongSoKPIBV";
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cTrongSoKPIBV.DefaultCellStyle = dataGridViewCellStyle54;
            this.cTrongSoKPIBV.HeaderText = "Trọng số KPI BV (%)";
            this.cTrongSoKPIBV.Name = "cTrongSoKPIBV";
            this.cTrongSoKPIBV.Width = 150;
            // 
            // cXoa
            // 
            this.cXoa.DataPropertyName = "xoa";
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.Name = "cXoa";
            this.cXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txt_Nam1
            // 
            this.txt_Nam1.Location = new System.Drawing.Point(292, 84);
            this.txt_Nam1.Name = "txt_Nam1";
            this.txt_Nam1.Size = new System.Drawing.Size(107, 21);
            this.txt_Nam1.TabIndex = 91;
            this.txt_Nam1.Visible = false;
            this.txt_Nam1.TextChanged += new System.EventHandler(this.txt_Nam1_TextChanged);
            // 
            // Frm_ChinhSuaCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 402);
            this.Controls.Add(this.dtgv_ChinhSuaChiTieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ChinhSuaCap";
            this.Text = "Frm_ChinhSuaCap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChinhSuaChiTieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Bieumau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTrongSo;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DataGridView dtgv_ChinhSuaChiTieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_TroLai;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuKPIBV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTieuChiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTieuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrongSoTCBV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrongSoKPIBV;
        private System.Windows.Forms.DataGridViewImageColumn cXoa;
        private TextBox txt_Nam1;
    }
}