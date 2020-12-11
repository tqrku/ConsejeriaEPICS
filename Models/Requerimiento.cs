using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsejeriaEPICS.Models
{
    [Table("t_requerimiento")]
    public class Requerimiento
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("user_id")]
        public int User_ID { get; set; }

        [Column("tipo_req")]
        public int Tipo_Req { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        [Column("detalles")]
        public string Detalle { get; set; }

        [Column("fechaini")]
        public DateTime Fecha_Inicio { get; set; }

        [Column("fechafin")]
        public DateTime? Fecha_Fin { get; set; }

        [Column("consejero_id")]
        public int? Consejero_ID { get; set; }

        [Column("respuesta")]
        public string Respuesta { get; set; }

    }
}