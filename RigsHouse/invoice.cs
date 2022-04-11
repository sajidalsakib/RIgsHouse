using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace RigsHouse
{
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            label1.Text = "Buyer Name:";label3.Text = "Moshiur Rahman";
            label2.Text = "Product Name:"; label4.Text = "Mouse";
            label7.Text = "Total Unit:"; label8.Text = "5";
            label9.Text = "Total Price:"; label10.Text = "10000$";
            label5.Text = "Date:"; label6.Text = DateTime.Now.ToString();



            e.Graphics.DrawString(label1.Text, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(label3.Text, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(52, 0));

            e.Graphics.DrawString(label2.Text, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, 20));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(60, 20));

            e.Graphics.DrawString(label5.Text, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString(label6.Text, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(52, 40));

            e.Graphics.DrawString(label7.Text, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, 50));
            e.Graphics.DrawString(label8.Text, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(52, 50));

            e.Graphics.DrawString(label9.Text, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, 60));
            e.Graphics.DrawString(label10.Text, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(52, 60));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 200, 200);
            //printDoc.DefaultPageSettings.PaperSize = new PaperSize("label", properWidthInHundretsOfInches, properHeightInHundretsOfInches);

          //  printDoc.DefaultPageSettings.PaperSize = 


            printPreviewDialog1.ShowDialog();
        }

        private void invoice_Load(object sender, EventArgs e)
        {

        }
    }
}
