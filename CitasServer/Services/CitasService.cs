using CitasServer.Protos;
using CitasServer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Grpc.Core;

namespace CitasServer.Services
{
    public class CitasService : RemoteCitas.RemoteCitasBase
    {
        private readonly ILogger<CitasService> Tlogger;
        private readonly CitasDbContext Tcontext;

        public CitasService(ILogger<CitasService> logger, CitasDbContext context)
        {
            Tlogger = logger;
            Tcontext = context;
        }
        public override Task<CitasModel> GetCitasInfo(CitasLookupModel request, ServerCallContext context)
        {
            CitasModel output = new CitasModel();
            var cita = Tcontext.Citas.Find(request.Id);
            Tlogger.LogInformation("Enviando respuesta de la Cita");

            if (cita != null)
            {
                output.Id = cita.Id;
                output.DocId = cita.DocId;
                output.Nombre = cita.Nombre;
                output.Apellido1 = cita.Apellido1;
                output.Apellido2 = cita.Apellido2;
            }
            return Task.FromResult(output);
        }
    }
}