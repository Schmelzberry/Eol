"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;
document.getElementById("userInput").focus();


connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    // document.getElementById("messagesList").appendChild(li);

    let anchor = document.getElementById("anchor");
    let messageBox = document.getElementById("messagesList");
    messageBox.insertBefore(li, anchor);

    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.innerHTML = `<span class="chatroom-sender">${user}</span>: <span class="chatroom-message">${message}</span>`;
    messageBox.scrollTop = messageBox.scrollHeight;
});

connection.on("ReceiveOwnPrivateMessage", function(selectedUser, fromUser, message) {
    var li = document.createElement("li");
    let privateBox = document.getElementById(`private-messagesList-${selectedUser}`);
    privateBox.appendChild(li);

    li.innerHTML = `<span class="p-message-author text-primary">${fromUser}</span>: ${message}`;
    privateBox.scrollTop = privateBox.scrollHeight;
});

connection.on("ReceivePrivateMessage", function (selectedUser, fromUser, message) {
    var li = document.createElement("li");
    
    createPrivateChatBox(fromUser);
    let privateBox = document.getElementById(`private-messagesList-${fromUser}`);
    privateBox.appendChild(li);
    
    li.innerHTML = `<span class="p-message-author text-danger">${fromUser}</span>: ${message}`;
    privateBox.scrollTop = privateBox.scrollHeight;
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
        //  if (ChatHub.Context.User === user) {
        //  onlineUsersList.removeChild(user)
        // } 
        // else {
        onlineUsersList.appendChild(listItem);
    });
});

// connection.start().then(function () {
//     document.getElementById("sendButton").disabled = false;
// }).catch(function (err) {
//     return console.error(err.toString());
// });

// Add this code within your connection.start() callback in chat.js
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;

    // Get the list of online users
    const onlineUsersList = document.getElementById("online-users");
    // Get the name of the current user:
    const currentUser = document.getElementById("userInput").value;
    // Add a click event listener to each user in the list
    onlineUsersList.addEventListener("click", function (event) {
        if (event.target.tagName === "LI") {
            const selectedUser = event.target.textContent;
            
            // If the user clicks on someone OTHER than themselves,
            // start a private chat.
            // if (currentUser != selectedUser) {
            //     createPrivateChatBox(selectedUser);
            // }

            createPrivateChatBox(selectedUser);
        }
    });
}).catch(function (err) {
    return console.error(err.toString());
});

// Function to create a new private chat box
function createPrivateChatBox(selectedUser) {
    const chatContainer = document.getElementById("private-chat-container");

    // Check if the chat box for the selected user already exists
    const existingChatBox = document.getElementById(`private-chat-${selectedUser}`);
    if (!existingChatBox) {
        const chatBox = document.createElement("div");
        chatBox.id = `private-chat-${selectedUser}`;
        chatBox.className = "private-chat-box";
        chatBox.innerHTML = `
            <input type="button" class="btn-close" id="close-private-${selectedUser}"/>
            
            <h3 class="private-chat-header">${selectedUser}</h3>
            
            <ul class="message-window" id="private-messagesList-${selectedUser}"></ul>
            <form id="private-chat-form-${selectedUser}" class="message-input">
                <input type="text" class="private-chat-form" id="private-messageInput-${selectedUser}" placeholder="Type Message..." />
                <input type="submit" id="private-sendButton-${selectedUser}" value="Send"/>
            </form>
        `;
      
        // Add the chat box to the container
        chatContainer.appendChild(chatBox);

        // Add an event listener to the new chat box to send private messages
        const chatForm = document.getElementById(`private-chat-form-${selectedUser}`);
        chatForm.addEventListener("submit", function (event) {
            event.preventDefault();
            const message = document.getElementById(`private-messageInput-${selectedUser}`).value;
            connection.invoke("SendPrivateMessage", selectedUser, message).catch(function (err) {
                return console.error(err.toString());
            });
            document.getElementById(`private-messageInput-${selectedUser}`).value = null;
        });
        
        const closeBtn = document.getElementById(`close-private-${selectedUser}`);
        closeBtn.addEventListener("click", function() {
            closeBtn.parentElement.remove();
        });
    }
}


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


