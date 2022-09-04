using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class Registration_Administrator : Form
    {
       public static int id;
        public Registration_Administrator()
        {
            id = int.Parse(documents_dataGridView.CurrentRow.Cells[4].Value.ToString());
            InitializeComponent();
        }

        private void Registration_Administrator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group5DataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.group5DataSet.Subject);
            // TODO: This line of code loads data into the 'group5DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.group5DataSet1.DataTable1);
            // TODO: This line of code loads data into the 'group5DataSet.RegisteredSubject' table. You can move, or remove it, as needed.
            timer1.Enabled = true;

            ///////////////////////////....................................................................................
            //Rounded picturebox
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, Profile_pictureBox.Width - 3, Profile_pictureBox.Height - 3);
            Region rg = new Region(gp);
            Profile_pictureBox.Region = rg;
            profile2_pictureBox.Region = rg;
            StudentDetails_DataGridview.CurrentCell = null;
            Logo2pictureBox.Region = rg;

            //Load the details of the chart
            //


            // TODO: This line of code loads data into the 'group5DataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.group5DataSet.DataTable1);
            // TODO: This line of code loads data into the 'group5DataSet.SupportingDocument' table. You can move, or remove it, as needed.
            this.supportingDocumentTableAdapter.Fill(this.group5DataSet.SupportingDocument, 1); // i will fill with the varible later. dankiee san

        }



       
   

        
        // This method clears the form inputs if the user wants to start afresh to insert the details
        //
        //
        //
        //
      
       
        // go back to manage sudents from manage subjects
        private void BackTobutton_Click(object sender, EventArgs e)
        {
            Admin_Tabcontrol.SelectedIndex = 0;
        }
     
    

        private void label5_Click(object sender, EventArgs e)
        {

        }
        // this textbox will search the subject the admin want to update the information about
        private void SearchToUpdate_textBox_TextChanged(object sender, EventArgs e)
        {
            //Some code to serch the subject in the database
        }
        // this will enable the admin to update the visibility of the subject or delete the subject... but the system will jist archive the subject
        // or set the isavailale feild to false
      

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void manage_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Document3Name_label_Click(object sender, EventArgs e)
        {

        }

        private void DeclineDocument_button_Click(object sender, EventArgs e)
        {
            DocumentsReader.LoadFile("");
            manage_tabControl.SelectedIndex = 1;
           
        }

        private void Accept_Document_Button_Click(object sender, EventArgs e)
        {
            //foreach ()
            //{ }

        }

        private void Payment_button_Click(object sender, EventArgs e)
        {

        }

        private void Document3_button_Click(object sender, EventArgs e)
        {

        }

        private void Names_Label_Click(object sender, EventArgs e)
        {

        }
        //this event will search the documents of the students and display them in the controls for verification.....
        private void Text_Chacked_Label_event(object sender, EventArgs e)
        {

        }

  

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //...............................................................................................................................................................
        //...................................................................................................................................................................
        //This event insert student details to the student portal
        //.......................................................................................................................................................................... 
        private void StudentDetails_DataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            }

        private void Profile_pictureBox_Click(object sender, EventArgs e)
        {
           
        }

        private void Done_button_Click(object sender, EventArgs e)
        {

            manage_tabControl.SelectedIndex = 2;
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }
        //    ..........................................................................................................................................
        /*
        //////////////////////////////////////llll
        llllllllllllllllllllllllllllllllllllll
        
        */
        private void StudentDetails_DataGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            Proof_of_registration p = new Proof_of_registration();
            p.ShowDialog();
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {

            if ( Next_Button.Text !=null)
            {
                Admin_Tabcontrol.SelectedIndex = 3;
                Proof_of_registration p = new Proof_of_registration( );
                p.ShowDialog();
            }
        }

        private void non_Registered_Click(object sender, EventArgs e)
        {

        }
       /*88888888888888888888888888888888888888888888888888888888888888888
        8888888888888888888888888888888888888888888888888888888888888888*/
        private void StudentDetails_DataGridview_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (StudentDetails_DataGridview.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Names_Label.Text = StudentDetails_DataGridview.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + StudentDetails_DataGridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Done_button.Enabled = true;
                    Rdate.Text = StudentDetails_DataGridview.Rows[e.RowIndex].Cells[2].Value.ToString();

                    if ((bool)StudentDetails_DataGridview.Rows[e.RowIndex].Cells[3].Value)
                    {
                        
                        Status_Label.Text = "Verified";
                        Status_Label.ForeColor = Color.Green;                          
                        Reason_Label.Text = "None";
                    }
                    else
                    {
                        Status_Label.Text = "Not Verified";
                        Reason_Label.Text = StudentDetails_DataGridview.Rows[e.RowIndex].Cells[4].Value.ToString();

                    }

                }
                else
                {
                    

                }
  registeredSubjectTableAdapter.FillBy(group5DataSet.RegisteredSubject, (int.Parse(StudentDetails_DataGridview.Rows[e.RowIndex].Cells[6].Value.ToString())));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void viewselectedDoc_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {try
            {
                var original = Statistics.Series.Add(F_LABEL.Text);
                var modified = Statistics.Series.Add(B_LABEL.Text);
                var l = Statistics.Series.Add(C_LABEL.Text);
                var m = Statistics.Series.Add(label7.Text);
                Statistics.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                Statistics.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                Statistics.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                Statistics.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

                original.Points.AddXY(F_LABEL.Text, (int.Parse(Registered.Text)));
                modified.Points.AddXY(B_LABEL.Text, int.Parse(non_Registered.Text));
                l.Points.AddXY(F_LABEL.Text, int.Parse(Verified.Text));
                m.Points.AddXY(B_LABEL.Text, int.Parse(Uverified.Text));
            }
            catch
            {


            }
        }

        private void SearchByName_Textbox_TextChanged(object sender, EventArgs e)
        {
          try
            {
                this.subjectTableAdapter.FillBy(this.group5DataSet.Subject, SearchByName_Textbox.Text);
            }
            catch
            {

            }
        }

        private void searchProductsDtagridview_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (NewPrice_TextBox.Text == "0")
            {

                NewPrice_TextBox.Focus();
                  NewPrice_TextBox.BorderStyle = BorderStyle.Fixed3D;
                NewPrice_TextBox.BackColor = Color.Blue;
                
                }
            else
            {
                try {
                    decimal r=decimal.Parse(NewPrice_TextBox.Text);
                    this.subjectTableAdapter.UpdateQuery(this.group5DataSet.Subject, searchProductsDtagridview.CurrentRow.Cells[0].Value.ToString(), r);
                    NewPrice_TextBox.Clear();
                    LastPrice_TextBox.Clear();
                    ;  
                  
                }
                catch
                {


                }

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(Uverified.Text) > 0)
            {
                manage_tabControl.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("There are no Unverified student details");
            }

        }

        private void searchProductsDtagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(searchProductsDtagridview.CurrentRow.Index != -1)
            {
                SubjectName_TextBox.Text += searchProductsDtagridview.CurrentRow.Cells[2].Value.ToString()+" Price";
                LastPrice_TextBox.Text = searchProductsDtagridview.CurrentRow.Cells[4].Value.ToString();

            }
        }
    }
    }

