using DO.Models;

namespace DalApi.Interfaces
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        Person GetPerson(int id);
        void UpdatePerson(Person person);
    }
}
