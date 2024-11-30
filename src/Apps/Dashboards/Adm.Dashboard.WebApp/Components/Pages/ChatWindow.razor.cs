using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;

namespace Companies.Adm.Panel.Client.Shared.Chat;

public partial class ChatWindow
{
}

public class ListDataModel
{
    public string Id { get; set; }
    public string Chat { get; set; }
    public string ToExternalId { get; set; }
    public string Avatar { get; set; }
    public string Text { get; set; }
    public string Message { get; set; }
}

public class ChatContext
{
    public bool IsOpen { get; set; }

    public Func<Task> CloseChat { get; set; }

    public Func<UserDTO, Task> OpenChatWithUser { get; set; }
}