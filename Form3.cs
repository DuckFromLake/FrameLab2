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
    public partial class Form3 : Form
    {
        Human[] arrayh = new Human[3];

        public Form3()
        {
            InitializeComponent();
            arrayh[0].name = "Никита";
            arrayh[0].age = 20;
            arrayh[0].number = 234;
            arrayh[1].name = "Егор";
            arrayh[1].age = 19;
            arrayh[1].number = 009;
            arrayh[2].name = "Данил";
            arrayh[2].age = 18;
            arrayh[2].number = 561;
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            label4.Text = arrayh[0].name;
            label5.Text = arrayh[1].name;
            label6.Text = arrayh[2].name;
            string age1 = Convert.ToString(arrayh[0].age);
            label7.Text = age1;
            string age2 = Convert.ToString(arrayh[1].age);
            label8.Text = age2;
            string age3 = Convert.ToString(arrayh[2].age);
            label9.Text = age3;

            string num1 = Convert.ToString(arrayh[0].number);
            label10.Text = num1;
            string num2 = Convert.ToString(arrayh[1].number);
            label11.Text = num2;
            string num3 = Convert.ToString(arrayh[2].number);
            label12.Text = num3;
        }
        struct Human
        {
            public int number;
            public string name;
            public int age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            int n = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < 3; i++)
            {
                if (arrayh[i].number == n)
                {
                    label15.Text = arrayh[i].name;
                    k = 1;
                }
            }
            if ( k == 0)
            {
                label15.Text = "Неверный номер";
            }
        }
    }
}
