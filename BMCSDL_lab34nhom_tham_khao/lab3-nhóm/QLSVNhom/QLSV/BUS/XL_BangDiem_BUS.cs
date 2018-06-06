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
    class XL_BangDiem_BUS
    {
        XL_BangDiem_DAO BangDiem_DAO = new XL_BangDiem_DAO();
        public List<BangDiem> LayDSBangDiem()
        {
            List<BangDiem> list = new List<BangDiem>();
            DataTable table = BangDiem_DAO.layDSBangDiem();
            foreach (DataRow row in table.Rows)
            {
                BangDiem bd = new BangDiem();
                bd.MaSV = (String)row[0];
                bd.MaHP = (String)row[1];
                bd.DiemThi = (Byte[])row[2];
                list.Add(bd);
            }
            return list;
        }

        public List<BangDiem> LayDSBangDiem(String maSV)
        {
            List<BangDiem> list = new List<BangDiem>();
            DataTable table = BangDiem_DAO.layDSBangDiem(maSV);
            foreach (DataRow row in table.Rows)
            {
                BangDiem bd = new BangDiem();
                bd.MaSV = (String)row[0];
                bd.MaHP = (String)row[1];
                bd.DiemThi = (Byte[])row[2];
                list.Add(bd);
            }
            return list;
        }
        
        public bool them(BangDiem BangDiem)
        {
            return BangDiem_DAO.them(BangDiem);
        }
        public bool sua(BangDiem bdMoi)
        {
            return BangDiem_DAO.sua(bdMoi);
        }

        public bool xoa(String maSV, String maHP)
        {
            return BangDiem_DAO.xoa(maSV,maHP);
        }
    }
}
