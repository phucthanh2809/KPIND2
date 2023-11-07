using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_QuanLyKPI.Constants
{
    class DataUserCurrent
    {
        private static DataUserCurrent _instance;
        public static DataUserCurrent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataUserCurrent();
                }
                return _instance;
            }
        }

        private DataUserCurrent() { }

        // Thêm các thuộc tính để lưu trữ thông tin của bạn
        public string IDUserCurrent { get; set; }
        public string Permission { get; set; }
    }
}
