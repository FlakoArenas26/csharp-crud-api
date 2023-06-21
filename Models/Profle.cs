using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("per")]
    public class Profile
    {

        [Column("per_id")]
        public int per_id { get; set; }

        [Column("per_codigo")]
        public string? per_codigo { get; set; }

        [Column("per_nombre")]
        public string? per_nombre { get; set; }

        [Column("per_descripcion")]
        public string? per_descripcion { get; set; }

        [Column("creado_por")]
        public string? creado_por { get; set; }

        [Column("fecha_creacion")]
        public DateTime? fecha_creacion { get; set; }

        [Column("modificado_por")]
        public string? modificado_por { get; set; }

        [Column("fecha_modificado")]
        public DateTime fecha_modificado { get; set; }
    }
}