using DO.Models;

namespace DalApi.Interfaces
{
    public interface IHostService
    {
        int AddHost(Host host);
        void DeleteHost(int id);
        Host GetHost(int id);
        void UpdateHost(Host host);
    }
}
