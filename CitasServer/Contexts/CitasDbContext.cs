using CitasServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasServer.Contexts
{
    public class CitasDbContext : DbContext
    {
        public CitasDbContext(DbContextOptions<CitasDbContext> options) : base(options) { }

        public DbSet<Cita> Citas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cita>().HasData(
                GetCitas()
                );
        }

        private static List<Cita> GetCitas()
        {
            List<Cita> citas = new List<Cita>
            {
                new Cita(){
                    Id=1,
                    DocId="108370630",
                    Nombre="Alexander",
                    Apellido1="Goicoechea",
                    Apellido2="Chavarría"
                },
                new Cita(){
                    Id=2,
                    DocId="111111111",
                    Nombre="Norberth",
                    Apellido1="Brunner",
                    Apellido2="Agüero"
                },
                new Cita(){
                    Id=3,
                    DocId="202220222",
                    Nombre="Manuel",
                    Apellido1="Gaviria",
                    Apellido2="Del Monte"
                }

            };
        return citas;
        }
    }
}
