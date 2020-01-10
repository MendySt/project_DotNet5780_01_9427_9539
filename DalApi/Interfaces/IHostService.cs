using DO.Models;

namespace DalApi.Interfaces
{
    public interface IHostService
    {
        void AddHostRequest(Host HostRequest);
        void UpdateHostRequestStatus(Host HostRequest);
        Host GetHostRequest();
        void UpdateHostRequest(Host updateHostRequest);
    }
}
