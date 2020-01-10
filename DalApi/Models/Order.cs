using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Models
{
    public class  Order
    {
        private int key;
        private int hotingUnitKey;
        private int guestRequestKey;
        private DateTime orderDate;
        private DateTime sentDate;
        private DateTime closeDate;
        public int Key { get; set; }
        public int HostingUnitKey { get; set; }
        public int GuestRequestKey { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime CloseDate { get; set; }
        public Status_Order Status { get; set; }
        public override string ToString()
        {
            return $"{key} ' ' { hotingUnitKey} ' '{guestRequestKey }' '{orderDate }' '{ sentDate}' '{closeDate}" +
                $" {Status}' '{"class Host"}";
        }

    }
}
