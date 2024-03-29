﻿using RegistrationSystem.UserControls;

namespace RegistrationSystem
{
    partial class LoginForm
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
            this.LogIn_label = new System.Windows.Forms.Label();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NotRegisteredYet_label = new System.Windows.Forms.Label();
            this.RegisterNow_button = new System.Windows.Forms.Button();
            this.Password_control = new RegistrationSystem.UserControls.UcInputField();
            this.EmailAddress_control = new RegistrationSystem.UserControls.UcInputField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogIn_label
            // 
            this.LogIn_label.AutoSize = true;
            this.LogIn_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_label.ForeColor = System.Drawing.Color.White;
            this.LogIn_label.Location = new System.Drawing.Point(131, 12);
            this.LogIn_label.Name = "LogIn_label";
            this.LogIn_label.Size = new System.Drawing.Size(87, 32);
            this.LogIn_label.TabIndex = 2;
            this.LogIn_label.Text = "Log In";
            // 
            // LogIn_button
            // 
            this.LogIn_button.BackColor = System.Drawing.Color.Black;
            this.LogIn_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn_button.FlatAppearance.BorderSize = 0;
            this.LogIn_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.LogIn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.LogIn_button.Location = new System.Drawing.Point(22, 279);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(305, 37);
            this.LogIn_button.TabIndex = 4;
            this.LogIn_button.Text = "LOG IN";
            this.LogIn_button.UseVisualStyleBackColor = false;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.Color.DarkRed;
            this.Close_button.Location = new System.Drawing.Point(305, 12);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(33, 29);
            this.Close_button.TabIndex = 5;
            this.Close_button.Text = "❌";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Controls.Add(this.LogIn_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 81);
            this.panel1.TabIndex = 6;
            // 
            // NotRegisteredYet_label
            // 
            this.NotRegisteredYet_label.AutoSize = true;
            this.NotRegisteredYet_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotRegisteredYet_label.Location = new System.Drawing.Point(65, 336);
            this.NotRegisteredYet_label.Name = "NotRegisteredYet_label";
            this.NotRegisteredYet_label.Size = new System.Drawing.Size(128, 17);
            this.NotRegisteredYet_label.TabIndex = 7;
            this.NotRegisteredYet_label.Text = "Not Registered yet? ";
            this.NotRegisteredYet_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegisterNow_button
            // 
            this.RegisterNow_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterNow_button.FlatAppearance.BorderSize = 0;
            this.RegisterNow_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RegisterNow_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RegisterNow_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterNow_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNow_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.RegisterNow_button.Location = new System.Drawing.Point(184, 331);
            this.RegisterNow_button.Name = "RegisterNow_button";
            this.RegisterNow_button.Size = new System.Drawing.Size(95, 29);
            this.RegisterNow_button.TabIndex = 6;
            this.RegisterNow_button.Text = "Register Now";
            this.RegisterNow_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterNow_button.UseVisualStyleBackColor = true;
            this.RegisterNow_button.Click += new System.EventHandler(this.RegisterNow_button_Click);
            // 
            // Password_control
            // 
            this.Password_control.AutoSize = true;
            this.Password_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_control.InputHasError = false;
            this.Password_control.InputLabel = "Passoword";
            this.Password_control.InputText = "Passoword";
            this.Password_control.Location = new System.Drawing.Point(12, 192);
            this.Password_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password_control.Name = "Password_control";
            this.Password_control.Size = new System.Drawing.Size(326, 67);
            this.Password_control.TabIndex = 3;
            // 
            // EmailAddress_control
            // 
            this.EmailAddress_control.AutoSize = true;
            this.EmailAddress_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress_control.InputHasError = false;
            this.EmailAddress_control.InputLabel = "Email Address";
            this.EmailAddress_control.InputText = "Email Address";
            this.EmailAddress_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Email;
            this.EmailAddress_control.Location = new System.Drawing.Point(12, 117);
            this.EmailAddress_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailAddress_control.Name = "EmailAddress_control";
            this.EmailAddress_control.Size = new System.Drawing.Size(326, 67);
            this.EmailAddress_control.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(348, 412);
            this.Controls.Add(this.RegisterNow_button);
            this.Controls.Add(this.NotRegisteredYet_label);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.Password_control);
            this.Controls.Add(this.EmailAddress_control);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcInputField EmailAddress_control;
        private System.Windows.Forms.Label LogIn_label;
        private UcInputField Password_control;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NotRegisteredYet_label;
        private System.Windows.Forms.Button RegisterNow_button;
    }
}