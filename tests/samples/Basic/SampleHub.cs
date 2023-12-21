using Microsoft.AspNetCore.SignalR;

namespace Basic;

public class SampleHub : Hub
{
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}
