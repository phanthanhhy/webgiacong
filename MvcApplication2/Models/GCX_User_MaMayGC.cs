using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class GCX_User_MaMayGC
    {
        public class GiaCongXuong_NhanVien
        {
            public Nullable<int> STTNhanVien { get; set; }
            public string Tenuser { get; set; }
            public string nvUser { get; set; }
            public string STTTB { get; set; }
        }

        public class GiaCongXuong_User_MayMay
        {
            public string MaMayGC { get; set; }
            public string TenThietBiGC { get; set; }
            public Nullable<int> STT { get; set; }
            public IEnumerable<GiaCongXuong_NhanVien> gcxChiTiets { get; set; }
        }
    }
}