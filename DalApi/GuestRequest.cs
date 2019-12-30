using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class GuestRequest
    {
        private int guestRequestKey;
        public int GuestRequestKey{ get; set; }
        private string privateName;
        public string PrivateName { get; set; }
        private string familyName;
        public string FamilyName { get; set; }
        private string mailAddress;
        public string MailAddress { get; set; }
        private bool status;
        public bool Status { get; set; }
        private DateTime registrationDate;
        public DateTime RegistrationDate { get; set; }
        private DateTime entryDate;
        public DateTime EntryDate { get; set; }
        private DateTime releaseDate;
        public DateTime ReleaseDate { get; set; }
        private string area;
        public string Area { get; set; }
        private string subArea;
        public string SubArea { get; set; }
        private string type;
        private string Type { get; set; }

    }
}
