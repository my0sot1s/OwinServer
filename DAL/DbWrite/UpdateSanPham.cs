/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class UpdateSanPham:UpdateDefined
    {
		#region Thêm dữ liệu vào SanPham
        public override int Insert(object data)
        {
            try
            {
                var temp = (SanPham)data;
                const string query = @"Insert into SanPham (MaSanPham,TenSanPham,MaChiTiet,ChietKhau,SoLuong,GiaNhap,MaNCC,Status) values (@MaSanPham,@TenSanPham,@MaChiTiet,@ChietKhau,@SoLuong,@GiaNhap,@MaNCC,@Status)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaSanPham",temp.MaSanPham  as long? ?? default(long));
						command.Parameters.AddWithValue("@TenSanPham",temp.TenSanPham  as string);
						command.Parameters.AddWithValue("@MaChiTiet",temp.MaChiTiet  as long? ?? default(long));
						command.Parameters.AddWithValue("@ChietKhau",temp.ChietKhau  as double? ?? default(double));
						command.Parameters.AddWithValue("@SoLuong",temp.SoLuong  as int? ?? default(int));
						command.Parameters.AddWithValue("@GiaNhap",temp.GiaNhap  as decimal? ?? default(decimal));
						command.Parameters.AddWithValue("@MaNCC",temp.MaNCC  as int? ?? default(int));
						command.Parameters.AddWithValue("@Status",temp.Status  as bool? ?? default(bool));

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
        
		#region Sửa dữ liệu SanPham
        public override bool Update(object data)
        {

            try
            {
                var temp = (SanPham)data;
                const string query = @"Update SanPham set TenSanPham = @TenSanPham,MaChiTiet = @MaChiTiet,ChietKhau = @ChietKhau,SoLuong = @SoLuong,GiaNhap = @GiaNhap,MaNCC = @MaNCC,Status = @Status where  MaSanPham = @MaSanPham ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaSanPham",temp.MaSanPham  as long? ?? default(long));
						command.Parameters.AddWithValue("@TenSanPham",temp.TenSanPham  as string);
						command.Parameters.AddWithValue("@MaChiTiet",temp.MaChiTiet  as long? ?? default(long));
						command.Parameters.AddWithValue("@ChietKhau",temp.ChietKhau  as double? ?? default(double));
						command.Parameters.AddWithValue("@SoLuong",temp.SoLuong  as int? ?? default(int));
						command.Parameters.AddWithValue("@GiaNhap",temp.GiaNhap  as decimal? ?? default(decimal));
						command.Parameters.AddWithValue("@MaNCC",temp.MaNCC  as int? ?? default(int));
						command.Parameters.AddWithValue("@Status",temp.Status  as bool? ?? default(bool));

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

		#region Xóa dữ liệu cho SanPham
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete SanPham where  MaSanPham = @MaSanPham ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaSanPham",key  as long? ?? default(long));

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