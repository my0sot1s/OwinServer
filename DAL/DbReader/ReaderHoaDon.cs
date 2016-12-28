
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class ReadHoaDon:DbInfor
    {
		#region Đọc dữ liệu bảng HoaDon
		static List<HoaDon> infor =null;
        public static List<HoaDon> ReadingHoaDon()
        {
            const string querystring = "Select MaHoaDon, LoaiHoaDon, NgayTiepNhan, NgayHoanTat, NhanVienXacNhan from HoaDon";
			infor =new List<HoaDon>();
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
							var entity = new HoaDon();
							entity.MaHoaDon = reader["MaHoaDon"] as long? ?? default(long);
							entity.LoaiHoaDon = reader["LoaiHoaDon"] as int? ?? default(int);
							entity.NgayTiepNhan = reader["NgayTiepNhan"] as DateTime? ?? default(DateTime);
							entity.NgayHoanTat = reader["NgayHoanTat"] as DateTime? ?? default(DateTime);
							entity.NhanVienXacNhan = reader["NhanVienXacNhan"] as string;

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
