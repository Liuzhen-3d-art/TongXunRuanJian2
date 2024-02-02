using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongXunRuanJian_KeHU
{
    public partial class Form1 : Form
    {
        int jishu = 0;
        public Socket socket;
        public EndPoint endPoint;
        string shuju;
        string[] nicheng2;


        string msg;
        public Form1()
        {
            InitializeComponent();
            Thread thread5 = new Thread(() => { this.FormClosing += Form1_FormClosing; });
            thread5.Start();
           
            int cishu = GetCiShu();
            string NiCheng = SuiJiNiCHeng(cishu);
            txtNC.AppendText(NiCheng);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtNC+":APP_SHUTDOWN_REQUESTED");//发送关闭程序代码
            socket.Send(buffer);//发送这个byte数组
            socket.Disconnect(true);
            Thread thread5 = new Thread(GuanBi);
            thread5.IsBackground = true;
            thread5.Start();

        }

        private void GuanBi()
        {
            while (true)
            {
                if (socket!=null)
                {
                    socket.Close();
                    break;
                }

              
            }
        }
        private string SuiJiNiCHeng(int cishu)
        {
            string jieguo=null;
            char[] hanzi = {'终', '国', '人', '民', '雅','和', '银', '霍', '家', '爱', '呼', '金', '廖', '顾', '罗', '洛', '络', '神', '伸', '美',
'那', '来', '霉', '梅', '徐', '瑟', '塞', '怀', '胡', '能', '恒', '横', '菊', '居', '多',
'少', '好','玩', '乐', '飞',};
            char[] xing = { '赵', '钱', '孙', '李', '周', '吴', '郑', '王', '冯', '陈', '褚', '卫', '蒋', '沈', '韩', '杨', '朱', '秦', '尤', '许', '何', '吕', '施', '张', '孔', '曹', '严', '华', '金', '魏', '陶', '姜', '戚', '谢', '邹', '喻', '柏', '水', '窦', '章', '云', '苏', '潘', '葛', '奚', '范', '彭', '郎', '鲁', '韦', '昌', '马', '苗', '凤', '花', '方', '俞', '任', '袁', '柳', '酆', '鲍', '史', '唐', '费', '廉', '岑', '薛', '雷', '贺', '倪', '汤', '滕', '殷', '罗', '毕', '郝', '邬', '安', '常', '乐', '于', '时', '傅', '皮', '卞', '齐', '康', '伍', '余', '元', '卜', '顾', '孟', '平', '黄', '和', '穆', '萧', '尹' };
            List<char> SiShiHanZi = new List<char>(hanzi);
            List<char> xingbie = new List<char>(xing);
            Random random = new Random();
            for (int i = 0; i < cishu; i++)
            {
                if (i == 0)
                {
                    int xingIndex = random.Next(0, xingbie.Count);
                    jieguo += xingbie[xingIndex];
                }
                if (i > 0)
                {
                    int index = random.Next(0, SiShiHanZi.Count);
                    jieguo += SiShiHanZi[index];
                }
            }
            return jieguo;
          

        }
        private int GetCiShu()
        {
            Random random = new Random();
             int cishu=  random.Next(2, 4);
            return cishu;
        }

        private void btn_QD_Click(object sender, EventArgs e)
        {

                jishu++;
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                endPoint=new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtDK.Text));

                socket.Connect(endPoint);
                byte[] nicheng = Encoding.UTF8.GetBytes("称呼>" + txtNC.Text);//获取昵称
                socket.Send(nicheng);//将昵称发送给服务器
                Xiaoxi.Text = "与服务器建立连接成功！";

                Thread thread = new Thread(new ThreadStart(JieSHouJIanCe));
                thread.IsBackground = true;
                thread.Start();
            if (nicheng2 != null)
            {
                Thread thead2 = new Thread(HaoYouListJianCe);
                thead2.IsBackground = true;
                thead2.Start();
            }


            if (jishu > 1)
                {
                    Xiaoxi.Text = "为避免出现连接故障，请勿多次点击连接传送！";
                    jishu = 0;

                }
            
        }
        private void HaoYouListJianCe()
        {
            int i = 0;
            while (true)
            {
                lock (_obj)
                {
                    foreach (var item in HaoYoulist.Items)
                    {
                        string abc = (string)item;
                        if (abc != nicheng2[i])
                        {
                            HaoYoulist.Items.Remove(item);
                            HaoYoulist.Items.Add(nicheng2[i]);
                        }
                        i++;
                    }
                }
                i = 0;
            }
        }
        private void btn_Fs_Click(object sender, EventArgs e)//发送消息
        {
            //var clientListName = HaoYoulist.SelectedItem.ToString();
            if (txtFS.Text != null)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(txtNC.Text+":"+txtFS.Text);//将需要发送的消息变成Byte数组
                socket.Send(buffer);//发送这个byte数组
            }

        }
        private static readonly object _obj = new object();
        private void JieSHouJIanCe()//接受消息
        {
           
                while (true || msg != null)
                {
                    byte[] huancun = new byte[1024 * 1024 * 2];
                    int shijichangdu = socket.Receive(huancun);
                    msg = Encoding.UTF8.GetString(huancun, 0, shijichangdu);

                    if (msg.Contains("称呼>"))//如果接收到发送的消息里带有称呼>标识的
                    {
                        Action action;
                        msg = msg.Replace("称呼>", "");//找到标识删除它
                        char[] fenGeFu = new[] { ':' };
                        /*string[] */
                        nicheng2 = msg.Split(fenGeFu, StringSplitOptions.RemoveEmptyEntries);//将昵称分开
                                                                                             //foreach (var item in nicheng2)
                                                                                             //{
                                                                                             //    nicheng3.Add(item);
                                                                                             //}
                        HaoYoulist.Invoke(action = delegate ()
                        {
                            HaoYoulist.Items.Clear();//先删除之前所有的内容
                        });

                    lock (_obj)
                    {
                        for (int i = 0; i < nicheng2.Length; i++)
                        {
                            string bba = nicheng2[i] + nicheng2[0];
                            if (nicheng2[i] != bba)
                            {

                                if (HaoYoulist.Items.Contains(nicheng2[i]) == false)
                                {
                                    Action action3;
                                    HaoYoulist.Invoke(action3 = delegate () { HaoYoulist.Items.Add(nicheng2[i]); });

                                }

                            }
                        }

                    }


                    Action action2;
                    if (msg.Contains("称呼>") == false && msg.EndsWith(":") == false)//屏蔽带有昵称标识和结尾带：的消息
                    {
                        txtMsg.Invoke(action2 = delegate//如果收到的满足以上条件就开始将消息显示到本地消息栏中。
                        {
                            txtMsg.AppendText($"{msg}\t{DateTime.Now}\r\n");
                        });

                    }

                }
            }


        }






    }
}
