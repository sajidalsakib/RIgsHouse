using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RigsHouse
{
    public partial class expertHome : Form

    {
        string username;
        public expertHome(String Username)
        {
            InitializeComponent();
            this.username = Username;
        }

        public expertHome()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            account a = new account(username);
            a.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageSell a = new manageSell(username);
            a.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
          

        }

        private void expertHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
