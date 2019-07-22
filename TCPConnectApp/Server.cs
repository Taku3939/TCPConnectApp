using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPConnectApp
{
    class Server
    {
        private TcpListener _listener;
        private List<TcpClient> _client = new List<TcpClient>();

        public event Action<string, TcpClient> OnReceiveEvent;
        public event Action<TcpClient> OnConnectEvent;
        public Server(int localPort)
        {
            _listener = new TcpListener(IPAddress.Any, localPort);
            _listener.Start();
        }
        public void Accept()
        {
            _listener.AcceptTcpClientAsync().ContinueWith(task =>
           {
               var client = task.Result;
               _client.Add(client);
               Console.WriteLine("Connected(Server)");
               Console.WriteLine($"Remote IP is : {client.Client.RemoteEndPoint}");
               OnConnectEvent(client);
               Accept();
           }, TaskScheduler.FromCurrentSynchronizationContext());

        }
        public void Receive()
        {
            //if (_client.Count == 0)
            //{
            //    Task.Delay(1000).ContinueWith(t =>
            //    {
            //        Receive();
            //    }, TaskScheduler.FromCurrentSynchronizationContext());
            //    return;
            //}
            var bytes = new Byte[256];
            foreach (var client in _client)
            {
                var stream = client.GetStream();
                stream.ReadAsync(bytes, 0, bytes.Length).ContinueWith(task =>
                    {
                        string message = Encoding.UTF8.GetString(bytes, 0, task.Result);
                        Console.WriteLine($"Reveive : {message} (Server)");
                        OnReceiveEvent?.Invoke(message, client);
                        if (message.Length == 0)
                        {
                            Console.WriteLine($@"Passive Closing : {client.Client.RemoteEndPoint}");
                            client.Close();
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
    }
}
