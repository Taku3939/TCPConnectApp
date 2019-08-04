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
       
        public ClientWindow()
        {
            InitializeComponent();
          

            //  client.OnConnectEvent += client => { textbox.Text += $"Connected to [] (TCP)\n"; };

        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {   
          
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

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            ip = iptext.Text;
            if (!client.Connected)
            {
                client.Connect(ip, 30000);
            }
        }
    }
}
