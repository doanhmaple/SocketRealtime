using System;
using System.Text;

namespace ClientRT.BLL
{

    public class BllClient
    {
        public string name;
        public int nameSize;
        public string password;
        public int passSize;
        public string status;
        public int statusSize;
        public string address;
        public int addressSize;
        public int size;
        public int messageSize;
        public string message;
        public int receiveDir; //sending is login or client

        public BllClient(string name, string password)
        {
            this.name = name;
            this.status = "Offline";
            this.password = password;
            this.address = "...";
            receiveDir = 0;
        }
        public BllClient(string name)
        {
            this.name = name;
            this.status = "Offline";
            this.address = "...";
            receiveDir = 0;
        }
        public void UpdateStatus(string status)
        {
            this.status = status;
        }
        public void UpdateReceiveDir(int dir)
        {
            this.receiveDir = dir;
        }
        public void UpdateAddress(string adress)
        {
            this.address = adress;
        }
        public void setMessage(string ms)
        {
            this.message = ms;
        }

        public BllClient(byte[] data)
        {
            int place = 0;
            nameSize = BitConverter.ToInt32(data, place);
            place += 4;
            name = Encoding.ASCII.GetString(data, place, nameSize);
            place += nameSize;
            passSize = BitConverter.ToInt32(data, place);
            place += 4;
            password = Encoding.ASCII.GetString(data, place, passSize);
            place += passSize;
            statusSize = BitConverter.ToInt32(data, place);
            place += 4;
            status = Encoding.ASCII.GetString(data, place, statusSize);
            place += statusSize;
            addressSize = BitConverter.ToInt32(data, place);
            place += 4;
            address = Encoding.ASCII.GetString(data, place, addressSize);
            place += addressSize;
            messageSize = BitConverter.ToInt32(data, place);
            place += 4;
            message = Encoding.ASCII.GetString(data, place, messageSize);
            place += messageSize;
            receiveDir = BitConverter.ToInt32(data, place);
        }
        public byte[] GetBytes()
        {
            byte[] data = new byte[1024];
            int place = 0;
            Buffer.BlockCopy(BitConverter.GetBytes(name.Length), 0, data, place, 4);
            place += 4;
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(name), 0, data, place, name.Length);
            place += name.Length;
            Buffer.BlockCopy(BitConverter.GetBytes(password.Length), 0, data, place, 4);
            place += 4;
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(password), 0, data, place, password.Length);
            place += password.Length;
            Buffer.BlockCopy(BitConverter.GetBytes(status.Length), 0, data, place, 4);
            place += 4;
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(status), 0, data, place, status.Length);
            place += status.Length;
            Buffer.BlockCopy(BitConverter.GetBytes(address.Length), 0, data, place, 4);
            place += 4;
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(address), 0, data, place, address.Length);
            place += address.Length;
            Buffer.BlockCopy(BitConverter.GetBytes(message.Length), 0, data, place, 4);
            place += 4;
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(message), 0, data, place, message.Length);
            place += message.Length;
            Buffer.BlockCopy(BitConverter.GetBytes(receiveDir), 0, data, place, 4);
            place += 4;
            size = place;
            return data;
        }
    }
}