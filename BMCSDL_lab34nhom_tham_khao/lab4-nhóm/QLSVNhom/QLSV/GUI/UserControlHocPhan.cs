using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.DTO;
using QLSV.BUS;

namespace QLSV.GUI
{
    public partial class UserControlHocPhan : UserControl
    {
        XL_HocPhan_BUS xl_hocphan_bus = new XL_HocPhan_BUS();
        int status = 0;
        private NhanVien nhanVien;
        public UserControlHocPhan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtMaHP.Enabled = true;
            txtTenHP.Enabled = true;
            txtSoTC.Enabled = true;
            //Khong cho phep sua/xoa trong qua trinh nay
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            status = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtMaHP.Enabled = true;
            txtTenHP.Enabled = true;
            txtSoTC.Enabled = true;
            //Khong cho phep them/xoa trong qua trinh nay
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            status = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSHocPhan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSHocPhan.SelectedItems[0];
                String maHP = item.SubItems[0].Text;
                if (xl_hocphan_bus.xoa(maHP))
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
            if (txtMaHP.Text == "" || txtTenHP.Text == "" || txtSoTC.Text == "")
            {
                MessageBox.Show("Điền thông tin vào ô trống");
                return;
            }
            HocPhan hp = new HocPhan();
            hp.MaHP = txtMaHP.Text;
            hp.TenHP = txtTenHP.Text;
            hp.SoTC = int.Parse(txtSoTC.Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);

            if (status == 1 && xl_hocphan_bus.them(hp))
            {
                MessageBox.Show("Thêm thành công!");
                reset();
                return;
            }
            else if (status == 2 && xl_hocphan_bus.sua(hp))
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
            
            loadLvDSHocPhan();

            txtMaHP.Clear();
            txtTenHP.Clear();
            txtSoTC.ResetText();

            txtMaHP.Enabled = false;
            txtTenHP.Enabled = false;
            txtSoTC.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void loadLvDSHocPhan()
        {
            try
            {

                List<HocPhan> list = xl_hocphan_bus.LayDSHocPhan();
                lvDSHocPhan.Items.Clear();
                foreach (HocPhan hp in list)
                {
                    ListViewItem lvi = new ListViewItem(hp.MaHP);
                    lvi.SubItems.Add(hp.TenHP);
                    lvi.SubItems.Add(hp.SoTC.ToString());

                    lvDSHocPhan.Items.Add(lvi);
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

        public void UserControlHocPhan_Load()
        {
            FormQLyLopHoc form = (FormQLyLopHoc)this.FindForm();
            nhanVien = form.nhanVien;
            reset();
        }

        private void lvDSHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSHocPhan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSHocPhan.SelectedItems[0];
                txtMaHP.Text = item.SubItems[0].Text;
                txtTenHP.Text = item.SubItems[1].Text;
                txtSoTC.Text = item.SubItems[2].Text;
               
            }
        }
    }
}
