using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO.Models;

namespace DalApi.Interfaces
{
    public interface IBankBranchService
    {
        List<BankBranch> GetBankBranches();
    }
}
