using System.Collections.Generic;
using DO;
using DO.Models;


namespace DalApi.Interfaces
{
    public interface IGuestRequestService
    { 
        int AddGuestRequest(GuestRequest guestRequest);
        void UpdateGuestRequestStatus(int requestKey, Status_GuestRequst requestStatus);
        GuestRequest GetGuestRequest(int key);
        void UpdateGuestRequest(GuestRequest guestRequest);
        List <GuestRequest> GetGuestRequests();

    }
}
