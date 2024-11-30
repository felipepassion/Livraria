namespace Niu.Nutri.Adm.Dashboard.WebApp.Components.Pages.T4.ChatAgg.Conversation.Cadastro;
public partial class Conversation1 : IDisposable
{
    public void Dispose()
    {
        this.hubConnection?.StopAsync();
    }
}
