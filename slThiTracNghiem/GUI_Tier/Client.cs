using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Business_Tier;

namespace GUI_Tier
{
    public class Client
    {
        B_ServerStatus status = new B_ServerStatus();

        IPEndPoint IP;
        Socket client;
        /// <summary>
        /// kết nối tới server
        /// </summary>
        public bool Connect(string s)
        {
            
            //IP: địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse(s), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            //giả sử connect không được thì cần trycatch
            try
            {
                client.Connect(IP);
                //tạo kết nối xong thì tạo 1 luồng ngồi lắng nghe ngta nói chuyện
                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới Server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// đóng kết nối hiện thời
        /// </summary>
        public void Close_Client()
        {
            try
            {
                //client.Disconnect(false);
                client.Close();
            }
            catch (Exception e)
            {
                return;
            }
        }

        /// <summary>
        /// gửi tin
        /// </summary>
        public void Send(string s)
        {
            try
            {
                if (s!="")
                    client.Send(Serialize(s));
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: /n" + e);
            }
        }

        /// <summary>
        /// nhận tin
        /// </summary>
        void Receive()
        {
            //nếu lỗi thì đóng
            try
            {
                //vòng lặp: nhận tin liên tục || lắng nghe liên tục
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    //phân tích data thành chuỗi
                    string message = (string)Deserialize(data);
                    //MessageBox.Show(message);
                    //add chuỗi vào listview
                    //AddMessage(message);

                }
            }
            catch
            {
                client.Close();
            }
        }

        ///// <summary>
        ///// add message vào khung chat
        ///// </summary>
        ///// <param name="s"></param>
        //void AddMessage(string s)
        //{
        //    lsvMessage.Items.Add(new ListViewItem() { Text = s });
        //    txtMessage.Clear();
        //}

        /// <summary>
        /// phân mảnh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public byte[] Serialize(object obj)
        {
            /*
             *muốn phân mảnh data cần phải có stream: kết nối trực tiếp và
             *format: ghi thông tin gì trên đó
             */

            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            //phân mảnh; obj: giá trị data muốn Serialize, gán obj vào stream
            formatter.Serialize(stream, obj);

            //stream bây giờ sẽ trả ra 1 dãy byte
            return stream.ToArray();
        }

        /// <summary>
        /// gom mảnh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            //trả về 1 object
            return formatter.Deserialize(stream);
        }

        public string Status(int idStatus)
        {
            try
            {
                
                var dt = status.B_getStatusOfServer(idStatus);
                return dt.Rows[0]["STATUS"].ToString();
            }
            catch
            {
                return "";
            }
        }

        public int ServerStatusIs(string stt, int idStatus)
        {
            return status.B_ServerStatusIs(stt, idStatus);
        }
    }

}
