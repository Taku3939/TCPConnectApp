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
    /// ClientWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ClientWindow : Window
    {
        private Client a;
        public ClientWindow()
        {
            InitializeComponent();
          
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            a = new Client();
            var text = textbox.Text;
            a.Send("text");
        }

        private void TextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
