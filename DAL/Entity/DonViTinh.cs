/*generate by tool EntityGenerate
 *Author:ManhTe
 * Recommend NetFramework 4.6 or later
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Kho
{
    public class DonViTinh
    {
		public  DonViTinh(){}
		#region Định nghĩa  DonViTinh

		[Required(ErrorMessage = @"MaDVT is required.")]
		public int MaDVT { get; set; }//Size:0

		[MaxLength(50,ErrorMessage = (@"Max of TenDVT is 50 out of range"))]
		public string TenDVT { get; set; }//Size:50

		[MaxLength(50,ErrorMessage = (@"Max of MoTa is 50 out of range"))]
		public string MoTa { get; set; }//Size:50

		public bool? TrangThai { get; set; }//Size:0


		#endregion

		public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}