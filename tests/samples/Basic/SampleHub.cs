using Microsoft.AspNetCore.SignalR;

namespace Basic;

public class SampleHub : Hub
{
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }

    public override async Task OnConnectedAsync()
    {
        // This newMessage call is what is not being received on the front end
        await Clients.Caller.SendAsync("OnConnected", "Connected!");

        await base.OnConnectedAsync();
    }
}
