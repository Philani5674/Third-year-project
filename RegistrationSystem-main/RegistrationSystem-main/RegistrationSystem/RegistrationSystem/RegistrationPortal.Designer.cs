using RegistrationSystem.UserControls;

namespace RegistrationSystem
{
    partial class RegistrationPortalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPortalForm));
            this.SubjectsRegistration_tabs = new System.Windows.Forms.TabControl();
            this.PersonalDetails_tabs = new System.Windows.Forms.TabPage();
            this.PersonalDetailsFooter_panel = new System.Windows.Forms.Panel();
            this.PDSaveAndContinue_button = new System.Windows.Forms.Button();
            this.PersonalDetails_panel = new System.Windows.Forms.Panel();
            this.PersonalDetailsForm_groupbox = new System.Windows.Forms.GroupBox();
            this.HomeAddress_label = new System.Windows.Forms.Label();
            this.ZipOrPostalCode_control = new RegistrationSystem.UserControls.UcInputField();
            this.Suburb_control = new RegistrationSystem.UserControls.UcInputField();
            this.CityOrTown_control = new RegistrationSystem.UserControls.UcInputField();
            this.Address_control = new RegistrationSystem.UserControls.UcInputField();
            this.GenderContainer_panel = new System.Windows.Forms.Panel();
            this.GenderField_panel = new System.Windows.Forms.Panel();
            this.Gender_label = new System.Windows.Forms.Label();
            this.Gender_combobox = new System.Windows.Forms.ComboBox();
            this.GenderBottom_panel = new System.Windows.Forms.Panel();
            this.DoBContainer_panel = new System.Windows.Forms.Panel();
            this.DoB_label = new System.Windows.Forms.Label();
            this.DateContainer_panel = new System.Windows.Forms.Panel();
            this.Day_label = new System.Windows.Forms.Label();
            this.Month_label = new System.Windows.Forms.Label();
            this.Year_label = new System.Windows.Forms.Label();
            this.DoBDay_combobox = new System.Windows.Forms.ComboBox();
            this.DoBBottom_panel = new System.Windows.Forms.Panel();
            this.DoBMonth_combobox = new System.Windows.Forms.ComboBox();
            this.DoBYear_combobox = new System.Windows.Forms.ComboBox();
            this.PhoneNumber_control = new RegistrationSystem.UserControls.UcInputField();
            this.PersonalDetailsIDorPassportNumber_control = new RegistrationSystem.UserControls.UcInputField();
            this.EmailAddress_control = new RegistrationSystem.UserControls.UcInputField();
            this.LastName_control = new RegistrationSystem.UserControls.UcInputField();
            this.FirstName_control = new RegistrationSystem.UserControls.UcInputField();
            this.PersonDetailsTitle_label = new System.Windows.Forms.Label();
            this.GuardianDetails_tab = new System.Windows.Forms.TabPage();
            this.GuardianDetailsFooter_panel = new System.Windows.Forms.Panel();
            this.GDSaveAndContinue_button = new System.Windows.Forms.Button();
            this.GuardianDetailsForm_panel = new System.Windows.Forms.Panel();
            this.GuardianDetailsForm_groupbox = new System.Windows.Forms.GroupBox();
            this.PersonalDetails_label = new System.Windows.Forms.Label();
            this.GHomeAddress_label = new System.Windows.Forms.Label();
            this.GuardianZipOrPostalCode_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianSuburb_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianCityOrTown_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianAddress_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianPhoneNumber_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianIDorPassportNumber_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianLastName_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianFirstName_control = new RegistrationSystem.UserControls.UcInputField();
            this.GuardianDetailsTitle_label = new System.Windows.Forms.Label();
            this.SupportingDocuments_tab = new System.Windows.Forms.TabPage();
            this.SupportDocumentsFooter_panel = new System.Windows.Forms.Panel();
            this.SDSaveAndContinue_button = new System.Windows.Forms.Button();
            this.SupportDocuments_panel = new System.Windows.Forms.Panel();
            this.FileUploadPreview_adobe = new AxAcroPDFLib.AxAcroPDF();
            this.SupportDocuments_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileUploadID_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileUplaodID_picturebox = new System.Windows.Forms.PictureBox();
            this.FileUplaodID_button = new System.Windows.Forms.Button();
            this.FileUploadMatric_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileUploadMatric_button = new System.Windows.Forms.Button();
            this.FileUploadMatric_picturebox = new System.Windows.Forms.PictureBox();
            this.FileUploadGuardianID_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileUplaodGuardianID_button = new System.Windows.Forms.Button();
            this.FileUplaodGuardianID_picturebox = new System.Windows.Forms.PictureBox();
            this.SubjectSelection_tab = new System.Windows.Forms.TabPage();
            this.SubjectSelectionFooter_panel = new System.Windows.Forms.Panel();
            this.SSSaveAndContinue_button = new System.Windows.Forms.Button();
            this.SubjectSelection_panel = new System.Windows.Forms.Panel();
            this.SubjectSelection_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SubjectDetailsTitle_label = new System.Windows.Forms.Label();
            this.PaymentPlan_tab = new System.Windows.Forms.TabPage();
            this.PaymentPlanFooter_panel = new System.Windows.Forms.Panel();
            this.PPSaveAndContinue_button = new System.Windows.Forms.Button();
            this.PaymentPlan_panel = new System.Windows.Forms.Panel();
            this.PaymentPlan_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.PaymentPlanTitle_label = new System.Windows.Forms.Label();
            this.Payment_tab = new System.Windows.Forms.TabPage();
            this.PaymentFooter_panel = new System.Windows.Forms.Panel();
            this.Register_button = new System.Windows.Forms.Button();
            this.Payment_panel = new System.Windows.Forms.Panel();
            this.PaymentTitle_label = new System.Windows.Forms.Label();
            this.BankingDetails_groupbox = new System.Windows.Forms.GroupBox();
            this.ExDateContainer_panel = new System.Windows.Forms.Panel();
            this.ExpiryDate_label = new System.Windows.Forms.Label();
            this.ExDate_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExpMonth_combobox = new System.Windows.Forms.ComboBox();
            this.ExpYear_combobox = new System.Windows.Forms.ComboBox();
            this.PaymentDue_panel = new System.Windows.Forms.Panel();
            this.AmountNotice_label = new System.Windows.Forms.Label();
            this.PaymentDue_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.PaymentDueAmount_label = new System.Windows.Forms.Label();
            this.PaymentDue_label = new System.Windows.Forms.Label();
            this.CVVorCVC_control = new RegistrationSystem.UserControls.UcInputField();
            this.CardNumber_control = new RegistrationSystem.UserControls.UcInputField();
            this.CardholderName_control = new RegistrationSystem.UserControls.UcInputField();
            this.BankName_control = new RegistrationSystem.UserControls.UcInputField();
            this.Confirmation_tab = new System.Windows.Forms.TabPage();
            this.Done_button = new System.Windows.Forms.Button();
            this.ConfirmationTitle_label = new System.Windows.Forms.Label();
            this.ConfirmationContainer_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmationRegisteredSubjects_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DetailedConfirmation_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.RegError_errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nav_panel = new System.Windows.Forms.Panel();
            this.FormTitle_label = new System.Windows.Forms.Label();
            this.FormClose_button = new System.Windows.Forms.Button();
            this.SubjectsRegistration_tabs.SuspendLayout();
            this.PersonalDetails_tabs.SuspendLayout();
            this.PersonalDetailsFooter_panel.SuspendLayout();
            this.PersonalDetails_panel.SuspendLayout();
            this.PersonalDetailsForm_groupbox.SuspendLayout();
            this.GenderContainer_panel.SuspendLayout();
            this.GenderField_panel.SuspendLayout();
            this.DoBContainer_panel.SuspendLayout();
            this.DateContainer_panel.SuspendLayout();
            this.GuardianDetails_tab.SuspendLayout();
            this.GuardianDetailsFooter_panel.SuspendLayout();
            this.GuardianDetailsForm_panel.SuspendLayout();
            this.GuardianDetailsForm_groupbox.SuspendLayout();
            this.SupportingDocuments_tab.SuspendLayout();
            this.SupportDocumentsFooter_panel.SuspendLayout();
            this.SupportDocuments_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileUploadPreview_adobe)).BeginInit();
            this.SupportDocuments_tablelayout.SuspendLayout();
            this.FileUploadID_tablelayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileUplaodID_picturebox)).BeginInit();
            this.FileUploadMatric_tablelayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileUploadMatric_picturebox)).BeginInit();
            this.FileUploadGuardianID_tablelayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileUplaodGuardianID_picturebox)).BeginInit();
            this.SubjectSelection_tab.SuspendLayout();
            this.SubjectSelectionFooter_panel.SuspendLayout();
            this.SubjectSelection_panel.SuspendLayout();
            this.PaymentPlan_tab.SuspendLayout();
            this.PaymentPlanFooter_panel.SuspendLayout();
            this.PaymentPlan_panel.SuspendLayout();
            this.Payment_tab.SuspendLayout();
            this.PaymentFooter_panel.SuspendLayout();
            this.Payment_panel.SuspendLayout();
            this.BankingDetails_groupbox.SuspendLayout();
            this.ExDateContainer_panel.SuspendLayout();
            this.ExDate_panel.SuspendLayout();
            this.PaymentDue_panel.SuspendLayout();
            this.PaymentDue_tablelayout.SuspendLayout();
            this.Confirmation_tab.SuspendLayout();
            this.ConfirmationContainer_tablelayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegError_errorprovider)).BeginInit();
            this.Nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectsRegistration_tabs
            // 
            this.SubjectsRegistration_tabs.CausesValidation = false;
            this.SubjectsRegistration_tabs.Controls.Add(this.PersonalDetails_tabs);
            this.SubjectsRegistration_tabs.Controls.Add(this.GuardianDetails_tab);
            this.SubjectsRegistration_tabs.Controls.Add(this.SupportingDocuments_tab);
            this.SubjectsRegistration_tabs.Controls.Add(this.SubjectSelection_tab);
            this.SubjectsRegistration_tabs.Controls.Add(this.PaymentPlan_tab);
            this.SubjectsRegistration_tabs.Controls.Add(this.Payment_tab);
            this.SubjectsRegistration_tabs.Controls.Add(this.Confirmation_tab);
            this.SubjectsRegistration_tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubjectsRegistration_tabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsRegistration_tabs.Location = new System.Drawing.Point(0, 27);
            this.SubjectsRegistration_tabs.Name = "SubjectsRegistration_tabs";
            this.SubjectsRegistration_tabs.SelectedIndex = 0;
            this.SubjectsRegistration_tabs.Size = new System.Drawing.Size(914, 632);
            this.SubjectsRegistration_tabs.TabIndex = 0;
            this.SubjectsRegistration_tabs.TabStop = false;
            // 
            // PersonalDetails_tabs
            // 
            this.PersonalDetails_tabs.Controls.Add(this.PersonalDetailsFooter_panel);
            this.PersonalDetails_tabs.Controls.Add(this.PersonalDetails_panel);
            this.PersonalDetails_tabs.Location = new System.Drawing.Point(4, 26);
            this.PersonalDetails_tabs.Name = "PersonalDetails_tabs";
            this.PersonalDetails_tabs.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalDetails_tabs.Size = new System.Drawing.Size(906, 602);
            this.PersonalDetails_tabs.TabIndex = 0;
            this.PersonalDetails_tabs.Tag = "PersonalDetailsForm_groupbox";
            this.PersonalDetails_tabs.Text = "Personal Details";
            this.PersonalDetails_tabs.UseVisualStyleBackColor = true;
            this.PersonalDetails_tabs.Enter += new System.EventHandler(this.Tab_Enter);
            this.PersonalDetails_tabs.Validating += new System.ComponentModel.CancelEventHandler(this.Tab_Validating);
            // 
            // PersonalDetailsFooter_panel
            // 
            this.PersonalDetailsFooter_panel.Controls.Add(this.PDSaveAndContinue_button);
            this.PersonalDetailsFooter_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PersonalDetailsFooter_panel.Location = new System.Drawing.Point(3, 507);
            this.PersonalDetailsFooter_panel.Name = "PersonalDetailsFooter_panel";
            this.PersonalDetailsFooter_panel.Size = new System.Drawing.Size(900, 92);
            this.PersonalDetailsFooter_panel.TabIndex = 3;
            // 
            // PDSaveAndContinue_button
            // 
            this.PDSaveAndContinue_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PDSaveAndContinue_button.BackColor = System.Drawing.Color.DarkOrange;
            this.PDSaveAndContinue_button.CausesValidation = false;
            this.PDSaveAndContinue_button.FlatAppearance.BorderSize = 0;
            this.PDSaveAndContinue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDSaveAndContinue_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDSaveAndContinue_button.ForeColor = System.Drawing.Color.White;
            this.PDSaveAndContinue_button.Location = new System.Drawing.Point(639, 36);
            this.PDSaveAndContinue_button.Name = "PDSaveAndContinue_button";
            this.PDSaveAndContinue_button.Size = new System.Drawing.Size(181, 37);
            this.PDSaveAndContinue_button.TabIndex = 0;
            this.PDSaveAndContinue_button.Tag = "PersonalDetailsForm_groupbox";
            this.PDSaveAndContinue_button.Text = "SAVE AND CONTINUE";
            this.PDSaveAndContinue_button.UseVisualStyleBackColor = false;
            this.PDSaveAndContinue_button.Click += new System.EventHandler(this.PDSaveAndContinue_button_Click);
            // 
            // PersonalDetails_panel
            // 
            this.PersonalDetails_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PersonalDetails_panel.Controls.Add(this.PersonalDetailsForm_groupbox);
            this.PersonalDetails_panel.Controls.Add(this.PersonDetailsTitle_label);
            this.PersonalDetails_panel.Location = new System.Drawing.Point(66, 6);
            this.PersonalDetails_panel.Name = "PersonalDetails_panel";
            this.PersonalDetails_panel.Size = new System.Drawing.Size(761, 494);
            this.PersonalDetails_panel.TabIndex = 2;
            // 
            // PersonalDetailsForm_groupbox
            // 
            this.PersonalDetailsForm_groupbox.Controls.Add(this.HomeAddress_label);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.ZipOrPostalCode_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.Suburb_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.CityOrTown_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.Address_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.GenderContainer_panel);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.DoBContainer_panel);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.PhoneNumber_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.PersonalDetailsIDorPassportNumber_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.EmailAddress_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.LastName_control);
            this.PersonalDetailsForm_groupbox.Controls.Add(this.FirstName_control);
            this.PersonalDetailsForm_groupbox.Location = new System.Drawing.Point(3, 37);
            this.PersonalDetailsForm_groupbox.Name = "PersonalDetailsForm_groupbox";
            this.PersonalDetailsForm_groupbox.Size = new System.Drawing.Size(755, 454);
            this.PersonalDetailsForm_groupbox.TabIndex = 4;
            this.PersonalDetailsForm_groupbox.TabStop = false;
            this.PersonalDetailsForm_groupbox.Tag = "";
            // 
            // HomeAddress_label
            // 
            this.HomeAddress_label.AutoSize = true;
            this.HomeAddress_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddress_label.ForeColor = System.Drawing.Color.DimGray;
            this.HomeAddress_label.Location = new System.Drawing.Point(414, 130);
            this.HomeAddress_label.Name = "HomeAddress_label";
            this.HomeAddress_label.Size = new System.Drawing.Size(98, 17);
            this.HomeAddress_label.TabIndex = 37;
            this.HomeAddress_label.Text = "Home Address";
            // 
            // ZipOrPostalCode_control
            // 
            this.ZipOrPostalCode_control.AutoSize = true;
            this.ZipOrPostalCode_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipOrPostalCode_control.InputHasError = false;
            this.ZipOrPostalCode_control.InputLabel = "Zip / Postal code";
            this.ZipOrPostalCode_control.InputMax = 5;
            this.ZipOrPostalCode_control.InputMin = 4;
            this.ZipOrPostalCode_control.InputText = "Zip / Postal code";
            this.ZipOrPostalCode_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Number;
            this.ZipOrPostalCode_control.Location = new System.Drawing.Point(413, 364);
            this.ZipOrPostalCode_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZipOrPostalCode_control.Name = "ZipOrPostalCode_control";
            this.ZipOrPostalCode_control.Size = new System.Drawing.Size(287, 63);
            this.ZipOrPostalCode_control.TabIndex = 8;
            this.ZipOrPostalCode_control.Tag = "CustomInputControl";
            this.ZipOrPostalCode_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // Suburb_control
            // 
            this.Suburb_control.AutoSize = true;
            this.Suburb_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suburb_control.InputHasError = false;
            this.Suburb_control.InputLabel = "Suburb / Village";
            this.Suburb_control.InputMin = 3;
            this.Suburb_control.InputText = "Suburb / Village";
            this.Suburb_control.Location = new System.Drawing.Point(413, 222);
            this.Suburb_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Suburb_control.Name = "Suburb_control";
            this.Suburb_control.Size = new System.Drawing.Size(287, 63);
            this.Suburb_control.TabIndex = 6;
            this.Suburb_control.Tag = "CustomInputControl";
            this.Suburb_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // CityOrTown_control
            // 
            this.CityOrTown_control.AutoSize = true;
            this.CityOrTown_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityOrTown_control.InputHasError = false;
            this.CityOrTown_control.InputLabel = "City / Town";
            this.CityOrTown_control.InputMin = 3;
            this.CityOrTown_control.InputText = "City / Town";
            this.CityOrTown_control.Location = new System.Drawing.Point(413, 293);
            this.CityOrTown_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CityOrTown_control.Name = "CityOrTown_control";
            this.CityOrTown_control.Size = new System.Drawing.Size(287, 63);
            this.CityOrTown_control.TabIndex = 7;
            this.CityOrTown_control.Tag = "CustomInputControl";
            this.CityOrTown_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // Address_control
            // 
            this.Address_control.AutoSize = true;
            this.Address_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_control.InputHasError = false;
            this.Address_control.InputLabel = "Postal Address";
            this.Address_control.InputMin = 3;
            this.Address_control.InputText = "Postal Address";
            this.Address_control.Location = new System.Drawing.Point(413, 151);
            this.Address_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Address_control.Name = "Address_control";
            this.Address_control.Size = new System.Drawing.Size(287, 63);
            this.Address_control.TabIndex = 5;
            this.Address_control.Tag = "CustomInputControl";
            this.Address_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // GenderContainer_panel
            // 
            this.GenderContainer_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderContainer_panel.Controls.Add(this.GenderField_panel);
            this.GenderContainer_panel.Location = new System.Drawing.Point(413, 13);
            this.GenderContainer_panel.Name = "GenderContainer_panel";
            this.GenderContainer_panel.Size = new System.Drawing.Size(284, 63);
            this.GenderContainer_panel.TabIndex = 0;
            // 
            // GenderField_panel
            // 
            this.GenderField_panel.Controls.Add(this.Gender_label);
            this.GenderField_panel.Controls.Add(this.Gender_combobox);
            this.GenderField_panel.Controls.Add(this.GenderBottom_panel);
            this.GenderField_panel.Location = new System.Drawing.Point(4, 1);
            this.GenderField_panel.Name = "GenderField_panel";
            this.GenderField_panel.Size = new System.Drawing.Size(277, 57);
            this.GenderField_panel.TabIndex = 0;
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.ForeColor = System.Drawing.Color.DimGray;
            this.Gender_label.Location = new System.Drawing.Point(-3, 5);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(51, 17);
            this.Gender_label.TabIndex = 18;
            this.Gender_label.Text = "Gender";
            // 
            // Gender_combobox
            // 
            this.Gender_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.Gender_combobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_combobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_combobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_combobox.Location = new System.Drawing.Point(0, 29);
            this.Gender_combobox.Name = "Gender_combobox";
            this.Gender_combobox.Size = new System.Drawing.Size(277, 25);
            this.Gender_combobox.TabIndex = 0;
            this.Gender_combobox.TabStop = false;
            this.Gender_combobox.Tag = "WinInputControl";
            // 
            // GenderBottom_panel
            // 
            this.GenderBottom_panel.BackColor = System.Drawing.Color.DarkGray;
            this.GenderBottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenderBottom_panel.Location = new System.Drawing.Point(0, 54);
            this.GenderBottom_panel.Name = "GenderBottom_panel";
            this.GenderBottom_panel.Size = new System.Drawing.Size(277, 3);
            this.GenderBottom_panel.TabIndex = 19;
            // 
            // DoBContainer_panel
            // 
            this.DoBContainer_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoBContainer_panel.Controls.Add(this.DoB_label);
            this.DoBContainer_panel.Controls.Add(this.DateContainer_panel);
            this.DoBContainer_panel.Location = new System.Drawing.Point(42, 354);
            this.DoBContainer_panel.Name = "DoBContainer_panel";
            this.DoBContainer_panel.Size = new System.Drawing.Size(299, 87);
            this.DoBContainer_panel.TabIndex = 0;
            // 
            // DoB_label
            // 
            this.DoB_label.AutoSize = true;
            this.DoB_label.ForeColor = System.Drawing.Color.DimGray;
            this.DoB_label.Location = new System.Drawing.Point(3, 0);
            this.DoB_label.Name = "DoB_label";
            this.DoB_label.Size = new System.Drawing.Size(81, 17);
            this.DoB_label.TabIndex = 21;
            this.DoB_label.Text = "Date of Birth";
            // 
            // DateContainer_panel
            // 
            this.DateContainer_panel.Controls.Add(this.Day_label);
            this.DateContainer_panel.Controls.Add(this.Month_label);
            this.DateContainer_panel.Controls.Add(this.Year_label);
            this.DateContainer_panel.Controls.Add(this.DoBDay_combobox);
            this.DateContainer_panel.Controls.Add(this.DoBBottom_panel);
            this.DateContainer_panel.Controls.Add(this.DoBMonth_combobox);
            this.DateContainer_panel.Controls.Add(this.DoBYear_combobox);
            this.DateContainer_panel.Location = new System.Drawing.Point(7, 20);
            this.DateContainer_panel.Name = "DateContainer_panel";
            this.DateContainer_panel.Size = new System.Drawing.Size(286, 63);
            this.DateContainer_panel.TabIndex = 0;
            // 
            // Day_label
            // 
            this.Day_label.AutoSize = true;
            this.Day_label.ForeColor = System.Drawing.Color.DimGray;
            this.Day_label.Location = new System.Drawing.Point(227, 9);
            this.Day_label.Name = "Day_label";
            this.Day_label.Size = new System.Drawing.Size(30, 17);
            this.Day_label.TabIndex = 20;
            this.Day_label.Text = "Day";
            // 
            // Month_label
            // 
            this.Month_label.AutoSize = true;
            this.Month_label.ForeColor = System.Drawing.Color.DimGray;
            this.Month_label.Location = new System.Drawing.Point(115, 9);
            this.Month_label.Name = "Month_label";
            this.Month_label.Size = new System.Drawing.Size(46, 17);
            this.Month_label.TabIndex = 19;
            this.Month_label.Text = "Month";
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.ForeColor = System.Drawing.Color.DimGray;
            this.Year_label.Location = new System.Drawing.Point(20, 9);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(33, 17);
            this.Year_label.TabIndex = 18;
            this.Year_label.Text = "Year";
            // 
            // DoBDay_combobox
            // 
            this.DoBDay_combobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBDay_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoBDay_combobox.Enabled = false;
            this.DoBDay_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoBDay_combobox.FormatString = "N0";
            this.DoBDay_combobox.FormattingEnabled = true;
            this.DoBDay_combobox.Location = new System.Drawing.Point(209, 35);
            this.DoBDay_combobox.Name = "DoBDay_combobox";
            this.DoBDay_combobox.Size = new System.Drawing.Size(74, 25);
            this.DoBDay_combobox.TabIndex = 3;
            this.DoBDay_combobox.TabStop = false;
            this.DoBDay_combobox.Tag = "WinInputControl";
            this.DoBDay_combobox.Enter += new System.EventHandler(this.DoBDay_combobox_Enter);
            this.DoBDay_combobox.Leave += new System.EventHandler(this.DoBDay_combobox_Leave);
            // 
            // DoBBottom_panel
            // 
            this.DoBBottom_panel.BackColor = System.Drawing.Color.DarkGray;
            this.DoBBottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DoBBottom_panel.Location = new System.Drawing.Point(0, 60);
            this.DoBBottom_panel.Name = "DoBBottom_panel";
            this.DoBBottom_panel.Size = new System.Drawing.Size(286, 3);
            this.DoBBottom_panel.TabIndex = 17;
            // 
            // DoBMonth_combobox
            // 
            this.DoBMonth_combobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DoBMonth_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoBMonth_combobox.Enabled = false;
            this.DoBMonth_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoBMonth_combobox.FormatString = "N0";
            this.DoBMonth_combobox.FormattingEnabled = true;
            this.DoBMonth_combobox.Location = new System.Drawing.Point(106, 35);
            this.DoBMonth_combobox.Name = "DoBMonth_combobox";
            this.DoBMonth_combobox.Size = new System.Drawing.Size(74, 25);
            this.DoBMonth_combobox.TabIndex = 2;
            this.DoBMonth_combobox.TabStop = false;
            this.DoBMonth_combobox.Tag = "WinInputControl";
            this.DoBMonth_combobox.SelectedIndexChanged += new System.EventHandler(this.DoBMonth_combobox_SelectedIndexChanged);
            this.DoBMonth_combobox.Enter += new System.EventHandler(this.DoBMonth_combobox_Enter);
            this.DoBMonth_combobox.Leave += new System.EventHandler(this.DoBMonth_combobox_Leave);
            // 
            // DoBYear_combobox
            // 
            this.DoBYear_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.DoBYear_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoBYear_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoBYear_combobox.FormatString = "N0";
            this.DoBYear_combobox.FormattingEnabled = true;
            this.DoBYear_combobox.Location = new System.Drawing.Point(3, 35);
            this.DoBYear_combobox.Name = "DoBYear_combobox";
            this.DoBYear_combobox.Size = new System.Drawing.Size(74, 25);
            this.DoBYear_combobox.TabIndex = 1;
            this.DoBYear_combobox.TabStop = false;
            this.DoBYear_combobox.Tag = "WinInputControl";
            this.DoBYear_combobox.SelectedIndexChanged += new System.EventHandler(this.DoBYear_combobox_SelectedIndexChanged);
            this.DoBYear_combobox.Enter += new System.EventHandler(this.DoBYear_combobox_Enter);
            this.DoBYear_combobox.Leave += new System.EventHandler(this.DoBYear_combobox_Leave);
            // 
            // PhoneNumber_control
            // 
            this.PhoneNumber_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNumber_control.AutoSize = true;
            this.PhoneNumber_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_control.InputHasError = false;
            this.PhoneNumber_control.InputLabel = "Phone Number";
            this.PhoneNumber_control.InputMin = 10;
            this.PhoneNumber_control.InputText = "Phone Number";
            this.PhoneNumber_control.Location = new System.Drawing.Point(43, 222);
            this.PhoneNumber_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneNumber_control.Name = "PhoneNumber_control";
            this.PhoneNumber_control.Size = new System.Drawing.Size(299, 63);
            this.PhoneNumber_control.TabIndex = 3;
            this.PhoneNumber_control.Tag = "CustomInputControl";
            this.PhoneNumber_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // PersonalDetailsIDorPassportNumber_control
            // 
            this.PersonalDetailsIDorPassportNumber_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PersonalDetailsIDorPassportNumber_control.AutoSize = true;
            this.PersonalDetailsIDorPassportNumber_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsIDorPassportNumber_control.InputHasError = false;
            this.PersonalDetailsIDorPassportNumber_control.InputLabel = "RSA ID/Passport Number";
            this.PersonalDetailsIDorPassportNumber_control.InputMax = 13;
            this.PersonalDetailsIDorPassportNumber_control.InputMin = 9;
            this.PersonalDetailsIDorPassportNumber_control.InputText = "RSA ID/Passport Number";
            this.PersonalDetailsIDorPassportNumber_control.Location = new System.Drawing.Point(43, 293);
            this.PersonalDetailsIDorPassportNumber_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonalDetailsIDorPassportNumber_control.Name = "PersonalDetailsIDorPassportNumber_control";
            this.PersonalDetailsIDorPassportNumber_control.Size = new System.Drawing.Size(299, 63);
            this.PersonalDetailsIDorPassportNumber_control.TabIndex = 4;
            this.PersonalDetailsIDorPassportNumber_control.Tag = "CustomInputControl";
            this.PersonalDetailsIDorPassportNumber_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // EmailAddress_control
            // 
            this.EmailAddress_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailAddress_control.AutoSize = true;
            this.EmailAddress_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress_control.InputHasError = false;
            this.EmailAddress_control.InputLabel = "Email Address";
            this.EmailAddress_control.InputText = "Email Address";
            this.EmailAddress_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Email;
            this.EmailAddress_control.Location = new System.Drawing.Point(43, 151);
            this.EmailAddress_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailAddress_control.Name = "EmailAddress_control";
            this.EmailAddress_control.Size = new System.Drawing.Size(299, 63);
            this.EmailAddress_control.TabIndex = 2;
            this.EmailAddress_control.Tag = "CustomInputControl";
            this.EmailAddress_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // LastName_control
            // 
            this.LastName_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastName_control.AutoSize = true;
            this.LastName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_control.InputHasError = false;
            this.LastName_control.InputLabel = "Last Name";
            this.LastName_control.InputMax = 32;
            this.LastName_control.InputMin = 2;
            this.LastName_control.InputText = "Last Name";
            this.LastName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.LastName_control.Location = new System.Drawing.Point(43, 80);
            this.LastName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastName_control.Name = "LastName_control";
            this.LastName_control.Size = new System.Drawing.Size(299, 63);
            this.LastName_control.TabIndex = 1;
            this.LastName_control.Tag = "CustomInputControl";
            this.LastName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // FirstName_control
            // 
            this.FirstName_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstName_control.AutoSize = true;
            this.FirstName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_control.InputHasError = false;
            this.FirstName_control.InputLabel = "First Name";
            this.FirstName_control.InputMax = 32;
            this.FirstName_control.InputMin = 2;
            this.FirstName_control.InputText = "First Name";
            this.FirstName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.FirstName_control.Location = new System.Drawing.Point(43, 13);
            this.FirstName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstName_control.Name = "FirstName_control";
            this.FirstName_control.Size = new System.Drawing.Size(299, 63);
            this.FirstName_control.TabIndex = 0;
            this.FirstName_control.Tag = "CustomInputControl";
            this.FirstName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.PersonalDetails_InputFieldError);
            // 
            // PersonDetailsTitle_label
            // 
            this.PersonDetailsTitle_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PersonDetailsTitle_label.AutoSize = true;
            this.PersonDetailsTitle_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonDetailsTitle_label.ForeColor = System.Drawing.Color.DimGray;
            this.PersonDetailsTitle_label.Location = new System.Drawing.Point(270, 3);
            this.PersonDetailsTitle_label.Name = "PersonDetailsTitle_label";
            this.PersonDetailsTitle_label.Size = new System.Drawing.Size(204, 25);
            this.PersonDetailsTitle_label.TabIndex = 3;
            this.PersonDetailsTitle_label.Text = "Enter Personal Details";
            this.PersonDetailsTitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuardianDetails_tab
            // 
            this.GuardianDetails_tab.Controls.Add(this.GuardianDetailsFooter_panel);
            this.GuardianDetails_tab.Controls.Add(this.GuardianDetailsForm_panel);
            this.GuardianDetails_tab.Location = new System.Drawing.Point(4, 26);
            this.GuardianDetails_tab.Name = "GuardianDetails_tab";
            this.GuardianDetails_tab.Padding = new System.Windows.Forms.Padding(3);
            this.GuardianDetails_tab.Size = new System.Drawing.Size(906, 602);
            this.GuardianDetails_tab.TabIndex = 1;
            this.GuardianDetails_tab.Tag = "GuardianDetailsForm_groupbox";
            this.GuardianDetails_tab.Text = "Guardian Details";
            this.GuardianDetails_tab.UseVisualStyleBackColor = true;
            this.GuardianDetails_tab.Enter += new System.EventHandler(this.Tab_Enter);
            this.GuardianDetails_tab.Validating += new System.ComponentModel.CancelEventHandler(this.Tab_Validating);
            // 
            // GuardianDetailsFooter_panel
            // 
            this.GuardianDetailsFooter_panel.Controls.Add(this.GDSaveAndContinue_button);
            this.GuardianDetailsFooter_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GuardianDetailsFooter_panel.Location = new System.Drawing.Point(3, 507);
            this.GuardianDetailsFooter_panel.Name = "GuardianDetailsFooter_panel";
            this.GuardianDetailsFooter_panel.Size = new System.Drawing.Size(900, 92);
            this.GuardianDetailsFooter_panel.TabIndex = 9;
            // 
            // GDSaveAndContinue_button
            // 
            this.GDSaveAndContinue_button.BackColor = System.Drawing.Color.DarkOrange;
            this.GDSaveAndContinue_button.FlatAppearance.BorderSize = 0;
            this.GDSaveAndContinue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GDSaveAndContinue_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDSaveAndContinue_button.ForeColor = System.Drawing.Color.White;
            this.GDSaveAndContinue_button.Location = new System.Drawing.Point(639, 36);
            this.GDSaveAndContinue_button.Name = "GDSaveAndContinue_button";
            this.GDSaveAndContinue_button.Size = new System.Drawing.Size(181, 37);
            this.GDSaveAndContinue_button.TabIndex = 0;
            this.GDSaveAndContinue_button.Tag = "GuardianDetailsForm_groupbox";
            this.GDSaveAndContinue_button.Text = "SAVE AND CONTINUE";
            this.GDSaveAndContinue_button.UseVisualStyleBackColor = false;
            this.GDSaveAndContinue_button.Click += new System.EventHandler(this.GDSaveAndContinue_button_Click);
            // 
            // GuardianDetailsForm_panel
            // 
            this.GuardianDetailsForm_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardianDetailsForm_panel.BackColor = System.Drawing.Color.Transparent;
            this.GuardianDetailsForm_panel.Controls.Add(this.GuardianDetailsForm_groupbox);
            this.GuardianDetailsForm_panel.Controls.Add(this.GuardianDetailsTitle_label);
            this.GuardianDetailsForm_panel.Location = new System.Drawing.Point(81, 6);
            this.GuardianDetailsForm_panel.Name = "GuardianDetailsForm_panel";
            this.GuardianDetailsForm_panel.Size = new System.Drawing.Size(742, 468);
            this.GuardianDetailsForm_panel.TabIndex = 8;
            // 
            // GuardianDetailsForm_groupbox
            // 
            this.GuardianDetailsForm_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardianDetailsForm_groupbox.Controls.Add(this.PersonalDetails_label);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GHomeAddress_label);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianZipOrPostalCode_control);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianSuburb_control);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianCityOrTown_control);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianAddress_control);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianPhoneNumber_control);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianIDorPassportNumber_control);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianLastName_control);
            this.GuardianDetailsForm_groupbox.Controls.Add(this.GuardianFirstName_control);
            this.GuardianDetailsForm_groupbox.Location = new System.Drawing.Point(3, 49);
            this.GuardianDetailsForm_groupbox.Name = "GuardianDetailsForm_groupbox";
            this.GuardianDetailsForm_groupbox.Size = new System.Drawing.Size(736, 416);
            this.GuardianDetailsForm_groupbox.TabIndex = 25;
            this.GuardianDetailsForm_groupbox.TabStop = false;
            // 
            // PersonalDetails_label
            // 
            this.PersonalDetails_label.AutoSize = true;
            this.PersonalDetails_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetails_label.Location = new System.Drawing.Point(35, 25);
            this.PersonalDetails_label.Name = "PersonalDetails_label";
            this.PersonalDetails_label.Size = new System.Drawing.Size(104, 17);
            this.PersonalDetails_label.TabIndex = 40;
            this.PersonalDetails_label.Text = "Personal Details";
            // 
            // GHomeAddress_label
            // 
            this.GHomeAddress_label.AutoSize = true;
            this.GHomeAddress_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GHomeAddress_label.Location = new System.Drawing.Point(429, 25);
            this.GHomeAddress_label.Name = "GHomeAddress_label";
            this.GHomeAddress_label.Size = new System.Drawing.Size(98, 17);
            this.GHomeAddress_label.TabIndex = 39;
            this.GHomeAddress_label.Text = "Home Address";
            // 
            // GuardianZipOrPostalCode_control
            // 
            this.GuardianZipOrPostalCode_control.AutoSize = true;
            this.GuardianZipOrPostalCode_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianZipOrPostalCode_control.InputHasError = false;
            this.GuardianZipOrPostalCode_control.InputLabel = "Zip / Postal code";
            this.GuardianZipOrPostalCode_control.InputMax = 5;
            this.GuardianZipOrPostalCode_control.InputMin = 4;
            this.GuardianZipOrPostalCode_control.InputText = "Zip / Postal code";
            this.GuardianZipOrPostalCode_control.Location = new System.Drawing.Point(432, 268);
            this.GuardianZipOrPostalCode_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianZipOrPostalCode_control.Name = "GuardianZipOrPostalCode_control";
            this.GuardianZipOrPostalCode_control.Size = new System.Drawing.Size(287, 63);
            this.GuardianZipOrPostalCode_control.TabIndex = 7;
            this.GuardianZipOrPostalCode_control.Tag = "CustomInputControl";
            this.GuardianZipOrPostalCode_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianSuburb_control
            // 
            this.GuardianSuburb_control.AutoSize = true;
            this.GuardianSuburb_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianSuburb_control.InputHasError = false;
            this.GuardianSuburb_control.InputLabel = "Suburb / Village";
            this.GuardianSuburb_control.InputMin = 3;
            this.GuardianSuburb_control.InputText = "Suburb / Village";
            this.GuardianSuburb_control.Location = new System.Drawing.Point(432, 126);
            this.GuardianSuburb_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianSuburb_control.Name = "GuardianSuburb_control";
            this.GuardianSuburb_control.Size = new System.Drawing.Size(287, 63);
            this.GuardianSuburb_control.TabIndex = 5;
            this.GuardianSuburb_control.Tag = "CustomInputControl";
            this.GuardianSuburb_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianCityOrTown_control
            // 
            this.GuardianCityOrTown_control.AutoSize = true;
            this.GuardianCityOrTown_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianCityOrTown_control.InputHasError = false;
            this.GuardianCityOrTown_control.InputLabel = "City / Town";
            this.GuardianCityOrTown_control.InputMin = 3;
            this.GuardianCityOrTown_control.InputText = "City / Town";
            this.GuardianCityOrTown_control.Location = new System.Drawing.Point(432, 197);
            this.GuardianCityOrTown_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianCityOrTown_control.Name = "GuardianCityOrTown_control";
            this.GuardianCityOrTown_control.Size = new System.Drawing.Size(287, 63);
            this.GuardianCityOrTown_control.TabIndex = 6;
            this.GuardianCityOrTown_control.Tag = "CustomInputControl";
            this.GuardianCityOrTown_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianAddress_control
            // 
            this.GuardianAddress_control.AutoSize = true;
            this.GuardianAddress_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianAddress_control.InputHasError = false;
            this.GuardianAddress_control.InputLabel = "Postal Address";
            this.GuardianAddress_control.InputMin = 3;
            this.GuardianAddress_control.InputText = "Postal Address";
            this.GuardianAddress_control.Location = new System.Drawing.Point(432, 55);
            this.GuardianAddress_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianAddress_control.Name = "GuardianAddress_control";
            this.GuardianAddress_control.Size = new System.Drawing.Size(287, 63);
            this.GuardianAddress_control.TabIndex = 4;
            this.GuardianAddress_control.Tag = "CustomInputControl";
            this.GuardianAddress_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianPhoneNumber_control
            // 
            this.GuardianPhoneNumber_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuardianPhoneNumber_control.AutoSize = true;
            this.GuardianPhoneNumber_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianPhoneNumber_control.InputHasError = false;
            this.GuardianPhoneNumber_control.InputLabel = "Phone Number";
            this.GuardianPhoneNumber_control.InputMin = 10;
            this.GuardianPhoneNumber_control.InputText = "Phone Number";
            this.GuardianPhoneNumber_control.Location = new System.Drawing.Point(26, 193);
            this.GuardianPhoneNumber_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianPhoneNumber_control.Name = "GuardianPhoneNumber_control";
            this.GuardianPhoneNumber_control.Size = new System.Drawing.Size(299, 63);
            this.GuardianPhoneNumber_control.TabIndex = 2;
            this.GuardianPhoneNumber_control.Tag = "CustomInputControl";
            this.GuardianPhoneNumber_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianIDorPassportNumber_control
            // 
            this.GuardianIDorPassportNumber_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuardianIDorPassportNumber_control.AutoSize = true;
            this.GuardianIDorPassportNumber_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianIDorPassportNumber_control.InputHasError = false;
            this.GuardianIDorPassportNumber_control.InputLabel = "RSA ID/Passport Number";
            this.GuardianIDorPassportNumber_control.InputMax = 13;
            this.GuardianIDorPassportNumber_control.InputMin = 9;
            this.GuardianIDorPassportNumber_control.InputText = "RSA ID/Passport Number";
            this.GuardianIDorPassportNumber_control.Location = new System.Drawing.Point(26, 264);
            this.GuardianIDorPassportNumber_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianIDorPassportNumber_control.Name = "GuardianIDorPassportNumber_control";
            this.GuardianIDorPassportNumber_control.Size = new System.Drawing.Size(299, 63);
            this.GuardianIDorPassportNumber_control.TabIndex = 3;
            this.GuardianIDorPassportNumber_control.Tag = "CustomInputControl";
            this.GuardianIDorPassportNumber_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianLastName_control
            // 
            this.GuardianLastName_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuardianLastName_control.AutoSize = true;
            this.GuardianLastName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianLastName_control.InputHasError = false;
            this.GuardianLastName_control.InputLabel = "Last Name";
            this.GuardianLastName_control.InputMin = 2;
            this.GuardianLastName_control.InputText = "Last Name";
            this.GuardianLastName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.GuardianLastName_control.Location = new System.Drawing.Point(26, 122);
            this.GuardianLastName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianLastName_control.Name = "GuardianLastName_control";
            this.GuardianLastName_control.Size = new System.Drawing.Size(299, 63);
            this.GuardianLastName_control.TabIndex = 1;
            this.GuardianLastName_control.Tag = "CustomInputControl";
            this.GuardianLastName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianFirstName_control
            // 
            this.GuardianFirstName_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuardianFirstName_control.AutoSize = true;
            this.GuardianFirstName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianFirstName_control.InputHasError = false;
            this.GuardianFirstName_control.InputLabel = "First Name";
            this.GuardianFirstName_control.InputMin = 2;
            this.GuardianFirstName_control.InputText = "First Name";
            this.GuardianFirstName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.GuardianFirstName_control.Location = new System.Drawing.Point(26, 55);
            this.GuardianFirstName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardianFirstName_control.Name = "GuardianFirstName_control";
            this.GuardianFirstName_control.Size = new System.Drawing.Size(299, 63);
            this.GuardianFirstName_control.TabIndex = 0;
            this.GuardianFirstName_control.Tag = "CustomInputControl";
            this.GuardianFirstName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Guardian_InputFieldError);
            // 
            // GuardianDetailsTitle_label
            // 
            this.GuardianDetailsTitle_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuardianDetailsTitle_label.AutoSize = true;
            this.GuardianDetailsTitle_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardianDetailsTitle_label.ForeColor = System.Drawing.Color.DimGray;
            this.GuardianDetailsTitle_label.Location = new System.Drawing.Point(242, 17);
            this.GuardianDetailsTitle_label.Name = "GuardianDetailsTitle_label";
            this.GuardianDetailsTitle_label.Size = new System.Drawing.Size(211, 25);
            this.GuardianDetailsTitle_label.TabIndex = 24;
            this.GuardianDetailsTitle_label.Text = "Enter Guardian Details";
            // 
            // SupportingDocuments_tab
            // 
            this.SupportingDocuments_tab.Controls.Add(this.SupportDocumentsFooter_panel);
            this.SupportingDocuments_tab.Controls.Add(this.SupportDocuments_panel);
            this.SupportingDocuments_tab.Location = new System.Drawing.Point(4, 26);
            this.SupportingDocuments_tab.Name = "SupportingDocuments_tab";
            this.SupportingDocuments_tab.Padding = new System.Windows.Forms.Padding(3);
            this.SupportingDocuments_tab.Size = new System.Drawing.Size(906, 602);
            this.SupportingDocuments_tab.TabIndex = 6;
            this.SupportingDocuments_tab.Text = "Supporting Documents";
            this.SupportingDocuments_tab.UseVisualStyleBackColor = true;
            // 
            // SupportDocumentsFooter_panel
            // 
            this.SupportDocumentsFooter_panel.Controls.Add(this.SDSaveAndContinue_button);
            this.SupportDocumentsFooter_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SupportDocumentsFooter_panel.Location = new System.Drawing.Point(3, 507);
            this.SupportDocumentsFooter_panel.Name = "SupportDocumentsFooter_panel";
            this.SupportDocumentsFooter_panel.Size = new System.Drawing.Size(900, 92);
            this.SupportDocumentsFooter_panel.TabIndex = 10;
            // 
            // SDSaveAndContinue_button
            // 
            this.SDSaveAndContinue_button.BackColor = System.Drawing.Color.DarkOrange;
            this.SDSaveAndContinue_button.FlatAppearance.BorderSize = 0;
            this.SDSaveAndContinue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SDSaveAndContinue_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDSaveAndContinue_button.ForeColor = System.Drawing.Color.White;
            this.SDSaveAndContinue_button.Location = new System.Drawing.Point(639, 36);
            this.SDSaveAndContinue_button.Name = "SDSaveAndContinue_button";
            this.SDSaveAndContinue_button.Size = new System.Drawing.Size(181, 37);
            this.SDSaveAndContinue_button.TabIndex = 0;
            this.SDSaveAndContinue_button.Tag = "GuardianDetailsForm_groupbox";
            this.SDSaveAndContinue_button.Text = "SAVE AND CONTINUE";
            this.SDSaveAndContinue_button.UseVisualStyleBackColor = false;
            this.SDSaveAndContinue_button.Click += new System.EventHandler(this.SDSaveAndContinue_button_Click);
            // 
            // SupportDocuments_panel
            // 
            this.SupportDocuments_panel.Controls.Add(this.FileUploadPreview_adobe);
            this.SupportDocuments_panel.Controls.Add(this.SupportDocuments_tablelayout);
            this.SupportDocuments_panel.Location = new System.Drawing.Point(68, 33);
            this.SupportDocuments_panel.Name = "SupportDocuments_panel";
            this.SupportDocuments_panel.Size = new System.Drawing.Size(755, 445);
            this.SupportDocuments_panel.TabIndex = 0;
            // 
            // FileUploadPreview_adobe
            // 
            this.FileUploadPreview_adobe.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileUploadPreview_adobe.Enabled = true;
            this.FileUploadPreview_adobe.Location = new System.Drawing.Point(0, 0);
            this.FileUploadPreview_adobe.Name = "FileUploadPreview_adobe";
            this.FileUploadPreview_adobe.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("FileUploadPreview_adobe.OcxState")));
            this.FileUploadPreview_adobe.Size = new System.Drawing.Size(345, 445);
            this.FileUploadPreview_adobe.TabIndex = 2;
            // 
            // SupportDocuments_tablelayout
            // 
            this.SupportDocuments_tablelayout.ColumnCount = 1;
            this.SupportDocuments_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SupportDocuments_tablelayout.Controls.Add(this.FileUploadID_tablelayout, 0, 0);
            this.SupportDocuments_tablelayout.Controls.Add(this.FileUploadMatric_tablelayout, 0, 2);
            this.SupportDocuments_tablelayout.Controls.Add(this.FileUploadGuardianID_tablelayout, 0, 1);
            this.SupportDocuments_tablelayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.SupportDocuments_tablelayout.Location = new System.Drawing.Point(351, 0);
            this.SupportDocuments_tablelayout.Name = "SupportDocuments_tablelayout";
            this.SupportDocuments_tablelayout.RowCount = 3;
            this.SupportDocuments_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SupportDocuments_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SupportDocuments_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SupportDocuments_tablelayout.Size = new System.Drawing.Size(404, 445);
            this.SupportDocuments_tablelayout.TabIndex = 0;
            // 
            // FileUploadID_tablelayout
            // 
            this.FileUploadID_tablelayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FileUploadID_tablelayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FileUploadID_tablelayout.ColumnCount = 2;
            this.FileUploadID_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileUploadID_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.FileUploadID_tablelayout.Controls.Add(this.FileUplaodID_picturebox, 0, 0);
            this.FileUploadID_tablelayout.Controls.Add(this.FileUplaodID_button, 1, 0);
            this.FileUploadID_tablelayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUploadID_tablelayout.Location = new System.Drawing.Point(3, 3);
            this.FileUploadID_tablelayout.Name = "FileUploadID_tablelayout";
            this.FileUploadID_tablelayout.RowCount = 1;
            this.FileUploadID_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileUploadID_tablelayout.Size = new System.Drawing.Size(398, 142);
            this.FileUploadID_tablelayout.TabIndex = 0;
            // 
            // FileUplaodID_picturebox
            // 
            this.FileUplaodID_picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUplaodID_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("FileUplaodID_picturebox.Image")));
            this.FileUplaodID_picturebox.Location = new System.Drawing.Point(4, 4);
            this.FileUplaodID_picturebox.Name = "FileUplaodID_picturebox";
            this.FileUplaodID_picturebox.Size = new System.Drawing.Size(100, 134);
            this.FileUplaodID_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FileUplaodID_picturebox.TabIndex = 0;
            this.FileUplaodID_picturebox.TabStop = false;
            // 
            // FileUplaodID_button
            // 
            this.FileUplaodID_button.BackColor = System.Drawing.Color.Transparent;
            this.FileUplaodID_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUplaodID_button.FlatAppearance.BorderSize = 0;
            this.FileUplaodID_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileUplaodID_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileUplaodID_button.ForeColor = System.Drawing.Color.DarkGray;
            this.FileUplaodID_button.Image = ((System.Drawing.Image)(resources.GetObject("FileUplaodID_button.Image")));
            this.FileUplaodID_button.Location = new System.Drawing.Point(111, 4);
            this.FileUplaodID_button.Name = "FileUplaodID_button";
            this.FileUplaodID_button.Size = new System.Drawing.Size(283, 134);
            this.FileUplaodID_button.TabIndex = 1;
            this.FileUplaodID_button.Tag = "Student ID";
            this.FileUplaodID_button.Text = "Upload your ID Copy";
            this.FileUplaodID_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FileUplaodID_button.UseVisualStyleBackColor = false;
            this.FileUplaodID_button.Click += new System.EventHandler(this.FileUpload_Click);
            // 
            // FileUploadMatric_tablelayout
            // 
            this.FileUploadMatric_tablelayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FileUploadMatric_tablelayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FileUploadMatric_tablelayout.ColumnCount = 2;
            this.FileUploadMatric_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.46348F));
            this.FileUploadMatric_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.53652F));
            this.FileUploadMatric_tablelayout.Controls.Add(this.FileUploadMatric_button, 1, 0);
            this.FileUploadMatric_tablelayout.Controls.Add(this.FileUploadMatric_picturebox, 0, 0);
            this.FileUploadMatric_tablelayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUploadMatric_tablelayout.Location = new System.Drawing.Point(3, 299);
            this.FileUploadMatric_tablelayout.Name = "FileUploadMatric_tablelayout";
            this.FileUploadMatric_tablelayout.RowCount = 1;
            this.FileUploadMatric_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileUploadMatric_tablelayout.Size = new System.Drawing.Size(398, 143);
            this.FileUploadMatric_tablelayout.TabIndex = 2;
            // 
            // FileUploadMatric_button
            // 
            this.FileUploadMatric_button.BackColor = System.Drawing.Color.Transparent;
            this.FileUploadMatric_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUploadMatric_button.FlatAppearance.BorderSize = 0;
            this.FileUploadMatric_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileUploadMatric_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileUploadMatric_button.ForeColor = System.Drawing.Color.DarkGray;
            this.FileUploadMatric_button.Image = ((System.Drawing.Image)(resources.GetObject("FileUploadMatric_button.Image")));
            this.FileUploadMatric_button.Location = new System.Drawing.Point(117, 4);
            this.FileUploadMatric_button.Name = "FileUploadMatric_button";
            this.FileUploadMatric_button.Size = new System.Drawing.Size(277, 135);
            this.FileUploadMatric_button.TabIndex = 1;
            this.FileUploadMatric_button.Tag = "Matric Statement";
            this.FileUploadMatric_button.Text = "Upload Matric Statement Copy";
            this.FileUploadMatric_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FileUploadMatric_button.UseVisualStyleBackColor = false;
            this.FileUploadMatric_button.Click += new System.EventHandler(this.FileUpload_Click);
            // 
            // FileUploadMatric_picturebox
            // 
            this.FileUploadMatric_picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUploadMatric_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("FileUploadMatric_picturebox.Image")));
            this.FileUploadMatric_picturebox.Location = new System.Drawing.Point(4, 4);
            this.FileUploadMatric_picturebox.Name = "FileUploadMatric_picturebox";
            this.FileUploadMatric_picturebox.Size = new System.Drawing.Size(106, 135);
            this.FileUploadMatric_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FileUploadMatric_picturebox.TabIndex = 0;
            this.FileUploadMatric_picturebox.TabStop = false;
            // 
            // FileUploadGuardianID_tablelayout
            // 
            this.FileUploadGuardianID_tablelayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FileUploadGuardianID_tablelayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FileUploadGuardianID_tablelayout.ColumnCount = 2;
            this.FileUploadGuardianID_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.46348F));
            this.FileUploadGuardianID_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.53652F));
            this.FileUploadGuardianID_tablelayout.Controls.Add(this.FileUplaodGuardianID_button, 1, 0);
            this.FileUploadGuardianID_tablelayout.Controls.Add(this.FileUplaodGuardianID_picturebox, 0, 0);
            this.FileUploadGuardianID_tablelayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUploadGuardianID_tablelayout.Location = new System.Drawing.Point(3, 151);
            this.FileUploadGuardianID_tablelayout.Name = "FileUploadGuardianID_tablelayout";
            this.FileUploadGuardianID_tablelayout.RowCount = 1;
            this.FileUploadGuardianID_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileUploadGuardianID_tablelayout.Size = new System.Drawing.Size(398, 142);
            this.FileUploadGuardianID_tablelayout.TabIndex = 3;
            // 
            // FileUplaodGuardianID_button
            // 
            this.FileUplaodGuardianID_button.BackColor = System.Drawing.Color.Transparent;
            this.FileUplaodGuardianID_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUplaodGuardianID_button.FlatAppearance.BorderSize = 0;
            this.FileUplaodGuardianID_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileUplaodGuardianID_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileUplaodGuardianID_button.ForeColor = System.Drawing.Color.DarkGray;
            this.FileUplaodGuardianID_button.Image = ((System.Drawing.Image)(resources.GetObject("FileUplaodGuardianID_button.Image")));
            this.FileUplaodGuardianID_button.Location = new System.Drawing.Point(117, 4);
            this.FileUplaodGuardianID_button.Name = "FileUplaodGuardianID_button";
            this.FileUplaodGuardianID_button.Size = new System.Drawing.Size(277, 134);
            this.FileUplaodGuardianID_button.TabIndex = 1;
            this.FileUplaodGuardianID_button.Tag = "Guardian ID";
            this.FileUplaodGuardianID_button.Text = "Upload Guardian ID Copy";
            this.FileUplaodGuardianID_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FileUplaodGuardianID_button.UseVisualStyleBackColor = false;
            this.FileUplaodGuardianID_button.Click += new System.EventHandler(this.FileUpload_Click);
            // 
            // FileUplaodGuardianID_picturebox
            // 
            this.FileUplaodGuardianID_picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUplaodGuardianID_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("FileUplaodGuardianID_picturebox.Image")));
            this.FileUplaodGuardianID_picturebox.Location = new System.Drawing.Point(4, 4);
            this.FileUplaodGuardianID_picturebox.Name = "FileUplaodGuardianID_picturebox";
            this.FileUplaodGuardianID_picturebox.Size = new System.Drawing.Size(106, 134);
            this.FileUplaodGuardianID_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FileUplaodGuardianID_picturebox.TabIndex = 0;
            this.FileUplaodGuardianID_picturebox.TabStop = false;
            // 
            // SubjectSelection_tab
            // 
            this.SubjectSelection_tab.Controls.Add(this.SubjectSelectionFooter_panel);
            this.SubjectSelection_tab.Controls.Add(this.SubjectSelection_panel);
            this.SubjectSelection_tab.Location = new System.Drawing.Point(4, 26);
            this.SubjectSelection_tab.Name = "SubjectSelection_tab";
            this.SubjectSelection_tab.Padding = new System.Windows.Forms.Padding(3);
            this.SubjectSelection_tab.Size = new System.Drawing.Size(906, 602);
            this.SubjectSelection_tab.TabIndex = 2;
            this.SubjectSelection_tab.Text = "Subject Selection";
            this.SubjectSelection_tab.UseVisualStyleBackColor = true;
            this.SubjectSelection_tab.Enter += new System.EventHandler(this.Tab_Enter);
            this.SubjectSelection_tab.Validating += new System.ComponentModel.CancelEventHandler(this.Tab_Validating);
            // 
            // SubjectSelectionFooter_panel
            // 
            this.SubjectSelectionFooter_panel.Controls.Add(this.SSSaveAndContinue_button);
            this.SubjectSelectionFooter_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubjectSelectionFooter_panel.Location = new System.Drawing.Point(3, 507);
            this.SubjectSelectionFooter_panel.Name = "SubjectSelectionFooter_panel";
            this.SubjectSelectionFooter_panel.Size = new System.Drawing.Size(900, 92);
            this.SubjectSelectionFooter_panel.TabIndex = 27;
            // 
            // SSSaveAndContinue_button
            // 
            this.SSSaveAndContinue_button.BackColor = System.Drawing.Color.DarkOrange;
            this.SSSaveAndContinue_button.FlatAppearance.BorderSize = 0;
            this.SSSaveAndContinue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSSaveAndContinue_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSSaveAndContinue_button.ForeColor = System.Drawing.Color.White;
            this.SSSaveAndContinue_button.Location = new System.Drawing.Point(639, 36);
            this.SSSaveAndContinue_button.Name = "SSSaveAndContinue_button";
            this.SSSaveAndContinue_button.Size = new System.Drawing.Size(181, 37);
            this.SSSaveAndContinue_button.TabIndex = 0;
            this.SSSaveAndContinue_button.Text = "SAVE AND CONTINUE";
            this.SSSaveAndContinue_button.UseVisualStyleBackColor = false;
            this.SSSaveAndContinue_button.Click += new System.EventHandler(this.SSSaveAndContinue_button_Click);
            // 
            // SubjectSelection_panel
            // 
            this.SubjectSelection_panel.Controls.Add(this.SubjectSelection_flowlayout);
            this.SubjectSelection_panel.Controls.Add(this.SubjectDetailsTitle_label);
            this.SubjectSelection_panel.Location = new System.Drawing.Point(29, 6);
            this.SubjectSelection_panel.Name = "SubjectSelection_panel";
            this.SubjectSelection_panel.Size = new System.Drawing.Size(841, 495);
            this.SubjectSelection_panel.TabIndex = 26;
            // 
            // SubjectSelection_flowlayout
            // 
            this.SubjectSelection_flowlayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectSelection_flowlayout.AutoScroll = true;
            this.SubjectSelection_flowlayout.Location = new System.Drawing.Point(3, 48);
            this.SubjectSelection_flowlayout.Name = "SubjectSelection_flowlayout";
            this.SubjectSelection_flowlayout.Size = new System.Drawing.Size(835, 444);
            this.SubjectSelection_flowlayout.TabIndex = 26;
            // 
            // SubjectDetailsTitle_label
            // 
            this.SubjectDetailsTitle_label.AutoSize = true;
            this.SubjectDetailsTitle_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectDetailsTitle_label.ForeColor = System.Drawing.Color.DimGray;
            this.SubjectDetailsTitle_label.Location = new System.Drawing.Point(335, 11);
            this.SubjectDetailsTitle_label.Name = "SubjectDetailsTitle_label";
            this.SubjectDetailsTitle_label.Size = new System.Drawing.Size(156, 25);
            this.SubjectDetailsTitle_label.TabIndex = 25;
            this.SubjectDetailsTitle_label.Text = "Choose Subjects";
            // 
            // PaymentPlan_tab
            // 
            this.PaymentPlan_tab.Controls.Add(this.PaymentPlanFooter_panel);
            this.PaymentPlan_tab.Controls.Add(this.PaymentPlan_panel);
            this.PaymentPlan_tab.Location = new System.Drawing.Point(4, 26);
            this.PaymentPlan_tab.Name = "PaymentPlan_tab";
            this.PaymentPlan_tab.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentPlan_tab.Size = new System.Drawing.Size(906, 602);
            this.PaymentPlan_tab.TabIndex = 3;
            this.PaymentPlan_tab.Text = "Payment Plan";
            this.PaymentPlan_tab.UseVisualStyleBackColor = true;
            this.PaymentPlan_tab.Enter += new System.EventHandler(this.PaymentPlan_tab_Enter);
            // 
            // PaymentPlanFooter_panel
            // 
            this.PaymentPlanFooter_panel.Controls.Add(this.PPSaveAndContinue_button);
            this.PaymentPlanFooter_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentPlanFooter_panel.Location = new System.Drawing.Point(3, 507);
            this.PaymentPlanFooter_panel.Name = "PaymentPlanFooter_panel";
            this.PaymentPlanFooter_panel.Size = new System.Drawing.Size(900, 92);
            this.PaymentPlanFooter_panel.TabIndex = 28;
            // 
            // PPSaveAndContinue_button
            // 
            this.PPSaveAndContinue_button.BackColor = System.Drawing.Color.DarkOrange;
            this.PPSaveAndContinue_button.FlatAppearance.BorderSize = 0;
            this.PPSaveAndContinue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PPSaveAndContinue_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPSaveAndContinue_button.ForeColor = System.Drawing.Color.White;
            this.PPSaveAndContinue_button.Location = new System.Drawing.Point(639, 36);
            this.PPSaveAndContinue_button.Name = "PPSaveAndContinue_button";
            this.PPSaveAndContinue_button.Size = new System.Drawing.Size(181, 37);
            this.PPSaveAndContinue_button.TabIndex = 0;
            this.PPSaveAndContinue_button.Text = "SAVE AND CONTINUE";
            this.PPSaveAndContinue_button.UseVisualStyleBackColor = false;
            this.PPSaveAndContinue_button.Click += new System.EventHandler(this.PPSaveAndContinue_button_Click);
            // 
            // PaymentPlan_panel
            // 
            this.PaymentPlan_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PaymentPlan_panel.Controls.Add(this.PaymentPlan_flowlayout);
            this.PaymentPlan_panel.Controls.Add(this.PaymentPlanTitle_label);
            this.PaymentPlan_panel.Location = new System.Drawing.Point(48, 6);
            this.PaymentPlan_panel.Name = "PaymentPlan_panel";
            this.PaymentPlan_panel.Size = new System.Drawing.Size(820, 482);
            this.PaymentPlan_panel.TabIndex = 27;
            // 
            // PaymentPlan_flowlayout
            // 
            this.PaymentPlan_flowlayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaymentPlan_flowlayout.Location = new System.Drawing.Point(41, 81);
            this.PaymentPlan_flowlayout.Name = "PaymentPlan_flowlayout";
            this.PaymentPlan_flowlayout.Size = new System.Drawing.Size(695, 319);
            this.PaymentPlan_flowlayout.TabIndex = 27;
            // 
            // PaymentPlanTitle_label
            // 
            this.PaymentPlanTitle_label.AutoSize = true;
            this.PaymentPlanTitle_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPlanTitle_label.ForeColor = System.Drawing.Color.DimGray;
            this.PaymentPlanTitle_label.Location = new System.Drawing.Point(277, 12);
            this.PaymentPlanTitle_label.Name = "PaymentPlanTitle_label";
            this.PaymentPlanTitle_label.Size = new System.Drawing.Size(204, 25);
            this.PaymentPlanTitle_label.TabIndex = 26;
            this.PaymentPlanTitle_label.Text = "Choose Payment Plan";
            // 
            // Payment_tab
            // 
            this.Payment_tab.Controls.Add(this.PaymentFooter_panel);
            this.Payment_tab.Controls.Add(this.Payment_panel);
            this.Payment_tab.Location = new System.Drawing.Point(4, 26);
            this.Payment_tab.Name = "Payment_tab";
            this.Payment_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Payment_tab.Size = new System.Drawing.Size(906, 602);
            this.Payment_tab.TabIndex = 4;
            this.Payment_tab.Tag = "BankingDetails_groupbox";
            this.Payment_tab.Text = "Payment";
            this.Payment_tab.UseVisualStyleBackColor = true;
            this.Payment_tab.Enter += new System.EventHandler(this.Payment_tab_Enter);
            this.Payment_tab.Validating += new System.ComponentModel.CancelEventHandler(this.Tab_Validating);
            // 
            // PaymentFooter_panel
            // 
            this.PaymentFooter_panel.Controls.Add(this.Register_button);
            this.PaymentFooter_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentFooter_panel.Location = new System.Drawing.Point(3, 507);
            this.PaymentFooter_panel.Name = "PaymentFooter_panel";
            this.PaymentFooter_panel.Size = new System.Drawing.Size(900, 92);
            this.PaymentFooter_panel.TabIndex = 10;
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.DarkOrange;
            this.Register_button.FlatAppearance.BorderSize = 0;
            this.Register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.ForeColor = System.Drawing.Color.White;
            this.Register_button.Location = new System.Drawing.Point(639, 36);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(181, 37);
            this.Register_button.TabIndex = 0;
            this.Register_button.Tag = "BankingDetails_groupbox";
            this.Register_button.Text = "REGISTER";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Payment_panel
            // 
            this.Payment_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Payment_panel.Controls.Add(this.PaymentTitle_label);
            this.Payment_panel.Controls.Add(this.BankingDetails_groupbox);
            this.Payment_panel.Location = new System.Drawing.Point(65, 6);
            this.Payment_panel.Name = "Payment_panel";
            this.Payment_panel.Size = new System.Drawing.Size(766, 497);
            this.Payment_panel.TabIndex = 0;
            // 
            // PaymentTitle_label
            // 
            this.PaymentTitle_label.AutoSize = true;
            this.PaymentTitle_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTitle_label.ForeColor = System.Drawing.Color.DimGray;
            this.PaymentTitle_label.Location = new System.Drawing.Point(266, 9);
            this.PaymentTitle_label.Name = "PaymentTitle_label";
            this.PaymentTitle_label.Size = new System.Drawing.Size(202, 25);
            this.PaymentTitle_label.TabIndex = 30;
            this.PaymentTitle_label.Text = "Enter Banking Details";
            // 
            // BankingDetails_groupbox
            // 
            this.BankingDetails_groupbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BankingDetails_groupbox.Controls.Add(this.ExDateContainer_panel);
            this.BankingDetails_groupbox.Controls.Add(this.PaymentDue_panel);
            this.BankingDetails_groupbox.Controls.Add(this.CVVorCVC_control);
            this.BankingDetails_groupbox.Controls.Add(this.CardNumber_control);
            this.BankingDetails_groupbox.Controls.Add(this.CardholderName_control);
            this.BankingDetails_groupbox.Controls.Add(this.BankName_control);
            this.BankingDetails_groupbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankingDetails_groupbox.Location = new System.Drawing.Point(205, 45);
            this.BankingDetails_groupbox.Name = "BankingDetails_groupbox";
            this.BankingDetails_groupbox.Size = new System.Drawing.Size(356, 431);
            this.BankingDetails_groupbox.TabIndex = 29;
            this.BankingDetails_groupbox.TabStop = false;
            this.BankingDetails_groupbox.Text = "Banking Detals";
            this.BankingDetails_groupbox.Validating += new System.ComponentModel.CancelEventHandler(this.Tab_Validating);
            // 
            // ExDateContainer_panel
            // 
            this.ExDateContainer_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExDateContainer_panel.Controls.Add(this.ExpiryDate_label);
            this.ExDateContainer_panel.Controls.Add(this.ExDate_panel);
            this.ExDateContainer_panel.Location = new System.Drawing.Point(10, 246);
            this.ExDateContainer_panel.Name = "ExDateContainer_panel";
            this.ExDateContainer_panel.Size = new System.Drawing.Size(171, 73);
            this.ExDateContainer_panel.TabIndex = 6;
            // 
            // ExpiryDate_label
            // 
            this.ExpiryDate_label.AutoSize = true;
            this.ExpiryDate_label.ForeColor = System.Drawing.Color.Gray;
            this.ExpiryDate_label.Location = new System.Drawing.Point(3, 0);
            this.ExpiryDate_label.Name = "ExpiryDate_label";
            this.ExpiryDate_label.Size = new System.Drawing.Size(78, 17);
            this.ExpiryDate_label.TabIndex = 21;
            this.ExpiryDate_label.Text = "Expiry Date";
            // 
            // ExDate_panel
            // 
            this.ExDate_panel.Controls.Add(this.label3);
            this.ExDate_panel.Controls.Add(this.label4);
            this.ExDate_panel.Controls.Add(this.panel3);
            this.ExDate_panel.Controls.Add(this.ExpMonth_combobox);
            this.ExDate_panel.Controls.Add(this.ExpYear_combobox);
            this.ExDate_panel.Location = new System.Drawing.Point(7, 20);
            this.ExDate_panel.Name = "ExDate_panel";
            this.ExDate_panel.Size = new System.Drawing.Size(158, 50);
            this.ExDate_panel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(92, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(16, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 3);
            this.panel3.TabIndex = 17;
            // 
            // ExpMonth_combobox
            // 
            this.ExpMonth_combobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExpMonth_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpMonth_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpMonth_combobox.FormatString = "N0";
            this.ExpMonth_combobox.FormattingEnabled = true;
            this.ExpMonth_combobox.Location = new System.Drawing.Point(83, 19);
            this.ExpMonth_combobox.Name = "ExpMonth_combobox";
            this.ExpMonth_combobox.Size = new System.Drawing.Size(74, 25);
            this.ExpMonth_combobox.TabIndex = 2;
            this.ExpMonth_combobox.TabStop = false;
            this.ExpMonth_combobox.Tag = "WinInputControl";
            // 
            // ExpYear_combobox
            // 
            this.ExpYear_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.ExpYear_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpYear_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpYear_combobox.FormatString = "N0";
            this.ExpYear_combobox.FormattingEnabled = true;
            this.ExpYear_combobox.Location = new System.Drawing.Point(3, 20);
            this.ExpYear_combobox.Name = "ExpYear_combobox";
            this.ExpYear_combobox.Size = new System.Drawing.Size(74, 25);
            this.ExpYear_combobox.TabIndex = 1;
            this.ExpYear_combobox.TabStop = false;
            this.ExpYear_combobox.Tag = "WinInputControl";
            // 
            // PaymentDue_panel
            // 
            this.PaymentDue_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaymentDue_panel.Controls.Add(this.AmountNotice_label);
            this.PaymentDue_panel.Controls.Add(this.PaymentDue_tablelayout);
            this.PaymentDue_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentDue_panel.ForeColor = System.Drawing.Color.DarkOrange;
            this.PaymentDue_panel.Location = new System.Drawing.Point(3, 366);
            this.PaymentDue_panel.Name = "PaymentDue_panel";
            this.PaymentDue_panel.Size = new System.Drawing.Size(350, 62);
            this.PaymentDue_panel.TabIndex = 5;
            // 
            // AmountNotice_label
            // 
            this.AmountNotice_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountNotice_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountNotice_label.ForeColor = System.Drawing.Color.DarkGray;
            this.AmountNotice_label.Location = new System.Drawing.Point(3, 46);
            this.AmountNotice_label.Name = "AmountNotice_label";
            this.AmountNotice_label.Size = new System.Drawing.Size(344, 13);
            this.AmountNotice_label.TabIndex = 1;
            this.AmountNotice_label.Text = "Note: The amount include R500.00* Registration fee";
            this.AmountNotice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentDue_tablelayout
            // 
            this.PaymentDue_tablelayout.ColumnCount = 2;
            this.PaymentDue_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.PaymentDue_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.PaymentDue_tablelayout.Controls.Add(this.PaymentDueAmount_label, 1, 0);
            this.PaymentDue_tablelayout.Controls.Add(this.PaymentDue_label, 0, 0);
            this.PaymentDue_tablelayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentDue_tablelayout.Location = new System.Drawing.Point(0, 0);
            this.PaymentDue_tablelayout.Name = "PaymentDue_tablelayout";
            this.PaymentDue_tablelayout.RowCount = 1;
            this.PaymentDue_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PaymentDue_tablelayout.Size = new System.Drawing.Size(350, 43);
            this.PaymentDue_tablelayout.TabIndex = 0;
            // 
            // PaymentDueAmount_label
            // 
            this.PaymentDueAmount_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaymentDueAmount_label.AutoSize = true;
            this.PaymentDueAmount_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentDueAmount_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDueAmount_label.Location = new System.Drawing.Point(150, 11);
            this.PaymentDueAmount_label.Name = "PaymentDueAmount_label";
            this.PaymentDueAmount_label.Size = new System.Drawing.Size(191, 21);
            this.PaymentDueAmount_label.TabIndex = 1;
            this.PaymentDueAmount_label.Text = "[Payment Due Amount]";
            this.PaymentDueAmount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentDue_label
            // 
            this.PaymentDue_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaymentDue_label.AutoSize = true;
            this.PaymentDue_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentDue_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDue_label.Location = new System.Drawing.Point(3, 11);
            this.PaymentDue_label.Name = "PaymentDue_label";
            this.PaymentDue_label.Size = new System.Drawing.Size(117, 21);
            this.PaymentDue_label.TabIndex = 0;
            this.PaymentDue_label.Text = "Payment Due:";
            this.PaymentDue_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CVVorCVC_control
            // 
            this.CVVorCVC_control.AutoSize = true;
            this.CVVorCVC_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVorCVC_control.InputHasError = false;
            this.CVVorCVC_control.InputLabel = "cvc/cvv";
            this.CVVorCVC_control.InputMax = 3;
            this.CVVorCVC_control.InputMin = 3;
            this.CVVorCVC_control.InputText = "cvc/cvv";
            this.CVVorCVC_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Number;
            this.CVVorCVC_control.Location = new System.Drawing.Point(187, 259);
            this.CVVorCVC_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CVVorCVC_control.Name = "CVVorCVC_control";
            this.CVVorCVC_control.Size = new System.Drawing.Size(163, 63);
            this.CVVorCVC_control.TabIndex = 4;
            this.CVVorCVC_control.Tag = "CustomInputControl";
            this.CVVorCVC_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Payment_InputFieldError);
            // 
            // CardNumber_control
            // 
            this.CardNumber_control.AutoSize = true;
            this.CardNumber_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber_control.InputHasError = false;
            this.CardNumber_control.InputLabel = "Card Number";
            this.CardNumber_control.InputMax = 16;
            this.CardNumber_control.InputMin = 16;
            this.CardNumber_control.InputText = "Card Number";
            this.CardNumber_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Number;
            this.CardNumber_control.Location = new System.Drawing.Point(10, 181);
            this.CardNumber_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CardNumber_control.Name = "CardNumber_control";
            this.CardNumber_control.Size = new System.Drawing.Size(344, 63);
            this.CardNumber_control.TabIndex = 2;
            this.CardNumber_control.Tag = "CustomInputControl";
            this.CardNumber_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Payment_InputFieldError);
            // 
            // CardholderName_control
            // 
            this.CardholderName_control.AutoSize = true;
            this.CardholderName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardholderName_control.InputHasError = false;
            this.CardholderName_control.InputLabel = "Cardholder Name";
            this.CardholderName_control.InputMax = 64;
            this.CardholderName_control.InputMin = 3;
            this.CardholderName_control.InputText = "Cardholder Name";
            this.CardholderName_control.Location = new System.Drawing.Point(6, 110);
            this.CardholderName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CardholderName_control.Name = "CardholderName_control";
            this.CardholderName_control.Size = new System.Drawing.Size(344, 63);
            this.CardholderName_control.TabIndex = 1;
            this.CardholderName_control.Tag = "CustomInputControl";
            this.CardholderName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Payment_InputFieldError);
            // 
            // BankName_control
            // 
            this.BankName_control.AutoSize = true;
            this.BankName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankName_control.InputHasError = false;
            this.BankName_control.InputLabel = "Bank Name";
            this.BankName_control.InputMax = 32;
            this.BankName_control.InputMin = 3;
            this.BankName_control.InputText = "Bank Name";
            this.BankName_control.Location = new System.Drawing.Point(6, 39);
            this.BankName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BankName_control.Name = "BankName_control";
            this.BankName_control.Size = new System.Drawing.Size(344, 63);
            this.BankName_control.TabIndex = 0;
            this.BankName_control.Tag = "CustomInputControl";
            this.BankName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.Payment_InputFieldError);
            // 
            // Confirmation_tab
            // 
            this.Confirmation_tab.Controls.Add(this.Done_button);
            this.Confirmation_tab.Controls.Add(this.ConfirmationTitle_label);
            this.Confirmation_tab.Controls.Add(this.ConfirmationContainer_tablelayout);
            this.Confirmation_tab.Location = new System.Drawing.Point(4, 26);
            this.Confirmation_tab.Name = "Confirmation_tab";
            this.Confirmation_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Confirmation_tab.Size = new System.Drawing.Size(906, 602);
            this.Confirmation_tab.TabIndex = 5;
            this.Confirmation_tab.Text = "Confirmation";
            this.Confirmation_tab.UseVisualStyleBackColor = true;
            this.Confirmation_tab.Enter += new System.EventHandler(this.Confirmation_tab_Enter);
            // 
            // Done_button
            // 
            this.Done_button.BackColor = System.Drawing.Color.DarkOrange;
            this.Done_button.FlatAppearance.BorderSize = 0;
            this.Done_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_button.ForeColor = System.Drawing.Color.White;
            this.Done_button.Location = new System.Drawing.Point(717, 9);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(181, 37);
            this.Done_button.TabIndex = 28;
            this.Done_button.Tag = "";
            this.Done_button.Text = "DONE";
            this.Done_button.UseVisualStyleBackColor = false;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // ConfirmationTitle_label
            // 
            this.ConfirmationTitle_label.AutoSize = true;
            this.ConfirmationTitle_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmationTitle_label.ForeColor = System.Drawing.Color.DimGray;
            this.ConfirmationTitle_label.Location = new System.Drawing.Point(320, 13);
            this.ConfirmationTitle_label.Name = "ConfirmationTitle_label";
            this.ConfirmationTitle_label.Size = new System.Drawing.Size(268, 25);
            this.ConfirmationTitle_label.TabIndex = 27;
            this.ConfirmationTitle_label.Text = "Confirmation of Registration";
            // 
            // ConfirmationContainer_tablelayout
            // 
            this.ConfirmationContainer_tablelayout.ColumnCount = 2;
            this.ConfirmationContainer_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78022F));
            this.ConfirmationContainer_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21978F));
            this.ConfirmationContainer_tablelayout.Controls.Add(this.ConfirmationRegisteredSubjects_flowlayout, 0, 0);
            this.ConfirmationContainer_tablelayout.Controls.Add(this.DetailedConfirmation_tablelayout, 1, 0);
            this.ConfirmationContainer_tablelayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfirmationContainer_tablelayout.Location = new System.Drawing.Point(3, 47);
            this.ConfirmationContainer_tablelayout.Name = "ConfirmationContainer_tablelayout";
            this.ConfirmationContainer_tablelayout.RowCount = 1;
            this.ConfirmationContainer_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ConfirmationContainer_tablelayout.Size = new System.Drawing.Size(900, 552);
            this.ConfirmationContainer_tablelayout.TabIndex = 1;
            // 
            // ConfirmationRegisteredSubjects_flowlayout
            // 
            this.ConfirmationRegisteredSubjects_flowlayout.AutoScroll = true;
            this.ConfirmationRegisteredSubjects_flowlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfirmationRegisteredSubjects_flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConfirmationRegisteredSubjects_flowlayout.Location = new System.Drawing.Point(3, 3);
            this.ConfirmationRegisteredSubjects_flowlayout.Name = "ConfirmationRegisteredSubjects_flowlayout";
            this.ConfirmationRegisteredSubjects_flowlayout.Size = new System.Drawing.Size(442, 546);
            this.ConfirmationRegisteredSubjects_flowlayout.TabIndex = 0;
            this.ConfirmationRegisteredSubjects_flowlayout.WrapContents = false;
            // 
            // DetailedConfirmation_tablelayout
            // 
            this.DetailedConfirmation_tablelayout.ColumnCount = 1;
            this.DetailedConfirmation_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailedConfirmation_tablelayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailedConfirmation_tablelayout.Location = new System.Drawing.Point(451, 3);
            this.DetailedConfirmation_tablelayout.Name = "DetailedConfirmation_tablelayout";
            this.DetailedConfirmation_tablelayout.RowCount = 4;
            this.DetailedConfirmation_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.53465F));
            this.DetailedConfirmation_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.46535F));
            this.DetailedConfirmation_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.DetailedConfirmation_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.DetailedConfirmation_tablelayout.Size = new System.Drawing.Size(446, 546);
            this.DetailedConfirmation_tablelayout.TabIndex = 1;
            // 
            // RegError_errorprovider
            // 
            this.RegError_errorprovider.ContainerControl = this;
            // 
            // Nav_panel
            // 
            this.Nav_panel.BackColor = System.Drawing.Color.DarkOrange;
            this.Nav_panel.Controls.Add(this.FormTitle_label);
            this.Nav_panel.Controls.Add(this.FormClose_button);
            this.Nav_panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Nav_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nav_panel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nav_panel.Location = new System.Drawing.Point(0, 0);
            this.Nav_panel.Name = "Nav_panel";
            this.Nav_panel.Size = new System.Drawing.Size(914, 30);
            this.Nav_panel.TabIndex = 1;
            this.Nav_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nav_panel_MouseDown);
            this.Nav_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nav_panel_MouseMove);
            this.Nav_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Nav_panel_MouseUp);
            // 
            // FormTitle_label
            // 
            this.FormTitle_label.AutoSize = true;
            this.FormTitle_label.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle_label.ForeColor = System.Drawing.Color.White;
            this.FormTitle_label.Location = new System.Drawing.Point(3, 4);
            this.FormTitle_label.Name = "FormTitle_label";
            this.FormTitle_label.Size = new System.Drawing.Size(147, 20);
            this.FormTitle_label.TabIndex = 4;
            this.FormTitle_label.Text = "Registration Portal";
            // 
            // FormClose_button
            // 
            this.FormClose_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormClose_button.BackColor = System.Drawing.Color.Transparent;
            this.FormClose_button.CausesValidation = false;
            this.FormClose_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormClose_button.FlatAppearance.BorderSize = 0;
            this.FormClose_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormClose_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormClose_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormClose_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormClose_button.ForeColor = System.Drawing.Color.Red;
            this.FormClose_button.Location = new System.Drawing.Point(879, 3);
            this.FormClose_button.Name = "FormClose_button";
            this.FormClose_button.Size = new System.Drawing.Size(32, 23);
            this.FormClose_button.TabIndex = 4;
            this.FormClose_button.Text = "❌";
            this.FormClose_button.UseVisualStyleBackColor = false;
            this.FormClose_button.Click += new System.EventHandler(this.FormClose_button_Click);
            this.FormClose_button.MouseEnter += new System.EventHandler(this.FormClose_button_MouseEnter);
            this.FormClose_button.MouseLeave += new System.EventHandler(this.FormClose_button_MouseLeave);
            // 
            // RegistrationPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(914, 659);
            this.Controls.Add(this.Nav_panel);
            this.Controls.Add(this.SubjectsRegistration_tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationPortalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectRegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.SubjectRegistrationForm_Load);
            this.SubjectsRegistration_tabs.ResumeLayout(false);
            this.PersonalDetails_tabs.ResumeLayout(false);
            this.PersonalDetailsFooter_panel.ResumeLayout(false);
            this.PersonalDetails_panel.ResumeLayout(false);
            this.PersonalDetails_panel.PerformLayout();
            this.PersonalDetailsForm_groupbox.ResumeLayout(false);
            this.PersonalDetailsForm_groupbox.PerformLayout();
            this.GenderContainer_panel.ResumeLayout(false);
            this.GenderField_panel.ResumeLayout(false);
            this.GenderField_panel.PerformLayout();
            this.DoBContainer_panel.ResumeLayout(false);
            this.DoBContainer_panel.PerformLayout();
            this.DateContainer_panel.ResumeLayout(false);
            this.DateContainer_panel.PerformLayout();
            this.GuardianDetails_tab.ResumeLayout(false);
            this.GuardianDetailsFooter_panel.ResumeLayout(false);
            this.GuardianDetailsForm_panel.ResumeLayout(false);
            this.GuardianDetailsForm_panel.PerformLayout();
            this.GuardianDetailsForm_groupbox.ResumeLayout(false);
            this.GuardianDetailsForm_groupbox.PerformLayout();
            this.SupportingDocuments_tab.ResumeLayout(false);
            this.SupportDocumentsFooter_panel.ResumeLayout(false);
            this.SupportDocuments_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileUploadPreview_adobe)).EndInit();
            this.SupportDocuments_tablelayout.ResumeLayout(false);
            this.FileUploadID_tablelayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileUplaodID_picturebox)).EndInit();
            this.FileUploadMatric_tablelayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileUploadMatric_picturebox)).EndInit();
            this.FileUploadGuardianID_tablelayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileUplaodGuardianID_picturebox)).EndInit();
            this.SubjectSelection_tab.ResumeLayout(false);
            this.SubjectSelectionFooter_panel.ResumeLayout(false);
            this.SubjectSelection_panel.ResumeLayout(false);
            this.SubjectSelection_panel.PerformLayout();
            this.PaymentPlan_tab.ResumeLayout(false);
            this.PaymentPlanFooter_panel.ResumeLayout(false);
            this.PaymentPlan_panel.ResumeLayout(false);
            this.PaymentPlan_panel.PerformLayout();
            this.Payment_tab.ResumeLayout(false);
            this.PaymentFooter_panel.ResumeLayout(false);
            this.Payment_panel.ResumeLayout(false);
            this.Payment_panel.PerformLayout();
            this.BankingDetails_groupbox.ResumeLayout(false);
            this.BankingDetails_groupbox.PerformLayout();
            this.ExDateContainer_panel.ResumeLayout(false);
            this.ExDateContainer_panel.PerformLayout();
            this.ExDate_panel.ResumeLayout(false);
            this.ExDate_panel.PerformLayout();
            this.PaymentDue_panel.ResumeLayout(false);
            this.PaymentDue_tablelayout.ResumeLayout(false);
            this.PaymentDue_tablelayout.PerformLayout();
            this.Confirmation_tab.ResumeLayout(false);
            this.Confirmation_tab.PerformLayout();
            this.ConfirmationContainer_tablelayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegError_errorprovider)).EndInit();
            this.Nav_panel.ResumeLayout(false);
            this.Nav_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SubjectsRegistration_tabs;
        private System.Windows.Forms.TabPage PersonalDetails_tabs;
        private System.Windows.Forms.TabPage GuardianDetails_tab;
        private System.Windows.Forms.TabPage SubjectSelection_tab;
        private System.Windows.Forms.TabPage PaymentPlan_tab;
        private System.Windows.Forms.TabPage Payment_tab;
        private System.Windows.Forms.TabPage Confirmation_tab;
        private System.Windows.Forms.Label PersonDetailsTitle_label;
        private System.Windows.Forms.Panel PersonalDetails_panel;
        private System.Windows.Forms.Panel GuardianDetailsForm_panel;
        private System.Windows.Forms.TableLayoutPanel ConfirmationContainer_tablelayout;
        private System.Windows.Forms.FlowLayoutPanel ConfirmationRegisteredSubjects_flowlayout;
        private System.Windows.Forms.TableLayoutPanel DetailedConfirmation_tablelayout;
        private System.Windows.Forms.Label GuardianDetailsTitle_label;
        private System.Windows.Forms.Label SubjectDetailsTitle_label;
        private System.Windows.Forms.Label PaymentPlanTitle_label;
        private System.Windows.Forms.Label ConfirmationTitle_label;
        private System.Windows.Forms.Panel SubjectSelection_panel;
        private System.Windows.Forms.FlowLayoutPanel SubjectSelection_flowlayout;
        private System.Windows.Forms.Panel PaymentPlan_panel;
        private System.Windows.Forms.FlowLayoutPanel PaymentPlan_flowlayout;
        private System.Windows.Forms.Panel Payment_panel;
        private System.Windows.Forms.Label PaymentTitle_label;
        private System.Windows.Forms.GroupBox BankingDetails_groupbox;
        private System.Windows.Forms.Panel PaymentDue_panel;
        private System.Windows.Forms.Label AmountNotice_label;
        private System.Windows.Forms.TableLayoutPanel PaymentDue_tablelayout;
        private System.Windows.Forms.Label PaymentDueAmount_label;
        private System.Windows.Forms.Label PaymentDue_label;
        private UcInputField CVVorCVC_control;
        private UcInputField CardNumber_control;
        private UcInputField CardholderName_control;
        private UcInputField BankName_control;
        private System.Windows.Forms.GroupBox PersonalDetailsForm_groupbox;
        private System.Windows.Forms.Panel GenderContainer_panel;
        private System.Windows.Forms.Panel GenderField_panel;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.ComboBox Gender_combobox;
        private System.Windows.Forms.Panel GenderBottom_panel;
        private System.Windows.Forms.Panel DoBContainer_panel;
        private System.Windows.Forms.Label DoB_label;
        private System.Windows.Forms.Panel DateContainer_panel;
        private System.Windows.Forms.Label Day_label;
        private System.Windows.Forms.Label Month_label;
        private System.Windows.Forms.Label Year_label;
        private System.Windows.Forms.ComboBox DoBDay_combobox;
        private System.Windows.Forms.Panel DoBBottom_panel;
        private System.Windows.Forms.ComboBox DoBMonth_combobox;
        private System.Windows.Forms.ComboBox DoBYear_combobox;
        private UcInputField PhoneNumber_control;
        private UcInputField PersonalDetailsIDorPassportNumber_control;
        private UcInputField EmailAddress_control;
        private UcInputField LastName_control;
        private UcInputField FirstName_control;
        private System.Windows.Forms.Label HomeAddress_label;
        private UcInputField ZipOrPostalCode_control;
        private UcInputField Suburb_control;
        private UcInputField CityOrTown_control;
        private UcInputField Address_control;
        private System.Windows.Forms.GroupBox GuardianDetailsForm_groupbox;
        private System.Windows.Forms.Label PersonalDetails_label;
        private System.Windows.Forms.Label GHomeAddress_label;
        private UcInputField GuardianZipOrPostalCode_control;
        private UcInputField GuardianSuburb_control;
        private UcInputField GuardianCityOrTown_control;
        private UcInputField GuardianAddress_control;
        private UcInputField GuardianPhoneNumber_control;
        private UcInputField GuardianIDorPassportNumber_control;
        private UcInputField GuardianLastName_control;
        private UcInputField GuardianFirstName_control;
        private System.Windows.Forms.Panel PersonalDetailsFooter_panel;
        private System.Windows.Forms.Button PDSaveAndContinue_button;
        private System.Windows.Forms.Panel GuardianDetailsFooter_panel;
        private System.Windows.Forms.Button GDSaveAndContinue_button;
        private System.Windows.Forms.Panel SubjectSelectionFooter_panel;
        private System.Windows.Forms.Button SSSaveAndContinue_button;
        private System.Windows.Forms.Panel PaymentPlanFooter_panel;
        private System.Windows.Forms.Button PPSaveAndContinue_button;
        private System.Windows.Forms.Panel PaymentFooter_panel;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.ErrorProvider RegError_errorprovider;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Panel Nav_panel;
        private System.Windows.Forms.Label FormTitle_label;
        private System.Windows.Forms.Button FormClose_button;
        private System.Windows.Forms.TabPage SupportingDocuments_tab;
        private System.Windows.Forms.Panel SupportDocumentsFooter_panel;
        private System.Windows.Forms.Button SDSaveAndContinue_button;
        private System.Windows.Forms.Panel SupportDocuments_panel;
        private System.Windows.Forms.TableLayoutPanel SupportDocuments_tablelayout;
        private System.Windows.Forms.Button FileUplaodGuardianID_button;
        private System.Windows.Forms.PictureBox FileUplaodGuardianID_picturebox;
        private System.Windows.Forms.Button FileUploadMatric_button;
        private System.Windows.Forms.PictureBox FileUploadMatric_picturebox;
        private System.Windows.Forms.Button FileUplaodID_button;
        private System.Windows.Forms.PictureBox FileUplaodID_picturebox;
        private System.Windows.Forms.TableLayoutPanel FileUploadID_tablelayout;
        private System.Windows.Forms.TableLayoutPanel FileUploadMatric_tablelayout;
        private AxAcroPDFLib.AxAcroPDF FileUploadPreview_adobe;
        private System.Windows.Forms.TableLayoutPanel FileUploadGuardianID_tablelayout;
        private System.Windows.Forms.Panel ExDateContainer_panel;
        private System.Windows.Forms.Label ExpiryDate_label;
        private System.Windows.Forms.Panel ExDate_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ExpMonth_combobox;
        private System.Windows.Forms.ComboBox ExpYear_combobox;
    }
}