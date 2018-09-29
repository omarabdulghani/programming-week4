using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string input = txtSide.Text;
            int n = int.Parse(input);

            int m = (panel1.Size.Width - lblSquare.Size.Width) / 2;
            lblSquare.Location = new Point(m, lblSquare.Location.Y);

            lblSquare.Text = "";
            

            for (int x = 1; x <= n; x++) 

            {
                for (int y = 1; y <= n; y++)
                {
                    if (x == 1 || x == n || y == 1 || y == n)
                    {
                       
                        lblSquare.Text += "X";
                    }
                    else
                    {
                        lblSquare.Text += " ";
                    }
                    
                     

                }

                lblSquare.Text += "\n";

            }
        }
        private void txtSide_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
