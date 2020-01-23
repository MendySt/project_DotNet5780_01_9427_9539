using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DO.Models;
namespace BL
{
    /// <summary>
    /// class used to convert BO to DO object and DO to BO.
    /// </summary>
    class Converters
    {
        // readonly DalApi.IDal dal = DalApi.DalFactory.GetDal();
        static BLImplementation instance = new BLImplementation();

        public static HostingUnit ConverFrom_BO_To_DoHostingUnit(BO.Models.HostingUnitBO other)
        {
            HostingUnit tmp = new HostingUnit();
            tmp.Key = other.Key;
            tmp.HostingUnitName = other.HostingUnitName;
            tmp.Owner = other.Owner;
            tmp.IsAvailable = other.IsAvailable;
            
            return tmp;

        }
        public static BO.HostingUnitBO ConverFrom_DO_To_BoHostingUnit(DO.HostingUnit other)
        {
            BO.HostingUnitBO tmp = new BO.HostingUnitBO();
            tmp.Key = other.Key;
            tmp.HostingUnitName = other.HostingUnitName;
            tmp.numOfOffers = other.NumOfoffers;
            tmp.Owner = other.Owner;
            tmp.PricePerNight = other.pricePerNight;
            tmp.Status = (BO.StatusActive)other.status;
            return tmp;
        }

        public static BO.Order ConverFrom_DO_To_BoOrder(DO.Order other)
        {
            BO.Order tmp = new BO.Order();
            tmp.CloseDate = other.CloseDate;
            tmp.GuestRequestKey = other.GuestRequestKey;
            tmp.HostingUnitKey = other.HostingUnitKey;
            tmp.KeyOrder = other.Key;
            tmp.OrderDate = other.OrderDate;
            tmp.SentDate = other.SentDate;
            tmp.Status = (BO.StatusOrder)other.Status;
            tmp.TotalPrice = other.TotalPrice;
            tmp.unit = instance.GetHoustingUinit(other.HostingUnitKey);
            tmp.HostId = (instance.GetHoustingUinit(other.HostingUnitKey)).Owner;
            tmp.NameClient = other.NameClient;
            return tmp;
        }
        public static DO.Order ConverFrom_BO_To_DoOrder(BO.Order other)
        {
            DO.Order tmp = new DO.Order();
            tmp.CloseDate = other.CloseDate;
            tmp.GuestRequestKey = other.GuestRequestKey;
            tmp.HostingUnitKey = other.HostingUnitKey;
            tmp.Key = other.KeyOrder;
            tmp.OrderDate = other.OrderDate;
            tmp.SentDate = other.SentDate;
            tmp.Status = (DO.StatusOrder)other.Status;
            tmp.TotalPrice = other.TotalPrice;


            return tmp;
        }

        public static DO.GuestRequest ConverFrom_BO_To_DoRequest(BO.GuestRequestBO other)
        {
            DO.GuestRequest tmp = new DO.GuestRequest();
            tmp.Adults = other.Adults;
            tmp.Area = (DO.Areas)other.Area;
            tmp.Children = other.Children;
            tmp.ChildrensAttractions = (DO.Answer)other.ChildrensAttractions;
            tmp.ClientId = other.ClientId;
            tmp.CreateDate = other.CreateDate;
            tmp.EntryDate = other.EntryDate;
            tmp.Garden = (DO.Answer)other.Garden;
            tmp.Jacuzzi = (DO.Answer)other.Jacuzzi;
            tmp.Key = other.Key;
            tmp.LeaveDate = other.LeaveDate;
            tmp.NumOfoffers = other.NumOfoffers;//need to chek if we need that
            tmp.Pool = (DO.Answer)other.Pool;
            tmp.Rooms = other.Rooms;
            tmp.Status = (DO.StatusRequest)other.Status;
            tmp.SubArea = other.SubArea;
            tmp.Terrace = other.Terrace;
            tmp.Type = (DO.HostingType)other.Type;
            return tmp;
        }
        public static BO.GuestRequestBO ConverFrom_DO_To_BoRequest(DO.GuestRequest other)
        {
            BO.GuestRequestBO tmp = new BO.GuestRequestBO();
            tmp.Adults = other.Adults;
            tmp.Area = (BO.Areas)other.Area;
            tmp.Children = other.Children;
            tmp.ChildrensAttractions = (BO.Answer)other.ChildrensAttractions;
            tmp.ClientId = other.ClientId;
            tmp.CreateDate = other.CreateDate;
            tmp.EntryDate = other.EntryDate;
            tmp.Garden = (BO.Answer)other.Garden;
            tmp.Jacuzzi = (BO.Answer)other.Jacuzzi;
            tmp.Key = other.Key;
            tmp.LeaveDate = other.LeaveDate;
            tmp.NumOfoffers = other.NumOfoffers;
            tmp.Pool = (BO.Answer)other.Pool;
            tmp.Rooms = other.Rooms;
            tmp.Status = (BO.StatusRequest)other.Status;
            tmp.SubArea = other.SubArea;
            tmp.Terrace = other.Terrace;
            tmp.Type = (BO.HostingType)other.Type;
            return tmp;
        }
        public static DO.Person ConverFrom_BO_To_DoPerson(BO.PersonBO other)
        {
            DO.Person copy = new DO.Person();
            copy.Id = other.Id;
            copy.Email = other.Email;
            copy.FirstName = other.FirstName;
            copy.LastName = other.LastName;
            copy.IdType = (DO.IdType)other.IdType;
            copy.Password = other.Password;
            copy.Phone = other.Phone;
            copy.Status = (DO.StatusPerson)other.Status;
            return copy;
        }
        public static BO.PersonBO ConverFrom_DO_To_BoPerson(DO.Person other)
        {
            BO.PersonBO copy = new BO.PersonBO();
            copy.Id = other.Id;
            copy.Email = other.Email;
            copy.FirstName = other.FirstName;
            copy.LastName = other.LastName;
            copy.IdType = (BO.IdType)other.IdType;
            copy.Password = other.Password;
            copy.Phone = other.Phone;
            copy.Status = (BO.StatusPerson)other.Status;
            return copy;
        }

