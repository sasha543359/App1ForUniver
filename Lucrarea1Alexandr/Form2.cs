using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lucrarea1Alexandr
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                mainForm.listBox1.Items.Clear();
                string[] stringsEntered = textBox1.Lines;
                for (int count = 0; count <
               stringsEntered.Length; count++)
                {

                    mainForm.listBox1.Items.Add(stringsEntered[count]);
                }
            }
            this.Close();
        }
    }
}
