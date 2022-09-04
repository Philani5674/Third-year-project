using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Net;
using System.Net.Mail;

namespace RegistrationSystem
{
    public partial class Proof_of_registration : Form
    {
        int Id;
        public Proof_of_registration()
        {
            Id = Registration_Administrator.id;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printRegistration_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreview.Document = printRegistration;
            printPreview.PrintPreviewControl.Zoom = 1;
            printPreview.ShowDialog();
            Print_Button.Visible = false;
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

           
        }

        private void Proof_of_registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group5DataSet.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.group5DataSet.Registration);
            int studentId = 1;
            // TODO: This line of code loads data into the 'group5DataSet.RegisteredSubject' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.group5DataSet.DataTable2,Id);
            Print_Button1.Focus();
        }

        private void Print_Button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreview.Document = printRegistration;
            printPreview.PrintPreviewControl.Zoom = 1;
            printPreview.ShowDialog();
            Print_Button.Visible = false;

            Registration_Administrator o = new Registration_Administrator();
            o.ShowDialog();
        }

    }
}