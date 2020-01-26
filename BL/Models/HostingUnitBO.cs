using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create speicel run code 
namespace BO.Models
{
    public class HostingUnitBO
    {
        public int Key { get; set; }
        public int Owner { get; set; }
        public string HostingUnitName { get; set; }
        public bool[,] Diary { get; set; } = new bool[12, 31];
        public bool IsAvailable { get; set; }
        public override string ToString() => $"{Key}  {Owner} {HostingUnitName } {IsAvailable} {Diary }class HostingUnitBO";


    }
}
