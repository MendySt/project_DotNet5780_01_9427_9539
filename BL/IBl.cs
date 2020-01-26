using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    interface IBl
    {
     bool CheckDate(DateTime FirstDay, DateTime LastDay);
     bool CheckAvailableInUnit(bool[,] calander, DateTime FirstDay, DateTime LastDay);
     
     
    
    
       
    }
}
