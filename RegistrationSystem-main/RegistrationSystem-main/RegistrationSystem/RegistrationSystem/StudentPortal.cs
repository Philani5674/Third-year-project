using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrationSystem.baseDataSetTableAdapters;
using RegistrationSystem.Classes;

namespace RegistrationSystem
{
    public partial class StudentPortal : Form
    {
        public StudentPortal(int accountId)
        {
            InitializeComponent();
            GetStudentDetails(accountId);
        }

        private readonly Student _student = new Student();
        private void GetStudentDetails(int accountId)
        {
            var set = new baseDataSet {EnforceConstraints = false};
            var acc = set.StudentAccount;

            if (accountId >= 1)
            {
                try
                {
                    var studentAccount = new StudentAccountTableAdapter();
                    studentAccount.Fill(acc, accountID: accountId);
                    var data = acc.Rows[0];
                    // check if student is registered
                    if (!string.IsNullOrWhiteSpace(data["StudentID"].ToString()))
                    {
                        _student.StudentID = (int)data["StudentID"];
                        _student.Account.FirstName = data["FirstName"].ToString();
                        _student.Account.LastName = data["LastName"].ToString();
                        _student.Account.EmailAddress = data["EmailAddress"].ToString();
                        DisplayStudentProfile();
                    }
                    else
                    {
                        // if not open registration portal
                        var account = new Account
                        {
                            AccountID = accountId,
                            EmailAddress = data["EmailAddress"].ToString(),
                            FirstName = data["FirstName"].ToString(),
                            LastName = data["LastName"].ToString()
                        };
                        var regPortal = new RegistrationPortalForm(account);
                        this.Show();
                        regPortal.ShowDialog();
                    }
                    
                }
                catch (StrongTypingException)
                {
                    MessageBox.Show("Test");
                }

            }
            else
            {
                var regForm = new RegistrationForm();
                regForm.ShowDialog();
            }
        }

        private void DisplayStudentProfile()
        {
            var profile = new UcStudent();
            // studentID default value is set to zero, updated only if there are student details
            if (_student.StudentID <= 0) return;
            profile.StudentFullName = $@"{_student.Account.FirstName} {_student.Account.LastName}";
            profile.StudentEmail = _student.Account.EmailAddress;
            profile.Anchor = AnchorStyles.None;
            var c = new Label
            {
                Text = $@"{profile.StudentFullName}"
            };
            StudentPortal_tablelayout.Controls.Add(profile, 0, 0);
        }
    }
}
