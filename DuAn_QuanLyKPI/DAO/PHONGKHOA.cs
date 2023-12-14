using DuAn_QuanLyKPI.DTO;
using PhanMemQuanLyKPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKPI.DAO
{
    public class PHONGKHOA
    {
        QuanLyKPIEntities db;
        public PHONGKHOA()
        {
            db = new QuanLyKPIEntities();
        }

        public List<PhongKhoa> getList()
        {
            return db.PhongKhoa.ToList();
        }

        public List<KPI_BENHVIEN_DTO> getFull()
        {
            var lstKPIBV = db.KPI_BenhVien.ToList();
            List<KPI_BENHVIEN_DTO> lstDTO = new List<KPI_BENHVIEN_DTO>();
            KPI_BENHVIEN_DTO kpiDTO;
            ChiTietKPIBenhVien _ctbv = new ChiTietKPIBenhVien();
            ChiTietTieuChiMucTieuBV _ctmcbv = new ChiTietTieuChiMucTieuBV();
            KPI _kpi = new KPI();
            NhomTieuChi _tc = new NhomTieuChi();
            foreach (var item in lstKPIBV)
            {
                kpiDTO = new KPI_BENHVIEN_DTO();
                _ctbv = new ChiTietKPIBenhVien();
                _ctmcbv = new ChiTietTieuChiMucTieuBV();
                _kpi = new KPI();
                kpiDTO.MaPhieuKPIBV = item.MaPhieuKPIBV;
                var itemCTBV = db.ChiTietKPIBenhVien.FirstOrDefault(x => x.MaPhieuKPIBV == item.MaPhieuKPIBV);
                kpiDTO.KeHoach = itemCTBV.KeHoach;
                kpiDTO.ThucHien = (float?)itemCTBV.ThucHien;
                kpiDTO.KetQua = (float?)itemCTBV.KetQua;
                var itemKPI = db.KPI.FirstOrDefault(x => x.MaKPI == itemCTBV.MaKPI);
                kpiDTO.PhuongPhapDo = itemKPI.PhuongPhapDo;
                kpiDTO.DonViTinh = itemKPI.DonViTinh;

                lstDTO.Add(kpiDTO);
            }
            return lstDTO;

        }
    }
}
