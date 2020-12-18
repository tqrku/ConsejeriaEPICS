using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsejeriaEPICS.Models
{

    [Table("t_usuario")]
    public class Usuario
    {
        [Required]
        [Column("id")]
        public int ID { get; set; }

        [Required]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required]
        [Column("apellido")]
        public string Apellido { get; set; }

        [Required]
        [Column("dni")]
        public string DNI { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Column("correo")]
        public string Correo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Column("password")]
        public string Password { get; set; }

        [Column("tipo")]
        public string Tipo { get; set; }
    }
}