
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class ReadChiTietSanPham:DbInfor
    {
		#region Đọc dữ liệu bảng ChiTietSanPham
		static List<ChiTietSanPham> infor =null;
        public static List<ChiTietSanPham> ReadingChiTietSanPham()
        {
            const string querystring = "Select MaChiTiet, NgayNhap, HanDung, NgaySX, ngayNhapKho from ChiTietSanPham";
			infor =new List<ChiTietSanPham>();
            if (infor.Count == 0)
            {
				using (SqlConnection connection =new SqlConnection(connectionString))
				{
					using (SqlCommand command = new SqlCommand(querystring, connection))
					{
						connection.Open();
						SqlDataReader reader = command.ExecuteReader();
						while (reader.Read())
						{
							var entity = new ChiTietSanPham();
							entity.MaChiTiet = reader["MaChiTiet"] as long? ?? default(long);
							entity.NgayNhap = reader["NgayNhap"] as DateTime? ?? default(DateTime);
							entity.HanDung = reader["HanDung"] as DateTime? ?? default(DateTime);
							entity.NgaySX = reader["NgaySX"] as DateTime? ?? default(DateTime);
							entity.ngayNhapKho = reader["ngayNhapKho"] as DateTime? ?? default(DateTime);

							infor.Add(entity);
						}
					}
				}
			}

			return infor;
		}
		#endregion
    }
}
