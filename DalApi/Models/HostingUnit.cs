using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create speicel run code 
namespace DO.Models
{
    public class HostingUnit
    {
        public int Key { get; set; }
        public int Owner { get; set; }
        public string HostingUnitName { get; set; }
        public bool[,] Diary { get; set; }
        public bool Pool { get; set; }
        public bool Jacuzzi { get; set; }
        public bool Garden { get; set; }
        public bool ChildrensAttractions { get; set; }

        /*** additional Functions ***/
        public bool IsAvailable { get; set; }


        public override string ToString() => $"{Key}  {Owner} {HostingUnitName } {IsAvailable} {Diary }class HostingUnit";


    }
}
