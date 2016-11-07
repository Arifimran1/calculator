using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "9";
        }

        private void bAc_Click(object sender, EventArgs e)
        {
            disp.Text = "";
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text.Remove(disp.Text.Length - 1);
            
            
        }

        private void b0_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + "0";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            disp.Text = disp.Text + ".";
        }

        private void benter_Click(object sender, EventArgs e)
        {

        }

        private void disp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
