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
        private Client client;
        private string ip;
        public MainWindow()
        {
            InitializeComponent();
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
            var MainWindowInstance = new MainWindow();
            MainWindowInstance.Show();
        }

        private void OnServerButton_1(object sender, RoutedEventArgs e)
        {
           
     
          
        }

        private void TextBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            var text = textBox1.Text;
            Console.WriteLine(text);
            client.Send("", 30000, text);
            textBox1.Text = "";
        }

        private void TextBox2_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ServerWindow swindow = new ServerWindow();
            swindow.Show();
        }

        private void TextBox1_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
