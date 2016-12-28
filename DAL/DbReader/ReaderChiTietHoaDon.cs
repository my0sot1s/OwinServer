
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class ReadChiTietHoaDon:DbInfor
    {
		#region Đọc dữ liệu bảng ChiTietHoaDon
		static List<ChiTietHoaDon> infor =null;
        public static List<ChiTietHoaDon> ReadingChiTietHoaDon()
        {
            const string querystring = "Select MaChiTiet, MaHoaDon, MaSanPham, MaDonViTinh, SoLuong, ChietKhauHoaDon, TienNhan, NguoiThayDoi, ThoiGianThayDoi from ChiTietHoaDon";
			infor =new List<ChiTietHoaDon>();
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
							var entity = new ChiTietHoaDon();
							entity.MaChiTiet = reader["MaChiTiet"] as long? ?? default(long);
							entity.MaHoaDon = reader["MaHoaDon"] as long? ?? default(long);
							entity.MaSanPham = reader["MaSanPham"] as long? ?? default(long);
							entity.MaDonViTinh = reader["MaDonViTinh"] as int? ?? default(int);
							entity.SoLuong = reader["SoLuong"] as int? ?? default(int);
							entity.ChietKhauHoaDon = reader["ChietKhauHoaDon"] as double? ?? default(double);
							entity.TienNhan = reader["TienNhan"] as decimal? ?? default(decimal);
							entity.NguoiThayDoi = reader["NguoiThayDoi"] as int? ?? default(int);
							entity.ThoiGianThayDoi = reader["ThoiGianThayDoi"] as DateTime? ?? default(DateTime);

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
