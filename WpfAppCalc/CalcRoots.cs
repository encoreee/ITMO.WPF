using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalcRoots : Form
    {

        static IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        public CalcRoots()
        {
            InitializeComponent();
        }

        public string Coef1 
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Coef2 
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string Coef3 
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double root1;
            double root2;
            double c1 = double.Parse(Coef1, formatter);
            double c2 = double.Parse(Coef2, formatter);
            double c3 = double.Parse(Coef3, formatter);

            CalcRootEngine.Ur2.Gg(c1,c2,c3,out root1,out root2);

            lblRoot1.Text = root1.ToString();
            lblRoot2.Text = root2.ToString();
        }
    }
}
