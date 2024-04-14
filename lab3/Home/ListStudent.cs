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

    public partial class ListStudent : Form
    {
        SqlConnection conn;

        public ListStudent(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string MaLop = textBox2.Text.ToString();
            string MaSV = textBox1.Text.ToString();
            if (MaLop != "" && MaSV != "")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE MASV = '" + MaSV + "' and MALOP ='" + MaLop + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (MaLop != "" && MaSV == "")
            {

                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE  MALOP ='" + MaLop + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (MaLop == "" && MaSV != "")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE  MASV ='" + MaSV + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void ListStudent_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MaLop = textBox2.Text.ToString();
            string MaSV = textBox1.Text.ToString();
            if (MaLop != "" && MaSV != "")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE MASV = '" + MaSV + "' and MALOP ='" + MaLop + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (MaLop != "" && MaSV == "")
            {

                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE  MALOP ='" + MaLop + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (MaLop == "" && MaSV != "")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE  MASV ='" + MaSV + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
