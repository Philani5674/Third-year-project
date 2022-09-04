using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using AxAcroPDFLib;
using RegistrationSystem.baseDataSetTableAdapters;
using RegistrationSystem.Classes;
using RegistrationSystem.Properties;
using RegistrationSystem.UserControls;
using static System.Linq.Enumerable;

namespace RegistrationSystem
{
    public partial class RegistrationPortalForm : Form
    {
        private readonly Account _account;
        public RegistrationPortalForm(Account account)
        {
            InitializeComponent();
            _account = account;
        }

        private Student _student;
        private Guardian _guardian;
        private PaymentPlan _selectedPaymentPlan;
        private Payment _payment = null;
        private readonly List<Subject> _availableSubjects= new List<Subject>();
        private readonly List<RegisteredSubject> _selectedSubjects = new List<RegisteredSubject>();
        private readonly List<SupportDocument> _supportDocs = new List<SupportDocument>();
        private BankDetails _bankDetails = null;
        private Registration _registrationData = null;

        // from custom helpers class
        private readonly Helpers.Helpers _helper = new Helpers.Helpers();

        // closing application when form closing event is fired
        private void SubjectRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // generates a new array of strings, given start and size 
        private static object[] GetArray(int start, int size)
        {
            try
            {
                object[] arr;
                if (start < 10)
                {
                    arr = Range(start, size).Select(x => x < 10 ? $"0{x}" : x.ToString()).ToArray();
                }
                else
                {
                    arr = Range(start, size).Select(x => x.ToString()).ToArray();
                }

                return arr;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void SubjectRegistrationForm_Load(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            var years = GetArray(DateTime.Now.Year - 50,
                (DateTime.Now.Year - 16) - (DateTime.Now.Year - 50)); // sets minimum age to 16 and max 50
            var months = GetArray(1, 12);
            var days = GetArray(1, 31);
            DoBYear_combobox.Items.AddRange(years);
            DoBMonth_combobox.Items.AddRange(months);
            DoBDay_combobox.Items.AddRange(days);
            DoBYear_combobox.SelectedItem = "2000";
            DoBMonth_combobox.SelectedItem = "10";
            DoBDay_combobox.SelectedItem = "17";
            DoBMonth_combobox.Enabled = true;

            // gender
            Gender_combobox.SelectedIndex = 0;

            // populate fields with account data
            FirstName_control.InputText = _account.FirstName;
            LastName_control.InputText = _account.LastName;
            EmailAddress_control.InputText = _account.EmailAddress;
            FirstName_control.Enabled = false;
            LastName_control.Enabled = false;
            EmailAddress_control.Enabled = false;
            LoadSubjects();
            LoadPaymentPlans();
        }

        private void LoadSubjects()
        {
            // loads subjects
            var subjectsAdapter = new SubjectTableAdapter();
            var subjects = subjectsAdapter.GetData();

            foreach (var subject in subjects)
            {
                var sub = new UcSubject
                {
                    Name = subject.SubjectCode,
                    SubjectName = subject.SubjectName,
                    SubjectCode = subject.SubjectCode,
                    SubjectDescription = subject.SubjectDiscription,
                    SubjectPrice = subject.SubjectPrice
                };
                sub.SubjectSelectedChanged += Subject_SubjectSelectedChanged;
                sub.MatricMarkChanged += Subject_MatricMarkChanged;
                SubjectSelection_flowlayout.Controls.Add(sub);
            }
        }

        private void LoadPaymentPlans()
        {
            var paymentPlanAdapter = new PaymentPlanTableAdapter();
            var paymentPlans = paymentPlanAdapter.GetData();

            foreach (var paymentPlan in paymentPlans)
            {
                var plan = new UcPaymentPlan
                {
                    Name = $"{paymentPlan.PaymentTitle}{paymentPlan.PaymentPlanID}",
                    PaymentPlanId = paymentPlan.PaymentPlanID.ToString(),
                    PaymentPlanTitle = paymentPlan.PaymentTitle,
                    PaymentPlanDescription = paymentPlan.PaymentPlanDescription,
                    PaymentPlanLength = paymentPlan.PaymentLength.ToString()
                };
                plan.SelectedPaymentPlanChanged += PaymentPlan_PaymentPlanSelectedChanged;
                PaymentPlan_flowlayout.Controls.Add(plan);
            }
        }


        #region PERSONAL DETAILS TAB
        //personal details
        private void PDSaveAndContinue_button_Click(object sender, EventArgs e)
        {

            var student = new Student();
            if (_helper.AllFieldsChecked(PersonalDetailsForm_groupbox))
            {
                var idPassportTuple = Helpers.Helpers.IsValidIdPassNumber(PersonalDetailsIDorPassportNumber_control.InputText);
                if (!idPassportTuple.Item1)
                {
                    MessageBox.Show(idPassportTuple.Item2, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // fill the account constructor
                student.Account.AccountID = _account.AccountID;
                student.Account.FirstName = _account.FirstName;
                student.Account.LastName = _account.LastName;
                student.Account.EmailAddress = _account.EmailAddress;
                // fill student constructor
                student.Address =
                    $@"{Address_control.InputText} {Suburb_control.InputText}, {CityOrTown_control.InputText} {ZipOrPostalCode_control.InputText}";
                student.DateOfBirth = new DateTime(int.Parse(DoBYear_combobox.Text), int.Parse(DoBMonth_combobox.Text),
                    int.Parse(DoBDay_combobox.Text));
                student.Gender = Gender_combobox.Text;
                student.IDNumber = PersonalDetailsIDorPassportNumber_control.InputText;
                student.PhoneNumber = PhoneNumber_control.InputText;
                _student = student;
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show(@"Please fill all the input in the form");
            }
        }

        #region Date of Birth related code
        private void ChangeDateValues()
        {
            int year;
            int month;
            if (int.TryParse(DoBYear_combobox.Text, out year) && int.TryParse(DoBMonth_combobox.Text, out month))
            {
                DoBDay_combobox.Items.Clear();
                object[] days;
                if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (month == 2)
                    {
                        // days = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? getArray(1, 29) : getArray(1, 28);
                        days = DateTime.IsLeapYear(year) ? GetArray(1, 29) : GetArray(1, 28);
                    }
                    else
                    {
                        days = GetArray(1, 30);
                    }
                }
                else
                {
                    days = GetArray(1, 31);
                }

                DoBDay_combobox.Items.AddRange(days);
                DoBDay_combobox.SelectedIndex = 0;
                DoBDay_combobox.Enabled = true;
            }
            else
            {
                DoBDay_combobox.Enabled = false;
                DoBMonth_combobox.Enabled = false;
            }
        }

        private void DoBYear_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDateValues();
        }

        private void DoBMonth_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDateValues();
        }
        #endregion

