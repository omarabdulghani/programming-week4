using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            double counter = 1;

            string startinput = txtStartAmount.Text;
            double capital = double.Parse(startinput);

             

            while (counter <= 5 )
            {
                counter++;
                capital = capital + (capital * 0.05);

            }

            lblFinalCapital.Text = capital.ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
