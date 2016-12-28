/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class UpdateNhaCungCap:UpdateDefined
    {
		#region Thêm dữ liệu vào NhaCungCap
        public override int Insert(object data)
        {
            try
            {
                var temp = (NhaCungCap)data;
                const string query = @"Insert into NhaCungCap (MaNCC,TenNCC,SDT,Email,DiaChi,NguoiDaiDien,Fax,TrangThai) values (@MaNCC,@TenNCC,@SDT,@Email,@DiaChi,@NguoiDaiDien,@Fax,@TrangThai)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaNCC",temp.MaNCC  as int? ?? default(int));
						command.Parameters.AddWithValue("@TenNCC",temp.TenNCC  as string);
						command.Parameters.AddWithValue("@SDT",temp.SDT  as string);
						command.Parameters.AddWithValue("@Email",temp.Email  as string);
						command.Parameters.AddWithValue("@DiaChi",temp.DiaChi  as string);
						command.Parameters.AddWithValue("@NguoiDaiDien",temp.NguoiDaiDien  as string);
						command.Parameters.AddWithValue("@Fax",temp.Fax  as string);
						command.Parameters.AddWithValue("@TrangThai",temp.TrangThai  as bool? ?? default(bool));

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
        
		#region Sửa dữ liệu NhaCungCap
        public override bool Update(object data)
        {

            try
            {
                var temp = (NhaCungCap)data;
                const string query = @"Update NhaCungCap set TenNCC = @TenNCC,SDT = @SDT,Email = @Email,DiaChi = @DiaChi,NguoiDaiDien = @NguoiDaiDien,Fax = @Fax,TrangThai = @TrangThai where  MaNCC = @MaNCC ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaNCC",temp.MaNCC  as int? ?? default(int));
						command.Parameters.AddWithValue("@TenNCC",temp.TenNCC  as string);
						command.Parameters.AddWithValue("@SDT",temp.SDT  as string);
						command.Parameters.AddWithValue("@Email",temp.Email  as string);
						command.Parameters.AddWithValue("@DiaChi",temp.DiaChi  as string);
						command.Parameters.AddWithValue("@NguoiDaiDien",temp.NguoiDaiDien  as string);
						command.Parameters.AddWithValue("@Fax",temp.Fax  as string);
						command.Parameters.AddWithValue("@TrangThai",temp.TrangThai  as bool? ?? default(bool));

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

		#region Xóa dữ liệu cho NhaCungCap
        public override bool Delete(object _key)
        {
            try
            {
				var key=(int) _key;
                const string query = @"Delete NhaCungCap where  MaNCC = @MaNCC ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaNCC",key  as int? ?? default(int));

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