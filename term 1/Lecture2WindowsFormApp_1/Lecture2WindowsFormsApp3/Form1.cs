using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double seconds = int.Parse(textBox1.Text);

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            string timeStr = time.ToString(@"hh\:mm\:ss");

            labelHour.Text = timeStr;
        }
    }
}
