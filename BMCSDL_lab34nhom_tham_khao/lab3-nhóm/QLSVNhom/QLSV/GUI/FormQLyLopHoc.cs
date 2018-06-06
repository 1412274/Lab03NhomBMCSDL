using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.DTO;

namespace QLSV.GUI
{
    public partial class FormQLyLopHoc : Form
    {
        public NhanVien nhanVien;

        public FormQLyLopHoc()
        {
            InitializeComponent();
        }

        private void FormQLyLopHoc_Load(object sender, EventArgs e)
        {
            this.userControlSinhVien1.UserControlSinhVien_Load();
            this.userControlLopHoc1.UserControlLopHoc_Load();
            this.userControlHocPhan1.UserControlHocPhan_Load();
            this.userControlBangDiem1.UserControlBangDiem_Load();
        }
    }
}
