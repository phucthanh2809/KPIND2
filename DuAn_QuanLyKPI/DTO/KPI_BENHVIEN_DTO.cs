using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKPI.DTO
{
    public class KPI_BENHVIEN_DTO
    {
        public string MaPhieuKPIBV { get; set; }
        public float TrongSo { get; set; }

        public string KeHoach { get; set; }
        public float? ThucHien { get; set; }
        public float? HoanThanh { get; set; }
        public float? KetQua { get; set; }

        public string PhuongPhapDo { get; set; }

        public string DonViTinh { get; set; }
    }
}
