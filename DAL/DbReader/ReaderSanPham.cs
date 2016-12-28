
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class ReadSanPham:DbInfor
    {
		#region Đọc dữ liệu bảng SanPham
		static List<SanPham> infor =null;
        public static List<SanPham> ReadingSanPham()
        {
            const string querystring = "Select MaSanPham, TenSanPham, MaChiTiet, ChietKhau, SoLuong, GiaNhap, MaNCC, Status from SanPham";
			infor =new List<SanPham>();
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
							var entity = new SanPham();
							entity.MaSanPham = reader["MaSanPham"] as long? ?? default(long);
							entity.TenSanPham = reader["TenSanPham"] as string;
							entity.MaChiTiet = reader["MaChiTiet"] as long? ?? default(long);
							entity.ChietKhau = reader["ChietKhau"] as double? ?? default(double);
							entity.SoLuong = reader["SoLuong"] as int? ?? default(int);
							entity.GiaNhap = reader["GiaNhap"] as decimal? ?? default(decimal);
							entity.MaNCC = reader["MaNCC"] as int? ?? default(int);
							entity.Status = reader["Status"] as bool? ?? default(bool);

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
