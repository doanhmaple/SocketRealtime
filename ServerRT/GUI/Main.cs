using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using ServerRT.BLL;

namespace ServerRT.GUI
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {

        IPEndPoint ipep;
        TcpListener server;
        List<TcpClient> clientList;
        List<BllServer> listUser;
        string keyDangNhap = "kkdf23k5342";
        //string password = "123";

        public Main()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            listUser = new List<BllServer>();
            ListenConnect();
            setDataClient();
            setUpListView();
        }

        public void setDataClient()
        {
            listUser.Add(new BllServer("tam", "123"));
            listUser.Add(new BllServer("thanh", "123"));
            listUser.Add(new BllServer("doanh", "123"));
        }
        // vẽ cột
        public void setUpListView()
        {
            clientView.View = View.Details;
            clientView.Columns.Add("user");
            clientView.Columns.Add("ip");
            clientView.Columns.Add("status");
            clientView.Columns[0].Width = 90;
            clientView.Columns[1].Width = 130;
            clientView.Columns[2].Width = 70;

            setDataListView();
        }
        

        public void setDataListView()
        {
            clientView.Items.Clear();
            int countOnline = 0;
            // hiển thị danh sách client
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "ALL";
            clientView.Items.Add(lvi);
            foreach (BllServer userItem in listUser)
            {
                ListViewItem lv2 = new ListViewItem();
                lv2.Text = userItem.name;
                lv2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = userItem.address });
                lv2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = userItem.status });
                clientView.Items.Add(lv2);
                if (userItem.status == "Online")
                {
                    countOnline++;
                }
            }
            usOnl.Text = "Client Online: " + countOnline.ToString();
        }

        // lắng nghe kết nối từ phía Client
        void ListenConnect()
        {
            ipep = new IPEndPoint(IPAddress.Any, 3000);
            server = new TcpListener(ipep);
            server.Start();
            clientList = new List<TcpClient>();
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        TcpClient client = server.AcceptTcpClient();
                        clientList.Add(client);
                        Thread thReceive = new Thread(Receive);
                        thReceive.IsBackground = true;
                        thReceive.Start(client);
                    }
                }
                catch
                {
                    ipep = new IPEndPoint(IPAddress.Any, 3000);
                    server = new TcpListener(ipep);
                }

            });
            listen.IsBackground = true;
            listen.Start();
        }

        void AddMessage(string ms)
        {
            listView.Items.Add(new ListViewItem() { Text = ms });
        }
        
        // gửi tin
        void SendMessage(TcpClient client, String message)
        {
            StreamWriter sw = new StreamWriter(client.GetStream());
            if (message != "")
            {
                sw.WriteLine(message);
                sw.Flush();
            }
        }
        void SendListOnline()
        {
            string stringNameOnline = "";
            foreach (BllServer userItem in listUser)
            {
                if (userItem.status == "Online")
                {
                    stringNameOnline += "-" + userItem.name;
                }
            }
            sendToClient("ALL", "login" + stringNameOnline);
        }

        // nhận tin
        void Receive(Object obj)
        {
            TcpClient client = obj as TcpClient;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    NetworkStream ns = client.GetStream();
                    byte[] size = new byte[2];
                    int recv = ns.Read(size, 0, 2);
                    int packsize = BitConverter.ToInt16(size, 0);
                    recv = ns.Read(data, 0, packsize);
                    BllServer userReceive = new BllServer(data);
                    if (userReceive.message == "dang_nhap-" + keyDangNhap) // kiểm tra đăng nhập
                    {
                        int count = 0;
                        foreach (BllServer item in listUser)
                        {
                            if (userReceive.name == item.name && userReceive.password == item.password)
                            {
                                if (userReceive.receiveDir == 1)
                                {
                                    if (item.status == "Online")
                                    {
                                        SendMessage(client, "TK da dang nhap");
                                        break;
                                    }
                                    SendMessage(client, "Dang nhap thanh cong");
                                    client.Close();
                                }
                                else
                                {
                                    string ip = ((IPEndPoint)client.Client.RemoteEndPoint).ToString();
                                    item.address = ip;
                                    item.status = "Online";
                                    SendListOnline();
                                }
                                setDataListView();
                                break;
                            }
                            count++;
                        }
                        if (count == listUser.Count())
                        {
                            SendMessage(client, "Dang nhap that bai");
                        }
                    }
                    else if (userReceive.message.Contains("SendClient"))
                    {
                        string[] arrayString = userReceive.message.Split('-');
                        string messageSendToClient = userReceive.name + " Send to you: " + arrayString[2];
                        string messageSaveInServer = userReceive.name + " Send to " + arrayString[1] + ": " + arrayString[2];
                        AddMessage(messageSaveInServer);
                        sendToClient(arrayString[1], messageSendToClient);
                    }
                    else if (userReceive.message.ToUpper().Equals("EXIT"))
                    {
                        foreach (BllServer userItem in listUser)
                        {
                            if (userItem.name == userReceive.name)
                            {
                                RemoveClientConnect(userReceive.address);
                                userItem.address = "...";
                                userItem.status = "Offline";
                                setDataListView();
                                SendListOnline();
                                break;
                            }
                        }
                    }
                    else if (userReceive.message != "")
                    {
                        // hiển thị user nào đang gửi tin tới
                        AddMessage(userReceive.name + ": " + userReceive.message);
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
        // đóng kết nối client
        private void RemoveClientConnect(string ipAddressRemove)
        {
            foreach (TcpClient itemConnect in clientList)
            {
                string ipClient = ((IPEndPoint)itemConnect.Client.RemoteEndPoint).ToString();
                if (ipClient == ipAddressRemove)
                {
                    clientList.Remove(itemConnect);
                    itemConnect.Close();
                }
            }
        }
        // gửi gói tin tới cho client
        private void sendToClient(string nameUser, string ms)
        {
            BllServer UserSending = listUser.Find(x => x.name == nameUser);
            if (nameUser != "ALL") // Gửi ALL cố định
            {
                foreach (TcpClient clientItem in clientList)
                {
                    string ipClient = ((IPEndPoint)clientItem.Client.RemoteEndPoint).ToString();
                    if (ipClient == UserSending.address)
                    {
                        this.SendMessage(clientItem, ms);
                    }
                }
            }
            else
            {
                foreach (TcpClient item in clientList)
                {
                    this.SendMessage(item, ms);
                }
            }
            AddMessage(messTxt.Text);
            messTxt.Clear();
        }

        private void addUserItem_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.Show();
        }

        private void clientView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = clientView.SelectedItems[0];
            lbSend.Text = item.SubItems[0].Text;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string nameSending = lbSend.Text;

            sendToClient(nameSending, messTxt.Text);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            sendToClient("ALL", "EXIT");
            this.closed();
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendToClient("ALL", "EXIT");
            this.closed();
            Application.Exit();
        }
        // dừng kết nối server
        private void closed()
        {
            server.Stop();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbSend.Text = "ALL";
        }
    }
}