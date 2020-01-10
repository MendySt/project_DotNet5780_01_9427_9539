using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// done
namespace DO.Models
{
    public class Person
    {
        public int Id { set; get;}
        public IdType_person IdType{ set; get;}
        public Status_person Status { set; get;}
        public double Password { set; get; }
        public string Email { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public double PhoneNo { set; get; }
        public override string ToString() => $"{Id} {IdType} {Status } {Password } { Email} {FirstName } {LastName} {PhoneNo } class Person";
    }
}
