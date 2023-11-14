
namespace DuAn_QuanLyKPI.GUI
{
    partial class XtraForm1
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridBieuMau = new DevExpress.XtraGrid.GridControl();
            this.dgrBieuMau = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cIDBieuMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenBieuMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaBieuMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChon = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBieuMau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBieuMau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridBieuMau);
            this.panel1.Location = new System.Drawing.Point(38, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 456);
            this.panel1.TabIndex = 0;
            // 
            // gridBieuMau
            // 
            this.gridBieuMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBieuMau.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridBieuMau.Location = new System.Drawing.Point(0, 0);
            this.gridBieuMau.MainView = this.dgrBieuMau;
            this.gridBieuMau.Name = "gridBieuMau";
            this.gridBieuMau.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChon});
            this.gridBieuMau.Size = new System.Drawing.Size(1223, 456);
            this.gridBieuMau.TabIndex = 4;
            this.gridBieuMau.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgrBieuMau});
            // 
            // dgrBieuMau
            // 
            this.dgrBieuMau.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgrBieuMau.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrBieuMau.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgrBieuMau.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgrBieuMau.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgrBieuMau.Appearance.Row.Options.UseBackColor = true;
            this.dgrBieuMau.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgrBieuMau.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgrBieuMau.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrBieuMau.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgrBieuMau.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cIDBieuMau,
            this.cTenBieuMau,
            this.cMaBieuMau,
            this.Chon});
            this.dgrBieuMau.GridControl = this.gridBieuMau;
            this.dgrBieuMau.Name = "dgrBieuMau";
            this.dgrBieuMau.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrBieuMau.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrBieuMau.OptionsBehavior.Editable = false;
            this.dgrBieuMau.OptionsBehavior.ReadOnly = true;
            this.dgrBieuMau.OptionsView.ShowGroupPanel = false;
            this.dgrBieuMau.RowHeight = 30;
            // 
            // cIDBieuMau
            // 
            this.cIDBieuMau.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDBieuMau.AppearanceCell.Options.UseFont = true;
            this.cIDBieuMau.AppearanceCell.Options.UseTextOptions = true;
            this.cIDBieuMau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cIDBieuMau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cIDBieuMau.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cIDBieuMau.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDBieuMau.AppearanceHeader.Options.UseBackColor = true;
            this.cIDBieuMau.AppearanceHeader.Options.UseFont = true;
            this.cIDBieuMau.AppearanceHeader.Options.UseTextOptions = true;
            this.cIDBieuMau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cIDBieuMau.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cIDBieuMau.Caption = "ID Biểu Mẫu";
            this.cIDBieuMau.FieldName = "IDBieuMau";
            this.cIDBieuMau.Name = "cIDBieuMau";
            this.cIDBieuMau.OptionsColumn.ReadOnly = true;
            this.cIDBieuMau.Visible = true;
            this.cIDBieuMau.VisibleIndex = 0;
            // 
            // cTenBieuMau
            // 
            this.cTenBieuMau.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cTenBieuMau.AppearanceCell.Options.UseFont = true;
            this.cTenBieuMau.AppearanceCell.Options.UseTextOptions = true;
            this.cTenBieuMau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cTenBieuMau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTenBieuMau.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cTenBieuMau.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cTenBieuMau.AppearanceHeader.Options.UseBackColor = true;
            this.cTenBieuMau.AppearanceHeader.Options.UseFont = true;
            this.cTenBieuMau.AppearanceHeader.Options.UseTextOptions = true;
            this.cTenBieuMau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cTenBieuMau.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTenBieuMau.Caption = "Tên Biểu Mẫu";
            this.cTenBieuMau.FieldName = "TenBieuMau";
            this.cTenBieuMau.Name = "cTenBieuMau";
            this.cTenBieuMau.OptionsColumn.ReadOnly = true;
            this.cTenBieuMau.Visible = true;
            this.cTenBieuMau.VisibleIndex = 1;
            // 
            // cMaBieuMau
            // 
            this.cMaBieuMau.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cMaBieuMau.AppearanceCell.Options.UseFont = true;
            this.cMaBieuMau.AppearanceCell.Options.UseTextOptions = true;
            this.cMaBieuMau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaBieuMau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaBieuMau.AppearanceHeader.BackColor = System.Drawing.Color.MistyRose;
            this.cMaBieuMau.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cMaBieuMau.AppearanceHeader.Options.UseBackColor = true;
            this.cMaBieuMau.AppearanceHeader.Options.UseFont = true;
            this.cMaBieuMau.AppearanceHeader.Options.UseTextOptions = true;
            this.cMaBieuMau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cMaBieuMau.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cMaBieuMau.Caption = "Biểu mẫu";
            this.cMaBieuMau.FieldName = "MaBieuMau";
            this.cMaBieuMau.Name = "cMaBieuMau";
            this.cMaBieuMau.OptionsColumn.ReadOnly = true;
            this.cMaBieuMau.Visible = true;
            this.cMaBieuMau.VisibleIndex = 2;
            // 
            // Chon
            // 
            this.Chon.Caption = "Chọn";
            this.Chon.ColumnEdit = this.btnChon;
            this.Chon.Name = "Chon";
            this.Chon.OptionsColumn.AllowEdit = false;
            this.Chon.Visible = true;
            this.Chon.VisibleIndex = 3;
            // 
            // btnChon
            // 
            this.btnChon.AutoHeight = false;
            editorButtonImageOptions1.Image = global::DuAn_QuanLyKPI.Properties.Resources.apply_32x322;
            this.btnChon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnChon.Name = "btnChon";
            this.btnChon.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 610);
            this.Controls.Add(this.panel1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBieuMau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBieuMau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridBieuMau;
        private DevExpress.XtraGrid.Views.Grid.GridView dgrBieuMau;
        private DevExpress.XtraGrid.Columns.GridColumn cIDBieuMau;
        private DevExpress.XtraGrid.Columns.GridColumn cTenBieuMau;
        private DevExpress.XtraGrid.Columns.GridColumn cMaBieuMau;
        private DevExpress.XtraGrid.Columns.GridColumn Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChon;
    }
}