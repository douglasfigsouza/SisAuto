namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REGRASACESSO")]
    public partial class REGRASACESSO
    {
        [Key]
        public int IDREGRA { get; set; }

        public int? IDNIVEL { get; set; }

        public int? IDUSU { get; set; }

        [Required]
        [StringLength(50)]
        public string REGRA { get; set; }

        public virtual NIVEISDEACESSO NIVEISDEACESSO { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
