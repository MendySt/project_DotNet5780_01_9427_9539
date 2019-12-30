using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
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
            guestRequest.FamilyName = null;
            guestRequests =new List<GuestRequest>();
            guestRequests.Add(guestRequest);
         hostingUnits=null;
         orders=null;
         persons=null;
         hosts = null;
         bankBranches = null;
        }
    }
}
