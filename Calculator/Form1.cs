using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double wynik = 0;
        string operacja = "";
        bool WykOper = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonTwenty_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") || (WykOper == true))
            {
                textBox1.Clear();
            }
            
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (textBox1.Text.Contains(","))
                {
                    ;
                }
                else
                {
                    textBox1.Text = textBox1.Text + button.Text;
                    WykOper = false;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
                WykOper = false;

            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KlawiszOperacji(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (wynik != 0)
            {
                ButtonTwenty.PerformClick();
                operacja = button.Text;
                WykOper = true;
                PoleOperacji.Text = textBox1.Text + " " + button.Text;
            }
            else
            {
               
                operacja = button.Text;
                wynik = Convert.ToDouble(textBox1.Text);
                WykOper = true;
                PoleOperacji.Text = textBox1.Text + " " + button.Text;
            }

        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void ButtonTen_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            wynik = 0;
        }

        private void KlawiszWyniku(object sender, EventArgs e)
        {
            //PoleOperacji.Text = PoleOperacji.Text + " " + textBox1.Text;
            switch (operacja)
            {

                case "+":

                    textBox1.Text = (Double.Parse(textBox1.Text) + wynik).ToString();
                    break;

                case "-":

                    textBox1.Text = (wynik - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":

                    textBox1.Text = (wynik / Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":

                    textBox1.Text = (Double.Parse(textBox1.Text) * wynik).ToString();
                    break;
                default:
                    break;
                                  
            }
            wynik = Double.Parse(textBox1.Text);
            PoleOperacji.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
