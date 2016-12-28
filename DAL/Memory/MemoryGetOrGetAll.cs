using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Kho;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        #region Lấy theo mã
        public static ChiTietSanPham GetChiTietSanPham(long chitietsanpham)
        {
            if (ChiTietSanPhamDic.ContainsKey(chitietsanpham))
                return ChiTietSanPhamDic[chitietsanpham].Clone() as ChiTietSanPham;
            return null;
        }
        public static NhaCungCap GetNhaCungCap(int nhacungcap)
        {
            if (NhaCungCapDic.ContainsKey(nhacungcap))
                return NhaCungCapDic[nhacungcap].Clone() as NhaCungCap;
            return null;
        }
        public static DonViTinh GetDonViTinh(int donvitinh)
        {
            if (DonViTinhDic.ContainsKey(donvitinh))
                return DonViTinhDic[donvitinh].Clone() as DonViTinh;
            return null;
        }
        public static SanPham GetSanPham(long sanpham)
        {
            if (SanPhamDic.ContainsKey(sanpham))
                return SanPhamDic[sanpham].Clone() as SanPham;
            return null;
        }
        public static HoaDon GetHoaDon(long hoadon)
        {
            if (HoaDonDic.ContainsKey(hoadon))
                return HoaDonDic[hoadon].Clone() as HoaDon;
            return null;
        }
        public static ChiTietHoaDon GetChiTietHoaDon(long chitiethoadon)
        {
            if (ChiTietHoaDonDic.ContainsKey(chitiethoadon))
                return ChiTietHoaDonDic[chitiethoadon].Clone() as ChiTietHoaDon;
            return null;
        }

        #endregion
        
        #region Lấy tất cả List
        public static List<ChiTietSanPham> GetAllChiTietSanPham()
        {
            return ChiTietSanPhamDic.Select(obj => obj.Value.Clone() as ChiTietSanPham).ToList();
        }
        public static List<NhaCungCap> GetAllNhaCungCap()
        {
            return NhaCungCapDic.Select(obj => obj.Value.Clone() as NhaCungCap).ToList();
        }
        public static List<DonViTinh> GetAllDonViTinh()
        {
            return DonViTinhDic.Select(obj => obj.Value.Clone() as DonViTinh).ToList();
        }
        public static List<SanPham> GetAllSanPham()
        {
            return SanPhamDic.Select(obj => obj.Value.Clone() as SanPham).ToList();
        }
        public static List<HoaDon> GetAllHoaDon()
        {
            return HoaDonDic.Select(obj => obj.Value.Clone() as HoaDon).ToList();
        }
        public static List<ChiTietHoaDon> GetAllChiTietHoaDon()
        {
            return ChiTietHoaDonDic.Select(obj => obj.Value.Clone() as ChiTietHoaDon).ToList();
        }

        #endregion
        
    }
}
