using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int textBox1Value = int.Parse(textBox1.Text);
            int textBox2Value = int.Parse(textBox2.Text);
            int textBox3Value = int.Parse(textBox3.Text);

            int average = (textBox1Value + textBox2Value + textBox3Value) / 3;

            averageLabel.Text = average.ToString("0.00");
        }
    }
}