        public static BO.HostBO ConverFrom_DO_To_BoHost(DO.Host other)
        {
            HostBO per = new HostBO();
            per.Info = instance.GetPerson(other.Id);
            per.Acoount = ConverFrom_DO_To_BoBankAccount(other.Account);
            per.CollectionClearance = other.CollectionClearance;
            per.Website = other.website;
            per.MyOrders = instance.GetOrdersByHost(other.Id);
            per.MyUnits = instance.GetHostingUnits(other.Id);
            return per;
        }

        public static DO.Host ConverFrom_BO_To_DoHost(BO.HostBO other)
        {
            DO.Host per = new DO.Host();
            per.Account = ConverFrom_BO_To_DoBankAccount(other.Acoount);
            per.CollectionClearance = other.CollectionClearance;
            per.website = other.Website;
            per.Id = other.Info.Id;
            per.Status = DO.StatusActive.Active;
            return per;
        }
        public static BO.BankAccount ConverFrom_DO_To_BoBankAccount(DO.BankAccount other)
        {
            BO.BankAccount tmp = new BO.BankAccount();
            tmp.AcouuntNumber = other.AcouuntNumber;
            tmp.BranchInfo = ConverFrom_DO_To_BoBankBranch(other.BranchInfo);
            return tmp;
        }
        public static DO.BankAccount ConverFrom_BO_To_DoBankAccount(BO.BankAccount other)
        {
            DO.BankAccount tmp = new DO.BankAccount();
            tmp.AcouuntNumber = other.AcouuntNumber;
            tmp.BranchInfo = ConverFrom_BO_To_DoBankBranch(other.BranchInfo);
            return tmp;
        }
        public static BO.BankBranch ConverFrom_DO_To_BoBankBranch(DO.BankBranch other)
        {
            BO.BankBranch tmp = new BO.BankBranch();
            tmp.BankName = other.BankName;
            tmp.BankNumber = other.BankNumber;
            tmp.BranchAddress = other.BranchAddress;
            tmp.BranchCity = other.BranchCity;
            tmp.BranchNumber = other.BranchNumber;
            tmp.phone = other.Phone;
            return tmp;
        }
        public static DO.BankBranch ConverFrom_BO_To_DoBankBranch(BO.BankBranch other)
        {
            DO.BankBranch tmp = new DO.BankBranch();
            tmp.BankName = other.BankName;
            tmp.BankNumber = other.BankNumber;
            tmp.BranchAddress = other.BranchAddress;
            tmp.BranchCity = other.BranchCity;
            tmp.BranchNumber = other.BranchNumber;
            tmp.Phone = other.phone;
            return tmp;
        }

        public static BO.BankBranch ConverFrom_DO_To_BoBank(DO.BankBranch other)
        {
            BankBranch temp = new BankBranch();
            temp.BankNumber = other.BankNumber;
            temp.BranchAddress = other.BranchAddress;
            temp.BranchNumber = other.BranchNumber;
            temp.BranchCity = other.BranchCity;
            temp.BankName = other.BankName;
            return temp;
        }
        public static DO.BankBranch ConverFrom_BO_To_DoBank(BO.BankBranch other)
        {

            DO.BankBranch temp = new DO.BankBranch();
            temp.BankNumber = other.BankNumber;
            temp.BranchAddress = other.BranchAddress;
            temp.BranchNumber = other.BranchNumber;
            temp.BranchCity = other.BranchCity;
            temp.BankName = other.BankName;
            return temp;
        }
        public static DO.Manager ConverFrom_BO_To_DoManager(BO.Manager other)
        {

            DO.Manager temp = new DO.Manager();
            temp.Id = other.info.Id;
            temp.NumberOfHosts = instance.NumOfHosts();
            return temp;

        }
        public static BO.Manager ConverFrom_DO_To_BoManager(DO.Manager other)
        {

            BO.Manager temp = new BO.Manager();
            temp.info = instance.GetPerson(other.Id);
            return temp;
        }


    }
}