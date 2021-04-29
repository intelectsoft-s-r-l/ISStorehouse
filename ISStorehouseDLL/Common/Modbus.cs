using System;
using System.IO.Ports;
using System.Linq;

namespace ISStorehouseDLL.Common
{
    public class Modbus : IDisposable
    {
        private SerialPort sp = new SerialPort();
        public string modbusStatus;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                sp.Dispose();
            }
            // free native resources
        }

        public Modbus()
        {
        }

        ~Modbus()
        {
            Dispose(false);
        }

        public bool Open(string portName, int baudRate, int databits, Parity parity, StopBits stopBits)
        {
            if (!sp.IsOpen)
            {
                sp.PortName = portName;
                sp.BaudRate = baudRate;
                sp.DataBits = databits;
                sp.Parity = parity;
                sp.StopBits = stopBits;
                sp.ReadTimeout = 1000;
                sp.WriteTimeout = 1000;
                sp.Handshake = Handshake.None;
                try
                {
                    sp.Open();
                }
                catch (Exception err)
                {
                    // LogList.Add(Now & " Error opening " & portName & ": " & err.Message)
                    return false;
                }
                // LogList.Add(Now & " " & portName & " opened successfully")
                return true;
            }
            else
            {
                // LogList.Add(Now & portName & " already opened")
                return false;
            }
        }

        public bool Close()
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Close();
                }
                catch (Exception err)
                {
                    // LogList.Add(Now & " Error closing " & sp.PortName & ": " & err.Message)
                    return false;
                }
                // LogList.Add(Now & sp.PortName & " closed successfully")
                return true;
            }
            else
            {
                // LogList.Add(Now & sp.PortName & " is not open")
                return false;
            }
        }

        private void GetCRC(byte[] message, ref byte[] CRC)
        {
            ushort CRCFull = 0xFFFF;
            // Dim CRCHigh As Byte = &HFF, CRCLow As Byte = &HFF
            char CRCLSB;
            for (int i = 0, loopTo = message.Length - 2 - 1; i <= loopTo; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);
                for (int j = 0; j <= 8 - 1; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x1);
                    CRCFull = (ushort)(CRCFull >> 1 & 0x7FFF);
                    if (CRCLSB == '\u0001')
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }

            CRC[1] = (byte)(CRCFull >> 8 & 0xFF);
            CRC[0] = (byte)(CRCFull & 0xFF);
        }

        private void BuildMessage(byte address, byte type, ushort start, ushort registers, ref byte[] message)
        {
            var CRC = new byte[2];
            message[0] = address;
            message[1] = type;
            message[2] = (byte)(start >> 8);
            message[3] = (byte)start;
            message[4] = (byte)(registers >> 8);
            message[5] = Convert.ToByte(registers & 0xFF);
            // message(5) = CByte(registers)
            GetCRC(message, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
        }

        private bool CheckResponse(byte[] response)
        {
            var CRC = new byte[2];
            GetCRC(response, ref CRC);
            if (CRC[0] == response[response.Length - 2] && CRC[1] == response[response.Length - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GetResponse(ref byte[] response)
        {
            for (int i = 0, loopTo = response.Length - 1; i <= loopTo; i++)
                response[i] = (byte)sp.ReadByte();
        }

        public bool SendFc16(byte address, ushort start, ushort registers, short[] values)
        {
            if (sp.IsOpen)
            {
                sp.DiscardOutBuffer();
                sp.DiscardInBuffer();
                var message = new byte[(9 + 2 * registers)];
                var response = new byte[8];
                message[6] = (byte)(registers * 2);
                for (int i = 0, loopTo = registers - 1; i <= loopTo; i++)
                {
                    var temp = BitConverter.GetBytes(values[i]);
                    message[7 + 2 * i] = temp[1]; // CByte(values(i) >> 8)
                    message[8 + 2 * i] = temp[0]; // CByte((values(i)))
                }

                BuildMessage(address, 16, start, registers, ref message);
                try
                {
                    sp.Write(message, 0, message.Length);
                    // Threading.Thread.Sleep(3)
                    GetResponse(ref response);
                }
                catch (Exception err)
                {
                    // LogList.Add(Now & "  Error in write event. Module " & CShort(address) & " " & err.Message)
                    return false;
                }

                if (CheckResponse(response))
                {
                    return true;
                }
                else
                {
                    // LogList.Add(Now & " CRC error on write.")
                    return false;
                }
            }
            else
            {
                // LogList.Add(Now & " Serial port not open.")
                // Beep()
                // Threading.Thread.Sleep(1000)
                // Open(My.Settings.COM, My.Settings.Baud, 8, IO.Ports.Parity.None, IO.Ports.StopBits.One)
                return false;
            }
        }

        public bool SendFc06(byte address, ushort StartRegister, ushort value)
        {
            if (sp.IsOpen)
            {
                sp.DiscardOutBuffer();
                sp.DiscardInBuffer();
                var message = new byte[8];
                var response = new byte[8];
                BuildMessage(address, 6, StartRegister, value, ref message);
                try
                {
                    sp.Write(message, 0, message.Length);
                    GetResponse(ref response);
                }
                catch (Exception err)
                {
                    return false;
                }

                if (CheckResponse(response) && message.SequenceEqual(response))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool SendFc3(byte address, ushort start, ushort registers, ref short[] values)
        {
            if (sp.IsOpen)
            {
                sp.DiscardOutBuffer();
                sp.DiscardInBuffer();
                var message = new byte[8];
                var response = new byte[(5 + 2 * registers)];
                BuildMessage(address, 3, start, registers, ref message);
                try
                {
                    sp.Write(message, 0, message.Length);
                    GetResponse(ref response);
                }
                catch (Exception err)
                {
                    // LogList.Add(Now & "  Error in read event. Module " & CShort(address) & " " & err.Message)
                    return false;
                }

                if (CheckResponse(response))
                {
                    for (int i = 0, loopTo = (int)Math.Round((response.Length - 5) / 2d - 1d); i <= loopTo; i++)
                    {
                        values[i] = response[2 * i + 3];
                        values[i] = (short)(values[i] << 8);
                        values[i] += response[2 * i + 4];
                    }
                    // modbusStatus = "Read successful"
                    return true;
                }
                else
                {
                    // LogList.Add(Now & " CRC error on read.")
                    return false;
                }
            }
            else
            {
                // LogList.Add(Now & " Serial port not open.")
                return false;
            }
        }

        public short[] PollFunction(int SlaveID, ushort pollStart, ushort pollLength)
        {
            var values = new short[pollLength]; // = New Short(pollLength) {}
            var start = DateTime.Now;
            TimeSpan span;
            bool Success = true;
            try
            {
                if (!SendFc3(Convert.ToByte(SlaveID), pollStart, pollLength, ref values))
                {
                    Success = false;
                }
            }
            // While Not SendFc3(Convert.ToByte(SlaveID), pollStart, pollLength, values)
            // 'Threading.Thread.Sleep(500)
            // span = Now - start
            // If span.Seconds > 1 Then
            // Success = False
            // Exit While
            // End If
            // End While
            catch (Exception err)
            {
                Success = false;
            } // LogList.Add(Now & "  Error in modbus read. Module " & SlaveID & " " & err.Message)

            if (Success)
            {
                return values;
            }

            return default;
        }

        public void WriteFunction(int SlaveID, ushort startRegister, ushort registers, ref short[] values)
        {
            var start = DateTime.Now;
            TimeSpan span;
            System.Threading.Thread.Sleep(10);
            try
            {
                while (!SendFc16(Convert.ToByte(SlaveID), startRegister, registers, values))
                {
                    span = DateTime.Now - start;
                    if (span.Seconds > 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception err)
            {
            }
        }

        public bool WriteSingle(int SlaveID, short StripNumber, ushort NumberOfLedsPerStrips, short LedNumber, byte FunctionCode, byte Color0, byte Color2)
        {
            var start = DateTime.Now;
            // Dim span As TimeSpan
            short Reg = (short)(StripNumber * NumberOfLedsPerStrips + LedNumber + 12);
            short Command;
            byte MSB;
            byte LSB;
            if (FunctionCode > 0 | Color2 > 0)
            {
                MSB = (byte)(Color2 << 2 | FunctionCode);
                LSB = Color0;
                Command = MSB;
                Command = (short)(Command << 8);
                Command = (short)(Command | LSB);
            }
            // Command = (MSB << 8) Or LSB
            else
            {
                Command = Color0;
            }

            try
            {
                if (SendFc06(Convert.ToByte(SlaveID), (ushort)Reg, (ushort)Command))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public bool WriteDirect(int SlaveID, short StripNumber, ushort NumberOfLedsPerStrips, short LedNumber, byte FunctionCode, byte Color0, byte Color2)
        {
            var start = DateTime.Now;
            // Dim span As TimeSpan
            short Reg = (short)(StripNumber * NumberOfLedsPerStrips + LedNumber + 12);
            short Command;
            byte MSB;
            byte LSB;
            if (FunctionCode > 0 | Color2 > 0)
            {
                MSB = (byte)(Color2 << 2 | FunctionCode);
                LSB = Color0;
                Command = MSB;
                Command = (short)(Command << 8);
                Command = (short)(Command | LSB);
            }
            // Command = (MSB << 8) Or LSB
            else
            {
                Command = Color0;
            }


            // Threading.Thread.Sleep(10)
            try
            {
                var cmd = new short[1];
                cmd[0] = Command;
                if (SendFc16(Convert.ToByte(SlaveID), (ushort)Reg, 1, cmd))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // 'While Not SendFc16(Convert.ToByte(SlaveID), Reg, 1, Command)
            // '    span = Now - start
            // '    If span.Seconds > 1 Then

            // '        Exit While
            // '    End If
            // 'End While

            catch (Exception err)
            {
                return false;
            }
        }
    }
}
