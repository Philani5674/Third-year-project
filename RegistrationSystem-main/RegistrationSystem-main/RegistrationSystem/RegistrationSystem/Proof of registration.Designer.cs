namespace RegistrationSystem
{
    partial class Proof_of_registration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proof_of_registration));
            this.label1 = new System.Windows.Forms.Label();
            this.registeredSubject_dataGridView = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDiscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group5DataSet = new RegistrationSystem.group5DataSet();
            this.Print_Button = new System.Windows.Forms.Button();
            this.printRegistration = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.registeredSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registeredSubjectTableAdapter = new RegistrationSystem.group5DataSetTableAdapters.RegisteredSubjectTableAdapter();
            this.dataTable2TableAdapter = new RegistrationSystem.group5DataSetTableAdapters.DataTable2TableAdapter();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.Print_Button1 = new System.Windows.Forms.Button();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationTableAdapter = new RegistrationSystem.group5DataSetTableAdapters.RegistrationTableAdapter();
            this.registrationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registrationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registrationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.registrationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentPlanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reasonNotApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registeredSubject_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 458);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registered Subject";
            // 
            // registeredSubject_dataGridView
            // 
            this.registeredSubject_dataGridView.AllowUserToAddRows = false;
            this.registeredSubject_dataGridView.AllowUserToDeleteRows = false;
            this.registeredSubject_dataGridView.AllowUserToOrderColumns = true;
            this.registeredSubject_dataGridView.AllowUserToResizeColumns = false;
            this.registeredSubject_dataGridView.AutoGenerateColumns = false;
            this.registeredSubject_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.registeredSubject_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.registeredSubject_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.registeredSubject_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registeredSubject_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.registeredSubject_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredSubject_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.subjectDiscriptionDataGridViewTextBoxColumn,
            this.subjectPriceDataGridViewTextBoxColumn});
            this.registeredSubject_dataGridView.DataSource = this.dataTable2BindingSource;
            this.registeredSubject_dataGridView.Location = new System.Drawing.Point(14, 489);
            this.registeredSubject_dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.registeredSubject_dataGridView.MultiSelect = false;
            this.registeredSubject_dataGridView.Name = "registeredSubject_dataGridView";
            this.registeredSubject_dataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registeredSubject_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.registeredSubject_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.registeredSubject_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.registeredSubject_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registeredSubject_dataGridView.Size = new System.Drawing.Size(503, 40);
            this.registeredSubject_dataGridView.TabIndex = 3;
            this.registeredSubject_dataGridView.TabStop = false;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            this.studentIDDataGridViewTextBoxColumn.Width = 117;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectNameDataGridViewTextBoxColumn.Width = 141;
            // 
            // subjectDiscriptionDataGridViewTextBoxColumn
            // 
            this.subjectDiscriptionDataGridViewTextBoxColumn.DataPropertyName = "SubjectDiscription";
            this.subjectDiscriptionDataGridViewTextBoxColumn.HeaderText = "SubjectDiscription";
            this.subjectDiscriptionDataGridViewTextBoxColumn.Name = "subjectDiscriptionDataGridViewTextBoxColumn";
            this.subjectDiscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectDiscriptionDataGridViewTextBoxColumn.Width = 180;
            // 
            // subjectPriceDataGridViewTextBoxColumn
            // 
            this.subjectPriceDataGridViewTextBoxColumn.DataPropertyName = "SubjectPrice";
            this.subjectPriceDataGridViewTextBoxColumn.HeaderText = "SubjectPrice";
            this.subjectPriceDataGridViewTextBoxColumn.Name = "subjectPriceDataGridViewTextBoxColumn";
            this.subjectPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectPriceDataGridViewTextBoxColumn.Width = 135;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.group5DataSet;
            // 
            // group5DataSet
            // 
            this.group5DataSet.DataSetName = "group5DataSet";
            this.group5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Print_Button
            // 
            this.Print_Button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Print_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Print_Button.Location = new System.Drawing.Point(1190, 898);
            this.Print_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(187, 57);
            this.Print_Button.TabIndex = 4;
            this.Print_Button.Text = "Print";
            this.Print_Button.UseVisualStyleBackColor = false;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // printRegistration
            // 
            this.printRegistration.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printRegistration_PrintPage);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // registeredSubjectBindingSource
            // 
            this.registeredSubjectBindingSource.DataMember = "RegisteredSubject";
            this.registeredSubjectBindingSource.DataSource = this.group5DataSet;
            // 
            // registeredSubjectTableAdapter
            // 
            this.registeredSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Image = global::RegistrationSystem.Properties.Resources.Logo_for_proof_of_registration;
            this.logo_pictureBox.Location = new System.Drawing.Point(3, 5);
            this.logo_pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(849, 186);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pictureBox.TabIndex = 1;
            this.logo_pictureBox.TabStop = false;
            this.logo_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Print_Button1
            // 
            this.Print_Button1.Location = new System.Drawing.Point(397, 715);
            this.Print_Button1.Name = "Print_Button1";
            this.Print_Button1.Size = new System.Drawing.Size(75, 33);
            this.Print_Button1.TabIndex = 5;
            this.Print_Button1.Text = "Print";
            this.Print_Button1.UseVisualStyleBackColor = true;
            this.Print_Button1.Click += new System.EventHandler(this.Print_Button1_Click);
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.group5DataSet;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // registrationBindingSource1
            // 
            this.registrationBindingSource1.DataMember = "Registration";
            this.registrationBindingSource1.DataSource = this.group5DataSet;
            // 
            // registrationBindingSource2
            // 
            this.registrationBindingSource2.DataMember = "Registration";
            this.registrationBindingSource2.DataSource = this.group5DataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registration";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn1,
            this.adminIDDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.paymentPlanIDDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn,
            this.amountPayedDataGridViewTextBoxColumn,
            this.isApprovedDataGridViewCheckBoxColumn,
            this.reasonNotApprovedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrationBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(16, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 52);
            this.dataGridView1.TabIndex = 8;
            // 
            // registrationBindingSource3
            // 
            this.registrationBindingSource3.DataMember = "Registration";
            this.registrationBindingSource3.DataSource = this.group5DataSet;
            // 
            // registrationIDDataGridViewTextBoxColumn
            // 
            this.registrationIDDataGridViewTextBoxColumn.DataPropertyName = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.HeaderText = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.Name = "registrationIDDataGridViewTextBoxColumn";
            this.registrationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "AdminID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "AdminID";
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.Width = 171;
            // 
            // paymentPlanIDDataGridViewTextBoxColumn
            // 
            this.paymentPlanIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentPlanIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentPlanID";
            this.paymentPlanIDDataGridViewTextBoxColumn.HeaderText = "PaymentPlanID";
            this.paymentPlanIDDataGridViewTextBoxColumn.Name = "paymentPlanIDDataGridViewTextBoxColumn";
            this.paymentPlanIDDataGridViewTextBoxColumn.Width = 157;
            // 
            // amountDueDataGridViewTextBoxColumn
            // 
            this.amountDueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountDueDataGridViewTextBoxColumn.DataPropertyName = "AmountDue";
            this.amountDueDataGridViewTextBoxColumn.HeaderText = "AmountDue";
            this.amountDueDataGridViewTextBoxColumn.Name = "amountDueDataGridViewTextBoxColumn";
            this.amountDueDataGridViewTextBoxColumn.Width = 129;
            // 
            // amountPayedDataGridViewTextBoxColumn
            // 
            this.amountPayedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountPayedDataGridViewTextBoxColumn.DataPropertyName = "AmountPayed";
            this.amountPayedDataGridViewTextBoxColumn.HeaderText = "AmountPayed";
            this.amountPayedDataGridViewTextBoxColumn.Name = "amountPayedDataGridViewTextBoxColumn";
            this.amountPayedDataGridViewTextBoxColumn.Width = 145;
            // 
            // isApprovedDataGridViewCheckBoxColumn
            // 
            this.isApprovedDataGridViewCheckBoxColumn.DataPropertyName = "IsApproved";
            this.isApprovedDataGridViewCheckBoxColumn.HeaderText = "IsApproved";
            this.isApprovedDataGridViewCheckBoxColumn.Name = "isApprovedDataGridViewCheckBoxColumn";
            this.isApprovedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // reasonNotApprovedDataGridViewTextBoxColumn
            // 
            this.reasonNotApprovedDataGridViewTextBoxColumn.DataPropertyName = "ReasonNotApproved";
            this.reasonNotApprovedDataGridViewTextBoxColumn.HeaderText = "ReasonNotApproved";
            this.reasonNotApprovedDataGridViewTextBoxColumn.Name = "reasonNotApprovedDataGridViewTextBoxColumn";
            this.reasonNotApprovedDataGridViewTextBoxColumn.Visible = false;
            // 
            // Proof_of_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Print_Button1);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.registeredSubject_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo_pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Proof_of_registration";
            this.Text = "Proof_of_registration";
            this.Load += new System.EventHandler(this.Proof_of_registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registeredSubject_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView registeredSubject_dataGridView;
        private System.Windows.Forms.Button Print_Button;
        private System.Drawing.Printing.PrintDocument printRegistration;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private group5DataSet group5DataSet;
        private System.Windows.Forms.BindingSource registeredSubjectBindingSource;
        private group5DataSetTableAdapters.RegisteredSubjectTableAdapter registeredSubjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDiscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private group5DataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.Button Print_Button1;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private group5DataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.BindingSource registrationBindingSource1;
        private System.Windows.Forms.BindingSource registrationBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource registrationBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentPlanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isApprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonNotApprovedDataGridViewTextBoxColumn;
    }
}