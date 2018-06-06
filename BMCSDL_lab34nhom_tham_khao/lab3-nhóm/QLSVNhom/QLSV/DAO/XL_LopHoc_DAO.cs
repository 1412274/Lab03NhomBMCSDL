using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QLSV.DTO;
namespace QLSV.DAO
{
    class XL_LopHoc_DAO
    {
        XL_DuLieu xl_duLieu = new XL_DuLieu();
        public DataTable layDSLop()
        {
            String sql = "SELECT * FROM LOP";
            return xl_duLieu.GetData(sql);
        }

        public DataTable layDSLop(String maNV)
        {
            String sql = "SELECT * FROM LOP WHERE LOP.MANV='" + maNV + "'";
            return xl_duLieu.GetData(sql);
        }

        public DataRow layLop(String maLop)
        {
            String sql = "SELECT * FROM LOP WHERE LOP.MALOP='"+maLop+"'";
            if (xl_duLieu.GetData(sql).Rows.Count > 0)
                return xl_duLieu.GetData(sql).Rows[0];
            else
                return null;
        }

        public Boolean them(Lop lop)
        {
            if (layLop(lop.MaLop) != null || lop == null)
            {
                return false;
            }
            String sql = "INSERT INTO LOP VALUES ('"+lop.MaLop+"','"+lop.TenLop+"','"+lop.MaNV+"') ";
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

        public Boolean xoa(String maLop)
        {
            if (layLop(maLop) == null)
                return false;

            String sql = "DELETE FROM LOP WHERE MALOP = '"+maLop+"'";
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

        public Boolean sua(Lop lopMoi)
        {
            if (layLop(lopMoi.MaLop) == null || lopMoi == null)
                return false;

            String sql = "UPDATE LOP SET TENLOP = '" + lopMoi.TenLop + "', MANV= '" + lopMoi.MaNV + "' WHERE MALOP = '" + lopMoi.MaNV + "'";
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
    }
}
