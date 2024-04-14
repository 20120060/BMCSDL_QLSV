using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Home;


namespace Login
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLSVNhom;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            /* //string str = @"DESKTOP-JGMIJDR\\BOO;Initial Catalog=QLSVNhom;Integrated Security=True";
             SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
             builder.DataSource = "DESKTOP-JGMIJDR\\BOO"; // Tên máy chủ
             builder.InitialCatalog = "QLSVNhom"; // Tên cơ sở dữ liệu
             builder.UserID = "sa"; // Tên người dùng
             builder.Password = "boo7112002"; // Mật khẩu
             SqlConnection conn = new SqlConnection(builder.ConnectionString);

             // conn = new SqlConnection(str);*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (TextTK.Text == "" || TextMK.Text == "")
            {
                MessageBox.Show("Please enter user and password! ");
                TextTK.Focus();
            }
            else
            {
                string usr = TextTK.Text;
                string pswd = TextMK.Text;
                conn.Open();


                SqlCommand cmd = new SqlCommand("select count(*) from NHANVIEN where MANV= @usr and MATKHAU=HASHBYTES('SHA1', @pswd)", conn);
                cmd.Parameters.AddWithValue("@usr", usr);
                cmd.Parameters.AddWithValue("@pswd", pswd);

                int CheckNV = (int)cmd.ExecuteScalar();
                if (CheckNV > 0)
                {
                    Home.IStudent.MaNV = TextTK.Text.ToString();
                    Home.AStudent.MaNV = TextTK.Text.ToString();
                    Home.IGrades.MaNV = TextTK.Text.ToString();
                    Home.Home form1 = new Home.Home(conn);
                    form1.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                }
                conn.Close();

            }
        }


        private void TextTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
