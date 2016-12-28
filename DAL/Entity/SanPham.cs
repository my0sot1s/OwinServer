/*generate by tool EntityGenerate
 *Author:ManhTe
 * Recommend NetFramework 4.6 or later
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Kho
{
    public class SanPham
    {
		public  SanPham(){}
		#region Định nghĩa  SanPham

		[Required(ErrorMessage = @"MaSanPham is required.")]
		public long MaSanPham { get; set; }//Size:0

		[MaxLength(50,ErrorMessage = (@"Max of TenSanPham is 50 out of range"))]
		public string TenSanPham { get; set; }//Size:50

		public long? MaChiTiet { get; set; }//Size:0

		public double? ChietKhau { get; set; }//Size:0

		public int? SoLuong { get; set; }//Size:0

		public decimal? GiaNhap { get; set; }//Size:0

		public int? MaNCC { get; set; }//Size:0

		public bool? Status { get; set; }//Size:0


		#endregion

		public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}