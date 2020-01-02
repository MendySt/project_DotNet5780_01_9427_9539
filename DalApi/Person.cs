using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// done
namespace DO
{
    public class Person
    {
        private string id;
        private string idType;
        private string status;
        private double password;
        private string email;
        private string firstName;
        private string lastName;
        private double phoneNo;
        public string Id { set; get;}
        public string IdType { set; get;}
        public string Status { set; get;}
        public double Password { set; get; }
        public string Email { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public double PhoneNo { set; get; }
        public override string ToString()
        {
            return $"{id} ' ' {idType} ' '{status }' '{password }' '{ email}' '{firstName }' '{lastName}' '{phoneNo }' ' {"class Person"}";

        }
    }
}
