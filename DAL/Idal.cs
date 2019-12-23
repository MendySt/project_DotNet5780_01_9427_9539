using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
     public interface Idal 
     {
        void AddGuestRequest(GuestRequest guestRequest);
        void UpdateGuestRequest(int update_GuestRequestKey);
        void AddHostingUnit(HostingUnit hostingUnit);
        void RemoveHostingUnit(int hostingUnitKey);
        void UpdateHostingUnit(HostingUnit update_hostingUnit);
        void AddOrders(Orders orders);
        void UpdateOrders(int orderKey);
        List<HostingUnit> GetHostingUnits();
        List<GuestRequest> GetGuestRequests();
        List<Orders> GetOrders();
        List<BankAccount> GetBankAccount();


    }
}
