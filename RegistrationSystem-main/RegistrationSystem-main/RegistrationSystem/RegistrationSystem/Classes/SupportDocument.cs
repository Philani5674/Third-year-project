using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.Classes
{
    
    public class SupportDocument
    {
        public int SupportDocumentId;
        public string FileName;
        public bool IsVerified;
        public byte[] File;


        public SupportDocument()
        {
            //
        }

        public SupportDocument(string fileName, byte[] file, bool isVerified=false, int supportDocumentId = 0)
        {
            this.SupportDocumentId = supportDocumentId;
            this.FileName = fileName;
            this.IsVerified = isVerified;
            this.File = file;
        }
    }
}
