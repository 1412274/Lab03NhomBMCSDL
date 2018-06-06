using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLSV.DAO;
using QLSV.DTO;

namespace QLSV.BUS
{
    class XL_Lop_BUS
    {
        XL_LopHoc_DAO Lop_DAO = new XL_LopHoc_DAO();
        public List<Lop> LayDSLop()
        {
            List<Lop> list = new List<Lop>();
            DataTable table = Lop_DAO.layDSLop();
            foreach (DataRow row in table.Rows)
            {
                Lop lop = new Lop();
                lop.MaLop = (String)row[0];
                lop.TenLop = (String)row[1];
                lop.MaNV = (String)row[2];
                list.Add(lop);
            }
            return list;
        }

        public List<Lop> LayDSLop(String maNV)
        {
            List<Lop> list = new List<Lop>();
            try
            {

                DataTable table = Lop_DAO.layDSLop(maNV);
                foreach (DataRow row in table.Rows)
                {
                    Lop lop = new Lop();
                    lop.MaLop = (String)row[0];
                    lop.TenLop = (String)row[1];
                    lop.MaNV = (String)row[2];
                    list.Add(lop);
                }
                return list;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public bool themLop(Lop Lop)
        {
            return Lop_DAO.them(Lop);
        }
        public bool sua(Lop lopMoi)
        {
            return Lop_DAO.sua(lopMoi);
        }

        public bool xoa(String maLop)
        {
            return Lop_DAO.xoa(maLop);
        }
    }
}
