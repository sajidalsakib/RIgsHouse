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
    public partial class buyUsed : Form
    {
        string username;    user a = new user(); Cuproduct p = new Cuproduct(); Cproduct c = new Cproduct();
        public buyUsed(string username, string id)
        {
            InitializeComponent();
            this.username = username;
            a.getInfo(username);    p.UgetInfo(id); 
            p.getCartStatus();
            
            
            pictureBox1.Image = p.pic00;
            pictureBox2.Image = p.pic01;

            productName.Text = p.name;

            label7.Text = a.name;
            label8.Text = p.price + "৳";
            richTextBox1.Text = p.description;

            if(p.status == "0")
            {

                label3.Visible = true;

            }

            else if(username == p.Username) { label3.Visible = false; }

            else if(p.Cstatus=="1")
            {

                button1.Visible = true; 
                numericUpDown1.Visible = true; 

                numericUpDown1.Value = 1;
              

            }

            else
            {

                button1.Visible = true; cart.Visible = true;
                numericUpDown1.Visible = true; numericUpDown2.Visible = true;

                numericUpDown1.Value = 1;
                numericUpDown2.Value = 1;

            }





        }

        private void buyUsed_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          bool flag = p.buyItem(username, Convert.ToInt32(numericUpDown1.Value));

            if (flag)
            {
                MessageBox.Show("Purchase Successfull.", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                p.updateUsedProductList();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Unsuccessful", "Please Try again");
            }

    


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int a = p.cart(username, Convert.ToInt32(numericUpDown2.Value));

            if (a > 0)
            {
                MessageBox.Show("Added to the cart");
                numericUpDown2.Visible = false;
                cart.Visible = false;
            }
            else
            {
                MessageBox.Show("Unable to Add");
            }



        }
    }
}
