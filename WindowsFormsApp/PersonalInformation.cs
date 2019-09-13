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
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void showAllIfoButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "Your First Name: " + fastNameTextBox.Text + "" + "Your Last Name: " + lastNameTextBox.Text + "" + "Father's Name: " + fatherNameTextBox.Text + "" + "Mother's Name: " + motherNameTextBox.Text + "" + "Address: " + addressTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text ="Your First Name: " +fastNameTextBox.Text + "" + "Your Last Name: "+lastNameTextBox.Text + "" +"Father's Name: "+ fatherNameTextBox.Text + "" + "Mother's Name: "+motherNameTextBox.Text + "" + "Address: "+addressTextBox.Text;
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "Your First Name: " + fastNameTextBox.Text + "" + "Your Last Name: " + lastNameTextBox.Text;
        }

        private void parantNameButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "Father's Name: " + fatherNameTextBox.Text + ", " + "Mother's Name: " + motherNameTextBox.Text;

        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "Address: " + addressTextBox.Text;

        }
    }
}
