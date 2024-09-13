using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Client");

var client = new UdpClient();
var connectEp = new IPEndPoint(IPAddress.Loopback, 27001); // 127.0.0.1

while (true)
{
    var msg = Console.ReadLine();
    var bytes = Encoding.UTF8.GetBytes(msg!);
    client.Send(bytes, bytes.Length, connectEp);
}

