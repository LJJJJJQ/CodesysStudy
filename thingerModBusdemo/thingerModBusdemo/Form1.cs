using System.IO.Ports;
using tinger.ModBusLib;

namespace thingerModBusdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.cmb_Port.DataSource = SerialPort.GetPortNames();
        }
        //创建对象
        //实例化对象
        //New对象
        private ModBusRTU modbusRTU = new ModBusRTU();

        private void btn_CloseConnect_Click(object sender, EventArgs e)
        {
            modbusRTU.CloseConnect();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {   
            // 连接串口
            modbusRTU.Connect(this.cmb_Port.Text);
        }
        private void btn_Read1_Clikc(object sender, EventArgs e)
        {
            //读取1号站点，从0开始的2个寄存器的值，结果是字节数组，长度为4
            byte[] data = modbusRTU.ReadKeepRegisters(1, 0, 2);

            if (data != null && data.Length == 4)
            {   
                //加判断，判断是否为null，如果不为null，判断长度是否为4
                this.txt_Humidity1.Text = ((data[0] * 256 + data[1]) * 0.1f).ToString();
                this.txt_Temp1.Text = ((data[2] * 256 + data[3]) * 0.1f).ToString();
            }
        }
    }
}
