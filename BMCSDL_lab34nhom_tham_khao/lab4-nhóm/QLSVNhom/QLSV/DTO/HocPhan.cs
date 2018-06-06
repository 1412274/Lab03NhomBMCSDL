using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    class HocPhan
    {
        private String maHP;
        private String tenHP;
        private int soTC;

        public int SoTC
        {
            get { return soTC; }
            set { soTC = value; }
        }

        public String TenHP
        {
            get { return tenHP; }
            set { tenHP = value; }
        }

        public String MaHP
        {
            get { return maHP; }
            set { maHP = value; }
        }

        
    }
}
