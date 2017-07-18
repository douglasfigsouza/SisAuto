namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUTOSDAVENDA")]
    public partial class PRODUTOSDAVENDA
    {
        [Key]
        public int IDPRODVENDA { get; set; }

        public int? IDPROD { get; set; }

        public int? IDVENDA { get; set; }

        public decimal? QTD { get; set; }

        public decimal? VALORTOTAL { get; set; }

        public virtual PRODUTOS PRODUTOS { get; set; }

        public virtual VENDAS VENDAS { get; set; }
    }
}
