using Microsoft.AspNetCore.SignalR;
namespace BtkAkademi.Web.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Clients.All.SendAsync("ReceiveMessage",user, message);
          //  Clients.User("").SendAsync(user,message);
        }
    }
}
