using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;
using Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests;

namespace Niu.Nutri.Chat.Api.Hubs.Hubs;

public class ChatHub : Hub
{
    bool _isLoggedIn => Context.User?.Identity?.IsAuthenticated == true;
    string id => Context?.GetHttpContext()?.GetRouteValue("id") as string;

    public async override Task OnConnectedAsync()
    {
        //if (!_isLoggedIn) return;

        await Groups.AddToGroupAsync(Context.ConnectionId, id);
        await base.OnConnectedAsync();
    }

    public async override Task OnDisconnectedAsync(Exception? exception)
    {
        if (id != null)
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, id);

        await base.OnDisconnectedAsync(exception);
    }

    public async Task SendMessageToUser(ConversationMessageDTO message)
    {
        //if (!_isLoggedIn) return;

        await base.OnConnectedAsync();
        await Clients.Group(id).SendAsync("ReceiveIndividualMessage", message);
    }

    public async Task OnMessageReceivedByOther(ConversationMessageDTO message)
    {
        await Clients.Group(id).SendAsync("OnMessageReceivedByOther", message);
    }

    public async Task OnAllMessagesRead(int fromUserId)
    {
        await Clients.Group(id).SendAsync("OnMessagesRead", fromUserId);
    }
}
