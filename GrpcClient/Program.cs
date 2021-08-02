using CitasServer;
using CitasServer.Protos;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("GoicoSOFT gRPC 1.0");
            Console.WriteLine("UNED - 2021");

            // var input = new HelloRequest { Name = "Alexander Goicoechea" };
            //
            // var channel = GrpcChannel.ForAddress("https://localhost:5001");
            // var client = new Greeter.GreeterClient(channel);
            //
            // var reply = await client.SayHelloAsync(input);
            // Console.WriteLine(reply.Message);

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var CitaClient = new RemoteCitas.RemoteCitasClient(channel);
            var citaInput = new CitasLookupModel { Id = 2 };
            var citaReply = await CitaClient.GetCitasInfoAsync(citaInput);
            Console.WriteLine($"{citaReply.Nombre} {citaReply.Apellido1} {citaReply.Apellido2} ");


        }
    }
}
