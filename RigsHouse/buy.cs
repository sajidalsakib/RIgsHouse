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
    public partial class buy : Form
    {
        Cproduct p = new Cproduct();
        string username; int Tprice;
        public buy(string username, string id, int unit)
        {
            InitializeComponent();
            p.getInfo(id); 
            this.username = username;

            label2.Text = p.name;
            label7.Text = Convert.ToString(unit);
            Tprice = p.Rprice - ((p.discount * p.Rprice) / 100);
            Tprice = unit * Tprice;
            label8.Text = Convert.ToString(Tprice)+"$";
            pictureBox1.Image = p.pic;
            
        }

        private void buy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = p.buyItem(username, Convert.ToInt32(label7.Text));
            if (flag == true)
                this.Hide();


        }
    }
}
