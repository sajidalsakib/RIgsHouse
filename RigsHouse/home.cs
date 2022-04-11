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
    public partial class home : Form
    {   
        string username;
        public home()
        {
            InitializeComponent();
        }

        public home(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepSkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DeepSkyBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.DeepSkyBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            product a = new product(username);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            account a = new account(username);
            a.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cart00 a = new cart00(username, 0);
            a.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellProduct a = new sellProduct(username);
            a.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            used a = new used(username);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Laptop", 0);
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Processor", 0);
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Graphics Card", 0);
            a.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Mouse", 0);
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "SSD", 0);
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Keyboard", 0);
            a.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "RAM(Desktop)", 0);
            a.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "RAM(Laptop)", 0);
            a.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "CPU Cooler", 0);
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Motherboard", 0);
            a.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Casing", 0);
            a.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Hard Disk Drive", 0);
            a.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Power Supply", 0);
            a.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Monitor", 0);
            a.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            displayProduct a = new displayProduct(username, "Others", 0);
            a.Show();
        }
    }
}
