

using System.IO.Ports;

namespace tinger.ModBusLib
{
    //串口通信类：本质就是对SerialPort这个类做二次封装
    //以太网通信类：本质就是对Socket这个类做二次封装
    public class ModBusRTU
    {
        //实例化
        public ModBusRTU()
        {
            serialport = new SerialPort();
        }
        //创建对象
        private SerialPort serialport = null;

        //打开串口
        //参数：端口号，波特率，数据位，校验位，停止位（9600 N 81）
        public void Connect(string portName, int baudRate = 9600, int dataBits = 8, Parity parity = Parity.None, StopBits stopBits = StopBits.One)
        {
            //1.如果打开就先关闭
            if (serialport.IsOpen)
            {
                serialport.Close();
            }
            //2.设置串口参数(参数赋给属性）
            serialport.PortName = portName;
            serialport.BaudRate = baudRate;
            serialport.DataBits = dataBits;
            serialport.Parity = parity;
            serialport.StopBits = stopBits;
            //3.打开串口：调用open方法
            serialport.Open();

        }

        //关闭串口
        public void CloseConnect()
        {
            //1.如果打开就先关闭
            if (serialport.IsOpen)
            {
                serialport.Close();
            }
        }

        //读取方法
        public byte[] ReadKeepRegisters(byte devAdd, ushort start, ushort length)
        {
            //1.拼接报文：最好是字节数组或字节集合
            //创建一个字节集合
            List<byte> sendCommand = new List<byte>();

            //协议格式：站地址+功能码+起始寄存器地址+寄存器数量+CRT校验
            //站地址
            sendCommand.Add(devAdd);
            //功能码
            sendCommand.Add(0x03);
            //起始寄存器地址
            sendCommand.Add((byte)(start / 256));
            sendCommand.Add((byte)(start % 256));
            //寄存器数量高位
            sendCommand.Add((byte)(length / 256));
            //寄存器数量低位
            sendCommand.Add((byte)(length % 256));
            //CRT校验
            byte[] crc = Crc16(sendCommand.ToArray(), sendCommand.Count);
            sendCommand.AddRange(crc);

            //2.发生报文
            serialport.Write(sendCommand.ToArray(), 0, sendCommand.Count);
            Thread.Sleep(20);

            //3.接受报文
            int byteCount = serialport.BytesToRead;
            byte[] data = new byte[byteCount];
            serialport.Read(data, 0, data.Length);

            //4.校验报文
            //1)验证总长度 2)验证站地址 3）验证功能码 4）CRC校验
            if (CheckCRC(data))
            {
                if (data.Length == 5 + length * 2)
                {
                    if (data[0] == devAdd)
                    {
                        if (data[1] == 0x03)
                        {
                            //保证数据是正确的
                            if (data[2] == length * 2)
                            {
                                //5.解析报文
                                byte[] result = new byte[length * 2];
                                Array.Copy(data, 3, result, 0, length * 2);
                                return result;
                            }
                        }
                    }
                }
            }
            return null;
        }

        private bool CheckCRC(byte[] data)
        {
            throw new NotImplementedException();
        }

        private byte[] Crc16(byte[] bytes, int count)
        {
            throw new NotImplementedException();
        }
    }
}

