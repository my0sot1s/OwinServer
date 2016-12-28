/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DbGenerate.Kho
{
    public class UpdateChiTietHoaDon:UpdateDefined
    {
		#region Thêm dữ liệu vào ChiTietHoaDon
        public override int Insert(object data)
        {
            try
            {
                var temp = (ChiTietHoaDon)data;
                const string query = @"Insert into ChiTietHoaDon (MaChiTiet,MaHoaDon,MaSanPham,MaDonViTinh,SoLuong,ChietKhauHoaDon,TienNhan,NguoiThayDoi,ThoiGianThayDoi) values (@MaChiTiet,@MaHoaDon,@MaSanPham,@MaDonViTinh,@SoLuong,@ChietKhauHoaDon,@TienNhan,@NguoiThayDoi,@ThoiGianThayDoi)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaChiTiet",temp.MaChiTiet  as long? ?? default(long));
						command.Parameters.AddWithValue("@MaHoaDon",temp.MaHoaDon  as long? ?? default(long));
						command.Parameters.AddWithValue("@MaSanPham",temp.MaSanPham  as long? ?? default(long));
						command.Parameters.AddWithValue("@MaDonViTinh",temp.MaDonViTinh  as int? ?? default(int));
						command.Parameters.AddWithValue("@SoLuong",temp.SoLuong  as int? ?? default(int));
						command.Parameters.AddWithValue("@ChietKhauHoaDon",temp.ChietKhauHoaDon  as double? ?? default(double));
						command.Parameters.AddWithValue("@TienNhan",temp.TienNhan  as decimal? ?? default(decimal));
						command.Parameters.AddWithValue("@NguoiThayDoi",temp.NguoiThayDoi  as int? ?? default(int));
						command.Parameters.AddWithValue("@ThoiGianThayDoi",temp.ThoiGianThayDoi  as DateTime? ?? default(DateTime));

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
        
		#region Sửa dữ liệu ChiTietHoaDon
        public override bool Update(object data)
        {

            try
            {
                var temp = (ChiTietHoaDon)data;
                const string query = @"Update ChiTietHoaDon set MaHoaDon = @MaHoaDon,MaSanPham = @MaSanPham,MaDonViTinh = @MaDonViTinh,SoLuong = @SoLuong,ChietKhauHoaDon = @ChietKhauHoaDon,TienNhan = @TienNhan,NguoiThayDoi = @NguoiThayDoi,ThoiGianThayDoi = @ThoiGianThayDoi where  MaChiTiet = @MaChiTiet ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@MaChiTiet",temp.MaChiTiet  as long? ?? default(long));
						command.Parameters.AddWithValue("@MaHoaDon",temp.MaHoaDon  as long? ?? default(long));
						command.Parameters.AddWithValue("@MaSanPham",temp.MaSanPham  as long? ?? default(long));
						command.Parameters.AddWithValue("@MaDonViTinh",temp.MaDonViTinh  as int? ?? default(int));
						command.Parameters.AddWithValue("@SoLuong",temp.SoLuong  as int? ?? default(int));
						command.Parameters.AddWithValue("@ChietKhauHoaDon",temp.ChietKhauHoaDon  as double? ?? default(double));
						command.Parameters.AddWithValue("@TienNhan",temp.TienNhan  as decimal? ?? default(decimal));
						command.Parameters.AddWithValue("@NguoiThayDoi",temp.NguoiThayDoi  as int? ?? default(int));
						command.Parameters.AddWithValue("@ThoiGianThayDoi",temp.ThoiGianThayDoi  as DateTime? ?? default(DateTime));

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

		#region Xóa dữ liệu cho ChiTietHoaDon
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete ChiTietHoaDon where  MaChiTiet = @MaChiTiet ";
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