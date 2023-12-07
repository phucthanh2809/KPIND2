
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
            this.cIDBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChon = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.nmQuarter = new System.Windows.Forms.NumericUpDown();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbQuarter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMau)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuarter)).BeginInit();
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
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 690);
            this.panel3.TabIndex = 1;
            // 
            // dgrChonBieuMau
            // 
            this.dgrChonBieuMau.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrChonBieuMau.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrChonBieuMau.ColumnHeadersHeight = 35;
            this.dgrChonBieuMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDBieuMau,
            this.cTenBieuMau,
            this.cMaBieuMau,
            this.cChon});
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
            this.dgrChonBieuMau.RowTemplate.Height = 40;
            this.dgrChonBieuMau.Size = new System.Drawing.Size(1364, 690);
            this.dgrChonBieuMau.TabIndex = 1;
            this.dgrChonBieuMau.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrChonBieuMau_CellMouseClick);
            this.dgrChonBieuMau.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrChonBieuMau_RowPostPaint);
            // 
            // cIDBieuMau
            // 
            this.cIDBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cIDBieuMau.DataPropertyName = "IDBieuMau";
            this.cIDBieuMau.HeaderText = "ID Biểu Mẫu";
            this.cIDBieuMau.Name = "cIDBieuMau";
            this.cIDBieuMau.ReadOnly = true;
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
            // cMaBieuMau
            // 
            this.cMaBieuMau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cMaBieuMau.DataPropertyName = "MaBieuMau";
            this.cMaBieuMau.HeaderText = "Biểu mẫu";
            this.cMaBieuMau.Name = "cMaBieuMau";
            this.cMaBieuMau.ReadOnly = true;
            this.cMaBieuMau.Width = 120;
            // 
            // cChon
            // 
            this.cChon.HeaderText = "Chọn";
            this.cChon.Image = ((System.Drawing.Image)(resources.GetObject("cChon.Image")));
            this.cChon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.cChon.Name = "cChon";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmYear);
            this.panel2.Controls.Add(this.nmQuarter);
            this.panel2.Controls.Add(this.lbYear);
            this.panel2.Controls.Add(this.lbQuarter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 46);
            this.panel2.TabIndex = 0;
            // 
            // nmYear
            // 
            this.nmYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmYear.Location = new System.Drawing.Point(1226, 7);
            this.nmYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nmYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(126, 32);
            this.nmYear.TabIndex = 5;
            this.nmYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmYear.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // nmQuarter
            // 
            this.nmQuarter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmQuarter.Location = new System.Drawing.Point(1061, 7);
            this.nmQuarter.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmQuarter.Name = "nmQuarter";
            this.nmQuarter.Size = new System.Drawing.Size(100, 32);
            this.nmQuarter.TabIndex = 4;
            this.nmQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbYear
            // 
            this.lbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(1167, 11);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(53, 24);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "Năm";
            // 
            // lbQuarter
            // 
            this.lbQuarter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuarter.AutoSize = true;
            this.lbQuarter.Location = new System.Drawing.Point(1008, 11);
            this.lbQuarter.Name = "lbQuarter";
            this.lbQuarter.Size = new System.Drawing.Size(47, 24);
            this.lbQuarter.TabIndex = 2;
            this.lbQuarter.Text = "Quý";
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
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuarter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrChonBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaBieuMau;
        private System.Windows.Forms.DataGridViewImageColumn cChon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbQuarter;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.NumericUpDown nmQuarter;
    }
}