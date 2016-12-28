using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Kho;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        #region Xóa field trong Dic
        public static void RemoveMemory(ChiTietSanPham objectValue)
        {
            if (ChiTietSanPhamDic.ContainsKey(objectValue.MaChiTiet))
			{
				ChiTietSanPhamDic.Remove(objectValue.MaChiTiet);
                _ChiTietSanPhamUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(NhaCungCap objectValue)
        {
            if (NhaCungCapDic.ContainsKey(objectValue.MaNCC))
			{
				NhaCungCapDic.Remove(objectValue.MaNCC);
                _NhaCungCapUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(DonViTinh objectValue)
        {
            if (DonViTinhDic.ContainsKey(objectValue.MaDVT))
			{
				DonViTinhDic.Remove(objectValue.MaDVT);
                _DonViTinhUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(SanPham objectValue)
        {
            if (SanPhamDic.ContainsKey(objectValue.MaSanPham))
			{
				SanPhamDic.Remove(objectValue.MaSanPham);
                _SanPhamUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(HoaDon objectValue)
        {
            if (HoaDonDic.ContainsKey(objectValue.MaHoaDon))
			{
				HoaDonDic.Remove(objectValue.MaHoaDon);
                _HoaDonUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(ChiTietHoaDon objectValue)
        {
            if (ChiTietHoaDonDic.ContainsKey(objectValue.MaChiTiet))
			{
				ChiTietHoaDonDic.Remove(objectValue.MaChiTiet);
                _ChiTietHoaDonUpdate.Delete(objectValue);
			}
                
        }

	 
        #endregion
        
    }
}
