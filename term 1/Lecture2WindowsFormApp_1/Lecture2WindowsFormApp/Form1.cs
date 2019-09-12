using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputPrice = textBox1.Text;
            double price = double.Parse(inputPrice);

            double vatPercent = 0.21;

            double vat = price * vatPercent;

            double total = price + vat;

            vatLabel.Text = vatPercent.ToString("0.00");
            priceLabel.Text = price.ToString("0.00");
            totalPriceLabel.Text = total.ToString("0.00");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
