using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab03Nhom
{
    public partial class DanhSachLop : Form
    {
        public DanhSachLop()
        {
            InitializeComponent();
            
        }
        
        string connectstring = "Data Source=HOANGLAN;Initial Catalog=QLSVN;Integrated Security=True";

        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectstring);
           
            string name = DangNhap.name;
            string pass = DangNhap.password;
        
            string query = "select * from NHANVIEN where MANV = '" + name + "' and hashbytes('sha1','" + pass + "') = MATKHAU";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlDataReader r = command.ExecuteReader();
            if (r.Read())
            {
                txtmanv.Text = r.GetValue(0).ToString();
                txthoten.Text = r.GetValue(1).ToString();
                txtemail.Text = r.GetValue(2).ToString();
            }
            connection.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            dataGridView1.DataSource = GetLopHoc().Tables[0];
        }

        DataSet GetLopHoc()
        {
            string manv = DangNhap.name;
            DataSet data = new DataSet();
            string query = "select l.MALOP, l.TENLOP from NHANVIEN nv, LOP l where l.MANV = nv.MANV and nv.MANV = '"+manv+"'";
            SqlConnection conn = new SqlConnection(connectstring);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(data);
            conn.Close();
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemLop lop = new ThemLop();
            this.Hide();
            lop.Show();

        }
    }
}
