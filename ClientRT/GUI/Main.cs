using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using ClientRT.BLL;

namespace ClientRT.GUI
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        IPEndPoint ipep;
        TcpClient clt;
        BllClient myUser;
        List<string> listOnline;
        string keyDangNhap = "kkdf23k5342";

        public Main()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            listOnline = new List<string>();
            this.ConnectToServer(Login.ipAddressConnect);
            string name = Login.userName;
            userLabel.Text = name;
            myUser = new BllClient(name, Login.password);
            loginAgain();
            setUpListView();
        }

        public void setUpListView()
        {
            viewUser.View = View.Details;
            viewUser.Columns.Add("user");
            viewUser.Columns[0].Width = 120;
            setDataListView();
        }

        // Update data list view        
        public void setDataListView()
        {
            viewUser.Items.Clear();
            ListViewItem item1 = new ListViewItem();
            item1.Text = "Server";
            viewUser.Items.Add(item1);
            if (listOnline.Count() != 0)
            {
                foreach (string stringItem in listOnline)
                {
                    if (stringItem != Login.userName)
                    {
                        ListViewItem item2 = new ListViewItem();
                        item2.Text = stringItem;
                        viewUser.Items.Add(item2);
                    }                    
                }                
            }
        }
  
        // kết nối server
        void ConnectToServer(string ipAddress)
        {
            ipep = new IPEndPoint(IPAddress.Parse(ipAddress), 3000);
            clt = new TcpClient();
            try
            {
                // ping tới server
                this.clt.Connect(ipep);
            }
            catch
            {
                // server chưa mở hoặc ping không được thì show lỗi
                MessageBox.Show("Không kết nối với server!", "Lỗi!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // khởi tạo luồng lắng nghe các gói tin
            Thread listen = new Thread(this.Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        // 
        void AddMessage(string ms)
        {
            listView.Items.Add(new ListViewItem() { Text = ms });
            messTxt.Clear();
        }

        // gửi tin nhắn
        void SendMessage(string text)
        {
            if (text.ToUpper().Equals("EXIT"))
            {
                Send("EXIT");
            }
            if (lbSendto.Text != "Server" && text != "")
            {
                Send("SendClient-" + lbSendto.Text + "-" + text);
            }
            else if (text != "")
            {
                Send(text);
            }
            else
            {
                MessageBox.Show("Gửi không thành công", "Lỗi!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private StreamReader getStreamReader()
        {
            while (true)
            {
                StreamReader sr = new StreamReader(clt.GetStream());
                if (sr != null)
                {
                    return sr;
                }
            }
        }

        // gửi gói tin
        public void Send(string ms)
        {
            try
            {
                // gửi dữ liệu ở dạng nhị phân (byte)
                myUser.setMessage(ms);
                NetworkStream netStream = clt.GetStream();
                byte[] data = myUser.GetBytes();
                int size = myUser.size;
                byte[] packsize = new byte[2];
                // convert byte -> string
                packsize = BitConverter.GetBytes(size);
                netStream.Write(packsize, 0, 2);
                netStream.Write(data, 0, size);
                netStream.Flush();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// Nhận gói tin
        void Receive()
        {
            try
            {
                while (true)
                {
                    // đọc dữ liệu
                    StreamReader sr = getStreamReader();
                    string msReceive = sr.ReadLine();
                    if (msReceive != null)
                    {
                        if (msReceive.ToUpper().Equals("EXIT"))
                        {
                            Application.Exit();
                        }
                        if (msReceive.Contains("login"))
                        {
                            listOnline.Clear();
                            string[] mslist = msReceive.Split('-');
                            foreach (string nameItem in mslist)
                            {
                                if (nameItem != "login")
                                {
                                    listOnline.Add(nameItem);
                                }
                            }
                            setDataListView();
                        }
                        else
                        {
                            AddMessage(msReceive);
                        }
                    }
                }
            }
            catch
            {
                Close();
            }
        }
        

        private void sendUserObject(BllClient userSending)
        {
            NetworkStream netStream = clt.GetStream();
            byte[] data = userSending.GetBytes();
            int size = userSending.size;
            byte[] packsize = new byte[2];
            packsize = BitConverter.GetBytes(size);
            netStream.Write(packsize, 0, 2);
            netStream.Write(data, 0, size);
            netStream.Flush();
        }

        private void loginAgain()
        {
            myUser.setMessage("dang_nhap-" + keyDangNhap);
            sendUserObject(myUser);
        }

        private void listUser_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = viewUser.SelectedItems[0]; // chọn user ở listview
            lbSendto.Text = item.SubItems[0].Text; // hiển thị tên user đang chat
            
        }
        // gửi tin
        private void sendBtn_Click(object sender, EventArgs e)
        {
            this.SendMessage(messTxt.Text); // gửi gói tin (tin nhắn)
            AddMessage(messTxt.Text); // hiển thị tin nhắn lên box chat
        }

        private void closed()
        {
            SendMessage("EXIT");
            clt.Close(); // đóng kết nối tcp client
        }

        // đóng Form thì ngắt kết nối tới server
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbSendto.Text = "Server"; // mặc định gửi đến Server
        }
    }
}