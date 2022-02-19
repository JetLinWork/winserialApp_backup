using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Threading;
using TextBox = System.Windows.Controls.TextBox;
using MessageBox = System.Windows.MessageBox;
using Application = System.Windows.Application;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class Window1 : Window
    {

    }

    public partial class Window2 : Window
    {

    }

    public partial class MainWindow : Window
    {
        public Window1 autoset1 = new Window1();
        public Window2 autoset2 = new Window2();
        public List<TextBox> TboxList = new List<TextBox>();
        public List<byte> RgList = new List<byte>();
        public List<byte> AtList = new List<byte>();
        public SerialPort _serialPort = new SerialPort();

        public void TboxListInit()
        {
            TboxList.Add(DR1);
            TboxList.Add(DR2);
            TboxList.Add(DR3);
            TboxList.Add(DR4);
            TboxList.Add(DR5);
            TboxList.Add(DR6);
            TboxList.Add(DR7);
            TboxList.Add(DR8);
            TboxList.Add(DR9);
            TboxList.Add(DR10);
            TboxList.Add(DR11);
            TboxList.Add(DR12);
            TboxList.Add(DR13);
            TboxList.Add(DR14);
            TboxList.Add(DR15);
            TboxList.Add(DR16);
            TboxList.Add(DR17);
            TboxList.Add(DR18);
            TboxList.Add(DR19);
            TboxList.Add(DR20);
            TboxList.Add(DR21);
            TboxList.Add(DR22);
            TboxList.Add(DR23);
            TboxList.Add(DR24);
            TboxList.Add(DR25);
            TboxList.Add(DR26);
            TboxList.Add(DR27);
            TboxList.Add(DR28);
            TboxList.Add(DR29);
            TboxList.Add(DR30);
            TboxList.Add(DR31);
            TboxList.Add(DR32);
            TboxList.Add(DR33);
            TboxList.Add(DR34);
            TboxList.Add(DR35);
            TboxList.Add(DR36);
            TboxList.Add(DR37);
            TboxList.Add(DR38);
            TboxList.Add(DR39);
            TboxList.Add(DR40);
            TboxList.Add(DR41);
            TboxList.Add(DR42);
            TboxList.Add(DR43);
            TboxList.Add(DR44);
            TboxList.Add(DR45);
            TboxList.Add(DR46);
            TboxList.Add(DR47);
            TboxList.Add(DR48);
            TboxList.Add(DR49);
            TboxList.Add(DR50);
            TboxList.Add(DR51);
            TboxList.Add(DR52);
            TboxList.Add(DR53);
            TboxList.Add(DR54);
            TboxList.Add(DR55);
            TboxList.Add(DR56);
            TboxList.Add(autoset1.DAutoKeyDown);
            TboxList.Add(autoset1.DAutoKeyUp);  //Delta 58 textbox data 
            TboxList.Add(IR1);
            TboxList.Add(IR2);
            TboxList.Add(IR3);
            TboxList.Add(IR4);
            TboxList.Add(IR5);
            TboxList.Add(IR6);
            TboxList.Add(IR7);
            TboxList.Add(IR8);
            TboxList.Add(IR9);
            TboxList.Add(IR10);
            TboxList.Add(IR11);
            TboxList.Add(IR12);
            TboxList.Add(IR13);
            TboxList.Add(IR14);
            TboxList.Add(IR15);
            TboxList.Add(IR16);
            TboxList.Add(IR17);
            TboxList.Add(IR18);
            TboxList.Add(IR19);
            TboxList.Add(IR20);
            TboxList.Add(IR21);
            TboxList.Add(IR22);
            TboxList.Add(IR23);
            TboxList.Add(IR24);
            TboxList.Add(IR25);
            TboxList.Add(IR26);
            TboxList.Add(IR27);
            TboxList.Add(IR28);
            TboxList.Add(IR29);
            TboxList.Add(IR30);
            TboxList.Add(IR31);
            TboxList.Add(IR32);
            TboxList.Add(IR33);
            TboxList.Add(IR34);
            TboxList.Add(IR35);
            TboxList.Add(IR36);
            TboxList.Add(IR37);
            TboxList.Add(IR38);
            TboxList.Add(IR39);
            TboxList.Add(IR40);
            TboxList.Add(IR41);
            TboxList.Add(IR42);
            TboxList.Add(IR43);
            TboxList.Add(IR44);
            TboxList.Add(IR45);
            TboxList.Add(IR46);
            TboxList.Add(IR47);
            TboxList.Add(IR48);
            TboxList.Add(IR49);
            TboxList.Add(IR50);
            TboxList.Add(IR50);
            TboxList.Add(IR51);
            TboxList.Add(IR52);
            TboxList.Add(IR53);
            TboxList.Add(IR54);
            TboxList.Add(IR55);
            TboxList.Add(IR56);
            TboxList.Add(autoset2.IAutoKeyDown);
            TboxList.Add(autoset2.IAutoKeyUp);      //Invert 58 textbox data 
            TboxList.Add(t_IPAddr);
            TboxList.Add(t_DevID);
            TboxList.Add(t_AuthInfo);
            TboxList.Add(t_ProductID);
        }

        public MainWindow()
        {
            InitializeComponent();
            TboxListInit();

            string[] ports = SerialPort.GetPortNames();     //get PC serriralport
            for (int index = 0; index < ports.Length; index++)
            {
                cb_SerialPortNumber.Items.Add(ports[index]);    //add exist seriralport to list
                cb_SerialPortNumber.SelectedIndex = index; 
            }
            StopSend.IsEnabled = false;
            cb_BaudRate.IsEnabled = false;
            cb_Check.IsEnabled = false;
            cb_DataBits.IsEnabled = false;
            cb_StopBits.IsEnabled = false;
            bt_ProductID.IsEnabled = false;
            bt_AuthInfo.IsEnabled = false;
            bt_ParaSet.IsEnabled = false;
            DevRestart.IsEnabled = false;
            DevFacReset.IsEnabled = false;
            bt_IPAddr.IsEnabled = false;
            bt_DevID.IsEnabled = false;
            t_APP_BIN.IsEnabled = false;
            bt_APP_BIN.IsEnabled = false;
            bt_APP_DOWNLOAD.IsEnabled = false;
            ParaDataFormat.packetID = 0;
            ParaDataFormat.PLCType = 0;
            ParaDataFormat.TotalNum = 0;

            try
            {
                FileStream ConfigFile = new FileStream("Config.ini", FileMode.Open);
                StreamReader sr = new StreamReader(ConfigFile);
                sr.ReadLine();
                for (int i = 0; i < 58; i++)
                {
                    TextBox temp = TboxList[i];
                    temp.Text = sr.ReadLine();
                }
                sr.ReadLine();
                for (int i = 58; i < 117; i++)
                {
                    TextBox temp = TboxList[i];
                    temp.Text = sr.ReadLine();
                }
                sr.ReadLine();
                for (int i = 117; i < TboxList.Count; i++)
                {
                    TextBox temp = TboxList[i];
                    temp.Text = sr.ReadLine();
                }
                sr.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show("请先保存或导入配置文件"); }
            catch (IOException ex) { MessageBox.Show("File ERR:" + ex.ToString()); }
           
        }
        public void initialize()
        {
            try
            {
                _serialPort.PortName = cb_SerialPortNumber.SelectedItem.ToString();
                ComboBoxItem seletedItem = (ComboBoxItem) cb_BaudRate.SelectedItem;
                _serialPort.BaudRate = Convert.ToInt32(seletedItem.Content.ToString());
                _serialPort.DataBits = 8;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Parity = Parity.None;
            }
            catch (System.IO.IOException) { MessageBox.Show("System.IO.IOException"); }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("ArgumentOutOfRangeException"); }
            catch (InvalidOperationException) {  }
            catch (ArgumentNullException) { MessageBox.Show("ArgumentNullException"); }

        }

        private void ClearReceiveData_Click(object sender, RoutedEventArgs e)
        {
            tb_receiveData.Text = "";
        }

        private void bt_SerialSwitch_Click(object sender, RoutedEventArgs e)
        {
            initialize();
            string strContent =  bt_SerialSwitch.Content.ToString();
            if (strContent == "打开串口")
            {
                try
                {
                    _serialPort.Open();
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    //_serialPort.DataReceived += DataReceivedHandler;
                    bt_SerialSwitch.Content = "关闭串口";
                    tb_switchStatus.Text = "串口为打开状态";
                    tb_ResultData.Text = "请选择PLC类型，设置PLC寄存器列表，设置自动按键键值；\n注：PLC寄存器列表读取至第一个未填写寄存器，自定义寄存器选填；";
                    //ManulSend.IsEnabled = true;
                    StopSend.IsEnabled = true;
                    e_status.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));

                    cb_SerialPortNumber.IsEnabled = false;
                    PortRefresh.IsEnabled = false;
                    bt_ParaSet.IsEnabled = true;
                    DevRestart.IsEnabled = true;
                    DevFacReset.IsEnabled = true;
                    bt_IPAddr.IsEnabled = true;
                    bt_DevID.IsEnabled = true;
                    bt_AuthInfo.IsEnabled = true;
                    bt_ProductID.IsEnabled = true;
                    bt_APP_BIN.IsEnabled = true;
                }
                catch(IOException){ MessageBox.Show("串口打开失败，串口被关闭！"); }
                catch(UnauthorizedAccessException) { MessageBox.Show("打开串口失败，请检查串口是否被占用！"); }
                catch (ArgumentOutOfRangeException) { MessageBox.Show("ArgumentOutOfRangeException"); }
                catch (ArgumentException) { MessageBox.Show("ArgumentException"); }
                catch (InvalidOperationException) { MessageBox.Show("InvalidOperationException"); }
            }
            else
            {
                try
                {
                    _serialPort.DataReceived -= DataReceivedHandler;
                    _serialPort.Close();
                    bt_SerialSwitch.Content = "打开串口";
                    tb_switchStatus.Text = "串口为关闭状态";
                    tb_ResultData.Text = "请先打开串口";
                    e_status.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                    StopSend.IsEnabled = false;
                    cb_SerialPortNumber.IsEnabled = true;
                    PortRefresh.IsEnabled = true;
                    bt_ParaSet.IsEnabled = false;
                    DevRestart.IsEnabled = false;
                    DevFacReset.IsEnabled = false;
                    bt_IPAddr.IsEnabled = false;
                    bt_DevID.IsEnabled = false;
                    bt_AuthInfo.IsEnabled = false;
                    bt_ProductID.IsEnabled = false;
                    bt_APP_BIN.IsEnabled = false;
                    bt_APP_DOWNLOAD.IsEnabled = false;
                }
                catch (System.IO.IOException) { MessageBox.Show("System.IO.IOException"); }
            }
        }

        public class OTA_FUNC
        {
            public byte[] reader { get; set; }
            public long FileLength { get; set; }
            public int OTA_Flag { get; set; }
            public byte CRC16H { get; set; }
            public byte CRC16L { get; set; }
            public int N_OFFSET { get; set; }
            public List<byte> OTA_BUFF;
            public List<byte> send_buf;
            public OTA_FUNC()
            {
                reader = new byte[1024 * 1024];            //1MB Bin Storege space
                FileLength = 0;
                OTA_Flag = 0;
                OTA_BUFF = new List<byte>();
                send_buf = new List<byte>();
                CRC16H = 0;
                CRC16L = 0;
                N_OFFSET = 0;
            }

            private void CRC16(List<byte> RawData, int len)
            {
                byte[] crcbuf = RawData.ToArray();
                int crc = 0xffff;
                for (int n = 0; n < len; n++)
                {
                    byte i;
                    crc = crc ^ crcbuf[n];
                    for (i = 0; i < 8; i++)
                    {
                        int TT;
                        TT = crc & 1;
                        crc = crc >> 1;
                        crc = crc & 0x7fff;
                        if (TT == 1)
                        {
                            crc = crc ^ 0xa001;
                        }
                        crc = crc & 0xffff;
                    }

                }
                CRC16L = (byte)((crc >> 8) & 0xff);
                CRC16H = (byte)(crc & 0xff);
            }

            public void OTA_PACK(int offset, int size)
            {
                send_buf.Clear();
                if ((offset + size) > (int)FileLength * 2) return;
                N_OFFSET = offset + size;
                string s = String.Format("OTA_DATA:{0:D},{1:D}," + BitConverter.ToString(reader, offset / 2, size / 2).Replace("-", ""), offset, size);
                for(int i = 0; i < s.Length; i++)
                {
                    send_buf.Add((byte)s.ToArray()[i]);
                }
                CRC16(send_buf, send_buf.Count);
                send_buf.Add(CRC16H);
                send_buf.Add(CRC16L);
                //s = String.Format("{0:X}{1:X}", CRC16H, CRC16L);
                //for (int i = 0; i < s.Length; i++)
                //{
                //    send_buf.Add((byte)s.ToArray()[i]);
                //}
                send_buf.Add((byte)'?');
                send_buf.Add((byte)'?');
                send_buf.Add((byte)'\r');
                send_buf.Add((byte)'\n');
            }
        }

        public class RecieveMatch
        {
            public int pOK { get; set; }
            public int pERR { get; set; }
            public int pRst { get; set; }
            public int pFacRst { get; set; }
            public int pIPset { get; set; }
            public int pDevID { get; set; }
            public int pAUTH { get; set; }
            public int pPRJID { get; set; }
            public int pOTA_HEAD { get; set; }
            public int pOTA_GET { get; set; }
            public int pOTA_FINISH { get; set; }
            public byte[] ResultOK;
            public byte[] ResultERR;
            public byte[] Reset;
            public byte[] FacRst;
            public byte[] IPset;
            public byte[] DevID;
            public byte[] AUTH;
            public byte[] PRJID;
            public byte[] OTA_HEAD;
            public byte[] OTA_GET;
            public byte[] OTA_FINISH;
            public RecieveMatch()
            {
                pOK = 0;
                pERR = 0;
                pRst = 0;
                pFacRst = 0;
                pIPset = 0;
                pDevID = 0;
                pAUTH = 0;
                pPRJID = 0;
                pOTA_HEAD = 0;
                pOTA_GET = 0;
                pOTA_FINISH = 0;
                ResultOK = Encoding.UTF8.GetBytes("RgAns:OK ");
                ResultERR = Encoding.UTF8.GetBytes("RgAns:ERR ");
                Reset = Encoding.UTF8.GetBytes("chip reset ");
                FacRst = Encoding.UTF8.GetBytes("factory reset ");
                IPset = Encoding.UTF8.GetBytes("IP&PORT write ");
                DevID = Encoding.UTF8.GetBytes("ok!devid ");
                AUTH = Encoding.UTF8.GetBytes("ok!authinfo ");
                PRJID = Encoding.UTF8.GetBytes("ok!prjid ");
                OTA_HEAD = Encoding.UTF8.GetBytes("OTA_HEAD:OK");
                OTA_GET = Encoding.UTF8.GetBytes("OTA_GET:");
                OTA_FINISH = Encoding.UTF8.GetBytes("OTA_FINISH:OK");
            }
            public int CheckReply(byte[] BArray, int index, byte cmp, string str)
            {
                if (BArray[index] == cmp)
                {
                    index++;
                    if (index >= (BArray.Length - 1))
                    {
                        MessageBox.Show(str);
                        index = 0;
                    }
                }
                else
                {
                    index = 0;
                }
                return index;
            }
        }
        private RecieveMatch RMatch = new RecieveMatch();
        private OTA_FUNC OTA = new OTA_FUNC();
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)//read seriraldata, show in textblock
        {
            int len =  _serialPort.BytesToRead;
            byte[] buffer = new byte[len];
            _serialPort.Read(buffer, 0, len);
            string strData = BitConverter.ToString(buffer, 0, len);
            string strData1 = Encoding.UTF8.GetString(buffer);            
            Dispatcher.Invoke(() =>
            {
                if( DisplaySwich.Content.ToString() == "Str")
                {
                    tb_receiveData.Text += strData1;
                    RecieveViewer.ScrollToBottom();
                }
                else
                {
                    tb_receiveData.Text += strData;
                    RecieveViewer.ScrollToBottom();
                }
            });
            for (int i = 0; i < len; i++)
            {
                RMatch.pOK = RMatch.CheckReply(RMatch.ResultOK, RMatch.pOK, buffer[i], "设置成功");
                RMatch.pERR = RMatch.CheckReply(RMatch.ResultERR, RMatch.pERR, buffer[i], "设置失败");
                RMatch.pRst = RMatch.CheckReply(RMatch.Reset, RMatch.pRst, buffer[i], "复位成功");
                RMatch.pFacRst = RMatch.CheckReply(RMatch.FacRst, RMatch.pFacRst, buffer[i], "恢复出厂设置成功");
                RMatch.pIPset = RMatch.CheckReply(RMatch.IPset, RMatch.pIPset, buffer[i], "服务器地址设置成功");
                RMatch.pDevID = RMatch.CheckReply(RMatch.DevID, RMatch.pDevID, buffer[i], "设备ID设置成功");
                RMatch.pAUTH = RMatch.CheckReply(RMatch.AUTH, RMatch.pAUTH, buffer[i], "设序列号设置成功");
                RMatch.pPRJID = RMatch.CheckReply(RMatch.PRJID, RMatch.pPRJID, buffer[i], "项目ID设置成功");
            }
            if(OTA.OTA_Flag == 1)
            {
                int size = 1024;
                int offset = 0;
                for (int i = 0; i < len; i++)
                {
                    OTA.OTA_BUFF.Add(buffer[i]);
                }
                if (Encoding.UTF8.GetString(OTA.OTA_BUFF.ToArray()).Contains("OTA_FINISH:FAILED"))
                {
                    MessageBox.Show("固件升级失败！");
                    OTA.OTA_Flag = 0;
                    OTA.OTA_BUFF.Clear();
                }
                if (Encoding.UTF8.GetString(OTA.OTA_BUFF.ToArray()).Contains("OTA_FINISH:OK"))
                {
                    MessageBox.Show("固件升级成功！");
                    OTA.OTA_Flag = 0;
                    OTA.OTA_BUFF.Clear();
                }
                if (Encoding.UTF8.GetString(OTA.OTA_BUFF.ToArray()).Contains("OTA_HEAD:OK"))
                {
                    if (OTA.FileLength * 2 < 1024) size = (int)OTA.FileLength * 2;

                    OTA.OTA_PACK(offset, size);
                    //Dispatcher.Invoke(() =>
                    //{
                    //    tb_ResultData.Text += String.Format("CRC = 0x{0:X},0x{1:X}", OTA.CRC16H, OTA.CRC16L);
                    //});
                    try
                    {
                        _serialPort.Write(OTA.send_buf.ToArray(), 0, OTA.send_buf.Count);
                    }
                    catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
                    OTA.OTA_BUFF.Clear();
                }
                
                if (Encoding.UTF8.GetString(OTA.OTA_BUFF.ToArray()).Contains("OTA_GET:"))
                {
                    //get offset from list OTA_BUFF
                    try
                    {
                        string str1 = Encoding.UTF8.GetString(OTA.OTA_BUFF.ToArray());
                        int first = str1.IndexOf("OTA_GET:") + "OTA_GET:".Length;
                        int last = str1.LastIndexOf("\r\n");
                        string str2 = str1.Substring(first, last - first);
                        int.TryParse(str2, out offset);
                    }
                    catch { offset = 0; }
                    if (OTA.FileLength * 2 - offset < 1024) size = (int)(OTA.FileLength * 2 - offset);
                    OTA.OTA_PACK(offset, size);
                    //Dispatcher.Invoke(() =>
                    //{
                    //    tb_ResultData.Text += Encoding.UTF8.GetString(OTA.send_buf.ToArray());
                    //});
                    try
                    {
                        _serialPort.Write(OTA.send_buf.ToArray(), 0, OTA.send_buf.Count);
                    }
                    catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
                    OTA.OTA_BUFF.Clear();
                }
            }
        }

        private void StopSend_Click(object sender, RoutedEventArgs e)//stop or restart recieve
        {
            string strContent =  StopSend.Content.ToString();
            if (strContent == "停止接收")
            {
                //byte[] data = { 0x99 };
                // _serialPort.Write(data, 0, data.Length);
                _serialPort.DataReceived -= DataReceivedHandler;
                StopSend.Content = "继续接收";
            }
            else
            {
                //byte[] data = { 0x66 };
                // _serialPort.Write(data, 0, data.Length);
                _serialPort.DataReceived += DataReceivedHandler;
                StopSend.Content = "停止接收";
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string strContent =  bt_SerialSwitch.Content.ToString();
            if (strContent == "关闭串口")
            {
                _serialPort.Close();
            }
            autoset1.Close();
            autoset2.Close();
            Application.Current.Shutdown();
        }

        private void SeriPortRefresh(object sender, RoutedEventArgs e)
        {
            string[] newports = SerialPort.GetPortNames();
            while(!cb_SerialPortNumber.Items.IsEmpty)
            {
                cb_SerialPortNumber.Items.RemoveAt(0);
            }
            for (int index = 0; index < newports.Length; index++)
            {
                cb_SerialPortNumber.Items.Add(newports[index]);   
                cb_SerialPortNumber.SelectedIndex = index;
            }
        }

        private void DisplaySwich_Click(object sender, RoutedEventArgs e)
        {
            if ( DisplaySwich.Content.ToString() == "Str")
            {
                DisplaySwich.Content = "Hex";
            }
            else
            {
                DisplaySwich.Content = "Str";
            }
        }

        /* select the Register setting page */
        private void Bt_DeltaSelect_Click(object sender, RoutedEventArgs e)
        {
            DeltaPLC.Visibility = Visibility.Visible;
            DeltaPLC.Height = 470;
            InvertPLC.Visibility = Visibility.Hidden;
            InvertPLC.Height = 0;
            bt_DeltaSelect.Background = new SolidColorBrush(Colors.Red);
            bt_InvertSelect.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));
        }
        private void Bt_InvertSelect_Click(object sender, RoutedEventArgs e)
        {
            DeltaPLC.Visibility = Visibility.Hidden;
            DeltaPLC.Height = 0;
            InvertPLC.Visibility = Visibility.Visible;
            InvertPLC.Height = 470;
            bt_DeltaSelect.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));
            bt_InvertSelect.Background =  new SolidColorBrush(Colors.Red);
        }

        public class ParaDataFormat
        {
            public static int packetID { get; set; }
            public static int TotalNum { get; set; }
            public static int PLCType { get; set; }
            public byte CRC16H { get; set; }
            public byte CRC16L { get; set; }
            public ParaDataFormat()
            {
                CRC16H = 0;
                CRC16L = 0;
            }
            //public int CRC16(List<byte> RawData,int len)
            /// <summary>
            /// CRC校验
            /// </summary>
            /// <param name="data">校验数据</param>
            /// <returns>高低8位</returns>
            public void CRC16(List<byte> RawData, int len)
            {
                byte[] crcbuf = RawData.ToArray();
                //计算并填写CRC校验码
                int crc = 0xffff;
                for (int n = 0; n < len; n++)
                {
                    byte i;
                    crc = crc ^ crcbuf[n];
                    for (i = 0; i < 8; i++)
                    {
                        int TT;
                        TT = crc & 1;
                        crc = crc >> 1;
                        crc = crc & 0x7fff;
                        if (TT == 1)
                        {
                            crc = crc ^ 0xa001;
                        }
                        crc = crc & 0xffff;
                    }

                }
                CRC16L = (byte)((crc >> 8) & 0xff);
                CRC16H = (byte)(crc & 0xff);

                
                //MessageBox.Show(CRC16H.ToString() +"+"+ CRC16L.ToString());
            }

            public byte[] ParaDataForm(List<byte> Addr)
            {
                byte[] FormatString;

                Addr.Insert(0, (byte)PLCType);
                Addr.Insert(0, (byte)TotalNum);
                Addr.Insert(0, (byte)':');
                Addr.Insert(0, (byte)'T');
                Addr.Insert(0, (byte)'E');
                Addr.Insert(0, (byte)'S');
                Addr.Insert(0, (byte)'g');
                Addr.Insert(0, (byte)'R');
                Addr.Add(CRC16H);
                Addr.Add(CRC16L);
                Addr.Add((byte)'\r');
                Addr.Add((byte)'\n');

                FormatString = Addr.ToArray();

                return FormatString;
            }

            public byte[] AutoSetForm(List<byte> Addr)
            {
                byte[] FormatString;
                
                Addr.Add(CRC16H);
                Addr.Add(CRC16L);
                Addr.Add((byte)'\r');
                Addr.Add((byte)'\r');
                Addr.Add((byte)'\n');
                Addr.Add((byte)' ');
                Addr.Add((byte)' ');

                FormatString = Addr.ToArray();

                return FormatString;
            }
        }

        public int DSendDataFormat(int Rg, int index)
        {
            if ((index >= 16) && (index <= 21))
            {
                if (Rg < 1536)
                {
                    Rg += 0x800;
                }
                else
                {
                    if (Rg < 4096)
                    {
                        Rg = Rg - 1536 + 0xB00;
                    }
                    else
                    {
                        MessageBox.Show("M寄存器只支持M0~M4095");
                        return -1;
                    }
                }
            }
            else
            {
                if ((index >= 6) && (index <= 8))
                {
                    Rg += 0xE00;
                }
                else
                {
                    if (Rg < 4096)
                    {
                        Rg += 0x1000;
                    }
                    else
                    {
                        Rg = Rg - 4096 + 0x9000;
                    }
                }
            }
            return Rg;
        }

        public int ISendDataFormat(int Rg, int index)
        {
            index -= 58;
            if ((index >= 16) && (index <= 21) || index == 26)
            {
                if (Rg < 2048)
                {
                    Rg += 2000;
                }
                else
                {
                    if (Rg < 10000)
                    {
                        Rg = Rg - 2048 + 12000;
                    }
                    else
                    {
                        MessageBox.Show("M寄存器只支持M0~M9999");
                        return -1;
                    }
                }
            }
            else if ((index >= 9) && (index <= 14))
            {
                if (Rg < 256)
                {
                    Rg += 8000;
                }
                else if(Rg<512)
                {
                    Rg = Rg - 256 + 12000;
                }
                else
                {
                    MessageBox.Show("SD寄存器只支持SD0~SD511");
                    return -1;
                }
            }
            else
            {
                if (Rg > 8000)
                {
                    MessageBox.Show("D寄存器只支持D0~D7999");
                    return -1;
                }
            }
            
            return Rg;
        }

        private void Bt_ParaSet_Click(object sender, RoutedEventArgs e)     //send the Register setting data to seriral port
        {
            int sum = 0, RgAddr, Tnum;
            ParaDataFormat DataToFormat = new ParaDataFormat();

            AtList.Clear();
            AtList.Add((byte)'A');
            AtList.Add((byte)'t');
            AtList.Add((byte)'S');
            AtList.Add((byte)'E');
            AtList.Add((byte)'T');
            AtList.Add((byte)':');
            
            //input Register check
            if (bt_DeltaSelect.Background.ToString() == "#FFFF0000")
            {
                if(autoset1.DAutoKeyDown.Text.ToString() == "" || autoset1.DAutoKeyUp.Text.ToString() == "")
                {
                    MessageBox.Show("请先设置自动按键键值");
                    return;
                }
                else
                {
                    int.TryParse(autoset1.DAutoKeyDown.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    int.TryParse(autoset1.DAutoKeyUp.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    int.TryParse(autoset2.IAutoKeyDown.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    int.TryParse(autoset2.IAutoKeyUp.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    DataToFormat.CRC16(AtList, AtList.Count);
                    DataToFormat.AutoSetForm(AtList);
                    /*try
                    {
                        _serialPort.Write(DataToSend1, 0, DataToSend1.Length);
                    }
                    catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }*/
                }

                RgList.Clear();
                ParaDataFormat.PLCType = 0x32;
                for (int i = 0; i < 56;i++)
                {
                    TextBox temp = TboxList[i];
                    if (temp.Text.ToString() == "") break;
                    int.TryParse(temp.Text.ToString(), out Tnum);
                    if (Tnum < 0 || Tnum > 9999)
                    {
                        temp.Text = "";
                        break;
                    }
                    RgAddr = DSendDataFormat(Tnum, i);
                    if (RgAddr == -1) return;
                    RgList.Add((byte)((RgAddr - (RgAddr % 256))/256));
                    RgList.Add((byte)(RgAddr % 256));
                    RgList.Add((byte)'M');
                    RgList.Add((byte)'N');
                    sum++;
                }
                if(sum < 16)
                {
                    MessageBox.Show("请设置至少前16个寄存器值");
                    return;
                }
            }
            if (bt_InvertSelect.Background.ToString() == "#FFFF0000")
            {
                if (autoset2.IAutoKeyDown.Text.ToString() == "" || autoset2.IAutoKeyUp.Text.ToString() == "")
                {
                    MessageBox.Show("请先设置自动按键键值");
                    return;
                }
                else
                {
                    int.TryParse(autoset1.DAutoKeyDown.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    int.TryParse(autoset1.DAutoKeyUp.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    int.TryParse(autoset2.IAutoKeyDown.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    int.TryParse(autoset2.IAutoKeyUp.Text.ToString(), out Tnum);
                    AtList.Add((byte)Tnum);
                    DataToFormat.CRC16(AtList, AtList.Count);
                    DataToFormat.AutoSetForm(AtList);
                }

                RgList.Clear();
                ParaDataFormat.PLCType = 0x31;
                for (int i = 58; i < 114; i++)
                {
                    TextBox temp = TboxList[i];
                    if (temp.Text.ToString() == "") break;
                    int.TryParse(temp.Text.ToString(), out Tnum);
                    if (Tnum < 0 || Tnum > 9999)
                    {
                        temp.Text = "";
                        break;
                    }
                    RgAddr = ISendDataFormat(Tnum, i);
                    if (RgAddr == -1) return;
                    RgList.Add((byte)((RgAddr - (RgAddr % 256)) / 256));
                    RgList.Add((byte)(RgAddr % 256));
                    RgList.Add((byte)'N');
                    RgList.Add((byte)'M');
                    sum++;
                }
                if (sum < 16)
                {
                    MessageBox.Show("请设置至少前16个寄存器值");
                    return;
                }
            }
            ParaDataFormat.TotalNum = sum;
            ParaDataFormat.packetID++;

            //send data through seriral port
            RgList.Add((byte)(ParaDataFormat.packetID % 256));
            DataToFormat.CRC16(RgList, 4 * sum + 1);
            DataToFormat.ParaDataForm(RgList);
            byte[] DataToSend = new byte[AtList.Count + RgList.Count];
            AtList.ToArray().CopyTo(DataToSend, 0);
            RgList.ToArray().CopyTo(DataToSend, AtList.Count);

            try
            {
                _serialPort.Write(DataToSend, 0, DataToSend.Length);
            }
            catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
        }

        private void Bt_DeltaAuto_Click(object sender, RoutedEventArgs e)   //call the delta PLC autobutton value setting window
        {
            autoset1.ShowDialog();
        }

        private void Bt_InvertAuto_Click(object sender, RoutedEventArgs e)  //call the dinvert PLC autobutton value setting window
        {
            autoset2.ShowDialog();
        }

        private void Bt_SaveData_Click(object sender, RoutedEventArgs e)    //save the config parameters
        {
            //byte[] ConfigData;

            try
            {
                FileStream ConfigFile = new FileStream("Config.ini", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(ConfigFile);
                sw.WriteLine("DELTA_PLC Register");
                for(int i=0;i<58;i++)
                {
                    TextBox temp = TboxList[i];
                    sw.WriteLine(temp.Text.ToString());
                }
                sw.WriteLine("INVERT_PLC Register");
                for (int i = 58; i < 117; i++)
                {
                    TextBox temp = TboxList[i];
                    sw.WriteLine(temp.Text.ToString());
                }
                sw.WriteLine("Other Register");
                for (int i = 117; i < TboxList.Count; i++)
                {
                    TextBox temp = TboxList[i];
                    sw.WriteLine(temp.Text.ToString());
                }
                sw.Close();
                MessageBox.Show("配置保存完成");
            }
            catch(IOException ex){ MessageBox.Show("File ERR:"+ex.ToString()); }
            
        }

        private void Bt_LoadData_Click(object sender, RoutedEventArgs e)    //load the config parameters
        {
            try
            {
                FileStream ConfigFile = new FileStream("Config.ini", FileMode.Open);
                StreamReader sr = new StreamReader(ConfigFile);
                sr.ReadLine();
                for (int i = 0; i < 58; i++)
                {
                    TextBox temp = TboxList[i];
                    temp.Text = sr.ReadLine();
                }
                sr.ReadLine();
                for (int i = 58; i < 117; i++)
                {
                    TextBox temp = TboxList[i];
                    temp.Text = sr.ReadLine();
                }
                sr.ReadLine();
                for (int i = 117; i < TboxList.Count; i++)
                {
                    TextBox temp = TboxList[i];
                    temp.Text = sr.ReadLine();
                }
                sr.Close();
                MessageBox.Show("配置读取完成");
            }
            catch (FileNotFoundException) { MessageBox.Show("请先保存或导入配置文件"); }
            catch (IOException ex) { MessageBox.Show("File ERR:" + ex.ToString()); }
        }

        private void TBox_KeyPress(object sender, KeyEventArgs e)   //Keyboard input limit
        {
            TextBox txt = sender as TextBox;

            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
            {
                e.Handled = false;
            }
            else if (((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //int TXT1 = txt.Text.Length;
            //MessageBox.Show(txt.Text.ToString()+"+"+TXT1.ToString());
        }

        private void TBox_TextChanged(object sender, TextChangedEventArgs e)    //reserved
        {
            TextBox TextBoxForText = sender as TextBox;
            try
            {
                string strNum = TextBoxForText.Text;
                if ("" == strNum || null == strNum)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DevRestart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _serialPort.Write("AT+RESET\r\n");
            }
            catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
        }

        private void DevFacReset_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _serialPort.Write("AT+FACTORY_RESET\r\n");
            }
            catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
        }

        private void Bt_IPAddr_Click(object sender, RoutedEventArgs e)
        {
            string str = t_IPAddr.Text.ToString();
            if (str == "")
            {
                MessageBox.Show("请先输入IP地址和端口");
            }
            else
            {
                byte[] IPAddress = Encoding.UTF8.GetBytes("AT+CIPSTART=" + str + "\r\n");
                try
                {
                    _serialPort.Write(IPAddress, 0, IPAddress.Length);
                }
                catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
            }
        }

        private void Bt_DevID_Click(object sender, RoutedEventArgs e)
        {
            string str = t_DevID.Text.ToString();
            if (str == "")
            {
                MessageBox.Show("请先输入设备的ID");
            }
            else
            {
                byte[] DevID = Encoding.UTF8.GetBytes("AT+DEVID=" + str + "\r\n");
                try
                {
                    _serialPort.Write(DevID, 0, DevID.Length);
                }
                catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
            }
        }

        private void Bt_AuthInfo_Click(object sender, RoutedEventArgs e)
        {
            string str = t_AuthInfo.Text.ToString();
            if (str == "")
            {
                MessageBox.Show("请先输入设备序列号");
            }
            else
            {
                byte[] DevID = Encoding.UTF8.GetBytes("AT+AUTH_INFO=" + str + "\r\n");
                try
                {
                    _serialPort.Write(DevID, 0, DevID.Length);
                }
                catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
            }
        }

        private void Bt_ProductID_Click(object sender, RoutedEventArgs e)
        {
            string str = t_ProductID.Text.ToString();
            if (str == "")
            {
                MessageBox.Show("请先输入设项目的ID");
            }
            else
            {
                byte[] DevID = Encoding.UTF8.GetBytes("AT+PRJID=" + str + "\r\n");
                try
                {
                    _serialPort.Write(DevID, 0, DevID.Length);
                }
                catch (InvalidOperationException) { MessageBox.Show("发送失败，串口未打开或被关闭！"); }
            }
        }

        private DispatcherTimer timer;
        private int UpdateCount = -1;
        private int TimeCount = 0;
        private void APP_DOWNLOAD_Tick(object sender, EventArgs e)
        {
            int UPprogress = OTA.N_OFFSET * 50 / (int)OTA.FileLength;
            if (UpdateCount != UPprogress || UPprogress == 100)
            {
                UpdateCount = UPprogress;
            }
            else
            {
                TimeCount++;
            }
            if (TimeCount > 4)
            {
                MessageBox.Show("固件升级失败！");
                OTA.OTA_Flag = 0;
                timer.Stop();
            }
            if (UPprogress == 100) UPprogress = 99;
            tb_ResultData.Text = String.Format("升级进度：{0:D} %", UPprogress) ;

            if (OTA.OTA_Flag == 0)
            {
                timer.Stop();
                if(UPprogress == 99)
                {
                    tb_ResultData.Text = String.Format("升级进度：100 % , 升级完成。");
                }
                else
                {
                    tb_ResultData.Text = String.Format("升级进度：{0:D} % , 升级失败 , 请重试。", UPprogress);
                }
            } 
        }
        private void Bt_APP_BIN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = "文本文件(*.bin)|*.bin";
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                t_APP_BIN.Text = fileDialog.FileName;
                tb_ResultData.Text = "选取的固件路径为：" + fileDialog.FileName + "；请点击烧录按钮；";
                if (fileDialog.FileName == "")
                {
                    MessageBox.Show("导入文件出错！");
                    return;
                }
                bt_APP_DOWNLOAD.IsEnabled = true;
            }
        }

        private void Bt_APP_DOWNLOAD_Click(object sender, RoutedEventArgs e)
        {
            string fileData = string.Empty;

            try
            {
                FileStream ConfigFile = new FileStream(t_APP_BIN.Text.ToString(), FileMode.Open);
                OTA.FileLength = ConfigFile.Length;
                //tb_ResultData.Text = "文件长度：" + OTA.FileLength.ToString() + "字节;\n";
                ConfigFile.Seek(0, SeekOrigin.Begin);
                if (ConfigFile.Length > (1024 * 1024))
                {
                    tb_ResultData.Text += "文件过大，超过1MB；\n";
                    OTA.FileLength = 0;
                }
                else
                {
                    ConfigFile.Read(OTA.reader, 0, (int)OTA.FileLength);
                }
                ConfigFile.Close();
            }
            catch (FileNotFoundException) { MessageBox.Show("导入文件出错"); }
            catch (IOException ex) { MessageBox.Show("File ERR:" + ex.ToString()); }

            if (OTA.FileLength == 0)
            {
                MessageBox.Show("文件过大！");
                return;
            }

            try
            {
                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromMilliseconds(500);
                timer.Tick += APP_DOWNLOAD_Tick;
            }
            catch (OverflowException) { MessageBox.Show("TIMER : OverflowException"); }
            catch (ArgumentException) { MessageBox.Show("TIMER : ArgumentException"); }

            
            //string OTA_String = "OTA_HEAD:" + FileLength.ToString() + "," + DateTime.Now.ToString() + "\r\n";
            //MessageBox.Show(OTA_String);

            //OTA.OTA_PACK(0, 1024);
            //tb_receiveData.Text += Encoding.UTF8.GetString(OTA.send_buf.ToArray());

            byte[] OTA_HEAD = Encoding.UTF8.GetBytes("OTA_HEAD:" + (OTA.FileLength * 2).ToString() + "," + DateTime.Now.ToString() + "\r\n");
            try
            {
                _serialPort.Write(OTA_HEAD, 0, OTA_HEAD.Length);
            }
            catch (InvalidOperationException) { MessageBox.Show("串口未打开或被关闭！"); }

            OTA.OTA_Flag = 1;
            UpdateCount = -1;
            TimeCount = 0;
            timer.Start();
        }
    }


}
