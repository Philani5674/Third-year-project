using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    public class Admin
    {
        public string AdminID;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public string PhoneNumber;

        public Admin()
        {
            
        }

        public Admin(string adminId, string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            this.AdminID = adminId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
        }
    }
}
