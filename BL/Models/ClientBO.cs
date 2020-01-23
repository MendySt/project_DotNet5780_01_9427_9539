using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class ClientBO:PersonBO
    {
        public List<GuestRequestBO> guestRequestBOs { get; set; }
        public bool SignedPermission { get; set; }
        public override string ToString() => $"{guestRequestBOs} ClientBO ";
        
    }
}
