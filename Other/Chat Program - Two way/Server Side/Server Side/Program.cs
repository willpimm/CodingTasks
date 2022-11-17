using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;


namespace Server_Side
{
    class Program
    {
        const int portNumber = 500; //This port number is for listening. But why is it 500?
        static void Main(string[] args)
        {
            System.Net.IPAddress localAddress = System.Net.IPAddress.Parse("127.0.0.1");
            
            //Create an instance of the TCP listener class.
            TcpListener listener = new TcpListener(localAddress, portNumber);
            listener.Start();

            while (true)
            {
                ChatClient user = new ChatClient(listener.AcceptTcpClient());
            }

            //Below is from start of book;

            TcpClient tcpClient = listener.AcceptTcpClient();

            // Using the network stream class we can send and recieve 'data'
            NetworkStream networkStream = tcpClient.GetStream();
            byte[] data = new byte[tcpClient.ReceiveBufferSize];

            int numBytesRead = networkStream.Read(data, 0, System.Convert.ToInt32(tcpClient.ReceiveBufferSize));

            Console.WriteLine("Recieved " + Encoding.ASCII.GetString(data, 0, numBytesRead));
            Console.ReadLine();

        }
    }
}
