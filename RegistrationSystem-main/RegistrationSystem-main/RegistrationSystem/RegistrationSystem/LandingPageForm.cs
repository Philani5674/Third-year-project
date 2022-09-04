using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            LoginForm newLogInForm = new LoginForm();
            newLogInForm.ShowDialog();
        }

        private void RegisterNow_button_Click(object sender, EventArgs e)
        {
            RegistrationForm newRegForm = new RegistrationForm();
            newRegForm.ShowDialog();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            Registration_Administrator Connect = new Registration_Administrator();
            Connect.ShowDialog();


        }
    }
}
