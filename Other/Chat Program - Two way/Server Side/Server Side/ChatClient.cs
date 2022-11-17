using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Net.Sockets;

namespace Server_Side
{
    class ChatClient
    {
        public static Hashtable AllClients = new Hashtable();

        //information about the client
        private TcpClient _client;
        private string _clientIP;
        private string _clientNick;

        private byte[] data; //for sending/ recieving data

        private bool RecieveNickname = true;

        public ChatClient(TcpClient client)
        {
            _client = client;

            _clientIP = client.Client.RemoteEndPoint.ToString();

            AllClients.Add(_clientIP, this);

            data = new byte[Client.RecieveBufferSize];
            client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(_client.ReceiveBufferSize), RecieveMessage, Null);
        }
        public void RecieveMessage(IAsyncResult ar)
        {
            try
            {
                int bytesRead;

                bytesRead = client.GetStream().EndRead(ar);

                if (bytesRead < 1)
                {
                    return;
                }
                else
                {
                    object[] para = { System.Text.Encoding.ASCII.GetString(data, 0, bytesRead) };
                    this Invoke(new delUpdateHistory(UpdateHistory), para);
                }
                _client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(_client.ReceiveBufferSize), recieveMessage, null);

            }

            catch (Exception ex)
            {

            }

        }

        private void Invoke(delUpdateHistory delUpdateHistory, object[] para)
        {
            throw new NotImplementedException();
        }

        public delegate void delUpdateHistory(string str);
        public void UpdateHistory(string str)
        {
            txtMessageHistory.AppendText(str);
        }
        public void Disconnect()
        {
            try
            {
                //---Disconnect from server---
                _client.GetStream().Close();
                _client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
