using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace RigsHouse
{
    public partial class productOverview : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["pltops"].ConnectionString;
        public string id, name, description;
        int Rprice, Sprice; byte[] img;

        public productOverview()
        {
            InitializeComponent();

            getInfo();
            pictureBox2.Image = GetPhoto(img);
          //  richTextBox2.Text = name;
            label1.Text = Sprice + "৳";

          /*  img = getImage(1);
            pictureBox1.Image = GetPhoto(img);
            richTextBox3.Text = name;
            label2.Text = Sprice + "৳";


            img = getImage(2);
            pictureBox3.Image = GetPhoto(img);
            richTextBox5.Text = name + "৳";
            label3.Text = Sprice + "৳";*/

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

           // id = getId(0); name = getName(0); Rprice = getRprice(0); Sprice = getSprice(0); description = getDescription(0);
        
        }

        

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

  

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;


        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;

        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;


        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //id = getId(1); name = getName(1); Rprice = getRprice(1); Sprice = getSprice(1); description = getDescription(1);

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //id = getId(2); name = getName(2); Rprice = getRprice(2); Sprice = getSprice(2); description = getDescription(2);

        }

        void getInfo()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from product where category='SSD'"; //we want to see
            SqlCommand passing = new SqlCommand(query, con);


            con.Open();


            SqlDataAdapter sd = new SqlDataAdapter(passing);
            DataTable data = new DataTable();
            sd.Fill(data);

            id = data.Rows[0][0].ToString(); 
            name = data.Rows[0][1].ToString();
            Rprice = Convert.ToInt32(data.Rows[0][2]);
            int discount = Convert.ToInt32(data.Rows[0][3]);
            Sprice = (Rprice * discount) / 100;

            description= data.Rows[0][7].ToString();
            img = (byte[])data.Rows[0][6];

            con.Close();
        
        }

    }
}
