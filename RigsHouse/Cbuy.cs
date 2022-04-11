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
    public partial class Cbuy : Form
    {
        Cproduct p = new Cproduct();
        string username;
        public Cbuy(string username, string id, string unit)
        {
            InitializeComponent();
            //using this we can find just info from cart
            this.username = username;
            p.cartInfo(id);

            label2.Text = p.name;
            label8.Text = p.Sprice+ "৳";

            if(p.Ustatus == "1")
            {
               btnUpdate.Visible = false;
                numericUpDown1.Maximum = 1;
            }

            else 
            {
                numericUpDown1.Value = Convert.ToInt32(unit); ;
                pictureBox1.Image = p.pic;
            }
            
        }

        private void buy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = p.buyItem(username, Convert.ToInt32(numericUpDown1.Value));

            if (flag == true)
            {
                int a = p.deleteCart(p.id);
                if (a > 0)
                {
                    // MessageBox.Show("Data Deleted Successfully");
                    this.Hide();
                    cart00 b = new cart00(username, 0);
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Unable to Remove");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.updateCart(Convert.ToString(numericUpDown1.Value));

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            cart00 a = new cart00(username, 0);
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
