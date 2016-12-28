/*generate by tool EntityGenerate
 *Author:ManhTe
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Kho;

namespace CreateDictionary.Memory
{
    public class Memory
    {
			public static Dictionary<long,ChiTietSanPham> ChiTietSanPhamDic = new Dictionary<long, ChiTietSanPham>();

			public static Dictionary<int,NhaCungCap> NhaCungCapDic = new Dictionary<int, NhaCungCap>();

			public static Dictionary<int,DonViTinh> DonViTinhDic = new Dictionary<int, DonViTinh>();

			public static Dictionary<long,SanPham> SanPhamDic = new Dictionary<long, SanPham>();

			public static Dictionary<long,HoaDon> HoaDonDic = new Dictionary<long, HoaDon>();

			public static Dictionary<long,ChiTietHoaDon> ChiTietHoaDonDic = new Dictionary<long, ChiTietHoaDon>();

            /*
             * Update
             */
			public static UpdateChiTietSanPham _ChiTietSanPhamUpdate = new UpdateChiTietSanPham();

			public static UpdateNhaCungCap _NhaCungCapUpdate = new UpdateNhaCungCap();

			public static UpdateDonViTinh _DonViTinhUpdate = new UpdateDonViTinh();

			public static UpdateSanPham _SanPhamUpdate = new UpdateSanPham();

			public static UpdateHoaDon _HoaDonUpdate = new UpdateHoaDon();

			public static UpdateChiTietHoaDon _ChiTietHoaDonUpdate = new UpdateChiTietHoaDon();


   
    }
}
