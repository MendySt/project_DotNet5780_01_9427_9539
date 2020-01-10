using DO.Models;

namespace DalApi.Interfaces
{
    public interface IPersonService
    {
        void UpdatePerson(Person person);
        void AddPerson(Person person);
        Person GetPerson();
    }
}
