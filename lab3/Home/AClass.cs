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


namespace Home
{
    public partial class AClass : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H707EH2\VUHIEU;Initial Catalog=QLSVNhom;Integrated Security=True");

        public AClass(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM LOP WHERE MALOP = '" + textBox4.Text.ToString() + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                textBox1.Text = table.Rows[0][0].ToString();
                textBox2.Text = table.Rows[0][1].ToString();
                textBox3.Text = table.Rows[0][2].ToString();
            }
            else
            {
                
            }

            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from LOP where MALOP ='" + textBox1.Text.ToString() + "'", conn);
            int check = (int)cmd.ExecuteScalar();
            if (check == 0)
            {
                try
                {
                    SqlCommand command = new SqlCommand("exec SP_ALTER_CLASS '" + textBox4.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "'", conn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa lớp thành công!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi sửa lớp: " + ex.Message);
                }
                finally
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lớp này đã tồn tại!");
                conn.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AClass_Load(object sender, EventArgs e)
        {

        }
    }
}
