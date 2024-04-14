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
    public partial class AStudent : Form
    {
        SqlConnection conn;
        public static string MaNV;
        public AStudent(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from LOP as l join SINHVIEN as s on l.MALOP = s.MALOP where MASV ='" + textBox4.Text.ToString() + "' and MANV= '" + MaNV + "'", conn);
            int check = (int)cmd.ExecuteScalar();
            if (check > 0)
            {
                SqlCommand cmd1 = new SqlCommand("select count(*) from SINHVIEN where MASV ='" + textBox3.Text.ToString() + "'and HOTEN ='" + textBox2.Text.ToString() + "'and DIACHI ='" + textBox8.Text.ToString() + "'and MALOP='" + textBox6.Text.ToString() + "'", conn);
                int check1 = (int)cmd1.ExecuteScalar();
                if (check1 == 0)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("exec SP_ALTER_SV '" +textBox4.Text.ToString()+"','"+ textBox3.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox1.Text.ToString() + "'", conn);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa sinh viên thành công!");

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi sửa sinh viên " + ex.Message);
                    }
                    finally
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên này đã tồn tại!");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Sinh viên này không thuộc nhân viên '" + MaNV + "' quản lý! ");
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE MASV = '" + textBox4.Text.ToString() + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                textBox3.Text = table.Rows[0][0].ToString();
                textBox2.Text = table.Rows[0][1].ToString();
                dateTimePicker1.Value = DateTime.Parse(table.Rows[0][2].ToString());
                textBox8.Text = table.Rows[0][3].ToString();
                textBox6.Text = table.Rows[0][4].ToString();
                textBox1.Text = table.Rows[0][5].ToString();
                textBox7.Text = "*********";

            }
            else
            {

            }

            reader.Close();
            conn.Close();
        }
    }
}
