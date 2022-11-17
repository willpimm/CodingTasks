using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace Client_Side
{
    class Program
    {
        const int portNumber = 500; //what happens if i use port 143 (internet message access protocol)
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient();

            tcpClient.Connect("127.0.0.1", portNumber);

            NetworkStream networkStream = tcpClient.GetStream();
            byte[] data = Encoding.ASCII.GetBytes("Hello");

            networkStream.Write(data, 0, data.Length);

        }
    }
}
