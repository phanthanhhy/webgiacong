using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class LichGiaCongController : Controller
    {
        //
        // GET: /LichGiaCong/

        public ActionResult Index()
        {
            if (@Session["nvUser"] != null)
            {
                string currentUser = @Session["nvUser"].ToString();
                List<string> listMaMay = new List<string>();
                khovatEntities db = new khovatEntities();
                List<GCX_TienDoGiaCongXuong_Tong> gcx_tong = db.GCX_TienDoGiaCongXuong_Tong.ToList();
                List<GCX_TienDoGiaCongXuong_ChiTiet> gcx_chiTiet = db.GCX_TienDoGiaCongXuong_ChiTiet.ToList();

                List<GCX_NhanVienDieuKhien> gcx_nvdk = db.GCX_NhanVienDieuKhien.Where(x => x.nvUser == currentUser).ToList();

                foreach (var nvdk in gcx_nvdk)
                {
                    List<GCX_DM_ThietBi> gcx_dmtb = db.GCX_DM_ThietBi.Where(x => x.STT == nvdk.STTTB).ToList();
                    for (int i = 0; i < gcx_dmtb.Count; i++)
                    {
                        listMaMay.Add(gcx_dmtb[i].MaMayGC);
                    }
                }

                List<GCX_TienDoGiaCongXuong_ChiTiet> gcx_chiTiet2 = db.GCX_TienDoGiaCongXuong_ChiTiet.Where(x => listMaMay.Any(maMay => x.MaMayGC.Contains(maMay)) && x.CoGC == "SGC").ToList();
                //GiaCongXuongMutilTable gcx_list = new GiaCongXuongMutilTable();

                GiaCongXuongMutilTableDetail gcx_list = new GiaCongXuongMutilTableDetail();
                List<GiaCongXuongMutilTableDetail> gcxlist2bang = gcx_chiTiet2.Select(x => new GiaCongXuongMutilTableDetail
                {
                    MaMayGC = x.MaMayGC,
                    TenMayGC = x.TenMayGC,
                    STT = x.STT,
                    IDPhanHoi = x.IDPhanHoi
                }).ToList();
                foreach (var item in gcxlist2bang)
                {
                    List<GiaCongXuongMutilTable> g = gcx_tong.Where(x => x.IDPhanHoi == item.IDPhanHoi)
                        .Select(x => new GiaCongXuongMutilTable
                        {
                            MaHangMuc = x.MaHangMuc,
                            TenHangMuc = x.TenHangMuc,
                            MaMay = x.MaMay,
                            TenMay = x.TenMay,
                            DKN = x.DKN,
                            DKT = x.DKT,
                            DAI = x.DAI,
                            Dai2 = x.Dai2,
                            Rong2 = x.Rong2,
                            Day2 = x.Day2,
                            DVT = x.DVT,
                            SoLuong = (float)x.SoLuong,
                            NgayHoanThanhDuKien = (DateTime)(x.NgayHoanThanhDuKien),
                            NgayLapGCX = (DateTime)x.NgayLapGCX,
                            NguoiLapVTHT = x.NguoiLapVTHT,
                        }).ToList();
                    item.gcxChiTiets = g;
                }
                return View(gcxlist2bang);
            }
            else
            {

                return View();
            }
        }

    }
}
