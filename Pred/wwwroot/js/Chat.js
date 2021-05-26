"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("div");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${message}`;
    var from = document.getElementById("username").getAttribute('userid');
    li.classList += 'message';
    if (user == from) {
        li.classList = 'sender';
    }
    var list = document.getElementById("messagesList");
    list.scrollTop = list.scrollHeight;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});
var currentgroup;

function setChatToUser(user) {
    document.getElementById('users-tb').value = user;
    var from = document.getElementById("username").getAttribute('userid');
    var to = user;
    var group;

    var users = [from, to];
    users.sort()
    var group = users[0] + users[1];
    connection.invoke("AddUserToGroup", group).catch(function (err) {
        return console.error(err.toString());
    });
    currentgroup = group;

    getMessage(group, from);
}

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("username").getAttribute('userid');
    var message = document.getElementById("messageInput").value;
    if (message.trim() === "")
        return;

    var from = document.getElementById("username").getAttribute('userid');
    var to = document.getElementById('users-tb').value;
    var users = [from, to];
    users.sort()
    var group = users[0] + users[1];

    saveMessage(group, user, message);
    document.getElementById("messageInput").value = "";

    event.preventDefault();
});

function saveMessage(group, user, message) {
    connection.invoke("SendMessageToGroup", group, user, message).catch(function (err) {
        return console.error(err.toString());
    }).then(function () {
        $.ajax({
            url: "/Chat/SaveMessage",
            data: {
                message: message,
                group: group,
                userId: user
            }
        });
    });
}

function getMessage(group, from) {
    $.ajax({
        url: "/Chat/GetMessages",
        data: {
            group: group
        },
        success:
            function (response) {
                document.getElementById("messagesList").innerHTML = ''
                response.forEach(m => {
                    var li = document.createElement("div");
                    var br = document.createElement("br");
                    document.getElementById("messagesList").appendChild(li);
                    li.textContent = `${m.message}`;
                    li.classList += 'message';
                    if (m.sender == from) {
                        li.classList = 'sender';
                    }
                    document.getElementById("messagesList").appendChild(br);
                })
                var list = document.getElementById("messagesList");
                list.scrollTop = list.scrollHeight;
            }
    });

}