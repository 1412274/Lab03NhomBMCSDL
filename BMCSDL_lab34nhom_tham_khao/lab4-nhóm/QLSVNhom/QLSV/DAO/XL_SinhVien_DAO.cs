using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QLSV.DTO;

namespace QLSV.DAO
{
    class XL_SinhVien_DAO
    {
        public static String INSERT_PROC = "SP_INS_PUBLIC_ENCRYPT_SINHVIEN";
        public static String UPDATE_PROC = "SP_UPDATE_PUBLIC_ENCRYPT_SINHVIEN";

        XL_DuLieu xl_duLieu = new XL_DuLieu();
        public DataTable layDSSinhVien()
        {
            String sql = "SELECT * FROM SINHVIEN";
            return xl_duLieu.GetData(sql);
        }

        public DataTable layDSSinhVien(String maLop)
        {
            String sql = "SELECT * FROM SINHVIEN WHERE SINHVIEN.MALOP='" + maLop + "'";
            return xl_duLieu.GetData(sql);
        }

        public DataRow laySinhVien(String maSinhVien)
        {
            String sql = "SELECT * FROM SINHVIEN WHERE SINHVIEN.MASV='" + maSinhVien + "'";
            if (xl_duLieu.GetData(sql).Rows.Count > 0)
                return xl_duLieu.GetData(sql).Rows[0];
            else
                return null;
        }

        public Boolean them(SinhVien SinhVien)
        {
            if (laySinhVien(SinhVien.MaSV) != null || SinhVien == null)
            {
                return false;
            }
            try
            {
                xl_duLieu.callInsertOrUpdateProc(INSERT_PROC, SinhVien);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Boolean xoa(String maSinhVien)
        {
            if (laySinhVien(maSinhVien) == null)
                return false;

            String sql = "DELETE FROM SINHVIEN WHERE MASV = '" + maSinhVien + "'";
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

        public Boolean sua(SinhVien SinhVienMoi)
        {
            if (laySinhVien(SinhVienMoi.MaSV) == null || SinhVienMoi == null)
                return false;

            try
            {
                xl_duLieu.callInsertOrUpdateProc(UPDATE_PROC,SinhVienMoi);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
