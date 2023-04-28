using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PR6
{

    public partial class TcpClientWindow : Window
    {
        private Socket socket;
        public IPAddress HmmIP;
        private CancellationTokenSource token;
        public TcpClientWindow(IPAddress MyIP)
        {
            InitializeComponent();
            HmmIP = MyIP;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           /* Dispatcher.Invoke(() => users.Items.Add(LoginWindow1.userName));*/
            socket.Connect(HmmIP, 8888);
            token = new CancellationTokenSource();
            Task.Run(() => ReciveMessage());
        }

        private async Task SendMessage(string message)
        {
            if (message == "/disconnect")
            {
                LoginWindow1 main = new LoginWindow1();
                main.Show();
                Close();
            }
            else
            {
                message = $"{DateTime.Now} Сообщение от {LoginWindow1.userName}: {message}";
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                await socket.SendAsync(bytes, SocketFlags.None);
                Dispatcher.Invoke(() => MessegeList.Items.Add(message));
                messegeinput.Clear();
            }
        }
        private async Task ReciveMessage()
        {
           
            while (!token.IsCancellationRequested)
            {
                DateTime now = DateTime.Now;
                byte[] bytes = new byte[1024];
                await socket.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);
                Dispatcher.Invoke(() => MessegeList.Items.Add(message));
            }
        }
        private async Task ListenToClientList()
        {
            var client = await socket.AcceptAsync();
            /*Dispatcher.Invoke(() => users.Items.Add(((IPEndPoint)client.RemoteEndPoint).Address));*/
        }

        private async Task userList()
        {
            while (true)
            {

            }
        }

        private void send(object sender, RoutedEventArgs e)
        {
            string message = messegeinput.Text;
            SendMessage(message);
        }

        private void exitBTN_Click(object sender, RoutedEventArgs e)
        {
            token.Cancel();
            LoginWindow1 loginWindow = new LoginWindow1();
            loginWindow.Show();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            token.Cancel();
            LoginWindow1 loginWindow = new LoginWindow1();
            loginWindow.Show();
        }
    }
}
