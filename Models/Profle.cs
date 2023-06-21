using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("PER")]
    public class Profile
    {
        [Column("PER_CODIGO")]
        public string PER_CODIGO { get; set; }

        [Column("PER_NOMBRE")]
        public string PER_NOMBRE { get; set; }

        [Column("PER_DESCRIPCION")]
        public string PER_DESCRIPCION { get; set; }

        [Column("CREADO_POR")]
        public string CREADO_POR { get; set; }

        [Column("FECHA_CREACION")]
        public DateTime FECHA_CREACION { get; set; }

        [Column("MODIFICADO_POR")]
        public string MODIFICADO_POR { get; set; }

        [Column("FECHA_MODIFICADO")]
        public DateTime FECHA_MODIFICADO { get; set; }
    }
}