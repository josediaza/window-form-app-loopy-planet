using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loopy_Planet_Challenge_project
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
        //Uranus planet
        protected void button1_Click(object sender, EventArgs e)
        {
           

            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");
            }
            else
            {
                double userWeight;
                double uranusWeight = 0;
                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    uranusWeight = userWeight * 1.15;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + uranusWeight.ToString() + " pounds on Uranus", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }

                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }


        }




        protected void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Venus planet
        protected void button8_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double venusWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    venusWeight = userWeight * 0.88;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + venusWeight.ToString() + " pounds on Venus", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();

            }

        }

        //Jupiter planet
        protected void button7_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double jupiterWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    jupiterWeight = userWeight * 2.64;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + jupiterWeight.ToString() + " pounds on Jupiter", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }

        }
        //Mars planet
        protected void button2_Click(object sender, EventArgs e)
        {
        
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");
            }
            else
            {
                double userWeight;
                double marsWeight = 0;
                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    marsWeight = userWeight * 0.38;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + marsWeight.ToString() + " pounds on Mars", "Result");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Saturn planet
        protected void button3_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");
            }
            else
            {
                double userWeight;
                double saturnWeight = 0;
                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    saturnWeight = userWeight * 1.15;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + saturnWeight.ToString() + " pounds on Saturn", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Pluto planet
        protected void button4_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double plutoWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    plutoWeight = userWeight * 0.05;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + plutoWeight.ToString() + " pounds on Pluto", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Mercury planet
        protected void button5_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double mercuryWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    mercuryWeight = userWeight * 0.37;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + mercuryWeight.ToString() + " pounds on Mercury", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Neptune planet
        protected void button6_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double neptuneWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    neptuneWeight = userWeight * 1.12;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + neptuneWeight.ToString() + " pounds on Neptune", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Quit button
        protected void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        protected void button10_Click(object sender, EventArgs e)
        { }
            /*Sform();
        }
        protected virtual void Sform()
        {
            if(MessageBox.Show("Would like to play on Galactic Stars?", "Other game", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
           
        }*/

        protected virtual void label1_Click(object sender, EventArgs e)
        {

        }

        protected virtual void label2_Click(object sender, EventArgs e)
        {

        }

        private void toDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Fill your weight below the space indicated--Click on the planet wanted","Help");
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Notice that your weights is different on the different worlds","Help");
        }
    }
}
    

