using DO.Models;

namespace DalApi.Interfaces
{
    public interface IPersonService
    {
        void UpdatePerson(Person person);
        int AddPerson(Person person);
        Person GetPerson(int id);
    }
}
