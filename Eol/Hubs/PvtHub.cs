// using Microsoft.AspNetCore.SignalR;
// using Microsoft.AspNetCore.Identity;

// public class PvtHub : Hub
// {
//   public async Task SendPrivateMessage(string user, string message)
//   {
//     // Validate that the sender and recipient are valid users in your system.
//     // You can use your user management and validation logic here.

//     // Send the message to the specified user only.
//     await Clients.User(user).SendAsync("ReceivePrivateMessage", Context.User.Identity.Name, message);
//   }

//   public override async Task OnConnectedAsync()
//   {
//     await Clients.All.SendAsync("ReceiveMessage", "ChatBot", $"{Context.User.Identity.Name} has joined.");
//   }
// }