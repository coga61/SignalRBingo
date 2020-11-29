using Microsoft.AspNetCore.SignalR;
using SignalRBingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRBingo.Hubs
{
    public class GameHub : Hub
    {
        private string Id => Context.GetHttpContext().Session.Id;

        

        public async Task SendMessage(string user, BingoNumber game)
        {
            await Clients.All.SendAsync("StartGame", user, game);
        }

    }
}
