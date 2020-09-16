using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаболаторна_ООП__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = 0;
            double volume = 0;
            bool result = double.TryParse(textBox1.Text.ToString(), out radius);
            if (result == false) 
            {
                label2.Text = "print only number";
            }
            else
            {
                if (radius < 0) 
                {
                    label2.Text = "radius can\'t be less than 0";
                  
                }
                else 
                {
                    volume = 4 * Math.PI * Math.Pow(radius, 3) / 3;
                    label2.Text = volume.ToString();
                }
                
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
