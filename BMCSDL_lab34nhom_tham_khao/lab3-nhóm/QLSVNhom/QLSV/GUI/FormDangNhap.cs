using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.BUS;
using QLSV.DTO;

namespace QLSV.GUI
{
    public partial class FormDangNhap : Form
    {
        XL_NhanVien_BUS xl_nhanvien_bus = new XL_NhanVien_BUS();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tenDn = txtTenDN.Text;
            String matKhau = txtMatKhau.Text;

            NhanVien nhanVien = xl_nhanvien_bus.getData(tenDn, matKhau);
            if (nhanVien != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                manHinhNhanVien(nhanVien);
                return;
            }
            else
            {
                MessageBox.Show("tên đăng nhập và mật khẩu không hợp lệ");
                return;
            }
        }

        private void manHinhNhanVien(NhanVien nhanVien)
        {
            this.Hide();
            FormQLyLopHoc formQLLopHoc = new FormQLyLopHoc();
            formQLLopHoc.nhanVien = nhanVien;
            formQLLopHoc.ShowDialog();
            this.Close();

        }
    }
}
