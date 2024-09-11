using System.Net;
using System.Net.Sockets;

var client = new TcpClient();

var port = 27001;
var ip = IPAddress.Parse("10.1.18.1");
var ep = new IPEndPoint(ip, port);

Console.ReadKey();
try
{
	client.Connect(ep);
	if (client.Connected)
	{
		while (true)
		{
			var text = Console.ReadLine();
			var sw = new StreamWriter(client.GetStream());
			sw.WriteLine(text);
			sw.AutoFlush = true;
		}
	}
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
