/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class UpdateHoaDon:UpdateDefined
    {
		#region Thêm dữ liệu vào HoaDon
        public override int Insert(object data)
        {
            try
            {
                var temp = (HoaDon)data;
                const string query = @"Insert into HoaDon (MaHoaDon,LoaiHoaDon,NgayTiepNhan,NgayHoanTat,NhanVienXacNhan) values (@MaHoaDon,@LoaiHoaDon,@NgayTiepNhan,@NgayHoanTat,@NhanVienXacNhan)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaHoaDon",temp.MaHoaDon  as long? ?? default(long));
						command.Parameters.AddWithValue("@LoaiHoaDon",temp.LoaiHoaDon  as int? ?? default(int));
						command.Parameters.AddWithValue("@NgayTiepNhan",temp.NgayTiepNhan  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@NgayHoanTat",temp.NgayHoanTat  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@NhanVienXacNhan",temp.NhanVienXacNhan  as string);

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
        
		#region Sửa dữ liệu HoaDon
        public override bool Update(object data)
        {

            try
            {
                var temp = (HoaDon)data;
                const string query = @"Update HoaDon set LoaiHoaDon = @LoaiHoaDon,NgayTiepNhan = @NgayTiepNhan,NgayHoanTat = @NgayHoanTat,NhanVienXacNhan = @NhanVienXacNhan where  MaHoaDon = @MaHoaDon ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaHoaDon",temp.MaHoaDon  as long? ?? default(long));
						command.Parameters.AddWithValue("@LoaiHoaDon",temp.LoaiHoaDon  as int? ?? default(int));
						command.Parameters.AddWithValue("@NgayTiepNhan",temp.NgayTiepNhan  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@NgayHoanTat",temp.NgayHoanTat  as DateTime? ?? default(DateTime));
						command.Parameters.AddWithValue("@NhanVienXacNhan",temp.NhanVienXacNhan  as string);

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

		#region Xóa dữ liệu cho HoaDon
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete HoaDon where  MaHoaDon = @MaHoaDon ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaHoaDon",key  as long? ?? default(long));

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