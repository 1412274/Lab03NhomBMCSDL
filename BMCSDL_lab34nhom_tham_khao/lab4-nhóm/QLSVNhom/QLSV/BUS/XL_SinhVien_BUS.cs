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
    class XL_SinhVien_BUS
    {
        XL_SinhVien_DAO xl_sinhvien_dao = new XL_SinhVien_DAO();


        public List<SinhVien> LayDSSinhVien() //Khong lay MatKhau
        {
            List<SinhVien> list = new List<SinhVien>();
            DataTable table = xl_sinhvien_dao.layDSSinhVien();
            foreach (DataRow row in table.Rows)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.MaSV = (String)row[0];
                sinhVien.HoTen = (String)row[1];
                sinhVien.NgaySinh = (DateTime)row[2];
                sinhVien.DiaChi = (String)row[3];
                sinhVien.MaLop = (String)row[4];
                sinhVien.TenDN = (String)row[5];
                sinhVien.MatKhau = null;//khong load
                list.Add(sinhVien);
            }
            return list;
        }

        public List<SinhVien> LayDSSinhVien(String maLop) //Khong lay MatKhau
        {
            List<SinhVien> list = new List<SinhVien>();
            DataTable table = xl_sinhvien_dao.layDSSinhVien(maLop);
            foreach (DataRow row in table.Rows)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.MaSV = (String)row[0];
                sinhVien.HoTen = (String)row[1];
                sinhVien.NgaySinh = (DateTime)row[2];
                sinhVien.DiaChi = (String)row[3];
                sinhVien.MaLop = (String)row[4];
                sinhVien.TenDN = (String)row[5];
                sinhVien.MatKhau = null;//khong load
                list.Add(sinhVien);
            }
            return list;
        }

        public bool them(SinhVien sinhVien)
        {
            return xl_sinhvien_dao.them(sinhVien);
        }
        public bool sua(SinhVien SinhVienMoi)
        {
            return xl_sinhvien_dao.sua(SinhVienMoi);
        }

        public bool xoa(String maSinhVien)
        {
            return xl_sinhvien_dao.xoa(maSinhVien);
        }
    }
}
