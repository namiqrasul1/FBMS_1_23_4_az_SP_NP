using System.Net;
using System.Net.Sockets;
using System.Text;
Console.WriteLine("Client");

var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

var ip = IPAddress.Parse("10.1.18.1");
var port = 27001;

var ep = new IPEndPoint(ip, port);

try
{
	while (true)
	{
		var msg = Console.ReadLine();
		var bytes = Encoding.UTF8.GetBytes(msg!);
		socket.SendTo(bytes, ep);
	}
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}