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
            if (xl_nhanvien_dao.getData(tenDN, matKhau).Rows.Count == 0)
            {
                return null;
            }
            DataRow data = xl_nhanvien_dao.getData(tenDN, matKhau).Rows[0];
            return LayNhanVien((String)data[0]);
        }

        public List<NhanVien> LayDSNhanVien() //Khong lay MatKhau
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable table = xl_nhanvien_dao.layDSNhanVien();
            foreach (DataRow row in table.Rows)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNV = (String)row[0];
                nhanVien.HoTen = (String)row[1];
                nhanVien.Email = (String)row[2];

                byte[] matKhau_encrypted = (byte[])row[5];
                nhanVien.Luong = (String)EncryptorRSA.RSAdecrypt((byte[])row[3], 
                                                            Convert.ToBase64String(matKhau_encrypted));//giai ma rsa
                nhanVien.TenDN = (String)row[4];
                nhanVien.MatKhau = null;//khong load
                nhanVien.PublicKey = (String)row[6];
                list.Add(nhanVien);
            }
            return list;
        }

        public NhanVien LayNhanVien(String maNV) //Khong lay MatKhau
        {
            DataRow row = xl_nhanvien_dao.layNhanVien(maNV);
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = (String)row[0];
            nhanVien.HoTen = (String)row[1];
            nhanVien.Email = (String)row[2];

            byte[] matKhau_encrypted = (byte[])row[5];
            nhanVien.Luong = (String)EncryptorRSA.RSAdecrypt((byte[])row[3],
                                                        Convert.ToBase64String(matKhau_encrypted));//giai ma rsa
            nhanVien.TenDN = (String)row[4];
            nhanVien.MatKhau = null;//khong load
            nhanVien.PublicKey = (String)row[6];
            return nhanVien;
        }

        public bool them(NhanVien nhanVien)
        {
            return xl_nhanvien_dao.them(nhanVien);
        }
        public bool sua(NhanVien NhanVienMoi)
        {
            return xl_nhanvien_dao.sua(NhanVienMoi);
        }

        public bool xoa(String maNhanVien)
        {
            return xl_nhanvien_dao.xoa(maNhanVien);
        }
    }
}
