using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Identity;


namespace Eol.Hubs;

public class ChatHub : Hub
{
  public async Task SendMessage(string user, string message)
  {
    await Clients.All.SendAsync("ReceiveMessage", user, message);
  }

  public override async Task OnConnectedAsync()
  {
    await Clients.All.SendAsync("ReceiveMessage", "ChatBot", $"{Context.User.Identity.Name} has joined.");
  }
}