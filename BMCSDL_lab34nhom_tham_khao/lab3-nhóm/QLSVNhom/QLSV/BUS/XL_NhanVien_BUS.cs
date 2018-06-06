using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using QLSV.DAO;
using QLSV.DTO;

namespace QLSV.BUS
{
    class XL_NhanVien_BUS
    {
        XL_NhanVien_DAO xl_nhanvien_dao = new XL_NhanVien_DAO();

        public NhanVien getData(String tenDN, String matKhau)
        {
            NhanVien nhanVien = new NhanVien();
            if (xl_nhanvien_dao.getData(tenDN, matKhau).Rows.Count == 0)
            {
                return null;
            }
            DataRow data = xl_nhanvien_dao.getData(tenDN, matKhau).Rows[0];
            nhanVien.MaNV = (String)data[0];
            nhanVien.HoTen = (String)data[1];
            nhanVien.Email = (String)data[2];
            nhanVien.Luong = (String)data[3];
            nhanVien.TenDN = tenDN;
            nhanVien.MatKhau = matKhau;
            nhanVien.PublicKey = nhanVien.MaNV;

            return nhanVien;
        }
    }
}
