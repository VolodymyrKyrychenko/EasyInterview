using Microsoft.AspNetCore.SignalR;

namespace Web.Hubs
{
    public class InterviewHub : Hub
    {
        public void Send(string content)
        {
            Clients.All.SendAsync("broadcastMessage", content);
        }
    }
}
