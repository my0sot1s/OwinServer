/*generate by tool EntityGenerate
 *Author:ManhTe
 * Recommend NetFramework 4.6 or later
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Kho
{
    public class NhaCungCap
    {
		public  NhaCungCap(){}
		#region Định nghĩa  NhaCungCap

		[Required(ErrorMessage = @"MaNCC is required.")]
		public int MaNCC { get; set; }//Size:0

		[MaxLength(50,ErrorMessage = (@"Max of TenNCC is 50 out of range"))]
		public string TenNCC { get; set; }//Size:50

		[MaxLength(20,ErrorMessage = (@"Max of SDT is 20 out of range"))]
		public string SDT { get; set; }//Size:20

		[MaxLength(250,ErrorMessage = (@"Max of Email is 250 out of range"))]
		public string Email { get; set; }//Size:250

		[MaxLength(250,ErrorMessage = (@"Max of DiaChi is 250 out of range"))]
		public string DiaChi { get; set; }//Size:250

		[MaxLength(50,ErrorMessage = (@"Max of NguoiDaiDien is 50 out of range"))]
		public string NguoiDaiDien { get; set; }//Size:50

		[MaxLength(20,ErrorMessage = (@"Max of Fax is 20 out of range"))]
		public string Fax { get; set; }//Size:20

		public bool? TrangThai { get; set; }//Size:0


		#endregion

		public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}