IChatMediator chatMediator = new ChatRoom();

IUser user1 = new User("John", chatMediator);
IUser user2 = new User("Alice", chatMediator);
IUser user3 = new User("Bob", chatMediator);

chatMediator.AddUser(user1);
chatMediator.AddUser(user2);
chatMediator.AddUser(user3);

user1.SendMessage("Hello, everyone!");
user2.SendMessage("Hi, John!");

Console.ReadLine();
