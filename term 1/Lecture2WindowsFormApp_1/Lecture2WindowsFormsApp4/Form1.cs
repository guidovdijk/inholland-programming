using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            const double vat = 0.21;
            double kmStart = double.Parse(textBoxStart.Text);
            double kmEnd = double.Parse(textBoxEnd.Text);
            double kmPrice = double.Parse(textBoxPricePerKm.Text);

            double totalKm = kmEnd - kmStart;
            double priceWithoutVat = totalKm * kmPrice;
            double vatPrice = priceWithoutVat * vat;

            double totalPrice = priceWithoutVat + vatPrice;

            labelPriceExVat.Text = priceWithoutVat.ToString();
            labelVat.Text = vatPrice.ToString();
            labelTotal.Text = totalPrice.ToString();
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            labelPriceExVat.Text = null;
            labelVat.Text = null;
            labelTotal.Text = null;

            textBoxStart.Text = null;
            textBoxEnd.Text = null;
            textBoxPricePerKm.Text = null;
        }
    }
}
