using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QLSV.DTO;

namespace QLSV.DAO
{
    class XL_HocPhan_DAO
    {
        XL_DuLieu xl_duLieu = new XL_DuLieu();
        public DataTable layDSHocPhan()
        {
            String sql = "SELECT * FROM HOCPHAN";
            return xl_duLieu.GetData(sql);
        }


        public DataRow layHocPhan(String maHocPhan)
        {
            String sql = "SELECT * FROM HOCPHAN WHERE HOCPHAN.MAHP='"+maHocPhan+"'";
            if (xl_duLieu.GetData(sql).Rows.Count > 0)
                return xl_duLieu.GetData(sql).Rows[0];
            else
                return null;
        }

        public Boolean them(HocPhan hp)
        {
            if (layHocPhan(hp.MaHP) != null || hp == null)
            {
                return false;
            }
            String sql = "INSERT INTO HOCPHAN VALUES ('"+hp.MaHP+"',N'"+hp.TenHP+"',"+hp.SoTC+") ";
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

        public Boolean xoa(String maHocPhan)
        {
            if (layHocPhan(maHocPhan) == null)
                return false;

            String sql = "DELETE FROM HOCPHAN WHERE MAHP = '"+maHocPhan+"'";
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

        public Boolean sua(HocPhan hocPhanMoi)
        {
            if (layHocPhan(hocPhanMoi.MaHP) == null || hocPhanMoi == null)
                return false;

            String sql = "UPDATE HOCPHAN SET TENHP='"+hocPhanMoi.TenHP+"', SOTC="+hocPhanMoi.SoTC+" WHERE MAHP='"+hocPhanMoi.MaHP+"'";
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
