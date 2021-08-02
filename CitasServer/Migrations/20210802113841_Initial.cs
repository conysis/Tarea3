using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CitasServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FecCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocId = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Apellido1 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Apellido2 = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    IdEspecialidadId = table.Column<int>(type: "int", nullable: true),
                    IdFormaDePagoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citas_Especialidad_IdEspecialidadId",
                        column: x => x.IdEspecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_FormaPago_IdFormaDePagoId",
                        column: x => x.IdFormaDePagoId,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "Apellido1", "Apellido2", "DocId", "FecCreacion", "IdEspecialidadId", "IdFormaDePagoId", "Nombre" },
                values: new object[] { 1, "Goicoechea", "Chavarría", "108370630", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Alexander" });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "Apellido1", "Apellido2", "DocId", "FecCreacion", "IdEspecialidadId", "IdFormaDePagoId", "Nombre" },
                values: new object[] { 2, "Brunner", "Agüero", "111111111", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Norberth" });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "Apellido1", "Apellido2", "DocId", "FecCreacion", "IdEspecialidadId", "IdFormaDePagoId", "Nombre" },
                values: new object[] { 3, "Gaviria", "Del Monte", "202220222", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Manuel" });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdEspecialidadId",
                table: "Citas",
                column: "IdEspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdFormaDePagoId",
                table: "Citas",
                column: "IdFormaDePagoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "FormaPago");
        }
    }
}
