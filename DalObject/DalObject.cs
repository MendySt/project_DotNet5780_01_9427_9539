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
using Dal;

namespace DalObject
{
    public class DalObject : IDal, IGuestRequestService, IHostService, IPersonService, IHosingUnitService, IOrderService, IBankBranchService
    {
        public int AddGuestRequest(GuestRequest guestRequest)
        {
            DataSource.guestRequests.Add(Cloning.Clone(guestRequest));
            return ++Configuration.GuestRequestKey;
        }

        public int  AddHost(Host host)
        {
            DataSource.hosts.Add(Cloning.Clone(host));
            return ++Configuration.HostKey;
        }

        public int  AddHostingUnit(HostingUnit hostingUnit)
        {
            DataSource.hostingUnits.Add(Cloning.Clone(hostingUnit));
            return ++Configuration.HostingUnitKey;
        }

        public int  AddOrder(Order order)
        {
            DataSource.orders.Add(Cloning.Clone(order));
            return ++Configuration.OrderKey;
        }

        public int  AddPerson(Person person)
        {
            if (DataSource.persons.Any(x => x.Id != person.Id))// check we dont have any two with same ID 
            {
                DataSource.persons.Add(Cloning.Clone(person));
                return ++Configuration.PersonKey;
            }
            return 10;//exception error
        }
        public void DeleteHost(int id)
        {
            DataSource.hosts.Find(x => x.Id == id).IsAvailable = false;
        }

        public List<BankBranch> GetBankBranches()
        {
            List<BankBranch> newBankBranches = new List<BankBranch>();
            newBankBranches.Add(new BankBranch
            {
                BankNUmber = 1,
                BankName = "mendy",
                BranchNumber = 1,
                BranchAdress = "habal shem tov 1",
                BranchCity = "kfar chabad"
            });
            newBankBranches.Add(new BankBranch
            {
                BankNUmber = 2,
                BankName = "asi",
                BranchNumber = 2,
                BranchAdress = "habal shem tov 2",
                BranchCity = "kfar chabad"
            });
            newBankBranches.Add(new BankBranch
            {
                BankNUmber = 3,
                BankName = "weis",
                BranchNumber = 3,
                BranchAdress = "habal shem tov 3",
                BranchCity = "kfar chabad"
            });
            newBankBranches.Add(new BankBranch
            {
                BankNUmber = 4,
                BankName = "mendel",
                BranchNumber = 4,
                BranchAdress = "habal shem tov 4",
                BranchCity = "kfar chabad"
            });
            newBankBranches.Add(new BankBranch
            {
                BankNUmber = 5,
                BankName = "mendel",
                BranchNumber = 5,
                BranchAdress = "habal shem tov 5",
                BranchCity = "kfar chabad"
            });
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

        public Host GetHost(int id)
        {
            return Cloning.Clone(DataSource.hosts.Find(x => x.Id == id));
        }

        public HostingUnit GetHostingUnit(int key)
        {
            return Cloning.Clone(DataSource.hostingUnits.Find(x => x.Key == key));
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
      
        public Person GetPerson(int id)
        {
            return Cloning.Clone(DataSource.persons.Find(x => x.Id == id));
        }

        public void RemoveHostingUnit(int hostingUnitKey)
        {
            DataSource.hostingUnits.Find(x => x.Key == hostingUnitKey).IsAvailable = false;
        }

        public void UpdateGuestRequest(GuestRequest guestRequest)
        {
            DataSource.guestRequests.Remove(DataSource.guestRequests.Find(x => x.Key == guestRequest.Key));
            DataSource.guestRequests.Add(Cloning.Clone(guestRequest));

        }

        public void UpdateGuestRequestStatus(int requestId, Status_GuestRequst requestStatus)
        {
            DataSource.guestRequests.Find(x => x.Key == requestId).Status = requestStatus;
        }

        public void UpdateHost(Host host)
        {
            DataSource.hosts.Remove(DataSource.hosts.Find(x => x.Id == host.Id));
            DataSource.hosts.Add(Cloning.Clone(host));
        }

        public void UpdatePerson(Person person)
        {
            DataSource.persons.Remove(DataSource.persons.Find(x => x.Id == person.Id));
            DataSource.persons.Add(Cloning.Clone(person));
        }

        public void UpdateHostingUnit(HostingUnit update_hostingUnit)
        {
            DataSource.hostingUnits.Remove(DataSource.hostingUnits.Find(x => x.Key == update_hostingUnit.Key));
            DataSource.hostingUnits.Add(Cloning.Clone(update_hostingUnit));
        }

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

        public void UpdateOrderStatus(int key, Status_Order status_Order)
        {
            DataSource.orders.Find(x => x.Key == key).Status = status_Order;
        }

    }

}
