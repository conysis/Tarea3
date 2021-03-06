// <auto-generated />
using System;
using CitasServer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CitasServer.Migrations
{
    [DbContext(typeof(CitasDbContext))]
    partial class CitasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CitasServer.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("DocId")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("FecCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEspecialidadId")
                        .HasColumnType("int");

                    b.Property<int?>("IdFormaDePagoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("IdEspecialidadId");

                    b.HasIndex("IdFormaDePagoId");

                    b.ToTable("Citas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido1 = "Goicoechea",
                            Apellido2 = "Chavarría",
                            DocId = "108370630",
                            FecCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Alexander"
                        },
                        new
                        {
                            Id = 2,
                            Apellido1 = "Brunner",
                            Apellido2 = "Agüero",
                            DocId = "111111111",
                            FecCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Norberth"
                        },
                        new
                        {
                            Id = 3,
                            Apellido1 = "Gaviria",
                            Apellido2 = "Del Monte",
                            DocId = "202220222",
                            FecCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Manuel"
                        });
                });

            modelBuilder.Entity("CitasServer.Models.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("CitasServer.Models.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("FormaPago");
                });

            modelBuilder.Entity("CitasServer.Models.Cita", b =>
                {
                    b.HasOne("CitasServer.Models.Especialidad", "IdEspecialidad")
                        .WithMany()
                        .HasForeignKey("IdEspecialidadId");

                    b.HasOne("CitasServer.Models.FormaPago", "IdFormaDePago")
                        .WithMany()
                        .HasForeignKey("IdFormaDePagoId");

                    b.Navigation("IdEspecialidad");

                    b.Navigation("IdFormaDePago");
                });
#pragma warning restore 612, 618
        }
    }
}
