namespace ChatServerAndClient;

public class ChatClient
{
    private string _name;
    private ChatServer _server;

    public ChatClient(string name, ChatServer server)
    {
        _name = name;
        _server = server;
        _server.Register(this);
    }

    public void Say(string message)
    {
        _server.Broadcast(this,$"{_name} sier {message}");
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{_name} mottak:{message}");
    }


}