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
    public partial class SinhVien : Form
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        String connectionstring = @"Data Source=KIM-PC;Initial Catalog=QLSVNhom;Integrated Security=True";

        public SinhVien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            connection = new SqlConnection(connectionstring);
            connection.Open();

            //command.Parameters.Clear();

            String procname = "SP_DSSV";
            command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            dg_DSSV.DataSource = table;
            connection.Close();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_LayDSSV_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open();

                //command.Parameters.Clear();

                String procname = "SP_UPDATE_SV";
                command = new SqlCommand(procname);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                int CurrentIndex = dg_DSSV.CurrentCell.RowIndex;
                string MASV = Convert.ToString(dg_DSSV.Rows[CurrentIndex].Cells[0].Value.ToString());
                string HOTEN = Convert.ToString(dg_DSSV.Rows[CurrentIndex].Cells[1].Value.ToString());
                string NGAYSINH = Convert.ToString(dg_DSSV.Rows[CurrentIndex].Cells[2].Value.ToString());
                string DIACHI = Convert.ToString(dg_DSSV.Rows[CurrentIndex].Cells[3].Value.ToString());
                string TENDN = Convert.ToString(dg_DSSV.Rows[CurrentIndex].Cells[5].Value.ToString());

                command.Parameters.Add("@MASV", SqlDbType.VarChar, 20);
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 100);
                command.Parameters.Add("@NGAYSINH", SqlDbType.DateTime);
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 200);
                command.Parameters.Add("@TENDN", SqlDbType.NVarChar, 100);

                command.Parameters["@MASV"].Value = MASV;
                command.Parameters["@HOTEN"].Value = HOTEN;
                command.Parameters["@NGAYSINH"].Value = NGAYSINH;
                command.Parameters["@DIACHI"].Value = DIACHI;
                command.Parameters["@TENDN"].Value = TENDN;

                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    LoadData();
                    MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sử thông tin thất bại!", "Thông báo", MessageBoxButtons.OK);
                }

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
