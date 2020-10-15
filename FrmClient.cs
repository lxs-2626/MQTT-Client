using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace M2QTT测试
{
    /// <summary>
    /// M2QTT的客户端测试。海宏软件，20191017，整理拼凑的
    /// </summary>
    public partial class FrmClient : Form
    {
        public MqttClient client = null;

        public FrmClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //https://blog.csdn.net/qq_37258787/article/details/80183923
            client = new MqttClient(txtNetIP.Text);
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            client.MqttMsgSubscribed += client_MqttMsgSubscribed;
            client.MqttMsgPublished += client_MqttMsgPublished;
            client.Connect(Guid.NewGuid().ToString().Substring(0,5), "bkeyms", "xf123456");
            //使能所有订阅中的选择框，并使其为未选中状态
            chkaction.Enabled = true;
            chkaction.Checked = false;
            chkdooraction.Enabled = true;
            chkdooraction.Checked = false;
            chkdoorstatus.Enabled = true;
            chkdoorstatus.Checked = false;
            chkgoodsstatus.Enabled = true;
            chkgoodsstatus.Checked = false;
            chkheartbeat.Enabled = true;
            chkheartbeat.Checked = false;
            chkmessage.Enabled = true;
            chkmessage.Checked = false;
            chkopendoor.Enabled = true;
            chkopendoor.Checked = false;
            chksyncstatus.Enabled = true;
            chksyncstatus.Checked = false;
            chksyncdoorstatus.Enabled = true;
            chksyncdoorstatus.Checked = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {   //https://blog.csdn.net/qq_37258787/article/details/80183923
            string buff = textBox2.Text;
            if (client is MqttClient && client.IsConnected)
            {
                client.Publish("xf/cabinet/goods/hardware/20/opendoor", Encoding.UTF8.GetBytes(buff));
                //client.Publish("xf/cabinet/key/hardware/20/synckeystatus",  Encoding.UTF8.GetBytes("{"mainboardno":"1","index":1}"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (client is MqttClient && client.IsConnected)
            {
                client.Disconnect();
            }
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            showInfo("@Receive:" + e.Topic + "->\t" + System.Text.Encoding.UTF8.GetString(e.Message));
        }

        void client_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            // write your code
            showInfo("client_MqttMsgUnsubscribed："+e.MessageId);
        }

        void client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            // write your code
            showInfo("client_MqttMsgSubscribed：" + e.MessageId);
        }

        void client_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            // write your code
            showInfo("client_MqttMsgPublished：" + e.MessageId);
        }



        public delegate void showInfoProc(string sInfo, bool lTime = true);
        private void showInfo(string sInfo, bool lTime = true)
        {
            if (txt_info.InvokeRequired)
            {   //在线程中
                showInfoProc p = new showInfoProc(showInfo);
                txt_info.Invoke(p, sInfo, lTime);
                return;
            }
            if (txt_info == null) return;
            txt_info.AppendText(sInfo + "\r\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
            this.Dispose();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int cheboxSelectCount()
        {
            int count = 0;
            if (chkaction.Checked) count++;
            if (chkdooraction.Checked) count++;
            if (chkdoorstatus.Checked) count++;
            if (chkgoodsstatus.Checked) count++;
            if (chkheartbeat.Checked) count++;
            if (chkmessage.Checked) count++;
            if (chkopendoor.Checked) count++;
            if (chksyncstatus.Checked) count++;
            if (chksyncdoorstatus.Checked) count++;

            return count;
        }
       
        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            //检查共有几个checkbox框被选中
            int chkCount;
            chkCount = cheboxSelectCount();
            if (chkCount <= 0) return;
            string[] topic = new string[chkCount];
            byte[] qosLevels = new byte[chkCount];
            chkCount = 0;
            if (chkaction.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/action";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chkaction.Enabled = false;
                chkaction.Checked = false;
                chkunaction.Enabled = true;
                chkunaction.Checked = true;
            }
            if (chkdooraction.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/dooraction";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chkdooraction.Enabled = false;
                chkdooraction.Checked = false;
                chkundooraction.Enabled = true;
                chkundooraction.Checked = true;
            }
            if (chkdoorstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/doorstatus";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chkdoorstatus.Enabled = false;
                chkdoorstatus.Checked = false;
                chkundoorstatus.Enabled = true;
                chkundoorstatus.Checked = true;
            }
            if (chkgoodsstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/goodsstatus";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chkgoodsstatus.Enabled = false;
                chkgoodsstatus.Checked = false;
                chkungoodsstatus.Enabled = true;
                chkungoodsstatus.Checked = true;
            }
            if (chkheartbeat.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/heartbeat";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chkheartbeat.Enabled = false;
                chkheartbeat.Checked = false;
                chkunheartbeat.Enabled = true;
                chkunheartbeat.Checked = true;
            }
            if (chkmessage.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/message";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chkmessage.Enabled = false;
                chkmessage.Checked = false;
                chkunmessage.Enabled = true;
                chkunmessage.Checked = true;
            }
            if (chkopendoor.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/opendoor";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chkopendoor.Enabled = false;
                chkopendoor.Checked = false;
                chkunopendoor.Enabled = true;
                chkunopendoor.Checked = true;
            }
            if (chksyncstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/syncstatus";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chksyncstatus.Enabled = false;
                chksyncstatus.Checked = false;
                chkunsyncstatus.Enabled = true;
                chkunsyncstatus.Checked = true;
            }
            if (chksyncdoorstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/syncdoorstatus";
                qosLevels[chkCount] = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;
                chkCount++;
                chksyncdoorstatus.Enabled = false;
                chksyncdoorstatus.Checked = false;
                chkunsyncdoorstatus.Enabled = true;
                chkunsyncdoorstatus.Checked = true;
            }
            client.Subscribe(topic, qosLevels);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            //订阅
            chkaction.Enabled = false;
            chkaction.Checked = false;
            chkdooraction.Enabled = false;
            chkdooraction.Checked = false;
            chkdoorstatus.Enabled = false;
            chkdoorstatus.Checked = false;
            chkgoodsstatus.Enabled = false;
            chkgoodsstatus.Checked = false;
            chkheartbeat.Enabled = false;
            chkheartbeat.Checked = false;
            chkmessage.Enabled = false;
            chkmessage.Checked = false;
            chkopendoor.Enabled = false;
            chkopendoor.Checked = false;
            chksyncstatus.Enabled = false;
            chksyncstatus.Checked = false;
            chksyncdoorstatus.Enabled = false;
            chksyncdoorstatus.Checked = false;
            //取消订阅
            chkunaction.Enabled = false;
            chkunaction.Checked = false;
            chkundooraction.Enabled = false;
            chkundooraction.Checked = false;
            chkundoorstatus.Enabled = false;
            chkundoorstatus.Checked = false;
            chkungoodsstatus.Enabled = false;
            chkungoodsstatus.Checked = false;
            chkunheartbeat.Enabled = false;
            chkunheartbeat.Checked = false;
            chkunmessage.Enabled = false;
            chkunmessage.Checked = false;
            chkunopendoor.Enabled = false;
            chkunopendoor.Checked = false;
            chkunsyncstatus.Enabled = false;
            chkunsyncstatus.Checked = false;
            chkunsyncdoorstatus.Enabled = false;
            chkunsyncdoorstatus.Checked = false;
        }
        int uncheboxSelectCount()
        {
            int count = 0;
            if (chkunaction.Checked) count++;
            if (chkundooraction.Checked) count++;
            if (chkundoorstatus.Checked) count++;
            if (chkungoodsstatus.Checked) count++;
            if (chkunheartbeat.Checked) count++;
            if (chkunmessage.Checked) count++;
            if (chkunopendoor.Checked) count++;
            if (chkunsyncstatus.Checked) count++;
            if (chkunsyncdoorstatus.Checked) count++;

            return count;
        }
        private void BtnUnSubscribe_Click(object sender, EventArgs e)
        {
            //检查共有几个checkbox框被选中
            int chkCount;
            chkCount = uncheboxSelectCount();
            if (chkCount <= 0) return;
            string[] topic = new string[chkCount];

            chkCount = 0;
            if (chkunaction.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/action";

                chkCount++;
                chkaction.Enabled = true;
                chkdooraction.Checked = false;
                chkunaction.Enabled = false;
                chkunaction.Checked = false;
            }
            if (chkundooraction.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/dooraction";

                chkCount++;
                chkdooraction.Enabled = true;
                chkdooraction.Checked = false;
                chkundooraction.Enabled = false;
                chkundooraction.Checked = false;
            }
            if (chkundoorstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/doorstatus";

                chkCount++;
                chkdoorstatus.Enabled = true;
                chkdoorstatus.Checked = false;
                chkundoorstatus.Enabled = false;
                chkundoorstatus.Checked = false;
            }
            if (chkungoodsstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/goodsstatus";

                chkCount++;
                chkgoodsstatus.Enabled = true;
                chkgoodsstatus.Checked = false;
                chkungoodsstatus.Enabled = false;
                chkungoodsstatus.Checked = false;
            }
            if (chkunheartbeat.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/heartbeat";

                chkCount++;
                chkheartbeat.Enabled = true;
                chkheartbeat.Checked = false;
                chkunheartbeat.Enabled = false;
                chkunheartbeat.Checked = false;
            }
            if (chkunmessage.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/message";

                chkCount++;
                chkmessage.Enabled = true;
                chkmessage.Checked = false;
                chkunmessage.Enabled = false;
                chkunmessage.Checked = false;
            }
            if (chkunopendoor.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/opendoor";

                chkCount++;
                chkopendoor.Enabled = true;
                chkopendoor.Checked = false;
                chkunopendoor.Enabled = false;
                chkunopendoor.Checked = false;
            }
            if (chkunsyncstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/syncstatus";

                chkCount++;
                chksyncstatus.Enabled = true;
                chksyncstatus.Checked = false;
                chkunsyncstatus.Enabled = false;
                chkunsyncstatus.Checked = false;
            }
            if (chkunsyncdoorstatus.Checked)
            {
                topic[chkCount] = "xf/cabinet/goods/software/syncdoorstatus";

                chkCount++;
                chksyncdoorstatus.Enabled = true;
                chksyncdoorstatus.Checked = false;
                chkunsyncdoorstatus.Enabled = false;
                chkunsyncdoorstatus.Checked = false;
            }
            client.Unsubscribe(topic);
        }

        private void BtnOpenDoor_Click(object sender, EventArgs e)
        {
            string buff="";
            buff = textBox2.Text;
            buff = "";
            buff += "{\"mainboardno\":\"" + txtmainboardno.Text
                 + "\",\"cabinetno\":\"" + txtcabinetno.Text
                 + "\",\"boxno\":" + txtboxno.Text
                 +  ",\"index\":" + txtindex.Text+"}";
            if (client is MqttClient && client.IsConnected)
            {
                client.Publish("xf/cabinet/goods/hardware/"+ txtmainboardno.Text+"/opendoor", Encoding.UTF8.GetBytes(buff));
                //client.Publish("xf/cabinet/key/hardware/20/synckeystatus",  Encoding.UTF8.GetBytes("{"mainboardno":"1","index":1}"));
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheckGoodsStatus_Click(object sender, EventArgs e)
        {
            string buff = "";
            buff += "{\"mainboardno\":\"" + txtmainboardno.Text
                 + "\",\"index\":" + txtindex.Text + "}";
            if (client is MqttClient && client.IsConnected)
            {
                client.Publish("xf/cabinet/goods/hardware/" + txtmainboardno.Text + "/syncstatus", Encoding.UTF8.GetBytes(buff));
                //client.Publish("xf/cabinet/key/hardware/20/synckeystatus",  Encoding.UTF8.GetBytes("{"mainboardno":"1","index":1}"));
            }
        }

        private void BtnCheckDoorStatus_Click(object sender, EventArgs e)
        {
            string buff = "";
            buff += "{\"mainboardno\":\"" + txtmainboardno.Text
                 + "\",\"index\":" + txtindex.Text + "}";
            if (client is MqttClient && client.IsConnected)
            {
                client.Publish("xf/cabinet/goods/hardware/" + txtmainboardno.Text + "/syncdoorstatus", Encoding.UTF8.GetBytes(buff));
                //client.Publish("xf/cabinet/key/hardware/20/synckeystatus",  Encoding.UTF8.GetBytes("{"mainboardno":"1","index":1}"));
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string buff = "";
            buff += "{\"message\":\"" + txtmessage.Text
                 + "\",\"index\":" + txtindex.Text + "}";
            if (client is MqttClient && client.IsConnected)
            {
                client.Publish("xf/cabinet/goods/hardware/" + txtmainboardno.Text + "/message", Encoding.UTF8.GetBytes(buff));
                //client.Publish("xf/cabinet/key/hardware/20/synckeystatus",  Encoding.UTF8.GetBytes("{"mainboardno":"1","index":1}"));
            }
        }
    }


}
