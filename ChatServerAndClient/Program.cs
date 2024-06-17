

using ChatServerAndClient;

ChatServer server = new ChatServer();

ChatClient per = new ChatClient("Per",server);
ChatClient pål = new ChatClient("Pål",server);
ChatClient espan = new ChatClient("Espen",server);

per.Say("Hello");
pål.Say("Hei");
espan.Say("Hei på deg");