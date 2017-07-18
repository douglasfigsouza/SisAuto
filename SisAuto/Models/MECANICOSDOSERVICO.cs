namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MECANICOSDOSERVICO")]
    public partial class MECANICOSDOSERVICO
    {
        [Key]
        public int IDMECVENDAS { get; set; }

        public int? IDVENDA { get; set; }

        public int? IDMEC { get; set; }

        [StringLength(1000)]
        public string DESCSERVICO { get; set; }

        public decimal? VALORSERVICO { get; set; }

        public virtual MECANICOS MECANICOS { get; set; }

        public virtual VENDAS VENDAS { get; set; }
    }
}
