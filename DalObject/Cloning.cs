using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using DO;
using DS;

namespace DalObject
{
    static class Cloning
    {
        internal static GuestRequest Clone(this GuestRequest original)
        {
            GuestRequest target = new GuestRequest();
            target.GuestRequestKey = original.GuestRequestKey;

            return target;
        }

        //internal static Lecture Clone(this Lecture original)
        //{
        //    Lecture target = new Lecture();
        //    target.id = original.id;
        //...
        //return target;
        
        
    }

}

