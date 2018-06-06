using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class SinhVien
    {
        private String maSV;
        private String hoTen;
        private DateTime ngaySinh;
        private String diaChi;
        private String maLop;
        private String tenDN;
        private String matKhau;

        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public String HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public String MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public String TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }

        public String MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }



    }
}
