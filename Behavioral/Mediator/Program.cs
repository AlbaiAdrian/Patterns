// See https://aka.ms/new-console-template for more information
using Mediator;

Console.WriteLine("Hello, Mediator!");

ChatRoom chatRoom = new ChatRoom();

User gigi = new User("Gigi");
User ion = new User("Ion");
User marie = new User("Marie");

chatRoom.Register(gigi);
chatRoom.Register(ion);
chatRoom.Register(marie);

// Private messages
gigi.Send("Ion", "Ioane hai la fan!");
ion.Send("Marie", "Marie esti acas? Ne ceama Ion la fan!");

// Broadcast message
marie.Broadcast("Inhamati caii, nu mai stati la birt!");

// Invalid user
ion.Send("Decebal", "Decebale tu nu potz veni?");
