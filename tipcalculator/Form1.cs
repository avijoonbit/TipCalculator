using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            double bill;
            int tip;
            int people;
            double tipperperson;
            double totalperperson;

            bill = Convert.ToDouble(textBox1.Text);
            tip = Convert.ToInt32(numericUpDown1.Value);
            people = Convert.ToInt32(numericUpDown2.Value);

            tipperperson = (bill * tip) / (people * 100);
            label6.Text = tipperperson.ToString("c");

            totalperperson = (bill / people) + tipperperson;
            label7.Text = totalperperson.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0)
            {
                numericUpDown1.Value = 0;
                MessageBox.Show("Tip cannot be negative!");
            }
            if (numericUpDown1.Value > 30)
            {
                numericUpDown1.Value = 30;
                MessageBox.Show("Tip cannot be more than 30%!");
            }


            double bill;
            int tip;
            int people;
            double tipperperson;
            double totalperperson;

            bill = Convert.ToDouble(textBox1.Text);
            tip = Convert.ToInt32(numericUpDown1.Value);
            people = Convert.ToInt32(numericUpDown2.Value);

            tipperperson = (bill * tip) / (people * 100);
            label6.Text = tipperperson.ToString("c");

            totalperperson = (bill / people) + tipperperson;
            label7.Text = totalperperson.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < 1)
            {
                numericUpDown2.Value = 1;
                MessageBox.Show("Minimum one person required");
            }
            if (numericUpDown2.Value > 10)
            {
                numericUpDown2.Value = 10;
                MessageBox.Show("Maximum person limit reached!");
            }
            double bill;
            int tip;
            int people;
            double tipperperson;
            double totalperperson;

            bill = Convert.ToDouble(textBox1.Text);
            tip = Convert.ToInt32(numericUpDown1.Value);
            people = Convert.ToInt32(numericUpDown2.Value);

            tipperperson = (bill * tip) / (people * 100);
            label6.Text = tipperperson.ToString("c");

            totalperperson = (bill / people) + tipperperson;
            label7.Text = totalperperson.ToString("c");
        }
    }
}
