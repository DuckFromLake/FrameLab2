using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameLab2NNN
{
    public partial class Form2 : Form
    {
        int x, y, z, h;
        double a, b, p = 0, k = 0;
        double[] array = new double[3];
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);
            h = Convert.ToInt32(textBox4.Text);

            a = (Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / (1 + (Math.Pow(2, x) / 2) + (Math.Pow(2, y) / 4));
            string ast = Convert.ToString(a);
            label8.Text = ast;
            b = x * (Math.Atan(z) + Math.Exp(1));
            string bs = Convert.ToString(b);
            label7.Text = bs;
            string st = Convert.ToString((Math.Pow(2, a) + (a * 2 * h)));
            label11.Text = st;

            array[0] = x;
            array[1] = y;
            array[2] = z;


            while (p == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    p = 1;
                    if (array[i] < array[i + 1])
                    {
                        k = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = k;
                        p = 0;
                    }
                }
            }

            string ar1 = Convert.ToString(array[0]);
            label13.Text = ar1;
            string ar2 = Convert.ToString(array[1]);
            label14.Text = ar2;
            string ar3 = Convert.ToString(array[2]);
            label15.Text = ar3;
        }
    }
}
