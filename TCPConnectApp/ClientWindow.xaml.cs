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
using System.Net.Sockets;
using System.Net;

namespace TCPConnectApp
{
    /// <summary>
    /// ClientWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ClientWindow : Window
    {
        private Client client;
        public ClientWindow()
        {
            InitializeComponent();
            client = new Client();
            
            //  client.OnConnectEvent += client => { textbox.Text += $"Connected to [] (TCP)\n"; };

            if (!client.Connected) { client.Connect("localhost", 30000);
            } }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var text = textbox.Text;
            Console.WriteLine(text);
            client.Send(text);
            textbox.Text = "";
        }

        private void TextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
