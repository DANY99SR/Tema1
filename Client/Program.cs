using Grpc.Core;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 16973;

            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);

            Console.WriteLine("Numele tau: ");

            do
            {
                var key = Console.ReadLine();

                var client = new Generated.ServiciuCerereNume.ServiciuCerereNumeClient(channel);


                client.AfiseazaNume(new Generated.Nume
                {Nume_ = key});
            }

            while (true);

        }
    }
}
