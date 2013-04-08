using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;

namespace UDPSerialProxy
{
    public partial class Form1:Form
    {
        private delegate void Delegate_write(string data);

        private bool isUDP2Serial = false;
        private bool isSerial2UDP = false;

        // ソケット生成
        private UdpClient udpClientSender = new UdpClient();
        private UdpClient udpClientReciver;
        private IAsyncResult asyncResult;
        public Form1()
        {
            InitializeComponent();
            setSerialComboBox();
        }

        // 参考
        // http://homepage2.nifty.com/nonnon/SoftSample/CS.NET/SampleUdpIp2.html
        private void Form1_Load(object sender, EventArgs e)
        {
            setIPAddress();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ソケットクローズ
            udpClientSender.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;

            writeUDP(message);

            if (logoutput_checkBox1.Checked)
            {
                // ソケット接続
                string targetIpAddress = targetIPTextBox.Text;
                int targetPort = int.Parse(targetPortTextBox.Text);

                String text = "Send " + targetIpAddress + ":" + targetPort.ToString() + " " + message;

                logTextBox.AppendText(text + "\n");
            }
        }

        private void writeUDP(string text)
        {
            // ソケット接続
            string targetIpAddress = targetIPTextBox.Text;
            int targetPort = int.Parse(targetPortTextBox.Text);
            udpClientSender.Connect(targetIpAddress, targetPort);
            //udpClientSender.Connect("192.168.0.255", 4000);

            String encodeName = Encoding.UTF8.BodyName;
            // ソケット送信
            Byte[] data = Encoding.GetEncoding(encodeName).GetBytes(text);
            udpClientSender.Send(data, data.GetLength(0));

        }

        private void ReceiveCallback(IAsyncResult AR)
        {


            // ソケット受信
            IPEndPoint ipAny = new IPEndPoint(IPAddress.Any, 0);
            Byte[] dat = udpClientReciver.EndReceive(AR, ref ipAny);

            String encodeName = Encoding.UTF8.BodyName;
            String text = Encoding.GetEncoding(encodeName).GetString(dat);
            Invoke(new Delegate_write(writeUDPLog), new Object[] { text });
            // ソケット非同期受信(System.AsyncCallback)
            asyncResult = udpClientReciver.BeginReceive(ReceiveCallback, udpClientReciver);
        }

