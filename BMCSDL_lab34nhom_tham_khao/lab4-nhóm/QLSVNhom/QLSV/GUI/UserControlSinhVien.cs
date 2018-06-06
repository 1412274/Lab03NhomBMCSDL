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
    public partial class UserControlSinhVien : UserControl
    {
        XL_SinhVien_BUS xl_sinhvien_bus = new XL_SinhVien_BUS();
        XL_Lop_BUS xl_lop_bus = new XL_Lop_BUS();
        int status = 0;
        private NhanVien nhanVien;
        public UserControlSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtDiaChi.Enabled = true;
            txtHoTen.Enabled = true;
            txtMaSV.Enabled = true;
            txtMatKhau.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtTenDangNhap.Enabled = true;
            //Khong cho phep sua/xoa trong qua trinh nay
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            status = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtDiaChi.Enabled = true;
            txtHoTen.Enabled = true;
            txtMaSV.Enabled = true;
            txtMatKhau.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtTenDangNhap.Enabled = true;
            //Khong cho phep them/xoa trong qua trinh nay
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            status = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSSinhVien.SelectedItems[0];
                String maHP = item.SubItems[0].Text;
                if (xl_sinhvien_bus.xoa(maHP))
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
                || txtMaSV.Text == ""
                || txtHoTen.Text == "")
            {
                MessageBox.Show("Điền thông tin vào ô trống");
                return;
            }
            SinhVien sv = new SinhVien();
            sv.MaSV = txtMaSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.NgaySinh = txtNgaySinh.Value;
            sv.DiaChi = txtDiaChi.Text;
            sv.TenDN = txtTenDangNhap.Text;
            sv.MatKhau = txtMatKhau.Text;
            sv.MaLop = comboBoxLop.Text;

            if (status == 1 && xl_sinhvien_bus.them(sv))
            {
                MessageBox.Show("Thêm thành công!");
                reset();
                return;
            }
            else if (status == 2 && xl_sinhvien_bus.sua(sv))
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
            comboBoxLop.Enabled = true;
            loadComboboxLop();
            loadLvDSSinhVien();

            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMatKhau.Clear();
            txtNgaySinh.ResetText();
            txtTenDangNhap.Clear();

            txtDiaChi.Enabled = false;
            txtHoTen.Enabled = false;
            txtMaSV.Enabled = false;
            txtMatKhau.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtTenDangNhap.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void loadLvDSSinhVien()
        {
            try
            {
                List<SinhVien> list = xl_sinhvien_bus.LayDSSinhVien(comboBoxLop.Text);
                lvDSSinhVien.Items.Clear();
                foreach (SinhVien sv in list)
                {
                    ListViewItem lvi = new ListViewItem(sv.MaSV);
                    lvi.SubItems.Add(sv.HoTen);
                    lvi.SubItems.Add(sv.NgaySinh.ToShortDateString());
                    lvi.SubItems.Add(sv.DiaChi);
                    lvi.SubItems.Add(sv.TenDN);

                    lvDSSinhVien.Items.Add(lvi);
                }
            }
            catch(Exception)
            {
                return;
            }
        }

        private void loadComboboxLop()
        {
            try
            {
                comboBoxLop.Items.Clear();
                List<Lop> list = xl_lop_bus.LayDSLop(nhanVien.MaNV);
                foreach (Lop lop in list)
                {
                    comboBoxLop.Items.Add(lop.MaLop);
                }
                comboBoxLop.SelectedItem = comboBoxLop.Items[0];
                comboBoxLop.Update();
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

        public void UserControlSinhVien_Load()
        {
            FormQLyLopHoc form = (FormQLyLopHoc)this.FindForm();
            nhanVien = form.nhanVien;
            reset();
        }

        private void comboBoxLop_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLvDSSinhVien();
            return;
        }

        private void lvDSSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSSinhVien.SelectedItems[0];
                txtMaSV.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                txtNgaySinh.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtTenDangNhap.Text = item.SubItems[4].Text;
            }
        }
    }
}
