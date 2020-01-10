using DO.Models;

namespace DalApi.Interfaces
{
    public interface IHostService
    {
      //  void AddHostRequest(Host HostRequest);
        void UpdateHostRequestStatus(Host HostRequest);
       // Host GetHostRequest(int key);
        void UpdateHostRequest(Host updateHostRequest);
    }
}
