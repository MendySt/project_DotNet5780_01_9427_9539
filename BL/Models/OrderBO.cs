using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class  OrderBO
    {     
        public int Key { get; set; }
        public int HostingUnitKey { get; set; }
        public int GuestRequestKey { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime SentMail { get; set; }
        public DateTime CloseDate { get; set; }
        public Status_Order Status { get; set; }
        public GuestRequestBO GuestRequestBO { get; set; }
        public HostingUnitBO HostingUnitBO { get; set; }



        public override string ToString() => $"{Key} {HostingUnitKey} {GuestRequestKey } { SentMail} {CloseDate} " +
            $"{OrderDate } {Status} {GuestRequestBO} {HostingUnitBO} class HostBO";


    }
}
