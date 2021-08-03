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


            // conecta con el servidor
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            //obtiene la conexión con Citas
            var CitaClient = new RemoteCitas.RemoteCitasClient(channel);

            // Recupera el registro de la base de datos
            var citaInput = new CitasLookupModel { Id = 2 };

            // Ejecuta el comandoy deposita el resulta en la variable
            var citaReply = await CitaClient.GetCitasInfoAsync(citaInput);

            // Crea el cliente para el Greeting
            var client = new Greeter.GreeterClient(channel);

            // Recupera el registro de la base de datos
            var input = new HelloRequest { Name = $"{citaReply.Nombre} {citaReply.Apellido1} {citaReply.Apellido2} " };

            // Recupera el registro de la base de datos
            var reply = await client.SayHelloAsync(input);

            //Imprime el saludo con el Id = 2
            Console.WriteLine(reply.Message);


            Console.ReadLine();
        }
    }
}
