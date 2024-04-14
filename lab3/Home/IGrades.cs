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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Home
{
    public partial class IGrades : Form

    {
        SqlConnection conn;
        public static string MaNV;
        public IGrades(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MASV = textBox1.Text.ToString();
            string MAHP = textBox3.Text.ToString();
            int DIEMTHI = int.Parse(textBox2.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from LOP as l join SINHVIEN as s on l.MALOP=s.MALOP where MASV ='" + MASV + "' and MANV= '" + MaNV + "'", conn);
            int check = (int)cmd.ExecuteScalar();
            if (check > 0)
            {
                try
                {
                    SqlCommand command = new SqlCommand("EXEC SP_INS_MARK_SINHVIEN '" + MASV + "','" + MAHP + "'," + DIEMTHI + ",'" + MaNV + "'", conn);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Nhập điểm thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi nhập điểm: " + ex.Message);
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
                MessageBox.Show("Sinh viên này không thuộc nhân viên '" + MaNV + "' quản lý!");
                conn.Close();
            }
        }

        private void IGrades_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
