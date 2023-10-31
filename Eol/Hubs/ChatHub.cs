using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Identity;


namespace Eol.Hubs;

public class ChatHub : Hub
{
  public async Task SendMessage(string user, string message)
  {
    await Clients.All.SendAsync("ReceiveMessage", user, message);
  }

  private static List<string> connectedUsers = new List<string>();

  public override async Task OnConnectedAsync()
  {
    string userName = Context.User.Identity.Name;
    connectedUsers.Add(userName);

    await Clients.All.SendAsync("UserConnected", userName);

    await Clients.Caller.SendAsync("ConnectedUsers", connectedUsers);

    await Clients.All.SendAsync("ReceiveMessage", "ChatBot", $"{Context.User.Identity.Name} has joined.");

    // await Clients.All.SendAsync("UserConnected", Context.User.Identity.Name);

    await base.OnConnectedAsync();
  }

  public override async Task OnDisconnectedAsync(Exception exception)
  {
    string userName = Context.User.Identity.Name;
    connectedUsers.Remove(userName);

    await Clients.All.SendAsync("UserDisconnected", userName);
    await Clients.All.SendAsync("ConnectedUsers", connectedUsers);

    await base.OnDisconnectedAsync(exception);
  }

  public async Task UserConnected(string userName)
  {
    await Clients.All.SendAsync("UserConnected", userName);
  }



}


// namespace Eol.Hubs;

// public class ChatHub : Hub
// {
//   public async Task SendMessage(string user, string message)
//   {
//     await Clients.All.SendAsync("ReceiveMessage", user, message);
//   }

//   public override async Task OnConnectedAsync()
//   {
//     await Clients.All.SendAsync("ReceiveMessage", "ChatBot", $"{Context.User.Identity.Name} has joined.");

//     await Clients.All.SendAsync("UserConnected", Context.User.Identity.Name);
//   }

//   public async Task UserConnected(string userName)
//   {
//     await Clients.All.SendAsync("UserConnected", userName);
//   }