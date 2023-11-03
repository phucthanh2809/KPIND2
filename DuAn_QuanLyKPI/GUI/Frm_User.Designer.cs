
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_User
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
            this.btnclear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrDanhSach = new System.Windows.Forms.DataGridView();
            this.cMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhongKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenChucDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.c_Xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhanQuyen = new ControlProject1510.ComboBoxSearch();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.cXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.cboChucDanh = new ControlProject1510.ComboBoxSearch();
            this.cboPhongKhoa = new ControlProject1510.ComboBoxSearch();
            this.txtMatKhau = new ControlProject1510.XFilteg();
            this.txtTenTaiKhoan = new ControlProject1510.XFilteg();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.OpenFileDialog();
            this.txtSDT = new ControlProject1510.XFilteg();
            this.txtEmail = new ControlProject1510.XFilteg();
            this.txtHoten = new ControlProject1510.XFilteg();
            this.txtMaNV = new ControlProject1510.XFilteg();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnUpImage = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSach)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.Location = new System.Drawing.Point(620, 78);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 34);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Phân quyền";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(516, 78);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 34);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "LÀM MỚI";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrDanhSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(328, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 558);
            this.panel3.TabIndex = 5;
            // 
            // dgrDanhSach
            // 
            this.dgrDanhSach.AllowUserToAddRows = false;
            this.dgrDanhSach.AllowUserToDeleteRows = false;
            this.dgrDanhSach.ColumnHeadersHeight = 50;
            this.dgrDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNV,
            this.cHoTen,
            this.cTenTaiKhoan,
            this.cPhongKhoa,
            this.cTenChucDanh,
            this.cHinhAnh,
            this.c_Xoa});
            this.dgrDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgrDanhSach.Name = "dgrDanhSach";
            this.dgrDanhSach.ReadOnly = true;
            this.dgrDanhSach.RowTemplate.Height = 100;
            this.dgrDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDanhSach.Size = new System.Drawing.Size(923, 558);
            this.dgrDanhSach.TabIndex = 0;
            this.dgrDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSach_CellClick);
            this.dgrDanhSach.Click += new System.EventHandler(this.dgrDanhSach_Click_1);
            // 
            // cMaNV
            // 
            this.cMaNV.DataPropertyName = "MANV";
            this.cMaNV.FillWeight = 200F;
            this.cMaNV.HeaderText = "Mã NV";
            this.cMaNV.Name = "cMaNV";
            this.cMaNV.ReadOnly = true;
            this.cMaNV.Width = 70;
            // 
            // cHoTen
            // 
            this.cHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cHoTen.DataPropertyName = "TenNV";
            this.cHoTen.HeaderText = "Họ tên";
            this.cHoTen.Name = "cHoTen";
            this.cHoTen.ReadOnly = true;
            // 
            // cTenTaiKhoan
            // 
            this.cTenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.cTenTaiKhoan.HeaderText = "Tên tài khoản";
            this.cTenTaiKhoan.Name = "cTenTaiKhoan";
            this.cTenTaiKhoan.ReadOnly = true;
            this.cTenTaiKhoan.Width = 105;
            // 
            // cPhongKhoa
            // 
            this.cPhongKhoa.DataPropertyName = "TenPK";
            this.cPhongKhoa.HeaderText = "Phòng khoa";
            this.cPhongKhoa.Name = "cPhongKhoa";
            this.cPhongKhoa.ReadOnly = true;
            this.cPhongKhoa.Width = 200;
            // 
            // cTenChucDanh
            // 
            this.cTenChucDanh.DataPropertyName = "TenChucDanh";
            this.cTenChucDanh.HeaderText = "Tên chức danh";
            this.cTenChucDanh.Name = "cTenChucDanh";
            this.cTenChucDanh.ReadOnly = true;
            this.cTenChucDanh.Width = 200;
            // 
            // cHinhAnh
            // 
            this.cHinhAnh.DataPropertyName = "HinhAnhNV";
            this.cHinhAnh.HeaderText = "Hình ảnh";
            this.cHinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.cHinhAnh.MinimumWidth = 30;
            this.cHinhAnh.Name = "cHinhAnh";
            this.cHinhAnh.ReadOnly = true;
            // 
            // c_Xoa
            // 
            this.c_Xoa.HeaderText = "Xóa";
            this.c_Xoa.Name = "c_Xoa";
            this.c_Xoa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // cboPhanQuyen
            // 
            this.cboPhanQuyen.AutoComplete = false;
            this.cboPhanQuyen.AutoDropdown = false;
            this.cboPhanQuyen.BackColorEven = System.Drawing.Color.White;
            this.cboPhanQuyen.BackColorOdd = System.Drawing.Color.White;
            this.cboPhanQuyen.ColumnNames = "TenQuyen";
            this.cboPhanQuyen.ColumnWidthDefault = 150;
            this.cboPhanQuyen.ColumnWidths = "";
            this.cboPhanQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPhanQuyen.FormattingEnabled = true;
            this.cboPhanQuyen.LinkedColumnIndex = 0;
            this.cboPhanQuyen.LinkedTextBox = null;
            this.cboPhanQuyen.Location = new System.Drawing.Point(117, 556);
            this.cboPhanQuyen.Name = "cboPhanQuyen";
            this.cboPhanQuyen.Size = new System.Drawing.Size(180, 27);
            this.cboPhanQuyen.TabIndex = 26;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(121, 649);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 34);
            this.btnQuaylai.TabIndex = 25;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Visible = false;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(204, 609);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(744, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 137);
            this.panel5.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(123, 609);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(123, 609);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Chức danh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phòng khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mật khẩu";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(12, 397);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(101, 19);
            this.lab.TabIndex = 15;
            this.lab.Text = "Tên tài khoản";
            // 
            // cXoa
            // 
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.Name = "cXoa";
            this.cXoa.ReadOnly = true;
            this.cXoa.Width = 50;
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.AutoComplete = false;
            this.cboChucDanh.AutoDropdown = false;
            this.cboChucDanh.BackColorEven = System.Drawing.Color.White;
            this.cboChucDanh.BackColorOdd = System.Drawing.Color.White;
            this.cboChucDanh.ColumnNames = "TenChucDanh";
            this.cboChucDanh.ColumnWidthDefault = 150;
            this.cboChucDanh.ColumnWidths = "";
            this.cboChucDanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.LinkedColumnIndex = 0;
            this.cboChucDanh.LinkedTextBox = null;
            this.cboChucDanh.Location = new System.Drawing.Point(117, 516);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(180, 27);
            this.cboChucDanh.TabIndex = 19;
            // 
            // cboPhongKhoa
            // 
            this.cboPhongKhoa.AutoComplete = false;
            this.cboPhongKhoa.AutoDropdown = false;
            this.cboPhongKhoa.BackColorEven = System.Drawing.Color.White;
            this.cboPhongKhoa.BackColorOdd = System.Drawing.Color.White;
            this.cboPhongKhoa.ColumnNames = "TenPK";
            this.cboPhongKhoa.ColumnWidthDefault = 150;
            this.cboPhongKhoa.ColumnWidths = "";
            this.cboPhongKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPhongKhoa.FormattingEnabled = true;
            this.cboPhongKhoa.LinkedColumnIndex = 0;
            this.cboPhongKhoa.LinkedTextBox = null;
            this.cboPhongKhoa.Location = new System.Drawing.Point(117, 474);
            this.cboPhongKhoa.Name = "cboPhongKhoa";
            this.cboPhongKhoa.Size = new System.Drawing.Size(180, 27);
            this.cboPhongKhoa.TabIndex = 18;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(117, 434);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(180, 26);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.xCoTimMoRong = false;
            this.txtMatKhau.xDataGrid = null;
            this.txtMatKhau.xField_Key = "";
            this.txtMatKhau.xKeep_Old_Value = false;
            this.txtMatKhau.xTimChinhXac = false;
            this.txtMatKhau.xTimMoRong = "";
            this.txtMatKhau.xTimTrenField = "";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(117, 393);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(180, 26);
            this.txtTenTaiKhoan.TabIndex = 13;
            this.txtTenTaiKhoan.xCoTimMoRong = false;
            this.txtTenTaiKhoan.xDataGrid = null;
            this.txtTenTaiKhoan.xField_Key = "";
            this.txtTenTaiKhoan.xKeep_Old_Value = false;
            this.txtTenTaiKhoan.xTimChinhXac = false;
            this.txtTenTaiKhoan.xTimMoRong = "";
            this.txtTenTaiKhoan.xTimTrenField = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(328, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 137);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Họ tên";
            // 
            // Upload
            // 
            this.Upload.FileName = "openFileDialog1";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(117, 352);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 26);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.xCoTimMoRong = false;
            this.txtSDT.xDataGrid = null;
            this.txtSDT.xField_Key = "";
            this.txtSDT.xKeep_Old_Value = false;
            this.txtSDT.xTimChinhXac = false;
            this.txtSDT.xTimMoRong = "";
            this.txtSDT.xTimTrenField = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(117, 312);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.xCoTimMoRong = false;
            this.txtEmail.xDataGrid = null;
            this.txtEmail.xField_Key = "";
            this.txtEmail.xKeep_Old_Value = false;
            this.txtEmail.xTimChinhXac = false;
            this.txtEmail.xTimMoRong = "";
            this.txtEmail.xTimTrenField = "";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(117, 274);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(180, 26);
            this.txtHoten.TabIndex = 1;
            this.txtHoten.xCoTimMoRong = false;
            this.txtHoten.xDataGrid = null;
            this.txtHoten.xField_Key = "";
            this.txtHoten.xKeep_Old_Value = false;
            this.txtHoten.xTimChinhXac = false;
            this.txtHoten.xTimMoRong = "";
            this.txtHoten.xTimTrenField = "";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(117, 234);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(180, 26);
            this.txtMaNV.TabIndex = 0;
            this.txtMaNV.xCoTimMoRong = false;
            this.txtMaNV.xDataGrid = null;
            this.txtMaNV.xField_Key = "";
            this.txtMaNV.xKeep_Old_Value = false;
            this.txtMaNV.xTimChinhXac = false;
            this.txtMaNV.xTimMoRong = "";
            this.txtMaNV.xTimTrenField = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboPhanQuyen);
            this.panel1.Controls.Add(this.btnQuaylai);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboChucDanh);
            this.panel1.Controls.Add(this.cboPhongKhoa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lab);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtTenTaiKhoan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.pbUser);
            this.panel1.Controls.Add(this.btnUpImage);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 695);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã NV";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(38, 609);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUser.Image = global::DuAn_QuanLyKPI.Properties.Resources.noimage;
            this.pbUser.Location = new System.Drawing.Point(77, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(170, 173);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            // 
            // btnUpImage
            // 
            this.btnUpImage.Location = new System.Drawing.Point(123, 190);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.Size = new System.Drawing.Size(75, 33);
            this.btnUpImage.TabIndex = 4;
            this.btnUpImage.Text = "Upload";
            this.btnUpImage.UseVisualStyleBackColor = true;
            this.btnUpImage.Click += new System.EventHandler(this.btnUpImage_Click_1);
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 695);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_User";
            this.Text = "Frm_User";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhongKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenChucDanh;
        private System.Windows.Forms.DataGridViewImageColumn cHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Xoa;
        private System.Windows.Forms.Label label1;
        private ControlProject1510.ComboBoxSearch cboPhanQuyen;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.DataGridViewImageColumn cXoa;
        private ControlProject1510.ComboBoxSearch cboChucDanh;
        private ControlProject1510.ComboBoxSearch cboPhongKhoa;
        private ControlProject1510.XFilteg txtMatKhau;
        private ControlProject1510.XFilteg txtTenTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog Upload;
        private ControlProject1510.XFilteg txtSDT;
        private ControlProject1510.XFilteg txtEmail;
        private ControlProject1510.XFilteg txtHoten;
        private ControlProject1510.XFilteg txtMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button btnUpImage;
    }
}