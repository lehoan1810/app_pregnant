"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
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

    var from = document.getElementById("username").getAttribute('userid');
    var to = document.getElementById('users').value;

    var users = [from, to];
    users.sort()
    var group = users[0] + users[1];

    connection.invoke("AddUserToGroup", group).catch(function (err) {
        return console.error(err.toString());
    });

}).catch(function (err) {
    return console.error(err.toString());
});
var currentgroup;

$(document).ready(function () {
    var from = document.getElementById("username").getAttribute('userid');
    var to = document.getElementById('users').value;

    var users = [from, to];
    users.sort()
    var group = users[0] + users[1];

    currentgroup = group;
    $.ajax({
        url: "/Chat/GetMessages",
        data: {
            group: group
        },
        success:
            function (response) {
                response.forEach(m => {
                    var li = document.createElement("li");
                    document.getElementById("messagesList").appendChild(li);
                    li.textContent = `${m.message}`;
                    li.classList += 'message';
                    if (m.sender == from) {
                        li.classList = 'sender';
                    }
                })
                var list = document.getElementById("messagesList");
                list.scrollTop = list.scrollHeight;
            }
    });

    
})

$('#users').on('change', function (e) {
    $('#messagesList').empty();
    var from = document.getElementById("username").getAttribute('userid');
    var to = document.getElementById('users').value;
    var group;

    var users = [from, to];
    users.sort()
    var group = users[0] + users[1];


    connection.invoke("AddUserToGroup", group).catch(function (err) {
        return console.error(err.toString());
    });
    currentgroup = group;

    $.ajax({
        url: "/Chat/GetMessages",
        data: {
            group: group
        },
        success:
            function (response) {
                response.forEach(m => {
                    var li = document.createElement("li");
                    document.getElementById("messagesList").appendChild(li);
                    li.textContent = `${m.message}`;
                    li.classList += 'message';
                    if (m.sender == from) {
                        li.classList = 'sender';
                    }
                })
            }
    });
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("username").getAttribute('userid');
    var message = document.getElementById("messageInput").value;
    if (message.trim() === "")
        return;

    var from = document.getElementById("username").getAttribute('userid');
    var to = document.getElementById('users').value;
    var users = [from, to];
    users.sort()
    var group = users[0] + users[1];

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
    document.getElementById("messageInput").value = "";

    
   

    event.preventDefault();
});