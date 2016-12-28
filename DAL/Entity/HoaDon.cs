/*generate by tool EntityGenerate
 *Author:ManhTe
 * Recommend NetFramework 4.6 or later
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Kho
{
    public class HoaDon
    {
		public  HoaDon(){}
		#region Định nghĩa  HoaDon

		[Required(ErrorMessage = @"MaHoaDon is required.")]
		public long MaHoaDon { get; set; }//Size:0

		[Required(ErrorMessage = @"LoaiHoaDon is required.")]
		public int LoaiHoaDon { get; set; }//Size:0

		public DateTime? NgayTiepNhan { get; set; }//Size:0

		public DateTime? NgayHoanTat { get; set; }//Size:0

		[MaxLength(50,ErrorMessage = (@"Max of NhanVienXacNhan is 50 out of range"))]
		public string NhanVienXacNhan { get; set; }//Size:50


		#endregion

		public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}