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
    public partial class mBuy : Form
    {
        string username, id; int unit; Cproduct p = new Cproduct();


        public mBuy(string username, string id, int unit)
        {
            InitializeComponent();  this.username = username;this.unit = unit;
            p.getInfo(id);
            label2.Text = p.name;
            label8.Text = Convert.ToString(p.Rprice)+ "৳";
            label3.Text = Convert.ToString(p.Rprice*unit)+ "৳";


        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = p.buyItem(username, unit);

            if (flag == true)
            {
                 // MessageBox.Show("Data Deleted Successfully");
                    this.Hide();
               
            }
        }

        private void mBuy_Load(object sender, EventArgs e)
        {

        }
    }
}
