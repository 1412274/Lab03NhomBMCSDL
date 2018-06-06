using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Lab03Nhom
{
    public partial class DangNhap : Form
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        String connectionstring = @"Data Source=KIM-PC;Initial Catalog=QLSVNhom;Integrated Security=True";

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //Mở kết nối
            connection = new SqlConnection(connectionstring);
            connection.Open();

            //command.Parameters.Clear();

            //Gọi procedure dưới DB
            String procname = "SP_SIGN_IN";
            command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            //Khai báo các tham số và gán giá trị cho chúng
            command.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MATKHAU", SqlDbType.VarChar, 100);
            command.Parameters.Add("@KETQUA", SqlDbType.Int).Direction = ParameterDirection.Output;

            command.Parameters["@TENDN"].Value = tb_TenDN.Text;
            command.Parameters["@MATKHAU"].Value = tb_MatKhau.Text;

            int n = command.ExecuteNonQuery();
            int ketqua = (int)command.Parameters["@KETQUA"].Value;

            if (ketqua == 1)
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK);

            connection.Close();

        }
    }
}
