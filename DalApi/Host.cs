using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{    
    public class Host
    {
        private double id;
        private short bankNumber;
        private short branchNumber;
        private int bankAccountNumber;
        private bool collectionClearance;
        public double Id{ get; set; }
        public short BankNumber { get; set; }
        public short BranchNumber { get; set; }
        public int BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }
        public override string ToString()
        {
            return $"{id} ' ' { bankNumber} ' '{branchNumber }' '{bankAccountNumber }' '{ collectionClearance}' '{"class Host"}";
        }
    }
}
