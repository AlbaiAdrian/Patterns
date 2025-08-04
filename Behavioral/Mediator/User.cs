namespace Mediator;

class User
{
    public string Name { get; private set; }
    private IChatRoom chatRoom;

    public User(string name)
    {
        Name = name;
    }

    public void SetChatRoom(IChatRoom chatRoom)
    {
        this.chatRoom = chatRoom;
    }

    public void Send(string to, string message)
    {
        Console.WriteLine($"{Name} sends to {to}: {message}");
        chatRoom?.Send(Name, to, message);
    }

    public void Broadcast(string message)
    {
        Console.WriteLine($"{Name} broadcasts: {message}");
        chatRoom?.Broadcast(Name, message);
    }

    public void Receive(string from, string message)
    {
        Console.WriteLine($"{Name} receives from {from}: {message}");
    }
}