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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TCPConnectApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private Server _tcpServer;

        public MainWindow()
        {
            InitializeComponent();
            _tcpServer = new Server(30000);
            _tcpServer.Accept();
            Console.WriteLine("Accept()");
            _tcpServer.OnReceiveEvent += (message, tcpClient) =>
            {
                textBox.Text += $"From [{tcpClient.Client.RemoteEndPoint}]\n\t=> : {message}\n";
                _tcpServer.Receive();
            };
            _tcpServer.OnConnectEvent += client =>
            {
                textBox.Text += $"Connected to [{client.Client.RemoteEndPoint}] (TCP)\n";
                _tcpServer.Receive();
            };
            textBox.Text += "Start TCP Receive...\n";
            _tcpServer.Receive();
           
            }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
     
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var ClientWindow = new ClientWindow();
            ClientWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
     
        }

        private void TextBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
