using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create propeteys + toString
namespace DO
{
    public class BankBranch
    {
        private int BankNUmber;
        private string BankName;
        private int BranchNumber;
        private string BranchAdress;
        private string BranchCity;
        public override string ToString()
        {
            return BankName;
        }
    }
}
