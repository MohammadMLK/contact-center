using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_center
{
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernamelable_Click(object sender, EventArgs e)
        {

        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("please fill the boxes");
            }
            else
            {
                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                
            }
            
        }
    }
}
