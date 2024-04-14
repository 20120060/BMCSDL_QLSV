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

namespace Home
{

    public partial class IClass : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H707EH2\VUHIEU;Initial Catalog=QLSVNhom;Integrated Security=True");
        SqlCommand command;
        public IClass(SqlConnection conn)
        {
            InitializeComponent();
            this.conn= conn;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IClass_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AClass form = new AClass(conn);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string malop = textBox1.Text.ToString();
            string tenlop = textBox3.Text.ToString();
            string MaNV = textBox2.Text.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from LOP where MALOP = '" + malop+"'", conn);

            int check = (int)cmd.ExecuteScalar();
            if (check == 0)
            {
                try
                {
                    command = new SqlCommand("insert into LOP(MALOP, TENLOP, MANV) values ('" + malop + "','" + tenlop + "','" + MaNV + "') ", conn);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Thêm lớp thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message);
                }
                finally
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lớp này đã tồn tại");
                conn.Close();
            }
        }


        private void button3_Click_2(object sender, EventArgs e)
        {
            string malop = textBox1.Text.ToString();
            string tenlop = textBox3.Text.ToString();
            string MaNV = textBox2.Text.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from LOP where MALOP = '"+malop+"'and TENLOP = '"+tenlop+ "'and MANV = '"+MaNV+"'",conn);
   
            int check = (int)cmd.ExecuteScalar();
            if (check > 0)
            {
                command = new SqlCommand("exec SP_DELETE_CLASS '" + malop + "','" + tenlop + "','" + MaNV + "'", conn);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa lớp thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi xóa lớp: " + ex.Message);
                }
                finally
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại lớp này");
                conn.Close();
            }
        }
    }
}
