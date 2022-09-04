using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using RegistrationSystem.baseDataSetTableAdapters;

namespace RegistrationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInAccount()
        {
            var email = EmailAddress_control.InputText;
            var pass = Password_control.InputText;
            var set = new baseDataSet {EnforceConstraints = false};
            var table = set.Account;
            var account = new AccountTableAdapter{ClearBeforeFill = true};
            try
            {
                account.FillByLogIn(table, EmailAddress: email, Password: pass);

                if (table.Count > 0)
                {
                   var dataRow = table.Rows;
                    switch (dataRow[0]["AccountType"].ToString().ToLower())
                    {
                        case "s":
                        {
                            var studentPortal = new StudentPortal((int) dataRow[0]["AccountID"]);
                            this.Close();
                            studentPortal.Show();
                            break;
                        }
                        case "a":
                            // admin
                            break;
                    }
                }
                else
                {
                    MessageBox.Show($@"Wrong Email or Password");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show($@"Fail to log In: {e}");
            }
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToLower() == "landingpage") {

                    //form.Hide();
                }
                else
                {
                    //form.Close();
                }
            }
            LogInAccount();
        }

        private void RegisterNow_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newRegForm = new RegistrationForm();
            newRegForm.ShowDialog();
        }
    }
}
