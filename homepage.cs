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
    public partial class homepage : Form
    {
        bool sideberExpand;
        public homepage()
        {
            InitializeComponent();
        }

        private void s(object sender, EventArgs e)
        {
            if (sideberExpand)
            {
                sideber1.Width -= 10;
                if (sideber1.Width == sideber1.MinimumSize.Width)
                {
                    sideberExpand = false;
                    sidebertimer.Stop();
                }
            }
            else
            {
                sideber1.Width += 10;
                if (sideber1.Width == sideber1.MaximumSize.Width)
                {
                    sideberExpand = true;
                    sidebertimer.Stop(); 
                }
            }
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            sidebertimer.Start();
        }

        private void mainbutton_Click(object sender, EventArgs e)
        {
            if(panel7.Height==205)
            {
                panel7.Height = 42;
            }
            else
            {
                panel7.Height = 205;
            }
             
        }

        private void homepage_load(object sender, EventArgs e)
        {
            panel7.Height = 42;
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show(); //logging out
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new About().Show();
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new profile().Show();
        }
    }
}
