using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Pred.Controllers;

namespace Pred.Models
{
    public class ChatHub : Hub
    {
        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}

        public async Task SendMessageToGroup(string group, string user, string message)
        {
            await Clients.Group(group).SendAsync("ReceiveMessage", user, message);
        }

        public async Task AddUserToGroup(string group)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, group);
            
        }

        public async Task RemoveUserFromGroup(string group)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, group);

        }
    }
}
