using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Kho;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        #region Set Gía trị từng Field
        public static void SetMemory(ChiTietSanPham dic)
        {
			if (!ChiTietSanPhamDic.ContainsKey(dic.MaChiTiet))
            {
                _ChiTietSanPhamUpdate.Insert(dic);
            }
            else
            {
                _ChiTietSanPhamUpdate.Update(dic);
            }
            ChiTietSanPhamDic[dic.MaChiTiet] = dic;
        }
        public static void SetMemory(NhaCungCap dic)
        {
			if (!NhaCungCapDic.ContainsKey(dic.MaNCC))
            {
                _NhaCungCapUpdate.Insert(dic);
            }
            else
            {
                _NhaCungCapUpdate.Update(dic);
            }
            NhaCungCapDic[dic.MaNCC] = dic;
        }
        public static void SetMemory(DonViTinh dic)
        {
			if (!DonViTinhDic.ContainsKey(dic.MaDVT))
            {
                _DonViTinhUpdate.Insert(dic);
            }
            else
            {
                _DonViTinhUpdate.Update(dic);
            }
            DonViTinhDic[dic.MaDVT] = dic;
        }
        public static void SetMemory(SanPham dic)
        {
			if (!SanPhamDic.ContainsKey(dic.MaSanPham))
            {
                _SanPhamUpdate.Insert(dic);
            }
            else
            {
                _SanPhamUpdate.Update(dic);
            }
            SanPhamDic[dic.MaSanPham] = dic;
        }
        public static void SetMemory(HoaDon dic)
        {
			if (!HoaDonDic.ContainsKey(dic.MaHoaDon))
            {
                _HoaDonUpdate.Insert(dic);
            }
            else
            {
                _HoaDonUpdate.Update(dic);
            }
            HoaDonDic[dic.MaHoaDon] = dic;
        }
        public static void SetMemory(ChiTietHoaDon dic)
        {
			if (!ChiTietHoaDonDic.ContainsKey(dic.MaChiTiet))
            {
                _ChiTietHoaDonUpdate.Insert(dic);
            }
            else
            {
                _ChiTietHoaDonUpdate.Update(dic);
            }
            ChiTietHoaDonDic[dic.MaChiTiet] = dic;
        }

        #endregion
        
        #region SetAll
            
        #endregion
    }
}
