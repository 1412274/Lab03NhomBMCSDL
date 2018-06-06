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
using QLSV.DAO;

namespace QLSV.GUI
{
    public partial class UserControlBangDiem : UserControl
    {
        XL_SinhVien_BUS xl_sinhvien_bus = new XL_SinhVien_BUS();
        XL_HocPhan_BUS xl_hocphan_bus = new XL_HocPhan_BUS();
        XL_Lop_BUS xl_lop_bus = new XL_Lop_BUS();
        XL_BangDiem_BUS xl_bangdiem_bus = new XL_BangDiem_BUS();
        int status = 0;
        private NhanVien nhanVien;
        public UserControlBangDiem()
        {
            InitializeComponent();
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

        //load sau ComboBoxLop
        private void loadComboboxSinhVien()
        {
            try
            {
                comboBoxMaSV.Items.Clear();
                List<SinhVien> list = xl_sinhvien_bus.LayDSSinhVien(comboBoxLop.Text);
                if (list.Count == 0)
                {
                    comboBoxMaSV.Enabled = false;
                    return;
                }
                foreach (SinhVien sv in list)
                {
                    comboBoxMaSV.Items.Add(sv.MaSV);
                }
                comboBoxMaSV.SelectedItem = comboBoxMaSV.Items[0];
                comboBoxMaSV.Update();

            }
            catch (Exception)
            {
                return;
            }
        }

        private void loadComboboxMaHP()
        {
            try
            {

                comboBoxMaHP.Items.Clear();
                List<HocPhan> list = xl_hocphan_bus.LayDSHocPhan();
                foreach (HocPhan hp in list)
                {
                    comboBoxMaHP.Items.Add(hp.MaHP);
                }
                comboBoxMaHP.SelectedItem = comboBoxMaHP.Items[0];
                comboBoxMaHP.Update();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void loadLvDSDiem()
        {
            try
            {

                List<BangDiem> list = xl_bangdiem_bus.LayDSBangDiem(comboBoxMaSV.Text);
                lvDSDiem.Items.Clear();
                foreach (BangDiem bd in list)
                {
                    ListViewItem lvi = new ListViewItem(bd.MaHP);
                    HocPhan hp = xl_hocphan_bus.layHocPhan(bd.MaHP);
                    if (hp != null)
                        lvi.SubItems.Add(hp.TenHP);
                    else
                        lvi.SubItems.Add("");
                    lvi.SubItems.Add(Security.AES256DecryptText(bd.DiemThi, nhanVien.PublicKey));

                    lvDSDiem.Items.Add(lvi);
                }
            }
            catch (Exception)
            {
                return;
            }
        }


        private void reset()
        {
            status = 0;
            comboBoxLop.Enabled = true;
            loadComboboxLop();
            txtDiem.Clear();
            loadComboboxMaHP();
            loadLvDSDiem();

            txtDiem.Enabled = false;
            comboBoxMaHP.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        public void UserControlBangDiem_Load()
        {
            FormQLyLopHoc form = (FormQLyLopHoc)this.FindForm();
            nhanVien = form.nhanVien;
            reset();
        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaSV.Enabled = true;
            loadComboboxSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtDiem.Enabled = true;
            comboBoxMaHP.Enabled = true;
            //Khong cho phep sua/xoa trong qua trinh nay
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            status = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtDiem.Enabled = true;
            comboBoxMaHP.Enabled = true;
            //Khong cho phep them/xoa trong qua trinh nay
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            status = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSDiem.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSDiem.SelectedItems[0];
                String maHP = item.SubItems[0].Text;
                if (xl_bangdiem_bus.xoa(comboBoxMaSV.Text, maHP))
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
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Điền thông tin vào ô trống");
                return;
            }
            BangDiem bd = new BangDiem();
            bd.MaHP = comboBoxMaHP.Text;
            bd.MaSV = comboBoxMaSV.Text;
            bd.DiemThi = Security.AES256EncryptText(txtDiem.Text,nhanVien.PublicKey);


            if (status == 1 && xl_bangdiem_bus.them(bd))
            {
                MessageBox.Show("Thêm thành công!");
                reset();
                return;
            }
            else if (status == 2 && xl_bangdiem_bus.sua(bd))
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

        private void comboBoxMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLvDSDiem();
        }

        private void lvDSDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSDiem.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSDiem.SelectedItems[0];
                comboBoxMaHP.Text = item.SubItems[0].Text;
                txtDiem.Text = item.SubItems[2].Text;
            }
        }

    }
}
