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
    public partial class WindowsFormApp : Form
    {
        public WindowsFormApp()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            //resultTextBox.Text=nameTextBox.Text;
           nameTextBox.Text = "Hello";
            
        }
    }
}
