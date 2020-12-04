using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsejeriaEPICS.Models
{

    [Table("t_usuario")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellido")]
        public string Apellido { get; set; }

        [Column("dni")]
        public string DNI { get; set; }

        [DataType(DataType.EmailAddress)]
        [Column("correo")]
        public string Correo { get; set; }

        [DataType(DataType.Password)]
        [Column("password")]
        public string Password { get; set; }

        [Column("tipo")]
        public string Tipo { get; set; }
    }
}