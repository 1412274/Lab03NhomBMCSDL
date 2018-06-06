using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    public class NhanVien
    {
        private String maNV;
        private String hoTen;
        private String email;
        private String luong;
        private String tenDN;
        private String matKhau;
        private String publicKey;

        public String PublicKey
        {
            get { return publicKey; }
            set { publicKey = value; }
        }

        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public String Luong
        {
            get { return luong; }
            set { luong = value; }
        }

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public String HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }

    }
}
