using System;
using System.Windows.Forms;
using RegistrationSystem.baseDataSetTableAdapters;
using System.Drawing;

namespace RegistrationSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private readonly Helpers.Helpers _helper = new Helpers.Helpers();

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            Hide();
            var newLogIn = new LoginForm();
            newLogIn.ShowDialog();
        }

        private static Tuple<int, string> Register(string firstName, string lastName, string email, string password)
        {
            var account = new AccountTableAdapter();
            try
            {
                // creates a new account
                var accountData = account.CreateAccount(firstName, lastName, email, password, DateTime.Now, "S", true);
                return Tuple.Create((int)accountData, "Account Registered");
            }
            catch (Exception ex)
            {
                var msg = ex.Message.Contains("UniqueEmail_Account")
                    ? @"Oops... Someone already registered with that email!"
                    : $@"Something went wrong trying to create account!";
                // returns 0(false) if registration failed
                return Tuple.Create(0, msg);
            }
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            if (_helper.AllFieldsChecked(RegistrationForm_panel))
            {
                if (Password_control.InputText != ConfirmPassword_control.InputText)
                {
                    MessageBox.Show(
                        $@"Your Passwords don't match!");
                    return;
                }

                var registered = Register(FirstName_control.InputText, LastName_control.InputText, EmailAddress_control.InputText,
                    Password_control.InputText);
                if (registered.Item1 < 1)
                {
                    MessageBox.Show(registered.Item2, @"Registration Failed", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);
                };

                // only opens if student successfully register
                MessageBox.Show(registered.Item2, @"Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var studentPortal = new StudentPortal(registered.Item1);
                this.Close();
                studentPortal.Show();
            }
            else
            {
                MessageBox.Show(@"All fields are required!", @"Incomplete", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void InputFieldError_Event(object sender, UserControls.InputFieldErrorEventArgs e)
        {
            if (!e.IsResolved)
            {
                Register_errorprovider.SetError(Register_button, "Please fix all errors in the form");
                Register_button.Enabled = false;
                Register_button.BackColor = Color.DarkGray;
            }else
            {
                Register_errorprovider.Clear();
                Register_button.Enabled = true;
                Register_button.BackColor = Color.Black;
            }
        }
    }
}