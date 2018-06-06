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
        public static int MAX = 1024;
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
            SqlCommand com = new SqlCommand(sql, conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
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
            SqlParameter matKhau = queryCM.Parameters.Add("@MATKHAU", SqlDbType.VarBinary, MAX);
            
            maSV.Value = sv.MaSV;
            hoTen.Value = sv.HoTen;
            ngaySinh.Value = sv.NgaySinh;
            diaChi.Value = sv.DiaChi;
            maLop.Value = sv.MaLop;
            tenDn.Value = sv.TenDN;
            matKhau.Value = Security.MD5Hash(sv.MatKhau);
           
            conn.Open();
            queryCM.ExecuteNonQuery();
            conn.Close();
        }

        public void callInsertOrUpdateProc(String procName, NhanVien nv)
        {
            SqlCommand queryCM = new SqlCommand(procName, conn);
            queryCM.CommandType = CommandType.StoredProcedure;
            SqlParameter maNV = queryCM.Parameters.Add("@MANV", SqlDbType.VarChar, 20);
            SqlParameter hoTen = queryCM.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 100);
            SqlParameter email = queryCM.Parameters.Add("@EMAIL", SqlDbType.VarChar,20);
            SqlParameter luong = queryCM.Parameters.Add("@LUONG", SqlDbType.VarBinary, MAX);
            SqlParameter tenDn = queryCM.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100);
            SqlParameter matKhau = queryCM.Parameters.Add("@MK", SqlDbType.VarBinary, MAX);
            SqlParameter publicKey = queryCM.Parameters.Add("@PUB", SqlDbType.VarChar, MAX);

            maNV.Value = nv.MaNV;
            hoTen.Value = nv.HoTen;
            email.Value = nv.Email;

            tenDn.Value = nv.TenDN;

            byte[] matkhau_encrypt = Security.SHA1Hash(nv.MatKhau);
            matKhau.Value = matkhau_encrypt;

            //Tao cap khoa
            String pubKey = EncryptorRSA.createKeyPair(Convert.ToBase64String(matkhau_encrypt));
            luong.Value = EncryptorRSA.RSAencrypt(nv.Luong, pubKey);//ma hoa rsa
            publicKey.Value = pubKey;//pubkey cua rsa de ma hoa 

            conn.Open();
            queryCM.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable callSelectProc(String procName, String tenDN, String matKhau)
        {
            SqlCommand queryCM = new SqlCommand(procName, conn);
            queryCM.CommandType = CommandType.StoredProcedure;
            SqlParameter tenDn = queryCM.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100);
            SqlParameter pass = queryCM.Parameters.Add("@MK", SqlDbType.VarBinary, MAX);

            tenDn.Value = tenDN;
            pass.Value = Security.SHA1Hash(matKhau);

            conn.Open();

            DataTable dt = new DataTable();

            dt.Load(queryCM.ExecuteReader());
            conn.Close();
            return dt;
        }

    }
}
