using Microsoft.AspNetCore.SignalR;

namespace Eol.Hubs;

public class ChatHub : Hub
{
  public async Task SendMessage(string user, string message)
  {
    await Clients.All.SendAsync("ReceiveMessage", user, message);
  }

  public override async Task OnConnectedAsync()
  {
    await Clients.All.SendAsync("ReceiveMessage", Context.ConnectionId, "has joined.");
  }
}