        private void writeUDPLog(string data)
        {
            if (data != null)
            {
                if (logoutput_checkBox1.Checked)
                {
                    logTextBox.AppendText(data + "\n");
                }
                UDP2Serial(data);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            connectButton.Enabled = false;
            recivePortTextBox.Enabled = false;
            int recivePortText = int.Parse(recivePortTextBox.Text);
            udpClientReciver = new UdpClient(recivePortText);//8989
            // ソケット非同期受信(System.AsyncCallback)
            asyncResult = udpClientReciver.BeginReceive(ReceiveCallback, udpClientReciver);
        }

        private void setIPAddress()
        {

            // ヴァーチャルマシンなどを使っていると、複数のIPAddressを持つ場合があります。
            // 正確でない場合があります。

            int count = 0;
            IPAddress resultIPAddress = null;
            string hostname = Dns.GetHostName();
            IPAddress[] ipAddressList = Dns.GetHostAddresses(hostname);
            foreach (IPAddress ipAddress in ipAddressList)
            {
                if (ipAddress.ToString().Length < 16)
                {
                    resultIPAddress = ipAddress;
                    count++;
                }

            }
            if (count == 0)
            {
                label1.Text = "適切なIPAddressが見つかりませんでした";
            }
            else if (count == 1)
            {
                label1.Text = "IPAddress:" + resultIPAddress.ToString();
            }
            else if (count > 1)
            {
                label1.Text = "複数の16桁未満のIPAddressが見つかりました";
            }


        }
        //////////////////
        /****************************************************************************/
        /*!
         * シリアルポートを選択するComboBoxを作ります。
         * 接続されているポートの名前を取得し、表示します。
         */
        private void setSerialComboBox()
        {
            Console.WriteLine("setSerialComboBox");
            foreach (var portName in SerialPort.GetPortNames())
            {
                portselectComboBox.Items.Add(portName);
            }
            if (portselectComboBox.Items.Count > 0)
            {
                portselectComboBox.SelectedIndex = 0;
                openButton.Enabled = true;
            }


        }
        /****************************************************************************/
        /*!
         * openButtonが押されると実行されます。
         * 接続の分岐をします。
         */
        private void openButton_Click(object sender, EventArgs e)
        {
            if (openButton.Text == "Open")
            {
                serialPortOpen();
                openButton.Text = "Close";
            }
            else
            {
                serialPortClose();
                openButton.Text = "Open";
            }
        }
        /****************************************************************************/
        /*!
         * 接続を開始します。
         */
        private void serialPortOpen()
        {
            string portName = portselectComboBox.SelectedItem.ToString();
            serialPort1.BaudRate = int.Parse(bauRateComboBox.Text);//9600;
            serialPort1.PortName = portName;
            serialPort1.Open();
            writeButton.Enabled = true;
        }
        /****************************************************************************/
        /*!
         * 接続を終了します。
         */
        private void serialPortClose()
        {
            serialPort1.Close();
            writeButton.Enabled = false;
        }
        /****************************************************************************/
        /*!
         * writeButtonが押されると実行されます。
         * serialPort1に送信します。
         */
        private void writeButton_Click(object sender, EventArgs e)
        {
            String text = messageTextBoxSerial.Text;
            writeSerial(text);
        }

        private void writeSerial(string text)
        {
            serialPort1.Write(text);
            if (logoutput_checkBox1.Checked)
            {
                logTextBoxSerial.AppendText("Write : " + text + "\n");
                //Console.WriteLine(text);
                // messageTextBoxをクリア
                messageTextBoxSerial.Text = "";
            }
        }

        /****************************************************************************/
        /*!
         * serialPort1でデータを受信すると実行されます。
         * スレッドが異なるので、Invokeを使う。
         * http://kana-soft.com/tech/sample_0007_4.htm
         */
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 受信したデータ
            string data = serialPort1.ReadLine();
            // 異なるスレッドのテキストボックスに書き込む
            Invoke(new Delegate_write(write), new Object[] { data });

        }

        /****************************************************************************/
        /*!
         * logTextBoxに受信内容を書き込みます。
         */
        private void write(string data)
        {
            if (data != null)
            {
                if (logoutput_checkBox1.Checked)
                {
                    logTextBoxSerial.AppendText("Read : " + data + "\n");
                }
                Serial2UDP(data);
            }
        }

        /****************************************************************************/
        /*!
         * ウィンドウが閉じられる際に実行されます。
         */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // シリアル通信していた場合は、閉じてから終了する
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void U2SButton_Click(object sender, EventArgs e)
        {
            isUDP2Serial = !isUDP2Serial;
            setConvertLabel();
        }
        private void S2UButton_Click(object sender, EventArgs e)
        {
            isSerial2UDP = !isSerial2UDP;
            setConvertLabel();
        }
        private void setConvertLabel()
        {
            if (isUDP2Serial && isSerial2UDP)
            {
                covertLabel.Text = "<< >>";
            }
            else if (isUDP2Serial)
            {
                covertLabel.Text = ">>";
            }
            else if (isSerial2UDP)
            {
                covertLabel.Text = "<<";
            }
            else
            {
                covertLabel.Text = "|";
            }
        }

        private void UDP2Serial(string text)
        {
            if (isUDP2Serial)
            {
                writeSerial(text);
            }

        }
        private void Serial2UDP(string text)
        {
            if (isSerial2UDP)
            {
                writeUDP(text);
            }
        }


    }
}
