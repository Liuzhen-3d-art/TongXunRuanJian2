using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;

namespace TongXunRuanJian
{
    public partial class Form1 : Form
    {
        Socket socket;
        Socket clientSocket;
        string _nicheng;
        string nichengHeJi;
        string Msg2;
        string MSG3 = " ";
        List<string> nichengList = new List<string>();
        Dictionary<string, Socket> clientList = new Dictionary<string, Socket>();
        Dictionary<string, Socket> clientList2 = new Dictionary<string, Socket>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_QD_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建服务器套接字对象
                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtDK.Text));//创建一个网络节点
                socket.Bind(endPoint);//关联客户端
                socket.Listen(20);//一次性接收20个信息
                Xiaoxi.Text = "服务启动成功！";
                Thread thread = new Thread(TcpAccept);//实时显示客户端线程
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception)
            {

                Xiaoxi.Text = "服务已经开启，请勿重复开启服务！";
            }
        }
        private void TcpAccept()//实时检测客户端并将客户端的发来的消息发到各处客户端中
        {
            try
            {
                while (true)
                {
                    clientSocket = socket.Accept();//创建一个新的套接字专门用于检测客户端连接，这个方法会在没有新客户端连接时处于阻断状态，也就是不会往下执行。

                    Action action1;
                    Thread thread = new Thread(() =>
                {
                    Receive(clientSocket);
                });//专门发送昵称的线程
                    thread.IsBackground = true;//将前台线程设置为后台
                    thread.Start();//开启
 
                    _nicheng = null;
                }
            }
            catch (Exception)
            {
                Action action;
                Xiaoxi.Invoke(action = delegate ()
                {
                    Xiaoxi.Text = "socket协议丢弃成功，已建立新的socket协议！";
                });

            }

        }
        public void FaSongKHDNam()//向客户端发送昵称
        {
            try//防止第一遍启动触发实例异常，因为字符串为空
            {
                this.nichengHeJi = nichengHeJi.Remove(0, nichengHeJi.Length);//每一次新客户端启动后都会先删除字符串再重新加载
            }
            catch (Exception)
            {
                nichengHeJi = null;
            }
            foreach (var item in clientList)
            {

                nichengHeJi+= (item.Key + ":");//获取昵称字符串
            }
            nichengHeJi = "称呼>" + nichengHeJi;//添加一个昵称标识
            foreach (var item in clientList)//遍历所有客户端发送昵称
            {
                
                    clientList[item.Key].Send(Encoding.UTF8.GetBytes(nichengHeJi));//发送昵称
                
            }
        }
        private void Receive(Socket clientScoket)//接收客户端消息
        {
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024 * 2];
                int len = clientScoket.Receive(buffer);
                _nicheng = Encoding.UTF8.GetString(buffer, 0, len);
                MSG3 = _nicheng;
                if (_nicheng.Contains("称呼>"))//如果接收到发送的消息里带有称呼>标识的
                {
                    Action action;
                    listBox1.Invoke(action = delegate ()
                    {
                        listBox1.Items.Clear();//先删除之前所有的内容
                    });
                    _nicheng = _nicheng.Replace("称呼>", "");//找到标识删除它
                    char[] fenGeFu = new[] { ':' };
                    string[] nicheng2 = _nicheng.Split(fenGeFu, StringSplitOptions.RemoveEmptyEntries);//将昵称分开
                    
                    try
                    {
                        nichengList.Add(nicheng2[0]);//将昵称保存到昵称集合中
                        clientList.Add(nicheng2[0], clientSocket);//保存客户端
                    }
                    catch (Exception)
                    {
                        nichengList.Clear();
                        nichengList.Add(nicheng2[0]);//将昵称保存到昵称集合中
                        clientList.Clear();
                        clientList.Add(nicheng2[0], clientSocket);
                    }
                    Action action3;
                    listBox1.Invoke(action3 = delegate ()
                    {
                        foreach (var item in nichengList)//将存有昵称的数组中的每一个昵称填装到客户端好友栏里
                        {
                            
                            listBox1.Invoke(action = delegate () { listBox1.Items.Add(item); });
                            Thread thread2 = new Thread(FaSongKHDNam);//专门发送昵称的线程
                            thread2.IsBackground = true;//将前台线程设置为后台
                            thread2.Start();//开启
                        }
                    });
                   
                }
                if (_nicheng.Contains("APP_SHUTDOWN_REQUESTED"))
                {

                    char[] Stp = new[] { ':' };
                    string[] Str = _nicheng.Split(Stp, StringSplitOptions.RemoveEmptyEntries);
                    string nicheng1 = Str[1];
                    nicheng1 = nicheng1.TrimStart();
                    //clientList[nicheng1].Disconnect(false);
                    Action action;
                    Xiaoxi.Invoke(action = delegate ()
                    {
                        Xiaoxi.Text = nicheng1;
                    });
                    Action action3;
                    txtTx.Invoke(action3 = delegate ()
                    {
                        txtTx.AppendText($"要删除的名字是:{nicheng1}");
                    });


                    if (_nicheng != null)
                    {
                        clientList2.Clear();
                        foreach (var item in clientList)
                        {
                            if (item.Key != nicheng1)
                            {
                                clientList2.Add(item.Key, item.Value);
                            }
                        }

                        nichengList.Remove(nicheng1);
                        Action action4;
                        listBox1.Invoke(action4 = delegate ()
                        {
                            listBox1.Items.Remove(nicheng1);
                        });
                        clientList.Clear();
                        foreach (var item in clientList2)
                        {
                            clientList.Add(item.Key, item.Value);
                        }
                        _nicheng = null;
                        FaSongKHDNam();
                    }
                }
                //if (_nicheng.Contains("称呼>")==false|| _nicheng.Contains("APP_SHUTDOWN_REQUESTED")==false)
                //{
                    foreach (var item in clientList)
                    {
                        item.Value.Send(Encoding.UTF8.GetBytes(MSG3));//发送消息

                    }
                    Action action2;
                    txtTx.Invoke(action2 = delegate ()//在消息框中显示出来
                    {
                        char[] Stp = new[] { ':' };
                        string[] Str = MSG3.Split(Stp, StringSplitOptions.RemoveEmptyEntries);

                        txtTx.AppendText(Msg2 + "\r\n");

                    });

                    //Msg2 = null;







                //}
            }
        }
        private void Btn_FS_Click(object sender, EventArgs e)
        {
        }
    }
}
