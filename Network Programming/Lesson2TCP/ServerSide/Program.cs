using System.Net;
using System.Net.Sockets;

var port = 27001;
var ip = IPAddress.Parse("10.1.18.1");
var ep = new IPEndPoint(ip, port);

using var listener = new TcpListener(ep);
listener.Start();
Console.WriteLine($"Listening on: {listener.LocalEndpoint}");

while (true)
{
    var client = listener.AcceptTcpClient();
    var task = Task.Run(() =>
    {
        Console.WriteLine($"{client.Client.RemoteEndPoint} connected");
        var stream = client.GetStream();
        var sr = new StreamReader(stream);
        while (true)
        {
            var message = sr.ReadLine();
            Console.WriteLine($"{client.Client.RemoteEndPoint}: {message}");
        }
    });
}