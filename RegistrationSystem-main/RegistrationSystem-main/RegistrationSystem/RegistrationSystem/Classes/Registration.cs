using System;

namespace RegistrationSystem.Classes
{
    public class Registration
    {
        public int RegistrationID;
        public int StudentID;
        public int PaymentPlanID;
        public int AdminID;
        public decimal AmountDue;
        public decimal AmountPayed;
        public bool IsApproved;
        public string ReasonNotApproved;
        public DateTime RegistrationDate;

        public Registration()
        {
            
        }

        // TODO: Change logic for Admin Id in registration
        public Registration(int registrationId, int studentId, int paymentPlanId, decimal amountDue, decimal amountPayed,
            string reasonNotApproved, DateTime registrationDate, int adminId = 1, bool isApproved = false)
        {
            this.RegistrationID = registrationId;
            this.StudentID = studentId;
            this.PaymentPlanID = paymentPlanId;
            this.AmountDue = amountDue;
            this.AmountPayed = amountPayed;
            this.IsApproved = isApproved;
            this.ReasonNotApproved = reasonNotApproved;
            this.RegistrationDate = registrationDate;
            this.AdminID = adminId;
        }
    }
}