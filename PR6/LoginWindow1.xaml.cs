using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

namespace PR6
{
    public partial class LoginWindow1 : Window
    {
        public static string serverName;
        public static string userName;
        public LoginWindow1()
        {
            InitializeComponent();
        }

        private void Toclient_Click(object sender, RoutedEventArgs e)
        {
            if (ClientNick.Text == "" || ClientNick.Text == "Введите ник:")
            {
                MessageBox.Show("Введите ник");
            }
            else
            {
                if (IPbox.Text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length == 4)
                {
                    IPAddress ipAddr; 
                    if (IPAddress.TryParse(IPbox.Text, out ipAddr))
                    {
                        userName = ClientNick.Text;
                        TcpClientWindow tcpClient = new TcpClientWindow(ipAddr);
                        tcpClient.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Октет не должен превышать значение 255");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный формат айпи адреса!");
                }
            }
        }
        private void Toserver_Click(object sender, RoutedEventArgs e)
        {
            if (ServerNick.Text == "" || ServerNick.Text == "Введите ник:")
            {
                MessageBox.Show("Введите ник");
            }
            else
            {
                serverName = ServerNick.Text;
                TcpServerWindow tcpServer = new TcpServerWindow();
                tcpServer.Show();
                Close();
            }

        }

        private void IPbox_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            IPbox.Text = "";
        }

        private void ClientNick_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientNick.Text = "";
        }

        private void ServerNick_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ServerNick.Text = "";
        }
    }
}
