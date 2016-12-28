
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class ReadNhaCungCap:DbInfor
    {
		#region Đọc dữ liệu bảng NhaCungCap
		static List<NhaCungCap> infor =null;
        public static List<NhaCungCap> ReadingNhaCungCap()
        {
            const string querystring = "Select MaNCC, TenNCC, SDT, Email, DiaChi, NguoiDaiDien, Fax, TrangThai from NhaCungCap";
			infor =new List<NhaCungCap>();
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
							var entity = new NhaCungCap();
							entity.MaNCC = reader["MaNCC"] as int? ?? default(int);
							entity.TenNCC = reader["TenNCC"] as string;
							entity.SDT = reader["SDT"] as string;
							entity.Email = reader["Email"] as string;
							entity.DiaChi = reader["DiaChi"] as string;
							entity.NguoiDaiDien = reader["NguoiDaiDien"] as string;
							entity.Fax = reader["Fax"] as string;
							entity.TrangThai = reader["TrangThai"] as bool? ?? default(bool);

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
