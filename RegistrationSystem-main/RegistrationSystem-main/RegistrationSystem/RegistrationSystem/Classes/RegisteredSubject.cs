using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    public class RegisteredSubject
    {
        public string StudentID;
        public string SubjectCode;
        public string MatricMark;
        public string UpgradeMark;

        // used for frontend display only not reflected on the db
        public decimal  SubjectPrice;
        public string SubjectName;
        public string SubjectDescription;

        public RegisteredSubject()
        {
            
        }
        public RegisteredSubject(
            string studentId, 
            string subjectCode,  
            string matricMark, 
            decimal subjectPrice,
            string subjectName,
            string subjectDescription,
            string upgradeMark = "0")
        {
            this.StudentID = studentId;
            this.SubjectCode = subjectCode;
            this.MatricMark = matricMark;
            this.UpgradeMark = upgradeMark;
            // not in the Db
            this.SubjectPrice = subjectPrice;
            this.SubjectName = subjectName;
        }
    }
}
