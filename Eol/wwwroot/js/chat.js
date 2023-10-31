"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;
document.getElementById("userInput").focus();


connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user}: ${message}`;
});

// connection.on("UserConnected", function(userName) {
//     // let onlineUserList = document.getElementById("online-users");
//     let li = document.createElement("li");
//     document.getElementById("online-users").appendChild(li);

//     li.textContent = userName;

//     // onlineUserList.appendChild(listItem);
// });

    connection.on("ConnectedUsers", function (users) {
    const onlineUsersList = document.getElementById("online-users");
    onlineUsersList.innerHTML = ''; // Clear the list before updating
    
    users.forEach(function (user) {
        const listItem = document.createElement("li");
        listItem.textContent = user;
        onlineUsersList.appendChild(listItem);
    });
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("chat-form").addEventListener("submit", function (event) {

    event.preventDefault();
    
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    // Remotely call on our Hub's SendMessage method:
    document.getElementById("messageInput").value = null;
    document.getElementById("messageInput").focus();
    
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());

        

    });
    // event.preventDefault();


    
});