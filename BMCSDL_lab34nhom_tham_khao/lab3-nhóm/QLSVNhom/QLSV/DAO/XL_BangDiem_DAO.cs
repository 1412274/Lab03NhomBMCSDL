using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLSV.DTO;

namespace QLSV.DAO
{
    class XL_BangDiem_DAO
    {
        XL_DuLieu xl_duLieu = new XL_DuLieu();
        public DataTable layDSBangDiem()
        {
            String sql = "SELECT * FROM BANGDIEM";
            return xl_duLieu.GetData(sql);
        }

        public DataTable layDSBangDiem(String maSV)
        {
            String sql = "SELECT * FROM BANGDIEM WHERE BANGDIEM.MASV='"+maSV+"'";
            return xl_duLieu.GetData(sql);
        }

        public DataRow layBangDiem(String maSV,String maHP)
        {
            String sql = "SELECT * FROM BANGDIEM WHERE BANGDIEM.MAHP='" + maHP + "' AND BANGDIEM.MASV='"+maSV+"'" ;
            if (xl_duLieu.GetData(sql).Rows.Count > 0)
                return xl_duLieu.GetData(sql).Rows[0];
            else
                return null;
        }

        public Boolean them(BangDiem bd)
        {
            if (layBangDiem(bd.MaSV, bd.MaHP) != null || bd == null)
            {
                return false;
            }
            String strDiem = "0x" + BitConverter.ToString(bd.DiemThi).Replace("-", "");
            String sql = "INSERT INTO BANGDIEM VALUES ('" + bd.MaSV + "','" + bd.MaHP + "'," + strDiem + ") ";
            try
            {
                xl_duLieu.Execute(sql);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Boolean xoa(String maSV, String maHP)
        {
            if (layBangDiem(maSV,maHP) == null)
                return false;

            String sql = "DELETE FROM BANGDIEM WHERE BANGDIEM.MAHP='" + maHP + "' AND BANGDIEM.MASV='" + maSV + "'";
            try
            {
                xl_duLieu.Execute(sql);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Boolean sua(BangDiem bdMoi)
        {
            string provider = "Data Source=.;Initial Catalog = QLSVNhom; Integrated Security = True";
            SqlConnection conn = new SqlConnection(provider);

            if (layBangDiem(bdMoi.MaSV, bdMoi.MaHP) == null || bdMoi == null)
                return false;
            String sql = "UPDATE BANGDIEM SET DIEMTHI=@DIEMTHI WHERE MAHP=@MAHP AND MASV=@MASV";
            SqlCommand queryCM = new SqlCommand(sql, conn);
            SqlParameter diemThi = queryCM.Parameters.Add("@DIEMTHI", SqlDbType.VarBinary, 1024);
            SqlParameter maHP = queryCM.Parameters.Add("@MAHP", SqlDbType.NVarChar, 100);
            SqlParameter maSV = queryCM.Parameters.Add("@MASV", SqlDbType.NVarChar, 100);

            diemThi.Value = bdMoi.DiemThi;
            maHP.Value = bdMoi.MaHP;
            maSV.Value = bdMoi.MaSV;

            try
            {
                conn.Open();
                queryCM.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            return true;
        }
    }
}
