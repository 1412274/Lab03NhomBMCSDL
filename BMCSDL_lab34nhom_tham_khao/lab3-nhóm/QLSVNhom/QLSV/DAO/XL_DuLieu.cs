using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DTO;


namespace QLSV.DAO
{
    class XL_DuLieu
    {
        static string provider = "Data Source=.;Initial Catalog = QLSVNhom; Integrated Security = True";
        SqlConnection conn = new SqlConnection(provider);

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            return dt;
        }

        public void Execute(string sql)
        {
            try
            {

                SqlCommand com = new SqlCommand(sql, conn);
                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
        }

        public void callInsertOrUpdateProc(String procName,SinhVien sv)
        {
            SqlCommand queryCM = new SqlCommand(procName, conn);
            queryCM.CommandType = CommandType.StoredProcedure;
            SqlParameter maSV = queryCM.Parameters.Add("@MASV", SqlDbType.NVarChar, 20);
            SqlParameter hoTen = queryCM.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 100);
            SqlParameter ngaySinh = queryCM.Parameters.Add("@NGAYSINH", SqlDbType.DateTime);
            SqlParameter diaChi = queryCM.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 200);
            SqlParameter maLop = queryCM.Parameters.Add("@MALOP", SqlDbType.VarChar, 20);
            SqlParameter tenDn = queryCM.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100);
            SqlParameter matKhau = queryCM.Parameters.Add("@MATKHAU", SqlDbType.VarChar, 100);
            
            maSV.Value = sv.MaSV;
            hoTen.Value = sv.HoTen;
            ngaySinh.Value = sv.NgaySinh;
            diaChi.Value = sv.DiaChi;
            maLop.Value = sv.MaLop;
            tenDn.Value = sv.TenDN;
            matKhau.Value = sv.MatKhau;
           
            conn.Open();
            queryCM.ExecuteNonQuery();
            conn.Close();
        }

        public void callInsertProc(String procName, NhanVien nv)
        {
            SqlCommand queryCM = new SqlCommand(procName, conn);
            queryCM.CommandType = CommandType.StoredProcedure;
            SqlParameter maNV = queryCM.Parameters.Add("@MANV", SqlDbType.VarChar, 20);
            SqlParameter hoTen = queryCM.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 100);
            SqlParameter email = queryCM.Parameters.Add("@EMAIL", SqlDbType.VarChar,20);
            SqlParameter luong = queryCM.Parameters.Add("@LUONG", SqlDbType.VarChar, 100);
            SqlParameter tenDn = queryCM.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100);
            SqlParameter matKhau = queryCM.Parameters.Add("@MK", SqlDbType.NVarChar, 100);

            maNV.Value = nv.MaNV;
            hoTen.Value = nv.HoTen;
            email.Value = nv.Email;
            luong.Value = nv.Luong;
            tenDn.Value = nv.TenDN;
            matKhau.Value = nv.MatKhau;

            conn.Open();
            queryCM.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable callSelectProc(String procName, String tenDN, String matKhau)
        {
            SqlCommand queryCM = new SqlCommand(procName, conn);
            queryCM.CommandType = CommandType.StoredProcedure;
            SqlParameter tenDn = queryCM.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100);
            SqlParameter pass = queryCM.Parameters.Add("@MK", SqlDbType.NVarChar, 100);

            tenDn.Value = tenDN;
            pass.Value = matKhau;

            conn.Open();

            DataTable dt = new DataTable();

            dt.Load(queryCM.ExecuteReader());
            conn.Close();
            return dt;
        }


    }
}
