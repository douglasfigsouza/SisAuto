namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VEICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEICULOS()
        {
            HISTORICO = new HashSet<HISTORICO>();
            VENDAS = new HashSet<VENDAS>();
        }

        [Key]
        public int IDVEIC { get; set; }

        public int? IDUSU { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCVEIC { get; set; }

        [StringLength(100)]
        public string MARCAVEIC { get; set; }

        [StringLength(100)]
        public string MODELOVEIC { get; set; }

        [StringLength(12)]
        public string PLACAVEIC { get; set; }

        public bool? ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDAS> VENDAS { get; set; }
    }
}
