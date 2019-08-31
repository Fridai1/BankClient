using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace BankClient
{
    public class Connection
    {
        private TcpClient clientSocket = new TcpClient("localhost", 6789);
        IPAddress ip = IPAddress.Parse("127.0.0.1");

        public string GetFunds(string accountId, double amount)
        {
            if (!clientSocket.Connected)
            {
                TcpClient a = new TcpClient("localhost", 6789);
                clientSocket = a;
            }
            Stream ns = clientSocket.GetStream();
            var sr = new StreamReader(ns);
            var sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing


            var message = $"{accountId} {amount}";
            sw.WriteLine(message);
            var serverAnswer =  sr.ReadLine();
            //ns.Close();
            clientSocket.Close();
            if (serverAnswer != null)
            {
                return serverAnswer;
            }

            return "Unable to retrieve funds";


        }
    }
}