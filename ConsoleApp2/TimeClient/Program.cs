/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Grpc.Net.Client;
//using GrpcService2;
using Grpc.Core;
using ConsoleApp2;



namespace TimeClient
{
    internal class Program
    {
        static void  Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5276");

           // var channel = new Channel($"{ServerAddress}:{ServerPort}", ChannelCredentials.Insecure);
             var client = new Time.TimeClient(channel);

            var response = client.GetCurrentTime(new Empty());

            Console.WriteLine($"Current Time: {response.CurrentTime}");
            Console.ReadLine();
            Console.ReadKey();
        }

    }
}*/
