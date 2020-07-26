using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class GiaCongXuongMutilTable
    {
        public Nullable<int> IDPhanHoi { get; set; }
        public string MaHangMuc { get; set; }
        public string TenHangMuc { get; set; }
        public string DKN { get; set; }
        public string DKT { get; set; }
        public string DAI { get; set; }
        public string Dai2 { get; set; }
        public string Rong2 { get; set; }
        public string Day2 { get; set; }
        public string DVT { get; set; }
        public string Hieu { get; set; }
        public string VatLieu { get; set; }
        public float SoLuong { get; set; }
        public string MaMay { get; set; }
        public string TenMay { get; set; }
        public DateTime NgayHoanThanhDuKien { get; set; }
        public DateTime NgayLapGCX { get; set; }
        public string NguoiLapVTHT { get; set; }
        //public IEnumerable<GiaCongXuongMutilTableDetail> gcxChiTiets { get; set; }
    }

    public class GiaCongXuongMutilTableDetail
    {
        public string MaMayGC { get; set; }
        public string TenMayGC { get; set; }
        public string SoGio { get; set; }
        public DateTime NgayHoanThanh { get; set; }
        public decimal SoLuong { get; set; }
        public decimal SoLuongCL { get; set; }
        public string GhiChu { get; set; }

        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public string NV { get; set; }
        public string MaMayTT { get; set; }
        public string TenMayTT { get; set; }
        public decimal SoGioTT { get; set; }
        public decimal SoGioCa { get; set; }
        public decimal SoCa { get; set; }

        public Nullable<int> IDPhanHoi { get; set; }
        public Nullable<int> STTGiaCong { get; set; }

        public string TinhTrangDuyetVatTu { get; set; }
        public string NguoiLapVatTu { get; set; }

        public string CoGC { get; set; }

        public Nullable<int> STT { get; set; }
        public IEnumerable<GiaCongXuongMutilTable> gcxChiTiets { get; set; }
    }


}