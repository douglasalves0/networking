using System.Net.Sockets;

using TcpClient client = new TcpClient("localhost", 8080);
using NetworkStream stream = client.GetStream();

using StreamWriter writer = new StreamWriter(stream);
using StreamReader reader = new StreamReader(stream);

writer.WriteLine("GET /sum?a=5&b=10 HTTP/1.1");
writer.WriteLine("Host: nao importa");
writer.WriteLine("Connection: close");
writer.WriteLine("");
writer.Flush();

Console.WriteLine(reader.ReadToEnd());