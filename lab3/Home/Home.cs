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
    public partial class Home : Form
    {
        SqlConnection conn;
        public Home(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            customizeDesign();

        }
        private void customizeDesign()
        {
            PImplement.Visible = false;
            PList.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        public void loadForm(object Form)
        {

            if (this.PTable.Controls.Count > 0)
                this.PTable.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PTable.Controls.Add(f);
            this.PTable.Tag = f;
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new ListClass(conn));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new ListStudent(conn));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(PList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(PImplement);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnI_class_Click(object sender, EventArgs e)
        {
            IClass form = new IClass(conn);
            form.Show();
        }

        private void btnI_Student_Click(object sender, EventArgs e)
        {
            IStudent form = new IStudent(conn);
            form.Show();
        }
    }
}
