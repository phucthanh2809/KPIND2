
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonBieuMau));
            this.pnTong = new System.Windows.Forms.Panel();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.dgrChonBieuMau = new System.Windows.Forms.DataGridView();
            this.cIDBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaBieuMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChon = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnTong.SuspendLayout();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMau)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTong
            // 
            this.pnTong.Controls.Add(this.pnGrid);
            this.pnTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTong.Location = new System.Drawing.Point(0, 0);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(1364, 736);
            this.pnTong.TabIndex = 0;
            // 
            // pnGrid
            // 
            this.pnGrid.Controls.Add(this.dgrChonBieuMau);
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrid.Location = new System.Drawing.Point(0, 0);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(1364, 736);
            this.pnGrid.TabIndex = 2;
            // 
            // dgrChonBieuMau
            // 
            this.dgrChonBieuMau.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrChonBieuMau.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrChonBieuMau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrChonBieuMau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrChonBieuMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChonBieuMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDBieuMau,
            this.cTenBieuMau,
            this.cMaBieuMau,
            this.cChon});
            this.dgrChonBieuMau.Location = new System.Drawing.Point(0, 0);
            this.dgrChonBieuMau.Name = "dgrChonBieuMau";
            this.dgrChonBieuMau.RowTemplate.Height = 30;
            this.dgrChonBieuMau.Size = new System.Drawing.Size(1364, 736);
            this.dgrChonBieuMau.TabIndex = 0;
            this.dgrChonBieuMau.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrChonBieuMau_CellMouseClick);
            this.dgrChonBieuMau.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrChonBieuMau_RowPostPaint);
            // 
            // cIDBieuMau
            // 
            this.cIDBieuMau.DataPropertyName = "IDBieuMau";
            this.cIDBieuMau.HeaderText = "ID Biểu Mẫu";
            this.cIDBieuMau.Name = "cIDBieuMau";
            this.cIDBieuMau.ReadOnly = true;
            this.cIDBieuMau.Visible = false;
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
            this.cMaBieuMau.DataPropertyName = "MaBieuMau";
            this.cMaBieuMau.HeaderText = "Biểu mẫu";
            this.cMaBieuMau.Name = "cMaBieuMau";
            this.cMaBieuMau.ReadOnly = true;
            this.cMaBieuMau.Width = 200;
            // 
            // cChon
            // 
            this.cChon.HeaderText = "Chọn";
            this.cChon.Image = ((System.Drawing.Image)(resources.GetObject("cChon.Image")));
            this.cChon.Name = "cChon";
            // 
            // FrmChonBieuMau
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.pnTong);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChonBieuMau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Biểu mẫu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTong.ResumeLayout(false);
            this.pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrChonBieuMau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.DataGridView dgrChonBieuMau;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenBieuMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaBieuMau;
        private System.Windows.Forms.DataGridViewImageColumn cChon;
    }
}