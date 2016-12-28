using DbGenerate.Kho;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        public static void  InitMemory()
        {
            #region lấy dữ liệu vào Memory từ Db
            ReadChiTietSanPham.ReadingChiTietSanPham().ForEach( obj => { ChiTietSanPhamDic.Add(obj.MaChiTiet, obj);} );

            ReadNhaCungCap.ReadingNhaCungCap().ForEach( obj => { NhaCungCapDic.Add(obj.MaNCC, obj);} );

            ReadDonViTinh.ReadingDonViTinh().ForEach( obj => { DonViTinhDic.Add(obj.MaDVT, obj);} );

            ReadSanPham.ReadingSanPham().ForEach( obj => { SanPhamDic.Add(obj.MaSanPham, obj);} );

            ReadHoaDon.ReadingHoaDon().ForEach( obj => { HoaDonDic.Add(obj.MaHoaDon, obj);} );

            ReadChiTietHoaDon.ReadingChiTietHoaDon().ForEach( obj => { ChiTietHoaDonDic.Add(obj.MaChiTiet, obj);} );

                
            #endregion
        }
        
    }
}