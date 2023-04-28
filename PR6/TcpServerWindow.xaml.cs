using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;

namespace PR6
{
    public partial class TcpServerWindow : Window
    {
        bool count = false;
        private Socket socket;
        private List<Socket> sockets = new List<Socket>();
        private CancellationTokenSource token;
        public TcpServerWindow()
        {
            InitializeComponent();
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
            serverIP.Text = "Ваш айпи: " + ipPoint.ToString();
            Dispatcher.Invoke(() => userlist.Items.Add(LoginWindow1.serverName));
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipPoint);
            socket.Listen(1000);
            token = new CancellationTokenSource();
            Task.Run(() => ListenToClients());
        }

        private async Task ListenToClients()
        {
            while (!token.IsCancellationRequested)
            {
                var client = await socket.AcceptAsync();
                Dispatcher.Invoke(() => userlist.Items.Add(((IPEndPoint)client.RemoteEndPoint).Address));
                Log("Подключен " + ((IPEndPoint)client.RemoteEndPoint).Address);
                sockets.Add(client);
                RecieveMessage(client);
            }
        }

        private async Task sendClientList()
        {
            while (true) 
            {
             
            }
        }
        private async Task RecieveMessage(Socket client)
        {
            while (!token.IsCancellationRequested)
            {
                byte[] bytes = new byte[1024];
                client.Receive(new ArraySegment<byte>(bytes), SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);
                
                Dispatcher.Invoke(() => MSGlist.Items.Add(message));
            }
        }

        private async Task SendMessage(Socket client, string message)
        {
            if (message == "/disconnect")
            {
                LoginWindow1 main = new LoginWindow1();
                main.Show();
                Close();
            }
            else
            {
                message = $"{DateTime.Now} Сообщение от {LoginWindow1.serverName}: {message}";
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                client.Send(bytes, SocketFlags.None);
                Dispatcher.Invoke(() => MSGlist.Items.Add(message));
                messegeTBX.Clear();
            }
        }
        private void sendBTN_Click(object sender, RoutedEventArgs e)
        {
            string message = messegeTBX.Text;
            foreach (var item in sockets)
            {
                SendMessage(item, message);
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            token.Cancel();
            LoginWindow1 loginWindow = new LoginWindow1();
            loginWindow.Show();
            Close();
        }

        private async Task Log(string message)
        {
            Dispatcher.Invoke(() => LogsPage.Instance.LogList.Items.Add(message));
        }

        private void LogsButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (count == false)
            {
                LogsFrame.Visibility = Visibility.Visible;
                LogsFrame.Content = new LogsPage();
                count = true;
            }
            else
            {
                LogsFrame.Content = null;
                LogsFrame.Visibility = Visibility.Hidden;
                count = false;
            }
        }
        private void TextBox_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            messegeTBX.Text = "";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            token.Cancel();
            LoginWindow1 loginWindow = new LoginWindow1();
            loginWindow.Show();
        }
    }
}
    
