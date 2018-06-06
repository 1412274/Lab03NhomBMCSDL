using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QLSV.DAO;
using QLSV.DTO;

namespace QLSV.BUS
{
    class XL_HocPhan_BUS
    {
        XL_HocPhan_DAO HocPhan_DAO = new XL_HocPhan_DAO();
        public List<HocPhan> LayDSHocPhan()
        {
            List<HocPhan> list = new List<HocPhan>();
            DataTable table = HocPhan_DAO.layDSHocPhan();
            foreach (DataRow row in table.Rows)
            {
                HocPhan hp = new HocPhan();
                hp.MaHP = (String)row[0];
                hp.TenHP = (String)row[1];
                hp.SoTC = (int)row[2];
                list.Add(hp);
            }
            return list;
        }

        public HocPhan layHocPhan(String maHP)
        {
            HocPhan hp = new HocPhan();

            DataRow row = HocPhan_DAO.layHocPhan(maHP);
            if (row == null) return null;
            else
            {
                hp.MaHP = (String)row[0];
                hp.TenHP = (String)row[1];
                hp.SoTC = (int)row[2];

            }
            return hp;
        }


        public bool them(HocPhan HocPhan)
        {
            return HocPhan_DAO.them(HocPhan);
        }
        public bool sua(HocPhan lopMoi)
        {
            return HocPhan_DAO.sua(lopMoi);
        }

        public bool xoa(String maHocPhan)
        {
            return HocPhan_DAO.xoa(maHocPhan);
        }
    }
}
