using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    public class Account
    {
        public int AccountID;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public Account()
        {

        }
        public Account(int accountID, string firstName, string lastName, string emailAddress)
        {
            this.AccountID = accountID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
        }
    }
}
