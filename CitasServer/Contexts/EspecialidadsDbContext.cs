using CitasServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasServer.Contexts
{
    public class EspecialidadsDbContext : DbContext
    {
        public EspecialidadsDbContext(DbContextOptions<EspecialidadsDbContext> options) : base(options) { }

        public DbSet<Especialidad> Especialidads { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Especialidad>().HasData(
                GetEspecialidads()
                );
        }
        private static List<Especialidad> GetEspecialidads()
        {
            List<Especialidad> especialidads = new List<Especialidad>
            {
                new Especialidad(){
                Id=1,
                Nombre="Odontología"
                },
               new Especialidad(){
                Id=2,
                Nombre="Psicología"
                },
               new Especialidad(){
                Id=3,
                Nombre="Cardiología"
                },
               new Especialidad(){
                Id=4,
                Nombre="Ginocología"
                },
               new Especialidad(){
                Id=5,
                Nombre="Oftamología"
                },
            };
            return especialidads;
        }
    }
}
