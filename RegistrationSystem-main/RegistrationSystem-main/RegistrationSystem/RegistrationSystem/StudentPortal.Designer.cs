namespace RegistrationSystem
{
    partial class StudentPortal
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentPortal_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.RegisteredSubjectsContainer_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisteredSubjects_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentPortal_tablelayout.SuspendLayout();
            this.RegisteredSubjectsContainer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Portal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StudentPortal_tablelayout
            // 
            this.StudentPortal_tablelayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentPortal_tablelayout.ColumnCount = 2;
            this.StudentPortal_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.StudentPortal_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.StudentPortal_tablelayout.Controls.Add(this.RegisteredSubjectsContainer_panel, 1, 0);
            this.StudentPortal_tablelayout.Location = new System.Drawing.Point(28, 48);
            this.StudentPortal_tablelayout.Name = "StudentPortal_tablelayout";
            this.StudentPortal_tablelayout.RowCount = 1;
            this.StudentPortal_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StudentPortal_tablelayout.Size = new System.Drawing.Size(932, 571);
            this.StudentPortal_tablelayout.TabIndex = 1;
            // 
            // RegisteredSubjectsContainer_panel
            // 
            this.RegisteredSubjectsContainer_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisteredSubjectsContainer_panel.Controls.Add(this.label2);
            this.RegisteredSubjectsContainer_panel.Controls.Add(this.RegisteredSubjects_flowlayout);
            this.RegisteredSubjectsContainer_panel.Location = new System.Drawing.Point(417, 3);
            this.RegisteredSubjectsContainer_panel.Name = "RegisteredSubjectsContainer_panel";
            this.RegisteredSubjectsContainer_panel.Size = new System.Drawing.Size(512, 565);
            this.RegisteredSubjectsContainer_panel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registered Subjects";
            // 
            // RegisteredSubjects_flowlayout
            // 
            this.RegisteredSubjects_flowlayout.AutoScroll = true;
            this.RegisteredSubjects_flowlayout.Location = new System.Drawing.Point(11, 21);
            this.RegisteredSubjects_flowlayout.Name = "RegisteredSubjects_flowlayout";
            this.RegisteredSubjects_flowlayout.Size = new System.Drawing.Size(489, 532);
            this.RegisteredSubjects_flowlayout.TabIndex = 3;
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 631);
            this.Controls.Add(this.StudentPortal_tablelayout);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StudentPortal_tablelayout.ResumeLayout(false);
            this.RegisteredSubjectsContainer_panel.ResumeLayout(false);
            this.RegisteredSubjectsContainer_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel StudentPortal_tablelayout;
        private System.Windows.Forms.Panel RegisteredSubjectsContainer_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel RegisteredSubjects_flowlayout;
    }
}