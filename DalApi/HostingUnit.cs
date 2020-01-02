using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create speicel run code 
namespace DO
{
    public class HostingUnit
    {
        private int key;
        private int owner;
        private string hostingUnitName;
        private bool[,] diary;
        public int Key { get; set; }
        public int Owner { get; set; }
        public string HostingUnitName { get; set; }
        public bool[,] Diary { get; set; }
        public override string ToString()
        {
            return $"{key} ' ' { owner} ' '{hostingUnitName }' '{ diary }' '{"class HostingUnit"}";
        }

    }
}
