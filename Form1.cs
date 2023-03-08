using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace The_Food_Taxi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void loginbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM  tbl_users WHERE username= '" + usernametextBox.Text + "' and password='" + passwordtextBox.Text + "' ";
            cmd= new OleDbCommand(login,con);
            OleDbDataReader dr= cmd.ExecuteReader();
            if (dr.Read()==true) 
            {
                con.Close();
                new homepage().Show();
                this.Hide();
            }
            else
            {
                con.Close();
                MessageBox.Show("Invalid Username or Password,Please Try Again","LogIN Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                usernametextBox.Clear();
                passwordtextBox.Clear();
                usernametextBox.Focus();
            }
        }

        private void clearloginbutton_Click(object sender, EventArgs e)
        {
            usernametextBox.Clear();
            passwordtextBox.Clear();
            usernametextBox.Focus();
        }

        private void showpasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasscheckBox.Checked)
            {
                passwordtextBox.PasswordChar = '\0';
 
            }
            else
            {
                passwordtextBox.PasswordChar = '*';
               
            }
        }

        private void createacclabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
