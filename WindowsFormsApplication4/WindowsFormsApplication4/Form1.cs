using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class CALCULATOR : Form
    {
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void textBox1num1_TextChanged(object sender, EventArgs e)
        {
            var NUM1 = textBox1num1.Text;
        }

        private void textBox2num2_TextChanged(object sender, EventArgs e)
        {
            var NUM2 = textBox2num2.Text;
        }

        private void addtion_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            var NUM1 = Convert.ToInt32(textBox1num1.Text);
            var NUM2 = Convert.ToInt32(textBox2num2.Text);
            result.Text=Convert.ToString(cal.ADD(NUM1,NUM2));
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            var NUM1 = Convert.ToInt32(textBox1num1.Text);
            var NUM2 = Convert.ToInt32(textBox2num2.Text);
            result.Text = Convert.ToString(cal.SUBSTRACT(NUM1, NUM2));
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            var NUM1 = Convert.ToInt32(textBox1num1.Text);
            var NUM2 = Convert.ToInt32(textBox2num2.Text);
            result.Text = Convert.ToString(cal.MULTIPLY(NUM1, NUM2));
        }

        private void division_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            var NUM1 = Convert.ToInt32(textBox1num1.Text);
            var NUM2 = Convert.ToInt32(textBox2num2.Text);
            result.Text = Convert.ToString(cal.DIVIDE(NUM1, NUM2));
        }
    }
}
