﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DO.Models;

namespace DalApi
//public delegate bool Predicate<T>(T obj);
// check the get and add

{
    public interface IDal 
     {
        
        void AddHostingUnit(HostingUnit hostingUnit);
        void RemoveHostingUnit(int hostingUnitKey);
        void UpdateHostingUnit(HostingUnit update_hostingUnit);
        HostingUnit GetHostingUnit(int key);
        Order GetOrder(int key);
        void AddOrder(Order order);

        //public delegate bool Predicate<T>(T obj);

        void UpdateOrder(int orderKey);
        List<HostingUnit> GetHostingUnits();
        List<GuestRequest> GetGuestRequests();
        List<Order> GetOrders();
        List<BankBranch> GetBankBranches();
        
        
    }
}
