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
    public partial class ListClass : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = QLSVNhom; Integrated Security = True");
        public ListClass(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void ListClass_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LOP", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string lop = textBox1.Text.ToString();
            if (lop != "")
            {
                SqlCommand command = new SqlCommand("SELECT * FROM LOP WHERE MALOP = '" + lop + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {

                SqlCommand command = new SqlCommand("SELECT * FROM LOP", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }
    }
}
