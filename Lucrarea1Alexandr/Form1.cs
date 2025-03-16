using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea1Alexandr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1.Text = DateTime.Now.ToString();

            textBox1.Text = "Today is " +
                    DateTime.Today.ToLongDateString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Leave(object sender, EventArgs e)
        {
            textBox2.Text = "La revedere !";

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Text = "Salut !";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buna ziua la toti!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Time " + DateTime.Now.ToLongTimeString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256), randomColor.Next(0, 256), randomColor.Next(0, 256));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inputText.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int nr1, nr2, sum;
                nr1 = Convert.ToInt32(num1.Text);
                nr2 = int.Parse(num2.Text);
                sum = nr1 + nr2;
                suma.Text = (nr1 + nr2).ToString();
            }
            catch
            {
                MessageBox.Show("Introduceti in casete doar numere intregi");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 subForm = new Form2(this);
            subForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}