using DO;
using DO.Models;

namespace DalApi.Interfaces
{
    public interface IGuestRequestService
    {
        void AddGuestRequest(GuestRequest guestRequest);
        void UpdateGuestRequestStatus(  int requestId, Status_GuestRequst requestStatus);
        GuestRequest GetGuestRequest(int key);
        void UpdateGuestRequest(GuestRequest guestRequest);
    }
}
