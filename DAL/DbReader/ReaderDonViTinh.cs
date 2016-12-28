
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class ReadDonViTinh:DbInfor
    {
		#region Đọc dữ liệu bảng DonViTinh
		static List<DonViTinh> infor =null;
        public static List<DonViTinh> ReadingDonViTinh()
        {
            const string querystring = "Select MaDVT, TenDVT, MoTa, TrangThai from DonViTinh";
			infor =new List<DonViTinh>();
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
							var entity = new DonViTinh();
							entity.MaDVT = reader["MaDVT"] as int? ?? default(int);
							entity.TenDVT = reader["TenDVT"] as string;
							entity.MoTa = reader["MoTa"] as string;
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
