using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    public class BankDetails
    {
        public int StudentId;
        public int BankDetailsId;
        public string BankName;
        public string CardHolder;
        public string CardNumber;
        public DateTime ExpiryDate;
        public string Cvc;

        public BankDetails()
        {
            
        }

        public BankDetails(int studentId, int bankDetailsId, string bankName, string cardHolder, string cardNumber, DateTime expiryDate, string cvc)
        {
            this.StudentId = studentId;
            this.BankName = bankName;
            this.BankDetailsId = bankDetailsId;
            this.CardHolder = cardHolder;
            this.CardNumber = cardNumber;
            this.ExpiryDate = expiryDate;
            this.Cvc = cvc;
        }
    }
}
