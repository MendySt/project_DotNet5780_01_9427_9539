using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// create speicel run code, check about enum 

namespace DO
{
    public class GuestRequest
    {
        private int key;
        private int clientId;
        private short adults;
        private short children;
        private string subArea;
        private DateTime createDate;
        private DateTime entryDate;
        private DateTime leaveDate;
     
        public int Key { get; set; }
        public int ClientId { get; set; }
        public short Adults { get; set; }
        public short Children { get; set; }
        public string SubArea { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public override string ToString()
        {
            return $"{key} ' ' { clientId} ' '{adults }' '{children }' '{ subArea}' ' {createDate} ' ' { entryDate} ' '{leaveDate }' '{"class GuestRequest"}";
        }

    }
}
