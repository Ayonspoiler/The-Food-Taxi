
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace The_Food_Taxi
{
    public partial class takeoutmenu : Form
    {
        public takeoutmenu()
        {
            InitializeComponent();
        }

        private void burgitem_Click(object sender, EventArgs e)
        {

        }

        private void plusbt_Click(object sender, EventArgs e)
        {
            
        }

        private void takeoutmenu_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void nagaburg_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkburglabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox2.Items.Add(chkburglabel.Label);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cartbt_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(dblchkburgtext.Text);
        }

        private void cartbutton_Click(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bigburgpricelabel_Click(object sender, EventArgs e)
        {

        }

        private void listViewbigshow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewchkburger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkburgreglabel_Click(object sender, EventArgs e)
        {

        }

        private void Backtakeoutlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new restaurant().Show();
        }

        private void viewcarttakeoutbt_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Addcartlist().Show();
        }

        private void oreoshakebt_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
