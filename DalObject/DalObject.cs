using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using DO;
using DS;

namespace DalObject
{
    public class DalObject : IDal
    {
        void IDal.AddGuestRequest(GuestRequest guestRequest)
        {
           DataSource.guestRequests.Add(Cloning.Clone(newGuestRequest));
        }
       
        void IDal.AddHostingUnit(HostingUnit hostingUnit)
        {
            DataSource.hostingUnit.Add(Cloning.Clone(newHostingUnit));
        }

        void IDal.AddOrder(Order order)
        {
            DataSource.Order.Add(Cloning.Clone(newOrder));
        }

        void IDal.AddPerson(Person person)
        {
            DataSource.Person.Add(Cloning.Clone(newPerson));
        }

        List<BankBranch> IDal.GetBankAccount()
        {

        }

        GuestRequest IDal.GetGuestRequest()
        {
            throw new NotImplementedException();
        }

        List<GuestRequest> IDal.GetGuestRequests()
        {
            throw new NotImplementedException();
        }

        HostingUnit IDal.GetHostingUnit()
        {
            throw new NotImplementedException();
        }

        List<HostingUnit> IDal.GetHostingUnits()
        {
            throw new NotImplementedException();
        }

        Order IDal.GetOrder()
        {
            throw new NotImplementedException();
        }

        List<Order> IDal.GetOrders()
        {
            throw new NotImplementedException();
        }

        Person IDal.GetPerson()
        {
            throw new NotImplementedException();
        }

        void IDal.RemoveHostingUnit(int hostingUnitKey)
        {
            throw new NotImplementedException();
        }

        void IDal.UpdateGuestRequest(GuestRequest updateGuestRequest)
        {
            throw new NotImplementedException();
        }

        void IDal.UpdateGuestRequestStatus(int update_GuestRequestKey)
        {
            throw new NotImplementedException();
        }

        void IDal.UpdateHostingUnit(HostingUnit update_hostingUnit)
        {
            throw new NotImplementedException();
        }

        void IDal.UpdateOrder(int orderKey)
        {
            throw new NotImplementedException();
        }

        void IDal.UpdatePerson(Person update_Person)
        {
            throw new NotImplementedException();
        }
    }
}
