using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    public class Payment
    {
        public int PaymentID;
        public int RegistrationID;
        public string PaymentDescription;
        public decimal Amount;
        public DateTime PaymentDate;

        public Payment()
        {
            
        }

        // instance of a single payment
        public Payment(int paymentId, int registrationID, string paymentDescription, decimal amount, DateTime paymentDate)
        {
            this.PaymentID = paymentId;
            this.RegistrationID = registrationID;
            this.PaymentDescription = paymentDescription;
            this.Amount = amount;
            this.PaymentDate = paymentDate;
        }
    }
}
