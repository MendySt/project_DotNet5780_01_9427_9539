using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{    
    public class HostBO: PersonBO
    {
        public string webSite { get; set; }
        public double IdHost{ get; set; }
        public short BankNumber { get; set; }
        public short BranchNumber { get; set; }
        public int BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }
        public bool IsAvailable { get; set; }
        public List<GuestRequestBO> guestRequestBOs { get; set; }
        public List<OrderBO> orderBOs { get; set; }

        public override string ToString()=> $"{IdHost} {webSite} {BankNumber} {BranchNumber } {IsAvailable} {BankAccountNumber} " +
            $"{CollectionClearance} {guestRequestBOs} {orderBOs}  class HostBO";
       
    }
}
