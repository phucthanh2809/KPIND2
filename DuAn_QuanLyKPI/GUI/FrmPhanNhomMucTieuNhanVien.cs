using BusinessCommon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DuAn_QuanLyKPI.GUI
{
    public partial class FrmPhanNhomMucTieuNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public static string mconnectstring = "server=192.168.50.108,1433;database=QuanLyKPI;uid=sa;pwd=123";
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        private string msql;

        public FrmPhanNhomMucTieuNhanVien()
        {
            InitializeComponent();
            load();
            combobox();
            dgrDanhSachMucTieuTaiChinhKPI.CellValueChanged += dgrDanhSachMucTieuTaiChinhKPI_CellValueChanged;
            dgrDanhSachMucTieuTaiChinhKPI.CurrentCellDirtyStateChanged += dgrDanhSachMucTieuTaiChinhKPI_CurrentCellDirtyStateChanged;

        }




        private void load()
        {
            msql = "SELECT * FROM [dbo].[MucTieuKPI] as a ,[dbo].[ChucDanh] as b , [dbo].[ChiTietKPIKhoaPhong] as c where a.MaChucDanh=b.MaChucDanh and a.MaKPIKPCT=c.MaKPIKPCT";
            DataTable tb = comm.GetDataTable(mconnectstring, msql, "");
            dgrDanhSachMucTieuTaiChinhKPI.AutoGenerateColumns = false;
            dgrDanhSachMucTieuTaiChinhKPI.DataSource = tb;
            // Thực thi lấy bảng dữ liệu đặt đều kiện lấy IDTieuChi làm điều kiện
        }
        private void combobox()
        {
            msql = "SELECT * FROM [dbo].[ChucDanh]";
            DataTable cbcd = comm.GetDataTable(mconnectstring, msql, "");

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Chức Danh";
            comboBoxColumn.DataPropertyName = "MaChucDanh";
            comboBoxColumn.Name = "cChucDanh";

            comboBoxColumn.Width = 400;

            dgrDanhSachMucTieuTaiChinhKPI.Columns.Add(comboBoxColumn);

            LoadDataIntoComboBoxColumn("MaChucDanh", "TenChucDanh", cbcd, comboBoxColumn);





            msql = "SELECT * FROM [dbo].[ChucDanh]";
            DataTable cbcd1 = comm.GetDataTable(mconnectstring, msql, "");

            DataGridViewComboBoxColumn comboBoxColumn1 = new DataGridViewComboBoxColumn();
            comboBoxColumn1.HeaderText = "Chức Danh";
            comboBoxColumn1.DataPropertyName = "MaChucDanh";
            comboBoxColumn1.Name = "cChucDanh";

            comboBoxColumn1.Width = 400;

            dgrDanhSachMucTieuKhachHangKPI.Columns.Add(comboBoxColumn1);

            LoadDataIntoComboBoxColumn1("MaChucDanh", "TenChucDanh", cbcd1, comboBoxColumn1);





            msql = "SELECT * FROM [dbo].[ChucDanh]";
            DataTable cbcd2 = comm.GetDataTable(mconnectstring, msql, "");

            DataGridViewComboBoxColumn comboBoxColumn2 = new DataGridViewComboBoxColumn();
            comboBoxColumn2.HeaderText = "Chức Danh";
            comboBoxColumn2.DataPropertyName = "MaChucDanh";
            comboBoxColumn2.Name = "cChucDanh";

            comboBoxColumn2.Width = 400;

            dgrDanhSachMucTieuVanHanhKPI.Columns.Add(comboBoxColumn2);

            LoadDataIntoComboBoxColumn2("MaChucDanh", "TenChucDanh", cbcd2, comboBoxColumn2);





            msql = "SELECT * FROM [dbo].[ChucDanh]";
            DataTable cbcd3 = comm.GetDataTable(mconnectstring, msql, "");

            DataGridViewComboBoxColumn comboBoxColumn3 = new DataGridViewComboBoxColumn();
            comboBoxColumn3.HeaderText = "Chức Danh";
            comboBoxColumn3.DataPropertyName = "MaChucDanh";
            comboBoxColumn3.Name = "cChucDanh";

            comboBoxColumn3.Width = 400;

            dgrDanhSachMucTieuPhatTrienKPI.Columns.Add(comboBoxColumn3);

            LoadDataIntoComboBoxColumn3("MaChucDanh", "TenChucDanh", cbcd3, comboBoxColumn3);
        }
        private void LoadDataIntoComboBoxColumn(string valueMember, string displayMember, DataTable dataTable, DataGridViewComboBoxColumn comboBoxColumn)
        {
            comboBoxColumn.DataSource = dataTable;
            comboBoxColumn.DisplayMember = displayMember;
            comboBoxColumn.ValueMember = valueMember;
        }
        private void LoadDataIntoComboBoxColumn1(string valueMember1, string displayMember1, DataTable dataTable1, DataGridViewComboBoxColumn comboBoxColumn1)
        {
            comboBoxColumn1.DataSource = dataTable1;
            comboBoxColumn1.DisplayMember = displayMember1;
            comboBoxColumn1.ValueMember = valueMember1;
        }
        private void LoadDataIntoComboBoxColumn2(string valueMember2, string displayMember2, DataTable dataTable2, DataGridViewComboBoxColumn comboBoxColumn2)
        {
            comboBoxColumn2.DataSource = dataTable2;
            comboBoxColumn2.DisplayMember = displayMember2;
            comboBoxColumn2.ValueMember = valueMember2;
        }
        private void LoadDataIntoComboBoxColumn3(string valueMember3, string displayMember3, DataTable dataTable3, DataGridViewComboBoxColumn comboBoxColumn3)
        {
            comboBoxColumn3.DataSource = dataTable3;
            comboBoxColumn3.DisplayMember = displayMember3;
            comboBoxColumn3.ValueMember = valueMember3;
        }
        private void updateCheckbox(int rowIndex)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < dgrDanhSachMucTieuTaiChinhKPI.Rows.Count)
                {
                    string id = dgrDanhSachMucTieuTaiChinhKPI.Rows[rowIndex].Cells["cID"].Value.ToString();

                    string updateQuery = "UPDATE [dbo].[MucTieuKPI] SET MucTieu = 1 WHERE ID = @ID";

                    using (SqlConnection connection = new SqlConnection(mconnectstring))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            int rowsAffected = command.ExecuteNonQuery();


                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid row index.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in updateCheckbox: {ex.Message}");
            }
        }



        private void deleteCheckbox(int rowIndex)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < dgrDanhSachMucTieuTaiChinhKPI.Rows.Count)
                {
                    string id = dgrDanhSachMucTieuTaiChinhKPI.Rows[rowIndex].Cells["cID"].Value.ToString();

                    string updateQuery = "UPDATE [dbo].[MucTieuKPI] SET MucTieu = 0 WHERE ID = @ID";

                    using (SqlConnection connection = new SqlConnection(mconnectstring))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            int rowsAffected = command.ExecuteNonQuery();

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid row index.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in deleteCheckbox: {ex.Message}");
            }
        }





        private void dgrDanhSachMucTieuTaiChinhKPI_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgrDanhSachMucTieuTaiChinhKPI_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgrDanhSachMucTieuTaiChinhKPI.IsCurrentCellDirty)
            {
                int rowIndex = dgrDanhSachMucTieuTaiChinhKPI.CurrentCell.RowIndex;
                int colIndex = dgrDanhSachMucTieuTaiChinhKPI.CurrentCell.ColumnIndex;

                if (colIndex == dgrDanhSachMucTieuTaiChinhKPI.Columns["cMucTieuTC"].Index)
                {
                    DataGridViewCheckBoxCell checkboxCell = dgrDanhSachMucTieuTaiChinhKPI.Rows[rowIndex].Cells["cMucTieuTC"] as DataGridViewCheckBoxCell;
                    bool isChecked = (bool)checkboxCell.EditingCellFormattedValue;

                    if (!isChecked)
                    {
                        deleteCheckbox(rowIndex);
                    }
                    else if (isChecked)
                    {
                        updateCheckbox(rowIndex);
                    }
                }
            }
        }

        private void dgrDanhSachMucTieuTaiChinhKPI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgrDanhSachMucTieuTaiChinhKPI.Columns["cMucTieuTC"].Index)
            {
                dgrDanhSachMucTieuTaiChinhKPI.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

    }
}
