namespace ChatServerAndClient;

public interface IClient
{
    public void Say(string message);
    public void Receive(string message);
}