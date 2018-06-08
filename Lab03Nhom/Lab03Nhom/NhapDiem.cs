using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03Nhom
{
    public partial class NhapDiem : Form
    {
        public string masv = null;
        public string hotensv = null;
        public string malop = null;

        public NhapDiem()
        {
            InitializeComponent();
        }

        public NhapDiem(string _masv, string _hotensv, string _malop)
        {
            InitializeComponent();
            this.masv = _masv;
            this.hotensv = _hotensv;
            this.malop = _malop;
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            tb_MaSV.Text = masv;
            tb_HoTen.Text = hotensv;
            tb_MaLop.Text = malop;
        }
    }
}
