using System.Net;
using System.Net.Sockets;
using System.Text;


Console.WriteLine("Server");

var server = new UdpClient(27001);
var remoteEp = new IPEndPoint(IPAddress.Any, 0);

while (true)
{
    var btyes = server.Receive(ref remoteEp);
    var str = Encoding.UTF8.GetString(btyes);
    Console.WriteLine(str);
}