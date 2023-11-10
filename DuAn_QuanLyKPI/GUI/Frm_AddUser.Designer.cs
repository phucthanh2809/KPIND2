
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_AddUser
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
            this.pnThongTinNhanVien = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpImage = new System.Windows.Forms.Button();
            this.btnLuuThem = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new ControlProject1510.XFilteg();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPhanQuyen = new ControlProject1510.ComboBoxSearch();
            this.txtHoten = new ControlProject1510.XFilteg();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new ControlProject1510.XFilteg();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new ControlProject1510.XFilteg();
            this.cboChucDanh = new ControlProject1510.ComboBoxSearch();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhongKhoa = new ControlProject1510.ComboBoxSearch();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new ControlProject1510.XFilteg();
            this.lab = new System.Windows.Forms.Label();
            this.txtMatKhau = new ControlProject1510.XFilteg();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnThongTinNhanVien.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnThongTinNhanVien
            // 
            this.pnThongTinNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongTinNhanVien.Controls.Add(this.flowLayoutPanel1);
            this.pnThongTinNhanVien.Controls.Add(this.panel6);
            this.pnThongTinNhanVien.Controls.Add(this.panel4);
            this.pnThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongTinNhanVien.Location = new System.Drawing.Point(0, 0);
            this.pnThongTinNhanVien.Name = "pnThongTinNhanVien";
            this.pnThongTinNhanVien.Size = new System.Drawing.Size(552, 736);
            this.pnThongTinNhanVien.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnUpImage);
            this.flowLayoutPanel1.Controls.Add(this.btnLuuThem);
            this.flowLayoutPanel1.Controls.Add(this.btnclear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(78, 683);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(390, 50);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // btnUpImage
            // 
            this.btnUpImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpImage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImage.Location = new System.Drawing.Point(3, 3);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.Size = new System.Drawing.Size(189, 42);
            this.btnUpImage.TabIndex = 4;
            this.btnUpImage.Text = "Tải hình lên";
            this.btnUpImage.UseVisualStyleBackColor = true;
            // 
            // btnLuuThem
            // 
            this.btnLuuThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThem.Location = new System.Drawing.Point(198, 3);
            this.btnLuuThem.Name = "btnLuuThem";
            this.btnLuuThem.Size = new System.Drawing.Size(90, 41);
            this.btnLuuThem.TabIndex = 6;
            this.btnLuuThem.Text = "Lưu";
            this.btnLuuThem.UseVisualStyleBackColor = true;
            this.btnLuuThem.Visible = false;
            this.btnLuuThem.Click += new System.EventHandler(this.btnLuuThem_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(294, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 42);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtMaNV);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cboPhanQuyen);
            this.panel6.Controls.Add(this.txtHoten);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtEmail);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtSDT);
            this.panel6.Controls.Add(this.cboChucDanh);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.cboPhongKhoa);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtTenTaiKhoan);
            this.panel6.Controls.Add(this.lab);
            this.panel6.Controls.Add(this.txtMatKhau);
            this.panel6.Location = new System.Drawing.Point(0, 273);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(546, 404);
            this.panel6.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Phân quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "SĐT";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(147, 8);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(396, 32);
            this.txtMaNV.TabIndex = 0;
            this.txtMaNV.xCoTimMoRong = false;
            this.txtMaNV.xDataGrid = null;
            this.txtMaNV.xField_Key = "";
            this.txtMaNV.xKeep_Old_Value = false;
            this.txtMaNV.xTimChinhXac = false;
            this.txtMaNV.xTimMoRong = "";
            this.txtMaNV.xTimTrenField = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // cboPhanQuyen
            // 
            this.cboPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPhanQuyen.AutoComplete = false;
            this.cboPhanQuyen.AutoDropdown = false;
            this.cboPhanQuyen.BackColorEven = System.Drawing.Color.White;
            this.cboPhanQuyen.BackColorOdd = System.Drawing.Color.White;
            this.cboPhanQuyen.ColumnNames = "TenQuyen";
            this.cboPhanQuyen.ColumnWidthDefault = 150;
            this.cboPhanQuyen.ColumnWidths = "";
            this.cboPhanQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPhanQuyen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanQuyen.FormattingEnabled = true;
            this.cboPhanQuyen.LinkedColumnIndex = 0;
            this.cboPhanQuyen.LinkedTextBox = null;
            this.cboPhanQuyen.Location = new System.Drawing.Point(147, 362);
            this.cboPhanQuyen.Name = "cboPhanQuyen";
            this.cboPhanQuyen.Size = new System.Drawing.Size(396, 33);
            this.cboPhanQuyen.TabIndex = 26;
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(147, 52);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(396, 32);
            this.txtHoten.TabIndex = 1;
            this.txtHoten.xCoTimMoRong = false;
            this.txtHoten.xDataGrid = null;
            this.txtHoten.xField_Key = "";
            this.txtHoten.xKeep_Old_Value = false;
            this.txtHoten.xTimChinhXac = false;
            this.txtHoten.xTimMoRong = "";
            this.txtHoten.xTimTrenField = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Chức danh";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(147, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(396, 32);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.xCoTimMoRong = false;
            this.txtEmail.xDataGrid = null;
            this.txtEmail.xField_Key = "";
            this.txtEmail.xKeep_Old_Value = false;
            this.txtEmail.xTimChinhXac = false;
            this.txtEmail.xTimMoRong = "";
            this.txtEmail.xTimTrenField = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phòng khoa";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(147, 140);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(396, 32);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.xCoTimMoRong = false;
            this.txtSDT.xDataGrid = null;
            this.txtSDT.xField_Key = "";
            this.txtSDT.xKeep_Old_Value = false;
            this.txtSDT.xTimChinhXac = false;
            this.txtSDT.xTimMoRong = "";
            this.txtSDT.xTimTrenField = "";
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanh.AutoComplete = false;
            this.cboChucDanh.AutoDropdown = false;
            this.cboChucDanh.BackColorEven = System.Drawing.Color.White;
            this.cboChucDanh.BackColorOdd = System.Drawing.Color.White;
            this.cboChucDanh.ColumnNames = "TenChucDanh";
            this.cboChucDanh.ColumnWidthDefault = 150;
            this.cboChucDanh.ColumnWidths = "";
            this.cboChucDanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboChucDanh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.LinkedColumnIndex = 0;
            this.cboChucDanh.LinkedTextBox = null;
            this.cboChucDanh.Location = new System.Drawing.Point(147, 317);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(396, 33);
            this.cboChucDanh.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã NV";
            // 
            // cboPhongKhoa
            // 
            this.cboPhongKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPhongKhoa.AutoComplete = false;
            this.cboPhongKhoa.AutoDropdown = false;
            this.cboPhongKhoa.BackColorEven = System.Drawing.Color.White;
            this.cboPhongKhoa.BackColorOdd = System.Drawing.Color.White;
            this.cboPhongKhoa.ColumnNames = "TenPK";
            this.cboPhongKhoa.ColumnWidthDefault = 150;
            this.cboPhongKhoa.ColumnWidths = "";
            this.cboPhongKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPhongKhoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongKhoa.FormattingEnabled = true;
            this.cboPhongKhoa.LinkedColumnIndex = 0;
            this.cboPhongKhoa.LinkedTextBox = null;
            this.cboPhongKhoa.Location = new System.Drawing.Point(147, 272);
            this.cboPhongKhoa.Name = "cboPhongKhoa";
            this.cboPhongKhoa.Size = new System.Drawing.Size(396, 33);
            this.cboPhongKhoa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mật khẩu";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(147, 184);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(396, 32);
            this.txtTenTaiKhoan.TabIndex = 13;
            this.txtTenTaiKhoan.xCoTimMoRong = false;
            this.txtTenTaiKhoan.xDataGrid = null;
            this.txtTenTaiKhoan.xField_Key = "";
            this.txtTenTaiKhoan.xKeep_Old_Value = false;
            this.txtTenTaiKhoan.xTimChinhXac = false;
            this.txtTenTaiKhoan.xTimMoRong = "";
            this.txtTenTaiKhoan.xTimTrenField = "";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(9, 188);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(132, 24);
            this.lab.TabIndex = 15;
            this.lab.Text = "Tên tài khoản";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(147, 228);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(396, 32);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.xCoTimMoRong = false;
            this.txtMatKhau.xDataGrid = null;
            this.txtMatKhau.xField_Key = "";
            this.txtMatKhau.xKeep_Old_Value = false;
            this.txtMatKhau.xTimChinhXac = false;
            this.txtMatKhau.xTimMoRong = "";
            this.txtMatKhau.xTimTrenField = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.pbUser);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 264);
            this.panel4.TabIndex = 28;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUser.Image = global::DuAn_QuanLyKPI.Properties.Resources.noimage;
            this.pbUser.Location = new System.Drawing.Point(145, 3);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(256, 256);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            // 
            // Frm_AddUser
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(552, 736);
            this.Controls.Add(this.pnThongTinNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Người dùng";
            this.pnThongTinNhanVien.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThongTinNhanVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnUpImage;
        private System.Windows.Forms.Button btnLuuThem;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private ControlProject1510.XFilteg txtMaNV;
        private System.Windows.Forms.Label label4;
        private ControlProject1510.ComboBoxSearch cboPhanQuyen;
        private ControlProject1510.XFilteg txtHoten;
        private System.Windows.Forms.Label label8;
        private ControlProject1510.XFilteg txtEmail;
        private System.Windows.Forms.Label label7;
        private ControlProject1510.XFilteg txtSDT;
        private ControlProject1510.ComboBoxSearch cboChucDanh;
        private System.Windows.Forms.Label label2;
        private ControlProject1510.ComboBoxSearch cboPhongKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private ControlProject1510.XFilteg txtTenTaiKhoan;
        private System.Windows.Forms.Label lab;
        private ControlProject1510.XFilteg txtMatKhau;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbUser;
    }
}