using System;
using System.IO;
using System.Net.Sockets;

namespace BankClient
{
    public class Connection
    {
        private readonly TcpClient clientSocket = new TcpClient("localhost", 6789);

        public void StartConnection(string AccountId, double amount)
        {
            Stream ns = clientSocket.GetStream();
            var sr = new StreamReader(ns);
            var sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing


            var message = $"{AccountId} {amount}";
            sw.WriteLine();
            var serverAnswer = sr.ReadLine();
            Console.WriteLine("Server: " + serverAnswer);

            ns.Close();
            clientSocket.Close();
        }
    }
}