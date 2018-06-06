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
    public partial class UserControlLopHoc : UserControl
    {
        XL_Lop_BUS xl_lop_bus = new XL_Lop_BUS();
        int status = 0;
        private NhanVien nhanVien;
        public UserControlLopHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            //Khong cho phep sua/xoa trong qua trinh nay
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            status = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cho phep nhap vao textbox
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            //Khong cho phep them/xoa trong qua trinh nay
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            status = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSLop.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSLop.SelectedItems[0];
                String maLop = item.SubItems[0].Text;
                if (xl_lop_bus.xoa(maLop))
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
            if (txtMaLop.Text == "" || txtTenLop.Text == "")
            {
                MessageBox.Show("Điền thông tin vào ô trống");
                return;
            }
            Lop lop = new Lop();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.MaNV = nhanVien.MaNV;
            if (status == 1 && xl_lop_bus.themLop(lop))
            {
                MessageBox.Show("Thêm thành công!");
                reset();
                return;
            }
            else if (status == 2 && xl_lop_bus.sua(lop))
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
            loadLvDSLop();

            txtMaLop.Clear();
            txtTenLop.Clear();

            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void loadLvDSLop()
        {
            try
            {

                List<Lop> list = xl_lop_bus.LayDSLop(nhanVien.MaNV);
                lvDSLop.Items.Clear();
                foreach (Lop lop in list)
                {
                    ListViewItem lvi = new ListViewItem(lop.MaLop);
                    lvi.SubItems.Add(lop.TenLop);

                    lvDSLop.Items.Add(lvi);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(status != 0)
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

        public void UserControlLopHoc_Load()
        {
            FormQLyLopHoc form = (FormQLyLopHoc)this.FindForm();
            nhanVien = form.nhanVien;
            reset();
        }

        private void lvDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSLop.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSLop.SelectedItems[0];
                txtMaLop.Text = item.SubItems[0].Text;
                txtTenLop.Text = item.SubItems[1].Text;
                
            }
        }



    }
}
