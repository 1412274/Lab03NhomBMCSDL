using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class Lop
    {
        private String maLop;
        private String tenLop;
        private String maNV;

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public String TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        public String MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
    }
}
