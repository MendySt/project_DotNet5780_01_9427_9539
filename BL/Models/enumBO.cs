using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    
        public enum IdType_person { ID, Passport, DriverLicence };
        public enum Status_person { Active, Inactive, Standby};
        public enum Status_GuestRequst { OPEN, EXPIRED, CANCELLED, ORDERED };
        public enum Area_GuestRequest { ALL, NORTH, SOUTH, CENTER, JERUSALEM };
        public enum Type_GuestRequest { ZIMMER, HOTEL, CAMPING, Room, Motel};
        public enum Pool_GuestRequest { YES, MAYBE, NO };
        public enum Jacuzzi_GuestRequest { YES, MAYBE, NO };
        public enum Garden_GuestRequest { YES, MAYBE, NO };
        public enum ChildrensAttractions_GuestRequest { YES, MAYBE, NO };
        public enum Status_Order { PROCESSING, MAIL_SENT, APPROVED, NO_CLIENT_RESPONSE};

    
}
