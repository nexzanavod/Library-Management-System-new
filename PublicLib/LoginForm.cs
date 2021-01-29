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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            
            {
                string user, pass;
                user = txtUser.Text;
                pass = txtPass.Text;
                if (user == "admin" && pass == "admin")
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Email or Password.Try Again");
                }
            }
   
    }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
