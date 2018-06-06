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
    public partial class Lop : Form
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        String connectionstring = @"Data Source=KIM-PC;Initial Catalog=QLSVNhom;Integrated Security=True";

        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionstring);
            connection.Open();

            String procname = "SP_LAY_DS_NV";
            command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            cb_DSNV.ValueMember = "MANV";
            cb_DSNV.DisplayMember = "MANV";
            cb_DSNV.DataSource = table;

            if (cb_DSNV.Text != "")
            {
                cb_DSNV.Text = "";
            }

            connection.Close();
        }

        private void btn_XemDSLop_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionstring);
            connection.Open();

            //command.Parameters.Clear();

            String procname = "SP_DANH_SACH_LOP";
            command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            dg_XemDSLop.DataSource = table;
            connection.Close();
        }

        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionstring);
            connection.Open();

            //command.Parameters.Clear();

            String procname = "SP_THEM_LOP";
            command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            //Khai báo các tham số và gán giá trị cho chúng
            command.Parameters.Add("@MALOP", SqlDbType.VarChar, 20);
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MANV", SqlDbType.VarChar, 20);

            command.Parameters["@MALOP"].Value = tb_MaLop.Text;
            command.Parameters["@TENLOP"].Value = tb_TenLop.Text;
            command.Parameters["@MANV"].Value = cb_DSNV.SelectedValue.ToString();

            int n = command.ExecuteNonQuery();

            if (n > 0)
                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Thêm lớp thất bại", "Thông báo", MessageBoxButtons.OK);

            connection.Close();

        }


    }
}
