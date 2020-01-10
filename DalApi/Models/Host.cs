using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Models
{    
    public class Host
    {
        public double Id{ get; set; }
        public short BankNumber { get; set; }
        public short BranchNumber { get; set; }
        public int BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }
        public override string ToString()=> $"{Id} {BankNumber} {BranchNumber } {BankAccountNumber} {CollectionClearance}  class Host";
        
    }
}
