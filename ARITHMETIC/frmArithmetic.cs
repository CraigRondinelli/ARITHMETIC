using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ARITHMETIC

    //Craig Rondinelli
    //CIS 202
    //Arithmetic
{
    public partial class frmArithmetic : Form
    {
        public frmArithmetic()
        {
            InitializeComponent();
        }

        private void frmArithmetic_Load(object sender, EventArgs e)
        {
            this.Text = "Craig Rondinelli";
            this.AcceptButton = btnAdd;
            this.CancelButton = btnClear;

        }
        //Converts numbers entered into textboxes, adds them, then displays the result in label.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y, z;
                x = int.Parse(txtIn1.Text);
                y = int.Parse(txtIn2.Text);
                z = x + y;
                lblOut.Text = (x.ToString("#,##")) + " + " + (y.ToString("#,##")) + " = " + (z.ToString("#,##"));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }
        //Converts numbers entered into textboxes, subtracts them, then displays the result in label.
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y, z;
                x = int.Parse(txtIn1.Text);
                y = int.Parse(txtIn2.Text);
                z = x - y;
                lblOut.Text = (x.ToString("#,##")) + " - " + (y.ToString("#,##")) + " = " + (z.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }
        //Converts numbers entered into textboxes, multiplies them, then displays the result in label.
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y, z;
                x = int.Parse(txtIn1.Text);
                y = int.Parse(txtIn2.Text);
                z = x * y;
                lblOut.Text = (x.ToString("#,##")) + " * " + (y.ToString("#,##")) + " = " + (z.ToString("#,##"));

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }
        //Converts numbers entered into textboxes, compares them, determines which number is larger, then displays the result in label.
        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y, z;
                x = int.Parse(txtIn1.Text);
                y = int.Parse(txtIn2.Text);
                z = Math.Max(x, y);
                lblOut.Text = "The bigger number of " + (x.ToString("#,##")) + " and " + (y.ToString("#,##")) + " is " + (z.ToString("#,##")) + ".";
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }
        //Clears all textboxes and label.
        private void btnClear_Click(object sender, EventArgs e)                                    
        {
            txtIn1.Clear();
            txtIn2.Clear();
            lblOut.Text = "";
        }
        //Enters a random number from 1-100 in each textbox.
        private void btnRandom_Click(object sender, EventArgs e)                                   
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 101);
            txtIn1.Text = (x.ToString());
            int y = rnd.Next(1, 101);
            txtIn2.Text = (y.ToString());
            
        }
        //Makes the picture disappear when clicked on.
        private void picMath_Click(object sender, EventArgs e)                                      
        {
            picMath.Visible = false;


        }
        //Resizes form window 200 pixels in width and height to reveal hidden picture.
        private void btnChallenge_Click(object sender, EventArgs e)
        {
            if (Size.Width <= 667)
            {
                this.Width = 867;
                this.Height = 686;
            }
            else
            {
                this.Width = 667;
                this.Height = 486;

            }
        }
        //Moves a picture down the side of the window and returns to the top, once it is completely off the bottom.
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            picChallenge.Top -= -4;
            if (picChallenge.Top >= ClientRectangle.Height)
                picChallenge.Top = 0 - picChallenge.Height;
            
        }

        

        
    }
}
