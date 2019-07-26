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
        public bool Connected => _client.Connected;
        //  public event Action<TcpClient> OnConnectEvent;
        public Client()
       {
            _client = new TcpClient();
        }
        public void Connect(string ip ,int port)
        {
            _client.ConnectAsync(ip, port);
          //  OnConnectEvent?.Invoke(_client);
        }
        public void Send(string message)
        {
            //try
            //{
            //    _client = new TcpClient("localhost", 30000); 
            //}
            //catch
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}
            var stream = _client.GetStream();
          // stream.ReadTimeout = 15000;
          //stream.WriteTimeout = 15000;
            var byteMessage = Encoding.UTF8.GetBytes(message);
            stream.WriteAsync(byteMessage, 0, byteMessage.Length).ContinueWith(task =>
            {
                Console.WriteLine("Sent(Client)");
            });
        }
    }
}