        private void PersonalDetails_InputFieldError(object sender, InputFieldErrorEventArgs e)
        {
            InputErrorEvent(PDSaveAndContinue_button, e, RegError_errorprovider);
        }

        #endregion

        #region GARDIAN DETAILS TAB

        private void GDSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            var guardian = new Guardian();
            if (_helper.AllFieldsChecked(GuardianDetailsForm_groupbox))
            {
                var idPassportTuple = Helpers.Helpers.IsValidIdPassNumber(GuardianIDorPassportNumber_control.InputText);
                if (!idPassportTuple.Item1)
                {
                    MessageBox.Show(idPassportTuple.Item2, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                guardian.FirstName = GuardianFirstName_control.InputText;
                guardian.LastName = GuardianLastName_control.InputText;
                guardian.Address = $@"{GuardianAddress_control.InputText} {GuardianSuburb_control.InputText}, {GuardianCityOrTown_control.InputText} {GuardianZipOrPostalCode_control.InputText}";
                guardian.PhoneNumber = GuardianPhoneNumber_control.InputText;
                guardian.IDNumber = GuardianIDorPassportNumber_control.InputText;
                _guardian = guardian;
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show(@"Please fill all the input in the form");
            }
        }
        private void Guardian_InputFieldError(object sender, InputFieldErrorEventArgs e)
        {
            InputErrorEvent(GDSaveAndContinue_button, e, RegError_errorprovider);
        }

        #endregion

        #region SUPPORTING DOCUMENTS TAB
        private static byte[] GetFileByte(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            var x = File.ReadAllBytes(path);
            return x;
        }
        
        // fileName/fileType can be (Student ID, Guardian ID or Matric Statement)
        private FileInfo FileUpload(string fileName)
        {
            var uploader = new OpenFileDialog
            {
                Filter = @"allfiles(pdf) | *.pdf",
                CheckFileExists = true,
                CheckPathExists = true,
                Title = fileName
            };
            if (uploader.ShowDialog() != DialogResult.OK) return null;
            try
            {
                var fileInfo = new FileInfo(uploader.FileName);
                if (fileInfo.Length > 4194304) // Max upload file size 4194304B(4MB)
                {
                    MessageBox.Show($@"File is too big ({fileInfo.Length / 1048576}MB). The Max size is 4MB");
                    return null;
                }
                
                var fileByte = GetFileByte(uploader.FileName);
                if (fileByte == null) return null;
                var file = new SupportDocument(fileName, fileByte);

                foreach (var doc in _supportDocs.ToList().Where(doc => doc.FileName == fileName))
                {
                    // first remove a doc with same name if all ready in the support docs
                    _supportDocs.Remove(doc);
                }
                _supportDocs.Add(file);
                return fileInfo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // uploading file from button click
        private void FileUpload_Click(object sender, EventArgs e)
        {
            var control = (Button)sender;
            var pControl = (TableLayoutPanel)control.Parent;
            var file = FileUpload(control.Tag.ToString());
            if (file == null) return;
            FileUploadPreview_adobe.src = file.FullName;

            control.Text = $@"Re{control.Text}";
            control.Image = Resources.checked_icon;
            
            PictureBox icon = null;
            try
            {
                icon = (PictureBox)pControl?.Controls[0];
            }
            catch (Exception)
            {

                icon = (PictureBox)pControl?.Controls[1];
            }
            if (icon != null) icon.Image = Resources.pdf_light_icon;
        }

        // save and continue button
        private void SDSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            if (_supportDocs.Count < 3)
            {
                MessageBox.Show(@"Upload all the required supporting documents!");
            }
            else
            {
                // next tab
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
        }

        #endregion

        #region SUBJECT SELECTION TAB
        // deals with selection of subjects
        private void Subject_SubjectSelectedChanged(object sender, EventArgs e)
        {
            var changedSubject = (UcSubject)sender;
            changedSubject.BackColor = changedSubject.SubjectSelected ? Color.DarkOrange : Color.Transparent;
            var subject = new RegisteredSubject
            {
                SubjectCode = changedSubject.SubjectCode,
                MatricMark = changedSubject.MatricMark,
                SubjectPrice = changedSubject.SubjectPrice,
                SubjectName = changedSubject.SubjectName,
                SubjectDescription = changedSubject.SubjectDescription,
                UpgradeMark = "0",
            };

            if (changedSubject.SubjectSelected)
            {
                _selectedSubjects.Add(subject);
            }
            else
            {
                _selectedSubjects.RemoveAll(sub=> sub.SubjectCode.Equals(subject.SubjectCode));
            }
        }
        private void Subject_MatricMarkChanged(object sender, EventArgs e)
        {
            var changedSubject = (UcSubject)sender;
            foreach (var sub in _selectedSubjects)
            {
                if(sub.SubjectCode == changedSubject.SubjectCode)
                {
                    sub.MatricMark = changedSubject.MatricMark;
                    break;
                }
            }
        }

        private bool MarksValid ()
        {
            foreach (var sub in _selectedSubjects)
            {
                byte mark;
                if (!byte.TryParse(sub.MatricMark, out mark))
                {
                    return false;
                }
                else
                {
                    if(mark < 0 && mark > 100)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // subject selection save and continue button
        private void SSSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            // subject selection
            if (_selectedSubjects.Count < 1)
            {
                MessageBox.Show(@"Choose at least one subject", "Subject Required");
            }
            else
            {
                if(MarksValid())
                {
                    SubjectsRegistration_tabs.SelectedIndex += 1;
                }
                else
                {
                    MessageBox.Show(@"Mak sure all selected subjects have valid matric marks", @"Invalid Marks");
                }
            }
        }

        // gets total of subjects selected
        private decimal GetTotal()
        {
            var total = _selectedSubjects.Sum(sub => sub.SubjectPrice);
            return total;
        }
        #endregion

        #region PAYMENTPLAN TAB
        // deals with selection of payment plans
        private void PaymentPlan_PaymentPlanSelectedChanged(object sender, EventArgs e)
        {
            var plan = (UcPaymentPlan)sender;
            _selectedPaymentPlan = null;
            var paymentPlan = new PaymentPlan
            {
                PaymentPlanID = int.Parse(plan.PaymentPlanId),
                PaymentPlanLength = plan.PaymentPlanLength,
                PaymentPlanTitle = plan.PaymentPlanTitle
            };
            _selectedPaymentPlan = paymentPlan;

            // updates the SelectIcon to indicated whether the payment is selected or not
            foreach (UcPaymentPlan payment in PaymentPlan_flowlayout.Controls)
            {
                payment.PaymentPlanSelected = int.Parse(payment.PaymentPlanId) == _selectedPaymentPlan.PaymentPlanID;
                payment.SelectIcon = payment.PaymentPlanSelected ? Resources.checked_icon : Resources.check_icon;
            }
        }

        private void PPSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            //payment plan
            if (_selectedPaymentPlan == null)
            {
                MessageBox.Show(@"Choose one payment plan");
            }
            else
            {
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
        }

        private void PaymentPlan_tab_Enter(object sender, EventArgs e)
        {
            if (_selectedSubjects.Count < 1)
            {
                MessageBox.Show(@"Please choose at least one subject");
                SubjectsRegistration_tabs.SelectedTab = SubjectSelection_tab;
            }
            else
            {
                foreach (UcPaymentPlan payment in PaymentPlan_flowlayout.Controls)
                {
                    switch (int.Parse(payment.PaymentPlanLength) < 1)
                    {
                        case true:
                            payment.ExpectedPay = $"R {GetTotal().ToString(CultureInfo.InvariantCulture)} full";
                            break;
                        default:
                            payment.ExpectedPay = $"R {(GetTotal() / decimal.Parse(payment.PaymentPlanLength)):N2} p/m";
                            break;
                    }
                }
            }

        }

        #endregion

        #region PAYMENT TAB
        // when the pab opens
        private void Payment_tab_Enter(object sender, EventArgs e)
        {
            if (_student == null)
            {
                MessageBox.Show(@"Personal Information Missing");
                SubjectsRegistration_tabs.SelectedTab = PersonalDetails_tabs;
                return;
            }

            if (_guardian == null)
            {
                MessageBox.Show(@"Guardian Information Missing");
                SubjectsRegistration_tabs.SelectedTab = GuardianDetails_tab;
                return;
            }

            if (_selectedSubjects.Count < 1)
            {
                MessageBox.Show(@"No Subjects were selected");
                SubjectsRegistration_tabs.SelectedTab = SubjectSelection_tab;
                return;
            }

            if (_selectedPaymentPlan != null)
            {
                ExpYear_combobox.Items.AddRange(GetArray(DateTime.Now.Year, 10));
                ExpMonth_combobox.Items.AddRange(GetArray(1, 12));
                var total = (int.Parse(_selectedPaymentPlan.PaymentPlanLength) > 0
                    ? GetTotal()
                    : decimal.Parse((GetTotal() / decimal.Parse(_selectedPaymentPlan.PaymentPlanLength))
                        .ToString("N2")));
                // R 500 registration fee
                PaymentDueAmount_label.Text = $@"R {total + 500}";
            }
            else
            {
                MessageBox.Show(@"No payment plan chosen", "Payment Required");
                SubjectsRegistration_tabs.SelectedTab = PaymentPlan_tab;
            }

        }


        private void Payment_InputFieldError(object sender, InputFieldErrorEventArgs e)
        {
            InputErrorEvent(Register_button, e, RegError_errorprovider);
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            // register
            _payment = new Payment();
            _bankDetails = new BankDetails();
            _registrationData = new Registration();
            var newRegistration = new HandleRegistration();
            if (_helper.AllFieldsChecked(BankingDetails_groupbox))
            {
                var isCardValid = Helpers.Helpers.IsValidDigits(CardNumber_control.InputText);
                if (isCardValid)
                {
                    if (_selectedPaymentPlan != null)
                    {
                        // initial amaount payed
                        var initAmount = int.Parse(_selectedPaymentPlan.PaymentPlanLength) > 0
                            ? GetTotal()
                            : decimal.Parse((GetTotal() / decimal.Parse(_selectedPaymentPlan.PaymentPlanLength))
                                .ToString("N2"));


                        _registrationData.AmountDue = GetTotal();
                        _registrationData.AmountPayed = initAmount;
                        _registrationData.PaymentPlanID = _selectedPaymentPlan.PaymentPlanID;
                        _registrationData.IsApproved = false;
                        _registrationData.ReasonNotApproved = "Pending Approval";
                        _registrationData.RegistrationDate = DateTime.Now;

                        // payment
                        _payment.Amount = initAmount;
                        _payment.PaymentDate = DateTime.Now;
                        _payment.PaymentDescription = "First payment including registration fee";

                        // collect ban details
                        _bankDetails.BankName = BankName_control.InputText;
                        _bankDetails.CardHolder = CardholderName_control.InputText;
                        _bankDetails.CardNumber = CardNumber_control.InputText;
                        _bankDetails.Cvc = CVVorCVC_control.InputText;
                        _bankDetails.ExpiryDate = new DateTime(int.Parse(ExpYear_combobox.Text), int.Parse(ExpMonth_combobox.Text), 01);

                        newRegistration.RegisterStudent(
                            student: _student,
                            guardian: _guardian,
                            supportDocuments: _supportDocs,
                            registeredSubjects: _selectedSubjects,
                            registrationData: _registrationData,
                            payment: _payment,
                            bankDetails: _bankDetails
                        );

                        SubjectsRegistration_tabs.SelectedTab = Confirmation_tab;
                    }
                }
                else
                {
                    MessageBox.Show(@"Invalid Card Number entered", @"Bank Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Please fill all the input in the form", "Input required");
            }

        }

        #endregion

        #region CONFIRMATION TAB
        // when confirmation tab opens up
        private void Confirmation_tab_Enter(object sender, EventArgs e)
        {
            if (!(_selectedSubjects.Count < 1))
            {
                // loops all the registered subjects from List<Subject>
                foreach (var subject in _selectedSubjects.Select(sub => new UcSubject
                {
                    SubjectName = sub.SubjectName,
                    SubjectCode = sub.SubjectCode,
                    SubjectDescription = sub.SubjectDescription,
                    SubjectPrice = sub.SubjectPrice,
                    // hides selection box(check icon) of subject
                    SubjectSelectable = false
                }))
                {
                    ConfirmationRegisteredSubjects_flowlayout.Controls.Add(subject);
                }
            }
            else
            {
                MessageBox.Show(@"Oops no subjects were chosen!", @"Subject(s) Required", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                SubjectsRegistration_tabs.SelectedTab = SubjectSelection_tab;
                return;
            }

            try
            {
                var paymentPlan = new UcPaymentPlan
                {
                    PaymentPlanId = _selectedPaymentPlan.PaymentPlanID.ToString(),
                    PaymentPlanLength = _selectedPaymentPlan.PaymentPlanLength,
                    PaymentPlanDescription = _selectedPaymentPlan.PaymentPlanDescription,
                    PaymentPlanTitle = _selectedPaymentPlan.PaymentPlanTitle,
                    PaymentPlanSelected = true,
                };

                DetailedConfirmation_tablelayout.Controls.Add(paymentPlan);
                DetailedConfirmation_tablelayout.Controls.Add(CreateLabel($@"Payment ID: {Guid.NewGuid().ToString()}"));
                DetailedConfirmation_tablelayout.Controls.Add(
                    CreateLabel($@"Registration ID: {Guid.NewGuid().ToString()}"));
                DetailedConfirmation_tablelayout.Controls.Add(CreateLabel(@"Registration Status: Pending approval"));
            }
            catch (Exception)
            {
                MessageBox.Show(@"Oops not Payment plan was chosen!", @"Payment Plan required", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                SubjectsRegistration_tabs.SelectedTab = PaymentPlan_tab;
            }
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            StudentPortal stu = new StudentPortal(_account.AccountID);
            this.Close();
            stu.Show();

        }

        #endregion

        #region Generic Events

        private void Tab_Enter(object sender, EventArgs e)
        {
            CausesValidation = true;
        }

        private void Tab_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                var control = (TabPage)sender;
                if (control == null) return;
                if (string.IsNullOrWhiteSpace(control.Tag.ToString())) return;
                var first = control.Controls.Find(control.Tag.ToString(), true).First();
                if (_helper.AllFieldsChecked(first)) return;
                e.Cancel = true;
                MessageBox.Show($@"All Fields are required at {control.Text} tab");
                SubjectsRegistration_tabs.SelectedTab = control;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private static void InputErrorEvent(Control button, InputFieldErrorEventArgs e, ErrorProvider err)
        {
            if (e.IsResolved)
            {
                button.BackColor = Color.DarkOrange;
                button.Enabled = true;
                err.Clear();
            }
            else
            {
                button.Enabled = false;
                button.BackColor = Color.DarkGray;
                err.SetError(button, "Please fix input errors");
            }
        }

        //close form
        private void FormClose_button_Click(object sender, EventArgs e)
        {
            var confirmClose = MessageBox.Show(@"Are you sure you want close application!",
                @"Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmClose == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FormClose_button_MouseEnter(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
        }

        private void FormClose_button_MouseLeave(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Inherit;
        }


        #endregion

        private static Label CreateLabel(string text)
        {
            var label = new Label
            {
                Name = new Random().Next().ToString(),
                Text = text,
                ForeColor = Color.DarkGray,
                Font = new Font("SegoeUI", 11, FontStyle.Bold),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleLeft,
                Size = new Size(438, 42)
            };
            return label;
        }

        #region nonting interesting just design thingy ;-)

        // called when control get focus
        private void ControlEnter()
        {
            DoBBottom_panel.BackColor = Color.DarkOrange;
            DoB_label.ForeColor = Color.DarkOrange;
        }

        // called when control loses focus
        private void ControlLeave()
        {
            DoBBottom_panel.BackColor = Color.DarkGray;
            DoB_label.ForeColor = Color.DarkGray;
        }

        private void DoBYear_combobox_Enter(object sender, EventArgs e)
        {
            ControlEnter();
            Year_label.ForeColor = Color.DarkOrange;
        }

        private void DoBYear_combobox_Leave(object sender, EventArgs e)
        {
            ControlLeave();
            Year_label.ForeColor = Color.DarkGray;
        }

        private void DoBMonth_combobox_Enter(object sender, EventArgs e)
        {
            ControlEnter();
            Month_label.ForeColor = Color.DarkOrange;
        }

        private void DoBMonth_combobox_Leave(object sender, EventArgs e)
        {
            ControlEnter();
            Month_label.ForeColor = Color.DarkGray;
        }

        private void DoBDay_combobox_Enter(object sender, EventArgs e)
        {
            ControlEnter();
            Day_label.ForeColor = Color.DarkOrange;
        }

        private void DoBDay_combobox_Leave(object sender, EventArgs e)
        {
            ControlLeave();
            Day_label.ForeColor = Color.DarkGray;
        }

        #endregion
        #region For draggability of the the form

        private bool _mouseDown;
        private Point _lastLocation;

        private void Nav_panel_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void Nav_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            Location = new Point(
                (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);

            Update();
        }

        private void Nav_panel_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
        #endregion
    }
}