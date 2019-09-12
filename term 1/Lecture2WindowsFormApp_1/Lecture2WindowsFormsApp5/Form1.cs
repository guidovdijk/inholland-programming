using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            // Define values
            const double vat = 0.21;
            double shirtsAmount = int.Parse(textBoxShirts.Text);
            double jeansAmount = int.Parse(textBoxJeans.Text);

            // Get date
            string date = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");

            // Calc price
            double price = (shirtsAmount * 30) + (jeansAmount * 100);
            double vatPrice = price * vat;
            double totalPrice = price + vatPrice;

            dateLabel.Text = date;
            priceLabel.Text = "€ " + price.ToString("00.00");
            vatLabel.Text = "€ " + vatPrice.ToString("00.00");
            totalPriceLabel.Text = "€ " + totalPrice.ToString("00.00");
        }
    }
}
