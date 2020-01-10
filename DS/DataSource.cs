using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DO.Models;

namespace DS
{
    static class DataSource
    {
        static List<GuestRequest> guestRequests;
        static List<HostingUnit> hostingUnits;
        static List<Order> orders;
        static List<Person> persons;
        static List<Host> hosts;
        static List<BankBranch> bankBranches;
        static DataSource()
        {
            GuestRequest guestRequest = new GuestRequest();
            guestRequest.ClientId = 12345678;
            guestRequest.Area = Area_GuestRequest;
            guestRequests = new List<GuestRequest>();
            hostingUnits = null;
            orders = null;
            persons = null;
            hosts = null;
            bankBranches = null;
        }
    }
}
