

using ChatServerAndClient;

ChatServer server = new ChatServer(new List<IClient>());

ChatClient per = new ChatClient("Per",server);
ChatClient pål = new ChatClient("Pål",server);
ChatClient espan = new ChatClient("Espen", server);

server.Register(per);
server.Register(pål);
server.Register(espan);

per.Say("Hello");
pål.Say("Hei");
espan.Say("Hei på deg");