using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ekok_Bul
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int a, b, c, ekok = 1, son;

        #endregion

        #region Metodlar

        public void son1()
        {

            if (a > b)
                son = a;
            else if (a < b)
                son = b;
        }

        public void son2()
        {
            son = 0;

            if (a > son)
            {
                son = a;
            }

            if (b > a)
            {
                son = b;
            }

            if (c > b)
            {
                son = c;
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            label3.Visible = false;
            label4.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label4.Visible = false;
                textBox3.Visible = false;
                groupBox2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekok = 1;

            if (radioButton1.Checked == true)
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                label6.Text = "Ekok(" + a + "," + b + ") =";

                son1();


                if (a == b)
                {
                    groupBox3.Visible = true;

                    label5.Text = a.ToString();
                }

                else
                {
                    for (int i = 2; i <= son; i++)
                    {
                        if (a % i == 0  || b % i == 0)
                        {
                            if (a%i==0)
                            {
                                a = a / i;
                            }

                            if (b%i==0)
                            {
                                b = b / i;
                            }
                            
                            son1();

                            ekok= ekok * i;

                            i--;
                            
                        }
                    }

                    groupBox3.Visible = true;

                    label5.Text = ekok.ToString();
                }

            }

            else if (radioButton2.Checked == true)
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = int.Parse(textBox3.Text);

                label6.Text = "Ekok(" + a + "," + b + "," + c + ") =";

                son2();

                if (a == b && b == c)
                {
                    groupBox3.Visible = true;

                    label5.Text = a.ToString();
                }

                else if (a != b)
                {

                    for (int i = 2; i <= son; i++)
                    {
                        if (a % i == 0 || b % i == 0 || c % i == 0)
                        {

                            if (a % i == 0)
                                a = a / i;
                            if (b % i == 0)
                                b = b / i;
                            if (c % i == 0)
                                c = c / i;

                            son2();

                            ekok = ekok * i;
                            i--;
                        }
                    }

                    groupBox3.Visible = true;

                    label5.Text = ekok.ToString();


                }
            }
        }
    }
}
