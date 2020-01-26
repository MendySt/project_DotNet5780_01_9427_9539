using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class Configuration
    {
        private static int personID = 20000000;
        private static int orderKey = 20000000;
        private static int hostingUnitKey = 20000000;
        private static int hostId = 20000000;
        private static int guestRequestKey = 20000000;


        public static int PersonID => personID++;
        public static int OrderKey => orderKey++;
        public static int HostingUnitKey => hostingUnitKey++;
        public static int HostId => hostId++;
        public static int GuestRequestKey => guestRequestKey++;




    }
}
