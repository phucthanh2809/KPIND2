using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Excel;
using BusinessCommon;
using DuAn_QuanLyKPI.Constants;

namespace DuAn_QuanLyKPI
{
    public partial class Frm_ImportExcel_GUI : DevExpress.XtraEditors.XtraForm
    {
        private clsCommonMethod comm = new clsCommonMethod();
        private clsEventArgs ev = new clsEventArgs("");
        public Frm_ImportExcel_GUI()
        {
            InitializeComponent();
            
        }

        void LayDuLieuLoadLenGrid()
        {
            var db = DataProvider.Ins.DB;
            var result = from c in db.ChiTietKPICaNhan
                             //where c.ID > 1 && c.ID <4
                         select c;
            gcData.DataSource = result.ToList();

        }

        #region Biểu mẫu
            public int sobieumau;
            public void LoadBieuMau()
            {
                switch (sobieumau)
                {
                    case 1: LoadBieuMauA71(); break;
                    case 2: LoadBieuMauA72(); break;
                    case 3: LoadBieuMauA73(); break;
                    case 4: LoadBieuMauA74(); break;
                    case 5: LoadBieuMauA75(); break;
                    case 6: LoadBieuMauA76(); break;
                    case 7: LoadBieuMauA77(); break;
                    case 8: LoadBieuMauA78(); break;
                    case 9: LoadBieuMauA79(); break;
                    case 10: LoadBieuMauA710(); break;
                }
            }
        private void LoadBieuMauA71()
        {

        }
        private void LoadBieuMauA72()
        {

        }
        private void LoadBieuMauA73()
        {     

        }
        private void LoadBieuMauA74()
        {

        }
        private void LoadBieuMauA75()
        {

        }
        private void LoadBieuMauA76()
        {

        }
        private void LoadBieuMauA77()
        {

        }
        private void LoadBieuMauA78()
        {

        }
        private void LoadBieuMauA79()
        {

        }
        private void LoadBieuMauA710()
        {

        }
        #endregion
        private void btnTaiFile_Click_1(object sender, EventArgs e)
        {
            //
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "Excel(*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //gán
                txtPath.Text = openFileDialog.FileName;
                //Tiến hàng đọc file Excel 
                ExcelDataSource excel = new ExcelDataSource();
                excel.FileName = txtPath.Text;
                ExcelWorksheetSettings excelWorksheetSettings = new ExcelWorksheetSettings("MyData", "A1:F99");
                excel.SourceOptions = new ExcelSourceOptions(excelWorksheetSettings);
                excel.SourceOptions = new CsvSourceOptions() { CellRange = "A1:F99" };
                //Không lấy cái vùng trống
                excel.SourceOptions.SkipEmptyRows = false;
                //lấy tiêu đề của cột để làm tiêu đề cho lưới
                excel.SourceOptions.UseFirstRowAsHeader = true;
                excel.Fill();
                gcData.DataSource = excel;
            }
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            //gcData.ExportToXlsx(Application.StartupPath + @"\DanhSach.xlsx");
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Word 2007 of higher(.docx) | *.docx";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                gcData.ExportToDocx(sf.FileName);
            }
        }

        private void btnExxportPDF_Click(object sender, EventArgs e)
        {
            {
                //gcData.ExportToXlsx(Application.StartupPath + @"\DanhSach.xlsx");
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF file (.pdf) | *.pdf";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    gcData.ExportToPdf(sf.FileName);
                }
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //gcData.ExportToXlsx(Application.StartupPath + @"\DanhSach.xlsx");
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel 2007 of higher(.xlsx) | *.xlsx";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                gcData.ExportToXlsx(sf.FileName);
            }
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã nhân viên";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ tên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày sinh";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Giới tính";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Phòng ban";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Chức vụ";

            cl6.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Tình trạng";

            cl7.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void btnGuiDi_Click(object sender, EventArgs e)
        {
            LoadBieuMauA73();
            //if(ev.QFrmThongBao_YesNo("Bạn có muốn xác nhận gửi đi không?"))
            //{

            //}   
            //else
            //{
            //    //
            //}    
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (ev.QFrmThongBao_YesNo("Bạn có muốn xác nhận gửi đi không?"))
            {

            }
            else
            {
                //
            }
        }
    }
}