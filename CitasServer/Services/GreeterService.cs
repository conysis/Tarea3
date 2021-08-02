using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasServer
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> Tlogger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            Tlogger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            Tlogger.LogInformation("Enviando respuesta de la Cita");
            return Task.FromResult(new HelloReply
            {
                Message = "¡Saludos! " + request.Name
            });
        }
    }
}
