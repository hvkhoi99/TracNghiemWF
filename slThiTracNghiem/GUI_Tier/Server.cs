using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Entities;
using Business_Tier;

namespace GUI_Tier
{
    public class Server
    {
        B_KetQua B_KQ = new B_KetQua();
        KetQua kqt;
        Client cli = new Client();

        IPEndPoint IP;
        Socket server;
        //danh sách lưu trữ tất cả các client kết nối tới server
        List<Socket> clientList;

        /// <summary>
        /// kết nối tới server
        /// </summary>
        public void Connect()
        {
            clientList = new List<Socket>();
            //IP: địa chỉ của server
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            //đợi
            server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            server.Bind(IP);

            //client nào nch với server?
            Thread Listen = new Thread(() =>
            {
                //thêm trycatch đề phòng server chết
                try
                {
                    //lắng nghe nhiều thằng cho vào while
                    while (true)
                    {
                        //100 client đang đợi server chấp nhận?
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    //nếu 1 client đóng thì bên trên sẽ bị vòng lặp liên tục, nên:
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        public void Close_Server()
        {
            try
            {
                if (cli.ServerStatusIs("The Server is off...", 1) == 1)
                {
                    server.Close();
                }
            }
            catch
            {
                //MessageBox.Show("" + e);
                return;
            }
        }

        ///// <summary>
        ///// gửi tin
        ///// </summary>
        //void Send(Socket client, string s)
        //{
        //    if (client != null && s != "")
        //        client.Send(Serialize(s));
        //}

        //public void SendMess(string s)
        //{
        //    //gửi cho các client
        //    foreach (Socket item in clientList)
        //    {
        //        //send cho thằng nào?
        //        Send(item, s);
        //    }

        //}

        /// <summary>
        /// nhận tin
        /// </summary>
        void Receive(object obj)
        {
            Socket client = obj as Socket;
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


                    //123,hvk,mt,10,10/03/1999
                    ChuoiNhan(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        void ShowMess(string s)
        {
            MessageBox.Show(s);
        }

        /// <summary>
        /// phân mảnh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        byte[] Serialize(object obj)
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
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            //trả về 1 object
            return formatter.Deserialize(stream);
        }

        void ChuoiNhan(string s)
        {
            string txtMessage = s.Trim();

            int i;
            int TrangDau = 0;
            int TrangCuoi = 0;
            int DaiChuoi = s.Length;

            //Tim khoang trang dau tien
            for (i = 0; i < txtMessage.Length; i++)
            {
                if (txtMessage.Substring(i, 1) == ",")
                {
                    TrangDau = i;
                    break;
                }
            }

            //tim khoang trang cuoi cung
            for (i = txtMessage.Length; i > 0; i--)
            {
                if (txtMessage.Substring(i - 1, 1) == ",")
                {
                    TrangCuoi = i - 1;
                    break;
                }
            }

            //lay ho
            string ho;
            if (TrangDau > 0)
                ho = txtMessage.Substring(0, TrangDau).ToString();
            else ho = "";

            //lay chu lot
            string chulot1;
            if (TrangCuoi - TrangDau - 1 > 0)
                chulot1 = txtMessage.Substring(TrangDau + 1, TrangCuoi - TrangDau - 1).ToString();
            else chulot1 = "";

            //lay ten
            string ten;
            if (TrangCuoi > 0)
                ten = txtMessage.Substring(TrangCuoi + 1, DaiChuoi - TrangCuoi - 1).ToString();
            else ten = "";

            //***************************************************************

            string chulot = chulot1.Trim();

            int j;
            int TrangDauLot = 0;
            int TrangCuoiLot = 0;
            int DaiChuoiLot = chulot1.Length;

            //Tim khoang trang dau tien
            for (j = 0; j < chulot.Length; j++)
            {
                if (chulot.Substring(j, 1) == ",")
                {
                    TrangDauLot = j;
                    break;
                }
            }

            //tim khoang trang cuoi cung
            for (j = chulot.Length; j > 0; j--)
            {
                if (chulot.Substring(j - 1, 1) == ",")
                {
                    TrangCuoiLot = j - 1;
                    break;
                }
            }

            //lay ho
            string lotdau;
            if (TrangDauLot > 0)
                lotdau = chulot.Substring(0, TrangDauLot).ToString();
            else lotdau = "";

            //lay chu lot
            string lotgiua;
            if (TrangCuoiLot - TrangDauLot - 1 > 0)
                lotgiua = chulot.Substring(TrangDauLot + 1, TrangCuoiLot - TrangDauLot - 1).ToString();
            else lotgiua = "";

            //lay ten
            string lotcuoi;
            if (TrangCuoiLot > 0)
                lotcuoi = chulot.Substring(TrangCuoiLot + 1, DaiChuoiLot - TrangCuoiLot - 1).ToString();
            else lotcuoi = "";
            LuuLaiKetQua(ho, lotdau, lotgiua, Convert.ToDouble(lotcuoi), ten);
        }



        void LuuLaiKetQua(string mssv, string ten, string mamonthi, double diem, string dateThi)
        {
            kqt = new KetQua(mssv, ten, mamonthi, diem, dateThi);
            if (B_KQ.LuuKetQua_B(kqt) > 0)
            {
                MessageBox.Show("Thí sinh " + kqt.TenThiSinh + " Thi Được : " + kqt.Diem + " Điểm!", "Kết Quả Thi!");
            }
            else
            {
                MessageBox.Show("Lỗi Lưu Kết Quả Khi Nhận Từ Client!", "Thông Báo!");
            }
        }
    }
}
