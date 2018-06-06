using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QLSV.DTO;

namespace QLSV.DAO
{
    class XL_NhanVien_DAO
    {

        public static String INSERT_PROC = "SP_INS_PUBLIC_ENCRYPT_NHANVIEN";
        public static String SELECT_PROC = "SP_SEL_PUBLIC_ENCRYPT_NHANVIEN";
        public static String UPDATE_PROC = "SP_UPDATE_PUBLIC_ENCRYPT_NHANVIEN";

        XL_DuLieu xl_duLieu = new XL_DuLieu();
        public DataTable getData(String tenDN, String matKhau)
        {
            return xl_duLieu.callSelectProc(SELECT_PROC, tenDN, matKhau);
        }
        public DataTable layDSNhanVien()
        {
            String sql = "SELECT * FROM NHANVIEN";
            return xl_duLieu.GetData(sql);
        }

        public DataRow layNhanVien(String maNhanVien)
        {
            String sql = "SELECT * FROM NHANVIEN WHERE NHANVIEN.MANV='" + maNhanVien + "'";
            if (xl_duLieu.GetData(sql).Rows.Count > 0)
                return xl_duLieu.GetData(sql).Rows[0];
            else
                return null;
        }

        public Boolean them(NhanVien NhanVien)
        {
            if (layNhanVien(NhanVien.MaNV) != null || NhanVien == null)
            {
                return false;
            }
            try
            {
                xl_duLieu.callInsertOrUpdateProc(INSERT_PROC, NhanVien);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Boolean xoa(String maNhanVien)
        {
            if (layNhanVien(maNhanVien) == null)
                return false;

            String sql = "DELETE FROM SINHVIEN WHERE MASV = '" + maNhanVien + "'";
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

        public Boolean sua(NhanVien NhanVienMoi)
        {
            if (layNhanVien(NhanVienMoi.MaNV) == null || NhanVienMoi == null)
                return false;

            try
            {
                xl_duLieu.callInsertOrUpdateProc(UPDATE_PROC, NhanVienMoi);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
