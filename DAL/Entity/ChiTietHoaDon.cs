/*generate by tool EntityGenerate
 *Author:ManhTe
 * Recommend NetFramework 4.6 or later
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Kho
{
    public class ChiTietHoaDon
    {
		public  ChiTietHoaDon(){}
		#region Định nghĩa  ChiTietHoaDon

		[Required(ErrorMessage = @"MaChiTiet is required.")]
		public long MaChiTiet { get; set; }//Size:0

		public long? MaHoaDon { get; set; }//Size:0

		[Required(ErrorMessage = @"MaSanPham is required.")]
		public long MaSanPham { get; set; }//Size:0

		[Required(ErrorMessage = @"MaDonViTinh is required.")]
		public int MaDonViTinh { get; set; }//Size:0

		public int? SoLuong { get; set; }//Size:0

		public double? ChietKhauHoaDon { get; set; }//Size:0

		public decimal? TienNhan { get; set; }//Size:0

		public int? NguoiThayDoi { get; set; }//Size:0

		public DateTime? ThoiGianThayDoi { get; set; }//Size:0


		#endregion

		public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}