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
  private static Dictionary<string, string> connectedUsersDict = new Dictionary<string, string>();

  public override async Task OnConnectedAsync()
  {
    string userName = Context.User.Identity.Name;
    connectedUsers.Add(userName);

    connectedUsersDict.Add(userName, Context.ConnectionId);

    await Clients.All.SendAsync("UserConnected", userName);

    await Clients.Caller.SendAsync("ConnectedUsers", connectedUsers);

    await Clients.All.SendAsync("ReceiveMessage", "ChatBot", $"{Context.User.Identity.Name} has joined.");

    await base.OnConnectedAsync();
  }

  public override async Task OnDisconnectedAsync(Exception exception)
  {
    string userName = Context.User.Identity.Name;
    connectedUsers.Remove(userName);
    connectedUsersDict.Remove(userName);

    await Clients.All.SendAsync("UserDisconnected", userName);
    await Clients.All.SendAsync("ConnectedUsers", connectedUsers);

    await base.OnDisconnectedAsync(exception);
  }

  public async Task SendPrivateMessage(string user, string message)
  {
    // Validate that the sender and recipient are valid users in your system.
    // You can use your user management and validation logic here.

    // Send the message to the specified user only.
    // Client needs ConnectionID 
    // User needs UserId 
    await Clients.Client(connectedUsersDict[user]).SendAsync("ReceivePrivateMessage", user, Context.User.Identity.Name, message);
    await Clients.Caller.SendAsync("ReceiveOwnPrivateMessage", user, Context.User.Identity.Name, message);
  }


}



// if (connectedUsers.Contains(targetUser))
// string currentUser = Context.User.Identity.Name;
//  await Clients.Caller.SendAsync("StartPrivateChat", targetUser);
//  await Clients.User(targetUser).SendAsync("StartPrivateChat", User);

// maybe we build a Dictionary instead of a list (on line 14), hold the UserName as key, their ConnectionID as value?

//From our Uncle...
//fix 1: Ensure that the recipients Connection ID is correctly identified to send messages. 
//var recipientConnectionId = GetConnectionIdForUser(user);

//     if (recipientConnectionId != null)
//     {
//         // Send the message to the specified user only using their ConnectionId
//         await Clients.Client(recipientConnectionId).SendAsync("ReceivePrivateMessage", user, Context.User.Identity.Name, message);
//         await Clients.Caller.SendAsync("ReceivePrivateMessage", user, Context.User.Identity.Name, message);
//     }
//     else
//     {
//         // Handle the case when the recipient is not online or doesn't exist.
//         // You can add error handling or offline message storage here.
//     }
// }

// or fix 2: need to make update to chat.js  
//connection.on("ReceivePrivateMessage", function (selectedUser, fromUser, message) {
// Check if the private chat box exists for the selected user
//     var privateMessagesList = document.getElementById(`private-messagesList-${selectedUser}`);

//     if (privateMessagesList) {
//         var li = document.createElement("li");
//         li.textContent = `${fromUser}: ${message}`;
//         privateMessagesList.appendChild(li);
//     } else {
//         // If the private chat box doesn't exist, create it and then add the message
//         createPrivateChatBox(selectedUser);
//         var li = document.createElement("li");
//         li.textContent = `${fromUser}: ${message}`;
//         document.getElementById(`private-messagesList-${selectedUser}`).appendChild(li);
//     }
// });


//the red text actually helped



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