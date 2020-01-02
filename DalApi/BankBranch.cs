using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//done
namespace DO
{
    public class BankBranch
    {
        private int bankNUmber;
        private string bankName;
        private int branchNumber;
        private string branchAdress;
        private string branchCity;
        //property
        public int BankNUmber { get; set; }
        public string BankName { get; set; }
        public int BranchNumber { get; set; }
        public string BranchAdress { get; set; }
        public string BranchCity { get; set; }


        public override string ToString()
        {
            return $"{bankNUmber}{BankName}{branchNumber}{branchAdress}{branchCity}";
        }
        
    }
}
