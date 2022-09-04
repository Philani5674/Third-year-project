using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    public class Subject
    {
        public string SubjectCode;
        public string SubjectName;
        public string SubjectDescription;
        public decimal SubjectPrice;
        public Subject()
        {
            
        }

        public Subject(string code, string name, string description, decimal price)
        {
            this.SubjectCode = code;
            this.SubjectName = name;
            this.SubjectDescription = description;
            this.SubjectPrice = price;
        }
    }
}
