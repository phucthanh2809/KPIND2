using DuAn_QuanLyKPI.GUI;
using PhanMemQuanLyKPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace DuAn_QuanLyKPI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //Khai báo biến để hạn chế mở phần mềm 2 lần cùng lúc 
        public const int ALLOW_INSTANCE = 1;
        static Semaphore semaphore = new Semaphore(ALLOW_INSTANCE, ALLOW_INSTANCE, "KPI");

        [STAThread]
        static void Main()
        {            

            bool createdNew = false;
            try
            {
                createdNew = semaphore.WaitOne(0, false);
            }
            catch (AbandonedMutexException)
            {
                createdNew = true;
            }

            if (createdNew)
            {
                try
                {
                    Application.EnableVisualStyles();
                    
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Tạo đường kết nối cho excute sql tạo mã phiếu 
                    SQLHelper.DATABASE = "QuanLyKPI";
                    SQLHelper.USERNAME_DB = "sa";
                    SQLHelper.PASSWORD_DB = "123";
                    SQLHelper.SERVER_NAME = "192.168.50.108,1433";
                    SQLHelper.ConnectString();

                    Application.Run(new Frm_AddKPIGrid());
                }
                finally
                {
                    semaphore.Release();
                }
            }
            else
            {
                MessageBox.Show($"Phần mềm này chỉ cho phép chạy {ALLOW_INSTANCE} phần mềm giống nhau cùng 1 lúc ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}