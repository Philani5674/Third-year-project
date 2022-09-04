using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    public class Teacher
    {
        public string TeacherID;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public string Gender;
        public string Qualification;

        public Teacher()
        {
            
        }
        public Teacher(string qualification, string teacherId, string firstName, string lastName, string emailAddress, string gender)
        {
            this.TeacherID = teacherId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.Gender = gender;
            this.Qualification = qualification;
        }
    }
}
