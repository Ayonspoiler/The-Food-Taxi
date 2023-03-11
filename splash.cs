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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timersplash_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            progress.Value= startpos;
            if(startpos <=33)
            {
                loadinglabel.Text = "Professional Application";
                loadinglabel.ForeColor= Color.WhiteSmoke;
            }
            else if(startpos>33 && startpos<=65)
            {
                loadinglabel.Text = "Developed by Professional Team";
                loadinglabel.ForeColor = Color.White;
            }
            else if(startpos>65)
            {
                loadinglabel.Text = "Contact: Ashik,Esham And Ayon";
                loadinglabel.ForeColor = Color.WhiteSmoke;
            }
            if(progress.Value==100)
            {
                progress.Value = 0;
                timersplash.Stop();
                this.Hide();
                new Login().Show();
            }

        }

        private void splash_Load(object sender, EventArgs e)
        {
            timersplash.Start();
        }
    }
}
