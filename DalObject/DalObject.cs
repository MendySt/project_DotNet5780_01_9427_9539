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
    internal class DalObject : IDal, IGuestRequestService, IHostService, IPersonService, IHosingUnitService, IOrderService, IBankBranchService
    {
        private DalObject()
        {

        }
        public DalObject dalObject { get; } = new DalObject();

        public void AddGuestRequest(GuestRequest guestRequest)
        {
            if (DataSource.guestRequests.Count != 0 && DataSource.guestRequests.Exists(item => item.Key == guestRequest.Key))
            {
                // זריקת חריגה
            }

            guestRequest.Key = Configuration.GuestRequestKey;
            DataSource.guestRequests.Add(Cloning.Clone(guestRequest));
        }

        public void AddHost(Host host)
        {
            if (DataSource.hosts.Count != 0 && DataSource.hosts.Exists(item => item.Id == host.Id))
            {
                // זריקת חריגה
            }

            host.Id = Configuration.HostId;
            DataSource.hosts.Add(Cloning.Clone(host));
        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {
            if (DataSource.hostingUnits.Count != 0 && DataSource.hostingUnits.Exists(item => item.HostingUnitName == hostingUnit.HostingUnitName))
            {
                // זריקת חריגה
            }

            hostingUnit.Key = Configuration.HostingUnitKey;
            DataSource.hostingUnits.Add(Cloning.Clone(hostingUnit));
        }

        public void AddOrder(Order order)
        {
            if (DataSource.orders.Count != 0 && DataSource.orders.Exists(item => item.Key == order.Key))
            {
                // זריקת חריגה
            }
            order.Key = Configuration.OrderKey;
            DataSource.orders.Add(Cloning.Clone(order));
        }

        public void AddPerson(Person person)
        {
            if (DataSource.persons.Exists(x => x.Id == person.Id))// check we dont have any two with same ID 
            {
                // זריקת חריגה
            }

            person.Id = Configuration.PersonID;
            DataSource.persons.Add(Cloning.Clone(person));
        }
        public void DeleteHost(int id)
        {
            DataSource.hosts.Find(x => x.Id == id).IsAvailable = false;
        }

        public List<BankBranch> GetBankBranches()
        {
            List<BankBranch> newBankBranches = new List<BankBranch>()
            {
                new BankBranch()
                {
                    BankNUmber = 1,
                    BankName = "mendy",
                    BranchNumber = 1,
                    BranchAdress = "habal shem tov 1",
                    BranchCity = "kfar chabad"
                },
                new BankBranch()
                {
                    BankNUmber = 2,
                    BankName = "asi",
                    BranchNumber = 2,
                    BranchAdress = "habal shem tov 2",
                    BranchCity = "kfar chabad",
                },
                new BankBranch()
                {
                    BankNUmber = 3,
                    BankName = "weis",
                    BranchNumber = 3,
                    BranchAdress = "habal shem tov 3",
                    BranchCity = "kfar chabad"
                },
                new BankBranch()
                {
                    BankNUmber = 4,
                    BankName = "mendel",
                    BranchNumber = 4,
                    BranchAdress = "habal shem tov 4",
                    BranchCity = "kfar chabad"
                },
                new BankBranch()
                {
                    BankNUmber = 5,
                    BankName = "mendel",
                    BranchNumber = 5,
                    BranchAdress = "habal shem tov 5",
                    BranchCity = "kfar chabad"
                }
            };

            return (from item in newBankBranches
                    select item.Clone()).ToList();
        }

        public GuestRequest GetGuestRequest(int key)
        {
            return Cloning.Clone(DataSource.guestRequests.Find(x => x.Key == key));
        }

        public List<GuestRequest> GetGuestRequests()
        {
            return (from gr in DataSource.guestRequests select Cloning.Clone(gr)).ToList();
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
            return (from hu in DataSource.hostingUnits select Cloning.Clone(hu)).ToList();
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
            return (from go in DataSource.orders select Cloning.Clone(go)).ToList();
        }

        public void UpdateOrderStatus(int key, Status_Order status_Order)
        {
            DataSource.orders.Find(x => x.Key == key).Status = status_Order;
        }

    }

}
