using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class XL_NhanVien_DAO
    {

        public static String INSERT_PROC = "SP_INS_PUBLIC_NHANVIEN";
        public static String SELECT_PROC = "SP_SEL_PUBLIC_NHANVIEN";

        XL_DuLieu xl_duLieu = new XL_DuLieu();
        public DataTable getData(String tenDN, String matKhau)
        {
            return xl_duLieu.callSelectProc(SELECT_PROC, tenDN, matKhau);
        }
    }
}
