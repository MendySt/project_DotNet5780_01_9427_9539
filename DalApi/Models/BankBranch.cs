using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//done
namespace DO.Models
{
    public class BankBranch
    {
        //property
        public int BankNUmber { get; set; }
        public string BankName { get; set; }
        public int BranchNumber { get; set; }
        public string BranchAdress { get; set; }
        public string BranchCity { get; set; }


        public override string ToString() => $"{BankNUmber} {BankName} {BranchNumber} {BranchAdress} {BranchCity}";
        
        
    }
}
