using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasServer.Models
{
    public class Cita
    {
        public int Id { get; set; }

        public DateTime FecCreacion { get; set; }

        public string DocId { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

    }
}
