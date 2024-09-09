using System.Net;
using System.Net.Sockets;
using System.Text;

var sockets = new List<Socket>();

using var listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

var ipAddress = IPAddress.Parse("10.1.18.1");
var port = 27001;

var endPoint = new IPEndPoint(ipAddress, port);

listener.Bind(endPoint);

listener.Listen();

Console.WriteLine($"Listener: {listener.LocalEndPoint}");
while (true)
{
    var client = listener.Accept();
    Console.WriteLine($"Client: {client.RemoteEndPoint}");
    sockets.Add(client);

    var task = Task.Run(() =>
    {
        
        var consoleColor = (ConsoleColor)((client.RemoteEndPoint as IPEndPoint)?.Port % 15)!;
        var bytes = new byte[1024];
        var msg = string.Empty;
        int len = 0;
        while (true)
        {
            len = client.Receive(bytes);
            msg = Encoding.UTF8.GetString(bytes, 0, len);
            if (msg.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
            {
                client.Shutdown(SocketShutdown.Send);
                client.Close();
                break;
            }

            foreach (var socket in sockets)
            {
                if(socket != client)
                    socket.Send(bytes);
            }
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(msg);
        }
    });
}