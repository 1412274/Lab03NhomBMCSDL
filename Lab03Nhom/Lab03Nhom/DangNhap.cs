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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void buttonXemDiemSV_Click(object sender, EventArgs e)
        {
            NhapDiem nd = new NhapDiem();

            nd.Show();
        }
    }
}
