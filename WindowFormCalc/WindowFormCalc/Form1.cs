using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLib;

namespace WindowFormCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate cal;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cal = new Calculate();
            cal.num1 = Convert.ToInt32(txtNum1.Text);
            cal.num2 = Convert.ToInt32(txtNum2.Text);
            lblAllMethod.Text = "Addition is " + cal.Addition().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            cal = new Calculate();
            cal.num1 = Convert.ToInt32(txtNum1.Text);
            cal.num2 = Convert.ToInt32(txtNum2.Text);
            lblAllMethod.Text = "Subtraction is " + cal.Subtract().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            cal = new Calculate();
            cal.num1 = Convert.ToInt32(txtNum1.Text);
            cal.num2 = Convert.ToInt32(txtNum2.Text);
            lblAllMethod.Text = "Multiplication is " + cal.Multiply().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            cal = new Calculate();
            cal.num1 = Convert.ToInt32(txtNum1.Text);
            cal.num2 = Convert.ToInt32(txtNum2.Text);
            lblAllMethod.Text = "Quotient is " + cal.Divide().ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
       
    }
}
