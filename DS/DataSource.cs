using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DO.Models;

namespace DS
{
    public static class DataSource
    {
        public static List<GuestRequest> guestRequests;
        public static List<HostingUnit> hostingUnits;
        public static List<Order> orders;
        public static List<Person> persons;
        public static List<Host> hosts;
        public static List<BankBranch> bankBranches;
        static DataSource()
        {
            GuestRequest guestRequest = new GuestRequest();
            guestRequest.ClientId = 12345678;
            //guestRequest.Area = Area_GuestRequest;
            guestRequests = new List<GuestRequest>();
            hostingUnits = null;
            orders = null;
            persons = null;
            hosts = null;
            bankBranches = null;
        }
    }
}
