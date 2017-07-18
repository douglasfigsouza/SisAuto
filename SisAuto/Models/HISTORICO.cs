namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HISTORICO")]
    public partial class HISTORICO
    {
        [Key]
        public int IDHISTORICO { get; set; }

        public int? IDUSU { get; set; }

        public int? IDCLI { get; set; }

        public int? IDMEC { get; set; }

        public int? IDPROD { get; set; }

        public int? IDVEIC { get; set; }

        public int? IDUNID { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCOP { get; set; }

        public DateTime DATAHROP { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        public virtual PRODUTOS PRODUTOS { get; set; }

        public virtual UNIDMEDIDA UNIDMEDIDA { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }

        public virtual VEICULOS VEICULOS { get; set; }

        public virtual MECANICOS MECANICOS { get; set; }
    }
}
