using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int number3 = int.Parse(textBox3.Text);
            int number4 = int.Parse(textBox4.Text);
            int total12 = number1 + number2;
            int total34 = number3 + number4;
            MessageBox.Show("1,2的總和是"+total12+"3,4的總和是"+total34);
        }
    }
}
