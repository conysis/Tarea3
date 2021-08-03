using CitasServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasServer.Contexts
{
    public class FormaPagosDbContext : DbContext
    {
        public FormaPagosDbContext(DbContextOptions<FormaPagosDbContext> options) : base(options) { }

        public DbSet<FormaPago> FormaPagos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FormaPago>().HasData(
                GetFormaPagos()
                );
        }
        private static List<FormaPago> GetFormaPagos()
        {
            List<FormaPago> formaPagos = new List<FormaPago>
            {
                new FormaPago(){
                    Id=1,
                    Nombre="Efectivo"
                },
                new FormaPago(){
                    Id=2,
                    Nombre="Tarjeta"
                },
                new FormaPago(){
                    Id=3,
                    Nombre="Depósito Bancario"
                },
            };
            return formaPagos;
        }
    }
}