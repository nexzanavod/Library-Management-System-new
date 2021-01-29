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
    
    public partial class KidMembersForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Dblibrary;Integrated Security=True");

        public KidMembersForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "" || FName.Text == "" || LName.Text == "" || Gender.Text == "" || Address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into C_Reader values (" + UserID.Text + ",'" + FName.Text + "','" + LName.Text + "','" + Gender.Text + "','" + Address.Text + "',)", Con);
                cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Kid Members Details Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "" || FName.Text == "" || LName.Text == "" || Gender.Text == "" || Address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update C_Reader set UserID='" + UserID.Text + "',FName='" + FName.Text + "',LName='" + LName.Text + "',Gender='" + Gender.Text + "',Address='" + Address.Text + "' where UserID =" + UserID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Kid Members Details Successfully Updated");
                Con.Close();
                populate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "")
            {
                MessageBox.Show("Enter The User ID");
            }
            else
            {
                Con.Open();
                string query = "delete from C_Reader where UserID = " + UserID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Kid Members Details Successfully Deleted");
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

        private void KidMembersForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from C_Reader";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            KidMembersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KidMembersDGV_Click(object sender, EventArgs e)

        {

        }

        private void KidMembersDGV_Navigate(object sender, NavigateEventArgs ne)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KidMembersDGV_Navigate_1(object sender, NavigateEventArgs ne)
        {

        }
    }
}
