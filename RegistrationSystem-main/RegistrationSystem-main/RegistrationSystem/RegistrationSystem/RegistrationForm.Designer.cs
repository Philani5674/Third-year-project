using RegistrationSystem.UserControls;

namespace RegistrationSystem
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Quote_label = new System.Windows.Forms.Label();
            this.Register_label = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.AlreadyRegistered_label = new System.Windows.Forms.Label();
            this.RegistrationForm_panel = new System.Windows.Forms.Panel();
            this.Register_errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmPassword_control = new RegistrationSystem.UserControls.UcInputField();
            this.Password_control = new RegistrationSystem.UserControls.UcInputField();
            this.EmailAddress_control = new RegistrationSystem.UserControls.UcInputField();
            this.LastName_control = new RegistrationSystem.UserControls.UcInputField();
            this.FirstName_control = new RegistrationSystem.UserControls.UcInputField();
            this.panel1.SuspendLayout();
            this.RegistrationForm_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Register_errorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quote_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 534);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "~ Nelson Mandela";
            // 
            // Quote_label
            // 
            this.Quote_label.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quote_label.ForeColor = System.Drawing.Color.White;
            this.Quote_label.Location = new System.Drawing.Point(24, 82);
            this.Quote_label.Name = "Quote_label";
            this.Quote_label.Size = new System.Drawing.Size(212, 299);
            this.Quote_label.TabIndex = 0;
            this.Quote_label.Text = "\"Education is the most powerful weapon which you can use to change the world.\"";
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_label.Location = new System.Drawing.Point(342, 9);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(154, 32);
            this.Register_label.TabIndex = 4;
            this.Register_label.Text = "Registration";
            // 
            // Close_button
            // 
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.Color.DarkRed;
            this.Close_button.Location = new System.Drawing.Point(526, 9);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(33, 29);
            this.Close_button.TabIndex = 6;
            this.Close_button.Text = "❌";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.Black;
            this.Register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_button.FlatAppearance.BorderSize = 0;
            this.Register_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.Register_button.Location = new System.Drawing.Point(270, 432);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(279, 37);
            this.Register_button.TabIndex = 9;
            this.Register_button.Text = "REGISTER";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // LogIn_button
            // 
            this.LogIn_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn_button.FlatAppearance.BorderSize = 0;
            this.LogIn_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogIn_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogIn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.LogIn_button.Location = new System.Drawing.Point(446, 486);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(50, 28);
            this.LogIn_button.TabIndex = 10;
            this.LogIn_button.Text = "Log In";
            this.LogIn_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // AlreadyRegistered_label
            // 
            this.AlreadyRegistered_label.AutoSize = true;
            this.AlreadyRegistered_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyRegistered_label.Location = new System.Drawing.Point(326, 491);
            this.AlreadyRegistered_label.Name = "AlreadyRegistered_label";
            this.AlreadyRegistered_label.Size = new System.Drawing.Size(126, 17);
            this.AlreadyRegistered_label.TabIndex = 11;
            this.AlreadyRegistered_label.Text = "Already registered? ";
            this.AlreadyRegistered_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegistrationForm_panel
            // 
            this.RegistrationForm_panel.Controls.Add(this.ConfirmPassword_control);
            this.RegistrationForm_panel.Controls.Add(this.Password_control);
            this.RegistrationForm_panel.Controls.Add(this.EmailAddress_control);
            this.RegistrationForm_panel.Controls.Add(this.LastName_control);
            this.RegistrationForm_panel.Controls.Add(this.FirstName_control);
            this.RegistrationForm_panel.Location = new System.Drawing.Point(260, 50);
            this.RegistrationForm_panel.Name = "RegistrationForm_panel";
            this.RegistrationForm_panel.Size = new System.Drawing.Size(307, 376);
            this.RegistrationForm_panel.TabIndex = 12;
            // 
            // Register_errorprovider
            // 
            this.Register_errorprovider.ContainerControl = this;
            // 
            // ConfirmPassword_control
            // 
            this.ConfirmPassword_control.AutoSize = true;
            this.ConfirmPassword_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_control.InputHasError = false;
            this.ConfirmPassword_control.InputLabel = "Confirm Password";
            this.ConfirmPassword_control.InputText = "Confirm Password";
            this.ConfirmPassword_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Secrete;
            this.ConfirmPassword_control.Location = new System.Drawing.Point(3, 288);
            this.ConfirmPassword_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPassword_control.Name = "ConfirmPassword_control";
            this.ConfirmPassword_control.Size = new System.Drawing.Size(299, 63);
            this.ConfirmPassword_control.TabIndex = 17;
            this.ConfirmPassword_control.Tag = "CustomInputControl";
            this.ConfirmPassword_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // Password_control
            // 
            this.Password_control.AutoSize = true;
            this.Password_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_control.InputHasError = false;
            this.Password_control.InputLabel = "Password";
            this.Password_control.InputText = "Password";
            this.Password_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Secrete;
            this.Password_control.Location = new System.Drawing.Point(3, 217);
            this.Password_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password_control.Name = "Password_control";
            this.Password_control.Size = new System.Drawing.Size(299, 63);
            this.Password_control.TabIndex = 16;
            this.Password_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // EmailAddress_control
            // 
            this.EmailAddress_control.AutoSize = true;
            this.EmailAddress_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress_control.InputHasError = false;
            this.EmailAddress_control.InputLabel = "Email Address";
            this.EmailAddress_control.InputText = "Email Address";
            this.EmailAddress_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Email;
            this.EmailAddress_control.Location = new System.Drawing.Point(3, 146);
            this.EmailAddress_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailAddress_control.Name = "EmailAddress_control";
            this.EmailAddress_control.Size = new System.Drawing.Size(299, 63);
            this.EmailAddress_control.TabIndex = 14;
            this.EmailAddress_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // LastName_control
            // 
            this.LastName_control.AutoSize = true;
            this.LastName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_control.InputHasError = false;
            this.LastName_control.InputLabel = "Last Name";
            this.LastName_control.InputMax = 32;
            this.LastName_control.InputMin = 3;
            this.LastName_control.InputText = "Last Name";
            this.LastName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.LastName_control.Location = new System.Drawing.Point(3, 75);
            this.LastName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastName_control.Name = "LastName_control";
            this.LastName_control.Size = new System.Drawing.Size(299, 63);
            this.LastName_control.TabIndex = 12;
            this.LastName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // FirstName_control
            // 
            this.FirstName_control.AutoSize = true;
            this.FirstName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_control.InputHasError = false;
            this.FirstName_control.InputLabel = "First Name";
            this.FirstName_control.InputMax = 32;
            this.FirstName_control.InputMin = 3;
            this.FirstName_control.InputText = "First Name";
            this.FirstName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.FirstName_control.Location = new System.Drawing.Point(3, 4);
            this.FirstName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstName_control.Name = "FirstName_control";
            this.FirstName_control.Size = new System.Drawing.Size(299, 63);
            this.FirstName_control.TabIndex = 10;
            this.FirstName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 534);
            this.Controls.Add(this.RegistrationForm_panel);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.AlreadyRegistered_label);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Register_label);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RegistrationForm_panel.ResumeLayout(false);
            this.RegistrationForm_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Register_errorprovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Label AlreadyRegistered_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quote_label;
        private UcInputField FirstName_control;
        private UcInputField LastName_control;
        private UcInputField EmailAddress_control;
        private UcInputField Password_control;
        private UcInputField ConfirmPassword_control;
        private System.Windows.Forms.Panel RegistrationForm_panel;
        private System.Windows.Forms.ErrorProvider Register_errorprovider;
    }
}