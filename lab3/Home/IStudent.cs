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
    public partial class IStudent : Form
    {
        SqlConnection conn;
        public static string MaNV;
        public IStudent(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void IStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IGrades form = new IGrades(conn);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AStudent form = new AStudent(conn);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    
            string MaSV = textBox1.Text.ToString();
            string TenSV = textBox3.Text.ToString();
            DateTime NgSinh = dateTimePicker1.Value;
            string DiaChi = textBox4.Text.ToString();
            string MaLop = textBox2.Text.ToString();
            string TenDN = textBox5.Text.ToString();
            string MatKhau = textBox7.Text.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from LOP where MALOP ='" + MaLop + "' and MANV= '" + MaNV + "'", conn);
            int check = (int)cmd.ExecuteScalar();
            if (check > 0)
            {

                try
                {
                    SqlCommand command = new SqlCommand("EXEC SP_INS_PUBLIC_SINHVIEN '" + MaSV + "', '" + TenSV + "', '" + NgSinh.ToString() + "', N'" + DiaChi + "', '" + MaLop + "', '" + TenDN + "', '" + MatKhau + "'", conn);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
                }
                finally
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox7.Clear();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lớp này không thuộc nhân viên " + MaNV + " quản lý!");
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MaSV = textBox1.Text.ToString();
            string TenSV = textBox3.Text.ToString();
            DateTime NgSinh = dateTimePicker1.Value;
            string DiaChi = textBox4.Text.ToString();
            string MaLop = textBox2.Text.ToString();
            string TenDN = textBox5.Text.ToString();
            string MatKhau = textBox7.Text.ToString();

            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from LOP as l join SINHVIEN as s on l.MALOP=s.MALOP where MASV ='" + MaSV + "' and MANV= '" + MaNV + "'", conn);
            int check = (int)cmd.ExecuteScalar();
            if (check > 0)
            {
                try
                {
                    SqlCommand command = new SqlCommand("delete SINHVIEN where MASV= '" + MaSV+"'",conn);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Xóa sinh viên thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
                }
                finally
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox7.Clear();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Sinh viên này không thuộc nhân viên '" + MaNV + "' quản lý!");
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
