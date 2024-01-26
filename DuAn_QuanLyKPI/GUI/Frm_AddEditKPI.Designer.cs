
namespace DuAn_QuanLyKPI.GUI
{
    partial class Frm_AddEditKPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditKPI));
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtPhuongPhapDo = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkCongViecCaNhan = new System.Windows.Forms.CheckBox();
            this.nmQuarter = new System.Windows.Forms.NumericUpDown();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.txtNoiDungKPI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChiTieu = new System.Windows.Forms.TextBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.cboPhuongDien = new ControlProject1510.ComboBoxSearch();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDVT
            // 
            this.txtDVT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDVT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(169, 112);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(380, 29);
            this.txtDVT.TabIndex = 0;
            this.txtDVT.Text = "                                    ";
            // 
            // txtPhuongPhapDo
            // 
            this.txtPhuongPhapDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhuongPhapDo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuongPhapDo.Location = new System.Drawing.Point(169, 157);
            this.txtPhuongPhapDo.Name = "txtPhuongPhapDo";
            this.txtPhuongPhapDo.Size = new System.Drawing.Size(521, 29);
            this.txtPhuongPhapDo.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(169, 251);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(140, 29);
            this.txtMaNV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quý:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Năm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phương pháp đo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phương diện:";
            // 
            // chkCongViecCaNhan
            // 
            this.chkCongViecCaNhan.AutoSize = true;
            this.chkCongViecCaNhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCongViecCaNhan.Location = new System.Drawing.Point(509, 205);
            this.chkCongViecCaNhan.Name = "chkCongViecCaNhan";
            this.chkCongViecCaNhan.Size = new System.Drawing.Size(181, 27);
            this.chkCongViecCaNhan.TabIndex = 12;
            this.chkCongViecCaNhan.Text = "Công viện cá nhân";
            this.chkCongViecCaNhan.UseVisualStyleBackColor = true;
            // 
            // nmQuarter
            // 
            this.nmQuarter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmQuarter.Location = new System.Drawing.Point(612, 65);
            this.nmQuarter.Name = "nmQuarter";
            this.nmQuarter.Size = new System.Drawing.Size(78, 32);
            this.nmQuarter.TabIndex = 13;
            this.nmQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(612, 110);
            this.nmYear.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(78, 32);
            this.nmYear.TabIndex = 14;
            this.nmYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // txtNoiDungKPI
            // 
            this.txtNoiDungKPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDungKPI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungKPI.Location = new System.Drawing.Point(169, 22);
            this.txtNoiDungKPI.Name = "txtNoiDungKPI";
            this.txtNoiDungKPI.Size = new System.Drawing.Size(521, 29);
            this.txtNoiDungKPI.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nội dung KPI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chỉ tiêu:";
            // 
            // txtChiTieu
            // 
            this.txtChiTieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChiTieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiTieu.Location = new System.Drawing.Point(169, 67);
            this.txtChiTieu.Name = "txtChiTieu";
            this.txtChiTieu.Size = new System.Drawing.Size(380, 29);
            this.txtChiTieu.TabIndex = 19;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(590, 245);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboPhuongDien
            // 
            this.cboPhuongDien.AllowDrop = true;
            this.cboPhuongDien.AutoComplete = true;
            this.cboPhuongDien.AutoDropdown = true;
            this.cboPhuongDien.BackColorEven = System.Drawing.Color.White;
            this.cboPhuongDien.BackColorOdd = System.Drawing.Color.White;
            this.cboPhuongDien.ColumnNames = "TenTieuChi";
            this.cboPhuongDien.ColumnWidthDefault = 200;
            this.cboPhuongDien.ColumnWidths = "";
            this.cboPhuongDien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPhuongDien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhuongDien.FormattingEnabled = true;
            this.cboPhuongDien.LinkedColumnIndex = 0;
            this.cboPhuongDien.LinkedTextBox = null;
            this.cboPhuongDien.Location = new System.Drawing.Point(169, 202);
            this.cboPhuongDien.Name = "cboPhuongDien";
            this.cboPhuongDien.Size = new System.Drawing.Size(323, 33);
            this.cboPhuongDien.TabIndex = 25;
            // 
            // Frm_AddEditKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 291);
            this.Controls.Add(this.cboPhuongDien);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtChiTieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoiDungKPI);
            this.Controls.Add(this.nmYear);
            this.Controls.Add(this.nmQuarter);
            this.Controls.Add(this.chkCongViecCaNhan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtPhuongPhapDo);
            this.Controls.Add(this.txtDVT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_AddEditKPI.IconOptions.Image")));
            this.Name = "Frm_AddEditKPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.nmQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtPhuongPhapDo;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCongViecCaNhan;
        private System.Windows.Forms.NumericUpDown nmQuarter;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.TextBox txtNoiDungKPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChiTieu;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private ControlProject1510.ComboBoxSearch cboPhuongDien;
    }
}