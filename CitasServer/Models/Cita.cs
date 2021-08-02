using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CitasServer.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Fecha Creación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FecCreacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Número de Identificación")]
        [Column(TypeName = "nvarchar(25)")]
        public string DocId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Column(TypeName = "nvarchar(25)")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Column(TypeName = "nvarchar(25)")]
        public string Apellido1 { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Column(TypeName = "nvarchar(25)")]
        public string Apellido2 { get; set; }

        public Especialidad IdEspecialidad { get; set; }

        public FormaPago IdFormaDePago { get; set; }

    }
}
