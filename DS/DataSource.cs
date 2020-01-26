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
            guestRequests = new List<GuestRequest>()
            {
                new GuestRequest()
                {
                  Key = ,
                  ClientId = ,
                  Status = ,
                  Adults = ,
                  Children = ,
                  CreateDate = ,
                  EntryDate = ,
                  LeaveDate = ,
                  Area = ,
                  Type = ,
                  Pool = ,
                  Jacuzzi = ,
                  Garden = ,
                  ChildrensAttractions = ,
                },
                new GuestRequest()
                {
                  Key = ,
                  ClientId = ,
                  Status = ,
                  Adults = ,
                  Children = ,
                  CreateDate = ,
                  EntryDate = ,
                  LeaveDate = ,
                  Area = ,
                  Type = ,
                  Pool = ,
                  Jacuzzi = ,
                  Garden = ,
                  ChildrensAttractions = ,
                },
                new GuestRequest()
                {
                  Key = ,
                  ClientId = ,
                  Status = ,
                  Adults = ,
                  Children = ,
                  CreateDate = ,
                  EntryDate = ,
                  LeaveDate = ,
                  Area = ,
                  Type = ,
                  Pool = ,
                  Jacuzzi = ,
                  Garden = ,
                  ChildrensAttractions = ,
                },
            }; // לאתחל ערכים

            hostingUnits = new List<HostingUnit>()
            {
                new HostingUnit()
                {
                    Key = ,
                    Owner = ,
                    HostingUnitName = ,
                    Diary = ,
                    Pool = ,
                    Jacuzzi = ,
                    Garden = ,
                    ChildrensAttractions = ,
                    IsAvailable = ,
                },
                new HostingUnit()
                {
                    Key = ,
                    Owner = ,
                    HostingUnitName = ,
                    Diary = ,
                    Pool = ,
                    Jacuzzi = ,
                    Garden = ,
                    ChildrensAttractions = ,
                    IsAvailable = ,
                },
                new HostingUnit()
                {
                    Key = ,
                    Owner = ,
                    HostingUnitName = ,
                    Diary = ,
                    Pool = ,
                    Jacuzzi = ,
                    Garden = ,
                    ChildrensAttractions = ,
                    IsAvailable = ,
                },
            };  // לאתחל ערכים

            orders = new List<Order>()
            {
                new Order()
                {
                    Key = ,
                    HostingUnitKey = ,
                    GuestRequestKey = ,
                    OrderDate = ,
                    SentDate = ,
                    CloseDate = ,
                    Status = ,
                },
                new Order()
                {
                    Key = ,
                    HostingUnitKey = ,
                    GuestRequestKey = ,
                    OrderDate = ,
                    SentDate = ,
                    CloseDate = ,
                    Status = ,
                },
                new Order()
                {
                    Key = ,
                    HostingUnitKey = ,
                    GuestRequestKey = ,
                    OrderDate = ,
                    SentDate = ,
                    CloseDate = ,
                    Status = ,
                }
            };  // לאתחל ערכים

            persons = new List<Person>()
            {
                new Person()
                {
                    Id = ,
                    IdType = ,
                    Status =, 
                    Password = , 
                    Email = ,
                    FirstName = ,
                    LastName =, 
                    PhoneNo = ,
                },
                new Person()
                {
                    Id = ,
                    IdType = ,
                    Status =,
                    Password = ,
                    Email = ,
                    FirstName = ,
                    LastName =,
                    PhoneNo = ,
                },
                new Person()
                {
                    Id = ,
                    IdType = ,
                    Status =,
                    Password = ,
                    Email = ,
                    FirstName = ,
                    LastName =,
                    PhoneNo = ,
                },
            };  // לאתחל ערכים

            hosts = new List<Host>()
            {
                new Host()
                {
                    Id = ,
                    BankNumber = ,
                    BranchNumber = ,
                    BankAccountNumber = ,
                    CollectionClearance = ,
                    IsAvailable = ,
                },
                new Host()
                {
                    Id = ,
                    BankNumber = ,
                    BranchNumber = ,
                    BankAccountNumber = ,
                    CollectionClearance = ,
                    IsAvailable = ,
                },
                new Host()
                {
                    Id = ,
                    BankNumber = ,
                    BranchNumber = ,
                    BankAccountNumber = ,
                    CollectionClearance = ,
                    IsAvailable = ,
                },
            };  // לאתחל ערכים

            bankBranches = new List<BankBranch>()
            {
                new BankBranch()
                {
                    BankNUmber = ,
                    BankName = , 
                    BranchNumber = ,
                    BranchAdress = ,
                    BranchCity = ,
                },
                new BankBranch()
                {
                    BankNUmber = ,
                    BankName = , 
                    BranchNumber = ,
                    BranchAdress = ,
                    BranchCity = ,
                },
                new BankBranch()
                {
                    BankNUmber = ,
                    BankName = ,
                    BranchNumber = ,
                    BranchAdress = ,
                    BranchCity = ,
                },
            };  // לאתחל ערכים



            //GuestRequest guestRequest = new GuestRequest();
            //guestRequest.ClientId = 12345678;
            ////guestRequest.Area = Area_GuestRequest;
            //guestRequests = new List<GuestRequest>();
            //hostingUnits = null;
            //orders = null;
            //persons = null;
            //hosts = null;
            //bankBranches = null;
        }
    }
}
