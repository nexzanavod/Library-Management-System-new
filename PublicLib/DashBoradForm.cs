using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PublicLib
{
    public partial class DashBoradForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Dblibrary;Integrated Security=True");
        public DashBoradForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void DashBoradForm_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from C_Reader", Con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            KidMembersID.Text = dt.Rows[0][0].ToString();

            
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from E_Reader", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            AdultMembersID.Text = dt2.Rows[0][0].ToString();

            
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from Authentication_system", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            AuthenticationsystemID.Text = dt3.Rows[0][0].ToString();

            
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from Bookinfo", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            BookinfoID.Text = dt4.Rows[0][0].ToString();

            
            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from Contact", Con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            ContactID.Text = dt5.Rows[0][0].ToString();

            
            SqlDataAdapter sda6 = new SqlDataAdapter("select count(*) from Pascode", Con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            PascodeID.Text = dt6.Rows[0][0].ToString();

            
            SqlDataAdapter sda7 = new SqlDataAdapter("select count(*) from Publisher", Con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            PublisherID.Text = dt7.Rows[0][0].ToString();

            
            SqlDataAdapter sda8 = new SqlDataAdapter("select count(*) from Registration_System", Con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            AuthenticationsystemID.Text = dt8.Rows[0][0].ToString();

            
            SqlDataAdapter sda9 = new SqlDataAdapter("select count(*) from Rentbook", Con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            RentbookID.Text = dt9.Rows[0][0].ToString();

            
            SqlDataAdapter sda10 = new SqlDataAdapter("select count(*) from staff", Con);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            staffID.Text = dt10.Rows[0][0].ToString();

            Con.Close();



        }

        private void KidMembersID_Click(object sender, EventArgs e)
        {

        }
    }
}
