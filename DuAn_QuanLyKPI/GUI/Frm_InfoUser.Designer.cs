
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_InfoUser
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
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.txtMaNV = new ControlProject1510.XFilteg();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new ControlProject1510.XFilteg();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new ControlProject1510.XFilteg();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new ControlProject1510.XFilteg();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhongKhoa = new ControlProject1510.XFilteg();
            this.txtChucDanh = new ControlProject1510.XFilteg();
            this.pnTong.SuspendLayout();
            this.pnThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTong
            // 
            this.pnTong.Controls.Add(this.pnThongTin);
            this.pnTong.Controls.Add(this.panel2);
            this.pnTong.Controls.Add(this.panel1);
            this.pnTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTong.Location = new System.Drawing.Point(0, 0);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(1056, 328);
            this.pnTong.TabIndex = 0;
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.txtChucDanh);
            this.pnThongTin.Controls.Add(this.txtPhongKhoa);
            this.pnThongTin.Controls.Add(this.txtMaNV);
            this.pnThongTin.Controls.Add(this.label5);
            this.pnThongTin.Controls.Add(this.label4);
            this.pnThongTin.Controls.Add(this.txtHoten);
            this.pnThongTin.Controls.Add(this.label3);
            this.pnThongTin.Controls.Add(this.label8);
            this.pnThongTin.Controls.Add(this.txtEmail);
            this.pnThongTin.Controls.Add(this.label2);
            this.pnThongTin.Controls.Add(this.label7);
            this.pnThongTin.Controls.Add(this.txtSDT);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTin.Location = new System.Drawing.Point(281, 63);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(775, 265);
            this.pnThongTin.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(139, 10);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(624, 32);
            this.txtMaNV.TabIndex = 66;
            this.txtMaNV.xCoTimMoRong = false;
            this.txtMaNV.xDataGrid = null;
            this.txtMaNV.xField_Key = "";
            this.txtMaNV.xKeep_Old_Value = false;
            this.txtMaNV.xTimChinhXac = false;
            this.txtMaNV.xTimMoRong = "";
            this.txtMaNV.xTimTrenField = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 72;
            this.label4.Text = "Email:";
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(139, 53);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(624, 32);
            this.txtHoten.TabIndex = 67;
            this.txtHoten.xCoTimMoRong = false;
            this.txtHoten.xDataGrid = null;
            this.txtHoten.xField_Key = "";
            this.txtHoten.xKeep_Old_Value = false;
            this.txtHoten.xTimChinhXac = false;
            this.txtHoten.xTimMoRong = "";
            this.txtHoten.xTimTrenField = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Họ tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 81;
            this.label8.Text = "Chức danh:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(139, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(624, 32);
            this.txtEmail.TabIndex = 68;
            this.txtEmail.xCoTimMoRong = false;
            this.txtEmail.xDataGrid = null;
            this.txtEmail.xField_Key = "";
            this.txtEmail.xKeep_Old_Value = false;
            this.txtEmail.xTimChinhXac = false;
            this.txtEmail.xTimMoRong = "";
            this.txtEmail.xTimTrenField = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Mã NV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 80;
            this.label7.Text = "Phòng khoa:";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(139, 139);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(624, 32);
            this.txtSDT.TabIndex = 69;
            this.txtSDT.xCoTimMoRong = false;
            this.txtSDT.xDataGrid = null;
            this.txtSDT.xField_Key = "";
            this.txtSDT.xKeep_Old_Value = false;
            this.txtSDT.xTimChinhXac = false;
            this.txtSDT.xTimMoRong = "";
            this.txtSDT.xTimTrenField = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 265);
            this.panel2.TabIndex = 2;
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUser.Image = global::DuAn_QuanLyKPI.Properties.Resources.noimage;
            this.pbUser.Location = new System.Drawing.Point(12, 6);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(256, 256);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 64;
            this.pbUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(331, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 55);
            this.label1.TabIndex = 66;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // txtPhongKhoa
            // 
            this.txtPhongKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhongKhoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongKhoa.Location = new System.Drawing.Point(139, 182);
            this.txtPhongKhoa.Name = "txtPhongKhoa";
            this.txtPhongKhoa.Size = new System.Drawing.Size(624, 32);
            this.txtPhongKhoa.TabIndex = 84;
            this.txtPhongKhoa.xCoTimMoRong = false;
            this.txtPhongKhoa.xDataGrid = null;
            this.txtPhongKhoa.xField_Key = "";
            this.txtPhongKhoa.xKeep_Old_Value = false;
            this.txtPhongKhoa.xTimChinhXac = false;
            this.txtPhongKhoa.xTimMoRong = "";
            this.txtPhongKhoa.xTimTrenField = "";
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChucDanh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucDanh.Location = new System.Drawing.Point(139, 225);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Size = new System.Drawing.Size(624, 32);
            this.txtChucDanh.TabIndex = 85;
            this.txtChucDanh.xCoTimMoRong = false;
            this.txtChucDanh.xDataGrid = null;
            this.txtChucDanh.xField_Key = "";
            this.txtChucDanh.xKeep_Old_Value = false;
            this.txtChucDanh.xTimChinhXac = false;
            this.txtChucDanh.xTimMoRong = "";
            this.txtChucDanh.xTimTrenField = "";
            // 
            // Frm_InfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 328);
            this.Controls.Add(this.pnTong);
            this.Name = "Frm_InfoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.pnTong.ResumeLayout(false);
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnThongTin;
        private ControlProject1510.XFilteg txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ControlProject1510.XFilteg txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private ControlProject1510.XFilteg txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private ControlProject1510.XFilteg txtSDT;
        private ControlProject1510.XFilteg txtChucDanh;
        private ControlProject1510.XFilteg txtPhongKhoa;
    }
}