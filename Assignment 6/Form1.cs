using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int sum = 0;
            

            string input = txtNumber.Text;
            int n = int.Parse(input);

            double sumtwo = n * (n + 1) / 2;

            while ( counter <= n )
            {
                sum = sum + counter;
                    
                counter++;

            }

            lblOne.Text = sum.ToString("0");
            lblTwo.Text = sumtwo.ToString("0");

            if ( sum == sumtwo)

            {
                lblsumandform.Text = "The sum and formula are equal.";
            }

            else

                lblsumandform.Text = "The sum and formula are not equal.";  //.. which will never happen :)
        }

        private void lblOne_Click(object sender, EventArgs e)
        {

        }
    }
}
