using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.DTO;
using QLSV.BUS;

namespace QLSV.GUI
{
    public partial class UserControlNhanVien : UserControl
    {
        XL_NhanVien_BUS xl_nhanvien_bus = new XL_NhanVien_BUS();
        int status = 0;
        //private NhanVien nhanVien;
        public UserControlNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtEmail.Enabled = true;
            txtHoTen.Enabled = true;
            txtLuong.Enabled = true;
            txtMaNV.Enabled = true;
            txtMatKhau.Enabled = true;
            txtTenDangNhap.Enabled = true;
            //Khong cho phep sua/xoa trong qua trinh nay
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            status = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtEmail.Enabled = true;
            txtHoTen.Enabled = true;
            txtLuong.Enabled = true;
            txtMaNV.Enabled = true;
            txtMatKhau.Enabled = true;
            txtTenDangNhap.Enabled = true;
            //Khong cho phep them/xoa trong qua trinh nay
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            status = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSNhanVien.SelectedItems[0];
                String maHP = item.SubItems[0].Text;
                if (xl_nhanvien_bus.xoa(maHP))
                {
                    MessageBox.Show("Xóa thành công");
                    reset();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng muốn xóa");
                return;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" 
                || txtMatKhau.Text == "" 
                || txtMaNV.Text == ""
                || txtHoTen.Text == ""
                || txtEmail.Text== ""
                || txtLuong.Text=="")
            {
                MessageBox.Show("Điền thông tin vào ô trống");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            nv.Email = txtEmail.Text;
            nv.Luong = txtLuong.Text;
            nv.TenDN = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;

            if (status == 1 && xl_nhanvien_bus.them(nv))
            {
                MessageBox.Show("Thêm thành công!");
                reset();
                return;
            }
            else if (status == 2 && xl_nhanvien_bus.sua(nv))
            {
                MessageBox.Show("Sửa thành công!");
                reset();
                return;
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
                return;
            }
        }

        private void reset()
        {
            status = 0;

            loadLvDSNhanVien();

            txtEmail.Clear();
            txtHoTen.Clear();
            txtLuong.Clear();
            txtMaNV.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();

            txtEmail.Enabled = false;
            txtHoTen.Enabled = false;
            txtLuong.Enabled = false;
            txtMaNV.Enabled = false;
            txtMatKhau.Enabled = false;
            txtTenDangNhap.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void loadLvDSNhanVien()
        {
            try
            {

                List<NhanVien> list = xl_nhanvien_bus.LayDSNhanVien();
                lvDSNhanVien.Items.Clear();
                foreach (NhanVien nv in list)
                {
                    ListViewItem lvi = new ListViewItem(nv.MaNV);
                    lvi.SubItems.Add(nv.HoTen);
                    lvi.SubItems.Add(nv.Email);
                    lvi.SubItems.Add(nv.Luong);

                    lvDSNhanVien.Items.Add(lvi);
                }
            }
            catch(Exception)
            {
                return;
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (status != 0)
            {
                status = 0;
                reset();
            }
            else
                Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void UserControlNhanVien_Load()
        {
            reset();
        }

        private void comboBoxLop_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLvDSNhanVien();
            return;
        }

        private void lvDSNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSNhanVien.SelectedItems[0];
                txtMaNV.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtLuong.Text = item.SubItems[3].Text;
            }
        }
    }
}
