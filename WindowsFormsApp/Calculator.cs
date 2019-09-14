using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void addBottun_Click(object sender, EventArgs e)
        {
            int firstNumber =Convert.ToInt32(fstNumberTextBox.Text);
            int secoundNumber = Convert.ToInt32(scndNumbertextBox2.Text);
            int result = firstNumber + secoundNumber;
            resultTextBox.Text =Convert.ToString(result);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(fstNumberTextBox.Text);
            int secoundNumber = Convert.ToInt32(scndNumbertextBox2.Text);
            int result = firstNumber - secoundNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(fstNumberTextBox.Text);
            int secoundNumber = Convert.ToInt32(scndNumbertextBox2.Text);
            int result = firstNumber * secoundNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(fstNumberTextBox.Text);
            double secoundNumber = Convert.ToDouble(scndNumbertextBox2.Text);
            double result = firstNumber / secoundNumber;
            resultTextBox.Text = Convert.ToString(result);
        }
    }
}
