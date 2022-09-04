using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace RegistrationSystem.Classes
{
    public class Guardian
    {
        public string GuardianID;
        public string StudentID;
        public string FirstName;
        public string LastName;
        public string IDNumber;
        public string Address;
        public string PhoneNumber;

        public Guardian()
        {
            
        }

        public Guardian([CanBeNull] string guardianId, [CanBeNull] string studentId, string firstName, string lastName, string idNumber, string phoneNumber, string address)
        {
            this.StudentID = studentId;
            this.GuardianID = guardianId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.IDNumber = idNumber;
            this.Address = address;
        }
    }
}
