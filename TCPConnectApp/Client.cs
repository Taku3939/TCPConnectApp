using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPConnectApp
{
    class Client
    {
        private TcpClient _client;
        public Client()
        {
            _client = new TcpClient();
           _client.ConnectAsync("localhost", 30000);
        }
        public void Send(string message)
        {
            try
            {
                _client = new TcpClient("localhost", 30000); 
            }
            catch
            {
                Console.WriteLine("Error");
                return;
            }
            var stream = _client.GetStream();
          //  stream.ReadTimeout = 15000;
          //  stream.WriteTimeout = 15000;
            var byteMessage = Encoding.UTF8.GetBytes(message);
            stream.WriteAsync(byteMessage, 0, byteMessage.Length).ContinueWith(task =>
            {
                Console.WriteLine("Sent(Client)");
            });
        }
    }
}
