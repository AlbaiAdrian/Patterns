namespace Mediator;

interface IChatRoom
{
    void Register(User user);
    void Send(string from, string to, string message);
    void Broadcast(string from, string message);
}
