using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create propeteys + toString
namespace DO
{
    public class Person
    {
        private  int Id;
        private string IdType;
        //...
        public override string ToString()
        {
            return IdType;
        }
    }
}
