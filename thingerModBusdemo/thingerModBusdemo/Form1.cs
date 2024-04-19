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
        //��������
        //ʵ��������
        //New����
        private ModBusRTU modbusRTU = new ModBusRTU();

        private void btn_CloseConnect_Click(object sender, EventArgs e)
        {
            modbusRTU.CloseConnect();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {   
            // ���Ӵ���
            modbusRTU.Connect(this.cmb_Port.Text);
        }
        private void btn_Read1_Clikc(object sender, EventArgs e)
        {
            //��ȡ1��վ�㣬��0��ʼ��2���Ĵ�����ֵ��������ֽ����飬����Ϊ4
            byte[] data = modbusRTU.ReadKeepRegisters(1, 0, 2);

            if (data != null && data.Length == 4)
            {   
                //���жϣ��ж��Ƿ�Ϊnull�������Ϊnull���жϳ����Ƿ�Ϊ4
                this.txt_Humidity1.Text = ((data[0] * 256 + data[1]) * 0.1f).ToString();
                this.txt_Temp1.Text = ((data[2] * 256 + data[3]) * 0.1f).ToString();
            }
        }
    }
}
