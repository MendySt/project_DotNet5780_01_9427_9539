using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class BankBranchBO
    {
  
        public int BankNUmber { get; set; }
        public int BranchNumber { get; set; }
        public string BranchAdress { get; set; }


        public override string ToString() => $"{BankNUmber}  {BranchNumber} {BranchAdress} BankBranchBO";
        
        
    }
}
