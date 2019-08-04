using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TCPConnectApp
{
    /// <summary>
    /// ServerWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ServerWindow : Window
    {
        private Server _tcpServer;
        private Client client;
        private string ip;
        public ServerWindow()
        {
            InitializeComponent();
            _tcpServer.Accept();
            Console.WriteLine("Accept()");
            textBox.Text += "Start TCP Receive...\n";
            _tcpServer.Receive();
        }

        private void SendButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
