/*generate by tool EntityGenerate
 *Author:ManhTe
 * Recommend NetFramework 4.6 or later
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Kho
{
    public class ChiTietSanPham
    {
		public  ChiTietSanPham(){}
		#region Định nghĩa  ChiTietSanPham

		[Required(ErrorMessage = @"MaChiTiet is required.")]
		public long MaChiTiet { get; set; }//Size:0

		public DateTime? NgayNhap { get; set; }//Size:0

		public DateTime? HanDung { get; set; }//Size:0

		public DateTime? NgaySX { get; set; }//Size:0

		public DateTime? ngayNhapKho { get; set; }//Size:0


		#endregion

		public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}