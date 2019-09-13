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
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Word");
        }
    }
}
