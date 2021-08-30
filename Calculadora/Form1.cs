using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public object TextResultado { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }
    }
}
