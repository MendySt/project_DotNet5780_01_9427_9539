using DO;
using DO.Models;

namespace DalApi.Interfaces
{
    public interface IGuestRequestService
    {
        void AddGuestRequest(GuestRequest guestRequest);
        void UpdateGuestRequestStatus(GuestRequest guestRequest);
        GuestRequest GetGuestRequest();
        void UpdateGuestRequest(int requestId, Status_GuestRequst requestStatus  );
    }
}
