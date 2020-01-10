using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using DalApi.Interfaces;
using DO;
using DO.Models;
using DS;

namespace DalObject
{
    public class DalObject : IDal,IGuestRequestService,IHostService,IPersonService
    {
        public void AddGuestRequest(GuestRequest guestRequest)
        {
            DataSource.guestRequests.Add(Cloning.Clone(guestRequest));
        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {
            DataSource.hostingUnits.Add(Cloning.Clone(hostingUnit));
        }

        

        public void AddOrder(Order order)
        {
            DataSource.orders.Add(Cloning.Clone(order));
        }

        public void AddPerson(Person person)
        {
            DataSource.persons.Add(Cloning.Clone(person));
        }

        public List<BankBranch> GetBankBranches()
        {
            List<BankBranch> newBankBranches = new List<BankBranch>();
            foreach (var item in DataSource.bankBranches)
            {
                newBankBranches.Add(Cloning.Clone(item));
            }
            return newBankBranches;
        }

        public GuestRequest GetGuestRequest(int key)
        {
            return Cloning.Clone(DataSource.guestRequests.Find(x => x.Key == key));
        }

        public List<GuestRequest> GetGuestRequests()
        {
            List<GuestRequest> newGuestRequest = new List<GuestRequest>();
            foreach (var item in DataSource.guestRequests)
            {
                newGuestRequest.Add(Cloning.Clone(item));
            }
            return newGuestRequest;
        }

        public HostingUnit GetHostingUnit(int key)
        {
            return Cloning.Clone(DataSource.hostingUnits.Find(x => x.Key== key));
        }

        public List<HostingUnit> GetHostingUnits()
        {
            List<HostingUnit> newhostingUnits = new List<HostingUnit>();
            foreach (var item in DataSource.hostingUnits)
            {
                newhostingUnits.Add(Cloning.Clone(item));
            }
            return newhostingUnits;
        }

        //public void AddHostRequest(Host HostRequest)
        //{
        //    DataSource..Add(Cloning.Clone(HostRequest));

        //}

        //public Host GetHostRequest(int key)
        //{
        //    return Cloning.Clone(DataSource..Find(x => x.Key == key));/// need to find
        //}

        public Order GetOrder(int key)
        {
            return Cloning.Clone(DataSource.orders.Find(x => x.Key == key));
        }

        public List<Order> GetOrders()
        {
            List<Order> neworders = new List<Order>();
            foreach (var item in DataSource.orders)
            {
                neworders.Add(Cloning.Clone(item));
            }
            return neworders;
        }

        public Person GetPerson(int id)
        {
            return Cloning.Clone(DataSource.persons.Find(x => x.Id == id));
        }

        public void RemoveHostingUnit(int hostingUnitKey)
        {
            DataSource.hostingUnits.Find(x => x.Key == hostingUnitKey).isAvailable = false;
        }

        public void UpdateGuestRequest( GuestRequest guestRequest)
        {

        }

        public void UpdateGuestRequestStatus(int requestId, Status_GuestRequst requestStatus)
        {
            DataSource.guestRequests.Find(x => x.Key == requestId).Status = requestStatus;
        }

        public void UpdateHostingUnit(HostingUnit update_hostingUnit)
        {
            DataSource.hostingUnits.Remove(DataSource.hostingUnits.Find(x => x.Key == update_hostingUnit.Key));
            DataSource.hostingUnits.Add(Cloning.Clone(update_hostingUnit));
        }

        public void UpdateHostRequest(Host updateHostRequest)
        {
            throw new NotImplementedException();
        }

        public void UpdateHostRequestStatus(Host HostRequest)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(int orderKey)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
