using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// create speicel run code, check about enum 

namespace DO.Models
{
    public class GuestRequest
    {
        public int Key { get; set; }
        public int ClientId { get; set; }
        public Status_GuestRequst Status { get; set; }

        public short Adults { get; set; }
        public short Children { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LeaveDate { get; set; }

        public Area_GuestRequest Area { get; set; }
        public Type_GuestRequest Type { get; set; }

        public Pool_GuestRequest Pool { get; set; }
        public Jacuzzi_GuestRequest Jacuzzi { get; set; }
        public Garden_GuestRequest Garden { get; set; }
        public ChildrensAttractions_GuestRequest ChildrensAttractions { get; set; }
        public override string ToString()=> $"{Status} {Area} {Type} {Pool} {Jacuzzi} {Garden} {ChildrensAttractions} {Key} {ClientId} {Adults} {Children }{CreateDate} {EntryDate} {LeaveDate } class GuestRequest";
       
    }
}
