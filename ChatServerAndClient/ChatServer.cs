namespace ChatServerAndClient;

public class ChatServer
{
    private List<IClient> _clients;

    public ChatServer(List<IClient> client)
    {
        _clients = client;
    }

    public void Register(IClient client)
    {
        _clients.Add(client);
    }

    public void Broadcast(IClient client, string message)
    {
        foreach (var chatClient in _clients)
        {
            if (chatClient != client)
            {
                chatClient.Receive(message);
            }
        }
    }

}