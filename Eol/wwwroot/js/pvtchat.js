
// "use strict";

// var connection = new signalR.HubConnectionBuilder().withUrl("/pvtHub").build();

// // Disable the send button until connection is established.
// document.getElementById("sendButton").disabled = true;
// document.getElementById("userInput").focus();

// // connection.on("ReceiveMessage", function (user, message) {
// //     var li = document.createElement("li");
// //     document.getElementById("messagesList").appendChild(li);
// //     li.textContent = `${user}: ${message}`;
// // });

// connection.on("ReceivePrivateMessage", function (user, message) {
//     // Handle incoming private messages differently.
//     var li = document.createElement("li");
//     document.getElementById("messagesList").appendChild(li);
//     li.textContent = `Private message from ${user}: ${message}`;
// });

// connection.start().then(function () {
//     document.getElementById("sendButton").disabled = false;
// }).catch(function (err) {
//     return console.error(err.toString());
// });

// document.getElementById("chat-form").addEventListener("submit", function (event) {
//     event.preventDefault();
//     // grab toUser username
//     var user = document.getElementById("userInput").value;
//     var message = document.getElementById("messageInput").value;

//     connection.invoke("SendPrivateMessage", user, message).catch(function (err) {
//     return console.error(err.toString());
//     });

//     document.getElementById("messageInput").value = null;
//     document.getElementById("messageInput").focus();
// });

// // const privateMessagesList = document.getElementById("private-messages");
// // const privateMessageInput = document.getElementById("private-message-input");
// // const privateSendButton = document.getElementById("private-send-button");

// // privateSendButton.addEventListener("click", () => {
// //     const message = privateMessageInput.value;
// //     if (message) {
// //         // Replace 'recipientUserName' with the actual username of the recipient
// //         sendPrivateMessage("notgonzobean7", message);
// //         privateMessageInput.value = "";
// //     }
// // });

// // function sendPrivateMessage(recipient, message) {
// //     connection.invoke("SendPrivateMessage", recipient, message).catch((error) => {
// //         console.error(error);
// //     });
// // }

// // connection.on("ReceivePrivateMessage", (sender, message) => {
// //     const messageElement = document.createElement("li");
// //     messageElement.textContent = `${sender}: ${message}`;
// //     privateMessagesList.appendChild(messageElement);
// // });
