using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class BangDiem
    {
        private String maSV;
        private String maHP;
        private Byte[] diemThi;

        public Byte[] DiemThi
        {
            get { return diemThi; }
            set { diemThi = value; }
        }

        public String MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public String MaHP
        {
            get { return maHP; }
            set { maHP = value; }
        }
    }
}
