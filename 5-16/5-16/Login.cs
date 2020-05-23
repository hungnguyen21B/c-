using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_16
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if ((txtUsername.Text.Equals("hung"))&&(txtPassword.Text.Equals("hung")) )
            {
                string message = "Do you want to login this window?";
                string title = "Login Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    CalculateForm cal = new CalculateForm();
                    cal.Show();  
                }   
            }
           else
            {
                string message = "Your username or password is incorrect?";
                string title = "Error Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                }
                else
                {
                    // Do something  
                }
            }
           
            
        }
    }
}
