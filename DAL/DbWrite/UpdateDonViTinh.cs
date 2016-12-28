/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class UpdateDonViTinh:UpdateDefined
    {
		#region Thêm dữ liệu vào DonViTinh
        public override int Insert(object data)
        {
            try
            {
                var temp = (DonViTinh)data;
                const string query = @"Insert into DonViTinh (MaDVT,TenDVT,MoTa,TrangThai) values (@MaDVT,@TenDVT,@MoTa,@TrangThai)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaDVT",temp.MaDVT  as int? ?? default(int));
						command.Parameters.AddWithValue("@TenDVT",temp.TenDVT  as string);
						command.Parameters.AddWithValue("@MoTa",temp.MoTa  as string);
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
        
		#region Sửa dữ liệu DonViTinh
        public override bool Update(object data)
        {

            try
            {
                var temp = (DonViTinh)data;
                const string query = @"Update DonViTinh set TenDVT = @TenDVT,MoTa = @MoTa,TrangThai = @TrangThai where  MaDVT = @MaDVT ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaDVT",temp.MaDVT  as int? ?? default(int));
						command.Parameters.AddWithValue("@TenDVT",temp.TenDVT  as string);
						command.Parameters.AddWithValue("@MoTa",temp.MoTa  as string);
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

		#region Xóa dữ liệu cho DonViTinh
        public override bool Delete(object _key)
        {
            try
            {
				var key=(int) _key;
                const string query = @"Delete DonViTinh where  MaDVT = @MaDVT ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaDVT",key  as int? ?? default(int));

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