
namespace DuAn_QuanLyKPI.GUI
{
    partial class FrmChonBieuMau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonBieuMau));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrChonBieuMau = new System.Windows.Forms.DataGridView();
            this.cMaBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuy1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cQuy2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cQuy3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cQuy4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cNam = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMau)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Chọn";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
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
            this.panel3.Controls.Add(this.dgrChonBieuMau);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 676);
            this.panel3.TabIndex = 1;
            // 
            // dgrChonBieuMau
            // 
            this.dgrChonBieuMau.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrChonBieuMau.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrChonBieuMau.BackgroundColor = System.Drawing.Color.White;
            this.dgrChonBieuMau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrChonBieuMau.ColumnHeadersHeight = 50;
            this.dgrChonBieuMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaBieuMau,
            this.cIDBieuMau,
            this.cTenBieuMau,
            this.cQuy1,
            this.cQuy2,
            this.cQuy3,
            this.cQuy4,
            this.cNam});
            this.dgrChonBieuMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrChonBieuMau.EnableHeadersVisualStyles = false;
            this.dgrChonBieuMau.Location = new System.Drawing.Point(0, 0);
            this.dgrChonBieuMau.Name = "dgrChonBieuMau";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMau.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrChonBieuMau.RowHeadersWidth = 75;
            this.dgrChonBieuMau.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrChonBieuMau.RowTemplate.Height = 50;
            this.dgrChonBieuMau.Size = new System.Drawing.Size(1364, 676);
            this.dgrChonBieuMau.TabIndex = 1;
            this.dgrChonBieuMau.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrChonBieuMau_CellMouseClick);
            this.dgrChonBieuMau.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrChonBieuMau_RowPostPaint);
            // 
            // cMaBieuMau
            // 
            this.cMaBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cMaBieuMau.DataPropertyName = "MaBieuMau";
            this.cMaBieuMau.HeaderText = "Biểu mẫu";
            this.cMaBieuMau.Name = "cMaBieuMau";
            this.cMaBieuMau.ReadOnly = true;
            this.cMaBieuMau.Width = 120;
            // 
            // cIDBieuMau
            // 
            this.cIDBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cIDBieuMau.DataPropertyName = "IDBieuMau";
            this.cIDBieuMau.HeaderText = "ID Biểu Mẫu";
            this.cIDBieuMau.Name = "cIDBieuMau";
            this.cIDBieuMau.ReadOnly = true;
            this.cIDBieuMau.Visible = false;
            this.cIDBieuMau.Width = 149;
            // 
            // cTenBieuMau
            // 
            this.cTenBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenBieuMau.DataPropertyName = "TenBieuMau";
            this.cTenBieuMau.HeaderText = "Tên Biểu Mẫu";
            this.cTenBieuMau.Name = "cTenBieuMau";
            this.cTenBieuMau.ReadOnly = true;
            // 
            // cQuy1
            // 
            this.cQuy1.HeaderText = "Quý 1";
            this.cQuy1.Name = "cQuy1";
            this.cQuy1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cQuy2
            // 
            this.cQuy2.HeaderText = "Quý 2";
            this.cQuy2.Name = "cQuy2";
            this.cQuy2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cQuy3
            // 
            this.cQuy3.HeaderText = "Quý 3";
            this.cQuy3.Name = "cQuy3";
            this.cQuy3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cQuy4
            // 
            this.cQuy4.HeaderText = "Quý 4";
            this.cQuy4.Name = "cQuy4";
            this.cQuy4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuy4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cNam
            // 
            this.cNam.HeaderText = "Năm";
            this.cNam.Name = "cNam";
            this.cNam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cNam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.txtTest);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbYear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 60);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "HỆ THỐNG BIỂU MẪU";
            // 
            // lbYear
            // 
            this.lbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(1163, 17);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(68, 26);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "Năm:";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(402, 13);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 32);
            this.txtTest.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(1237, 14);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(120, 32);
            this.txtYear.TabIndex = 8;
            // 
            // FrmChonBieuMau
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmChonBieuMau.IconOptions.Image")));
            this.Name = "FrmChonBieuMau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Biểu mẫu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMau)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrChonBieuMau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenBieuMau;
        private System.Windows.Forms.DataGridViewImageColumn cQuy1;
        private System.Windows.Forms.DataGridViewImageColumn cQuy2;
        private System.Windows.Forms.DataGridViewImageColumn cQuy3;
        private System.Windows.Forms.DataGridViewImageColumn cQuy4;
        private System.Windows.Forms.DataGridViewImageColumn cNam;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtYear;
    }
}