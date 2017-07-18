namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTOS()
        {
            HISTORICO = new HashSet<HISTORICO>();
            PRODUTOSDAVENDA = new HashSet<PRODUTOSDAVENDA>();
        }

        [Key]
        public int IDPROD { get; set; }

        public int? IDUSU { get; set; }

        public int? IDUNID { get; set; }

        [Required]
        [StringLength(100)]
        public string CODPROD { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCPROD { get; set; }

        public decimal? CUSTOPROD { get; set; }

        public bool? ATIVO { get; set; }

        public decimal? VENDAPROD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTOSDAVENDA> PRODUTOSDAVENDA { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }

        public virtual UNIDMEDIDA UNIDMEDIDA { get; set; }
    }
}
