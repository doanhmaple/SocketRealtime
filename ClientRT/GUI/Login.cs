using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using ClientRT.BLL;

namespace ClientRT.GUI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        IPEndPoint ipep;
        TcpClient clt;
        BllClient myUser;
        string keyDangNhap = "kkdf23k5342";
        public static string userName = "";
        public static string password = "";
        public static string ipAddressConnect = "";

        public Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            myUser = new BllClient("aaa", "111");
            textIPAddress.Text = "192.168.13.166";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;
            usNameTxt.Enabled = false;
            passTxt.Enabled = false;
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            string ipAddress = textIPAddress.Text;
            ConnectToServer(ipAddress);
            loginBtn.Enabled = true;
            usNameTxt.Enabled = true;
            passTxt.Enabled = true;
        }

        void ConnectToServer(string address)
        {
            ipep = new IPEndPoint(IPAddress.Parse(address), 3000);
            clt = new TcpClient();
            try
            {
                this.clt.Connect(ipep);
                ipAddressConnect = textIPAddress.Text;
                MessageBox.Show("Kết nối với server thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                connectBtn.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không kết nối với server!", "Lỗi!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(this.Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Receive()
        {
            while (true)
            {
                StreamReader sr = new StreamReader(clt.GetStream());
                string msReceive = sr.ReadLine().ToString();
                if (msReceive.ToUpper().Equals("EXIT"))
                {
                    Application.Exit();
                }
                else if (msReceive == "Dang nhap thanh cong")
                {
                    userName = myUser.name;
                    password = myUser.password;
                    this.Hide();
                    Main formClient = new Main();
                    formClient.ShowDialog();
                    Close();
                    break;
                }
                else if (msReceive == "TK da dang nhap")
                {
                    MessageBox.Show("Tài khoản này đã được đăng nhập ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (msReceive == "Dang nhap that bai")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void sendMessage(string ms)
        {
            try
            {
                myUser.setMessage(ms);
                NetworkStream netStream = clt.GetStream();
                byte[] data = myUser.GetBytes();
                int size = myUser.size;
                byte[] packsize = new byte[2];
                packsize = BitConverter.GetBytes(size);
                netStream.Write(packsize, 0, 2);
                netStream.Write(data, 0, size);
                netStream.Flush();
            }
            catch
            {
                MessageBox.Show("Error login", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string name = usNameTxt.Text;
            string pass = passTxt.Text;
            if (name != "" && pass != "")
            {
                BllClient userSending = new BllClient(name, pass);
                userSending.setMessage("dang_nhap-" + keyDangNhap);
                myUser = userSending;
                myUser.receiveDir = 1;
                sendUserObject(userSending);
            }
            else
            {
                MessageBox.Show("User name or Password are error", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
        
    }
}