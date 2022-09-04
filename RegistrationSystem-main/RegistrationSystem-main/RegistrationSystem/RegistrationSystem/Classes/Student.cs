using System;

namespace RegistrationSystem.Classes
{
    public class Student
    {
        public int StudentID;
        public string IDNumber;
        public DateTime DateOfBirth;
        public string Address;
        public string PhoneNumber;
        public string Gender;
        public Account Account;
        public Student()
        {
            Account = new Account();
        }



        public Student(int accountId, string firstName, string lastName, string emailAddress, string phoneNumber, string idNumber,
            DateTime dateOfBirth, string gender, string address, int studentId = 0)
        {
            this.Account = new Account(accountID: accountId, firstName: firstName, lastName: lastName,
                emailAddress: emailAddress);
            this.StudentID = studentId;
            this.PhoneNumber = phoneNumber;
            this.IDNumber = idNumber;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
        }
    }
}
