using System;
using System.IO.Ports;
using System.Threading;

namespace ConsoleApplication1
{

    public class PortChat
    {
        static bool _continue;
        static SerialPort _serialPort;
        static Program runtime;

        public static void Main()
        {
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            runtime = new Program();
            Thread readThread = new Thread(read);

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort("COM37", 9600, Parity.None, 8, StopBits.One);

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;


            _serialPort.Open();
            _continue = true;
            readThread.Start();

            while (_continue)
            {
                message = Console.ReadLine();

                if (stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
                else
                {
                    read();
                    runtime.run();
                }
            }

            readThread.Join();
            _serialPort.Close();
        }

        public static void read()
        {
            while (_continue)
            {
                try
                {
                    int message = _serialPort.ReadByte();
                    parser(message);
                    Console.WriteLine(message);
                }
                catch (TimeoutException) { }
            }
        }

        public static void parser(int code)
        {
            /*lock=0;
              unlock=3
              left=6
              right=9
              up=12
              down=15
             */
            runtime.LOCK = 0;
            runtime.UNLOCK = 0;
            runtime.LEFT = 0;
            runtime.RIGHT = 0;
            runtime.UP = 0;
            runtime.DOWN = 0;
            if (code < 2)
            {
                runtime.LOCK = 1;
            }
            else if (code < 5)
            {
                runtime.UNLOCK = 1;
            }
            else if (code < 8)
            {
                runtime.LEFT = 1;
            }
            else if (code < 11)
            {
                runtime.RIGHT = 1;
            }
            else if (code < 14)
            {
                runtime.UP = 1;
            }
            else if (code < 17)
            {
                runtime.DOWN = 1;
            }
            else
            {
                //do nothing no code match
            }


        }
    }
}
