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
    public partial class cart00 : Form
    {
        Cproduct p = new Cproduct();   

        string username; int number; int row;

        string id1, id2, id3, id4, id5, id6;

       string unit1, unit2, unit3, unit4, unit5, unit6;




        public cart00(string username, int num)
        {
            InitializeComponent();
            this.username = username; this.number = num;

            row = p.getRow(username);

            if (number == 0)
            {
                privious.Visible = false;
            }

            if (number < row)
            {

                pictureBox1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;

                p.cartList(username, number); //cart list will give us the information for the blocks we draw
                
                id1 = p.id; label2.Text = p.name;    unit1 = p.unit; pictureBox1.Image = p.pic;

                
                
                number++;
            }

            if (number < row)
            {

                pictureBox2.Visible = true;
                label3.Visible = true;
                button2.Visible = true;

                p.cartList(username, number);

                id2 = p.id;     label3.Text = p.name;    unit2 = p.unit; pictureBox2.Image = p.pic;
               
                number++;
            }

            if (number < row)
            {

                pictureBox3.Visible = true;
                label4.Visible = true;
                button3.Visible = true;

                p.cartList(username, number);

                id3 = p.id;     label4.Text = p.name;    unit3 = p.unit;    pictureBox3.Image = p.pic;
                number++;
            }

        
            if (number < row)
            {

                pictureBox4.Visible = true;
                label5.Visible = true;
                button4.Visible = true;

                p.cartList(username, number);

                id4 = p.id;     label5.Text = p.name;    unit4 = p.unit;    pictureBox4.Image = p.pic;
                number++;
            }

        
            if (number < row)
            {

                pictureBox5.Visible = true;
                label6.Visible = true;
                button5.Visible = true;

                p.cartList(username, number);

                id5 = p.id;     label6.Text = p.name;    unit5 = p.unit;     pictureBox5.Image = p.pic;
                number++;
            }

            if (number < row)
            {

                pictureBox6.Visible = true;
                label7.Visible = true;
                button6.Visible = true;

                p.cartList(username, number);

                id6 = p.id;     label7.Text = p.name;    unit6 = p.unit;    pictureBox6.Image = p.pic;
                number++;
            }

            if (number > 5 && number < row)
            {
                next.Visible = true;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = p.deleteCart(id1);
            if (a > 0)
            {
                // MessageBox.Show("Data Deleted Successfully");
                refresh();
            }
            else
            {
                MessageBox.Show("Unable to Remove");
            }

        }

        void refresh()
        {
            this.Hide();
            cart00 a = new cart00(username, 0);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = p.deleteCart(id2);
            if (a > 0)
            {
                // MessageBox.Show("Data Deleted Successfully");
                refresh();
            }
            else
            {
                MessageBox.Show("Unable to Remove");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = p.deleteCart(id3);
            if (a > 0)
            {
                // MessageBox.Show("Data Deleted Successfully");
                refresh();
            }
            else
            {
                MessageBox.Show("Unable to Remove");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = p.deleteCart(id4);
            if (a > 0)
            {
                // MessageBox.Show("Data Deleted Successfully");
                refresh();
            }
            else
            {
                MessageBox.Show("Unable to Remove");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = p.deleteCart(id5);
            if (a > 0)
            {
                // MessageBox.Show("Data Deleted Successfully");
                refresh();
            }
            else
            {
                MessageBox.Show("Unable to Remove");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = p.deleteCart(id6);
            if (a > 0)
            {
                // MessageBox.Show("Data Deleted Successfully");
                refresh();
            }
            else
            {
                MessageBox.Show("Unable to Remove");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cbuy a = new Cbuy(username, id1, unit1);
            a.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cbuy a = new Cbuy(username, id2, unit2);
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cbuy a = new Cbuy(username, id3, unit3);
            a.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cbuy a = new Cbuy(username, id4, unit4);
            a.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cbuy a = new Cbuy(username, id5, unit5);
            a.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cbuy a = new Cbuy(username, id6, unit6);
            a.Show();
        }

        private void privious_Click(object sender, EventArgs e)
        {
            cart00 a = new cart00(username, 0);
            this.Hide();
            a.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            cart00 a = new cart00(username, number);
            this.Hide();
            a.Show();
        }
        private void cart00_Load(object sender, EventArgs e)
        {

        }
    }
}
