namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDAS()
        {
            MECANICOSDOSERVICO = new HashSet<MECANICOSDOSERVICO>();
            PRODUTOSDAVENDA = new HashSet<PRODUTOSDAVENDA>();
        }

        [Key]
        public int IDVENDA { get; set; }

        public int? IDCLI { get; set; }

        public int? IDVEIC { get; set; }

        public DateTime DATAINICIO { get; set; }

        public DateTime? DATATERMINO { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MECANICOSDOSERVICO> MECANICOSDOSERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTOSDAVENDA> PRODUTOSDAVENDA { get; set; }

        public virtual VEICULOS VEICULOS { get; set; }
    }
}
