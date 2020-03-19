using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Server.Hubs
{
	public class ChatHub : Hub
	{
		public async Task PosaljiPoruku(string Ko, string Sta)
		{
			await Clients.All.SendAsync("PrimiPoruku", Ko, Sta);
		}
	}
}
