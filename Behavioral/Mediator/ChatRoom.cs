namespace Mediator;

class ChatRoom : IChatRoom
{
    private Dictionary<string, User> users = new Dictionary<string, User>();

    public void Register(User user)
    {
        if (!users.ContainsKey(user.Name))
        {
            users[user.Name] = user;
            user.SetChatRoom(this);
        }
    }

    public void Send(string from, string to, string message)
    {
        if (users.ContainsKey(to))
        {
            users[to].Receive(from, message);
        }
        else
        {
            Console.WriteLine($"User '{to}' not found in chat room.");
        }
    }

    public void Broadcast(string from, string message)
    {
        foreach (var user in users.Values)
        {
            if (user.Name != from)
            {
                user.Receive(from, message);
            }
        }
    }
}
