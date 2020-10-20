using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemoSovellus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Numbers numbers = ReadNumbers();
            int sum = numbers.A + numbers.B;
            MessageBox.Show(sum.ToString());
        }

        private Numbers ReadNumbers()
        {
            Numbers numbers = new Numbers()
            {
                A = int.Parse(number1TextBox.Text),
                B = int.Parse(number2TextBox.Text)
            };

            return numbers;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            Numbers numbers = ReadNumbers();
            int sum = numbers.A - numbers.B;
            MessageBox.Show(sum.ToString());
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            Numbers numbers = ReadNumbers();
            int sum = numbers.A * numbers.B;
            MessageBox.Show(sum.ToString());
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            Numbers numbers = ReadNumbers();
            int sum = numbers.A / numbers.B;
            MessageBox.Show(sum.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }
    }

    public class Numbers
    {
        public int A { get; set; }
        public int B { get; set; }
    }
}
