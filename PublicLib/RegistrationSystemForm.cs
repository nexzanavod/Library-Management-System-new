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

namespace PublicLib
{
    public partial class RegistrationSystemForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Dblibrary;Integrated Security=True");
        public RegistrationSystemForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Regno.Text == "" || Fname.Text == "" || Lname.Text == "" || Dob.Text == "" || Membertype.Text == "" | Userid.Text == "" || Regdate.Text == "" || Expdate.Text == "" || Regfee.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Registration_System values (" + Regno.Text + ",'" + Fname.Text + "','" + Fname.Text + "','" + Dob.Text + "','" + Membertype.Text + "','" + Userid.Text + "','" + Regdate.Text + "','" + Expdate.Text + "','" + Regfee.Text + "',)", Con);
                cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Memeber Registration Details Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void RegistrationSystemForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from Registration_System";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RegistrationSystemDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Regno.Text == "" || Fname.Text == "" || Lname.Text == "" || Dob.Text == "" || Membertype.Text == "" | Userid.Text == "" || Regdate.Text == "" || Expdate.Text == "" || Regfee.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update Registration_System set Regno='" + Regno.Text + "',Fname='" + Fname.Text + "',Lname='" + Lname.Text + "',Dob='" + Dob.Text + "',Membertype='" + Membertype.Text + "',Userid='" + Userid.Text + "',Regdate='" + Regdate.Text + "',Expdate='" + Expdate.Text + "',Regfee='" + Regfee.Text + "' where UserID =" + Regno.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Member Registration Details Successfully Updated");
                Con.Close();
                populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Regno.Text == "")
            {
                MessageBox.Show("Enter The Reg. No");
            }
            else
            {
                Con.Open();
                string query = "delete from Registration_System where Regno = " + Regno.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Member Registration Details Successfully Deleted");
                Con.Close();
                populate();
            }
        }
    }
}
