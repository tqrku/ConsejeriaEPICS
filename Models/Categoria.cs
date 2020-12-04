using System.ComponentModel.DataAnnotations.Schema;

namespace ConsejeriaEPICS.Models
{
    [Table("t_categorias")]
    public class Categoria
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}