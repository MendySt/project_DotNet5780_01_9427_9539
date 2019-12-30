using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
namespace DalApi
{
     public interface IDal 
     {
        void AddGuestRequest(GuestRequest guestRequest);
        void UpdateGuestRequestStatus(int update_GuestRequestKey);
        GuestRequest GetGuestRequest();
        void UpdateGuestRequest(GuestRequest updateGuestRequest);
        void AddHostingUnit(HostingUnit hostingUnit);
        void RemoveHostingUnit(int hostingUnitKey);
        void UpdateHostingUnit(HostingUnit update_hostingUnit);
        HostingUnit GetHostingUnit();
        Order GetOrder();
        void AddOrder(Order order);

        //public delegate bool Predicate<T>(T obj);

        void UpdateOrder(int orderKey);
        List<HostingUnit> GetHostingUnits();
        List<GuestRequest> GetGuestRequests();
        List<Order> GetOrders();
        List<BankBranch> GetBankAccount();
        void AddPerson(Person person);
        Person GetPerson();
        void UpdatePerson(Person update_Person);





    }
}
