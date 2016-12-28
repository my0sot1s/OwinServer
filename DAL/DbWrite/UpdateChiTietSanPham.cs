/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class UpdateChiTietSanPham:UpdateDefined
    {
		#region Thêm dữ liệu vào ChiTietSanPham
        public override int Insert(object data)
        {
            try
            {
                var temp = (ChiTietSanPham)data;
                const string query = @"Insert into ChiTietSanPham (MaChiTiet,NgayNhap,HanDung,NgaySX,ngayNhapKho) values (@MaChiTiet,@NgayNhap,@HanDung,@NgaySX,@ngayNhapKho)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaChiTiet",temp.MaChiTiet  as long? ?? default(long));
						command.Parameters.AddWithValue("@NgayNhap",temp.NgayNhap  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@HanDung",temp.HanDung  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@NgaySX",temp.NgaySX  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@ngayNhapKho",temp.ngayNhapKho  as DateTime? ?? default(DateTime));

                        connection.Open();
                        var i=command.ExecuteNonQuery();
                        connection.Close();
                        return i;
                    }
                }
            }
            catch (Exception)
            {
                return -1;   
                throw;
            }
        }
		#endregion
        
		#region Sửa dữ liệu ChiTietSanPham
        public override bool Update(object data)
        {

            try
            {
                var temp = (ChiTietSanPham)data;
                const string query = @"Update ChiTietSanPham set NgayNhap = @NgayNhap,HanDung = @HanDung,NgaySX = @NgaySX,ngayNhapKho = @ngayNhapKho where  MaChiTiet = @MaChiTiet ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaChiTiet",temp.MaChiTiet  as long? ?? default(long));
						command.Parameters.AddWithValue("@NgayNhap",temp.NgayNhap  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@HanDung",temp.HanDung  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@NgaySX",temp.NgaySX  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@ngayNhapKho",temp.ngayNhapKho  as DateTime? ?? default(DateTime));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
		#endregion

		#region Xóa dữ liệu cho ChiTietSanPham
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete ChiTietSanPham where  MaChiTiet = @MaChiTiet ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaChiTiet",key  as long? ?? default(long));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
		#endregion
    }
}