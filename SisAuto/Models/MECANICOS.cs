namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MECANICOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MECANICOS()
        {
            HISTORICO = new HashSet<HISTORICO>();
            MECANICOSDOSERVICO = new HashSet<MECANICOSDOSERVICO>();
        }

        [Key]
        public int IDMEC { get; set; }

        public int? IDUSU { get; set; }

        public int? CIDADEID { get; set; }

        [Required]
        [StringLength(200)]
        public string NOMEMEC { get; set; }

        [Required]
        [StringLength(200)]
        public string BAIRROMEC { get; set; }

        [StringLength(200)]
        public string RUAMEC { get; set; }

        public int? NUMMEC { get; set; }

        [StringLength(20)]
        public string FONEMEC { get; set; }

        public bool? ATIVO { get; set; }

        public virtual CIDADE CIDADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MECANICOSDOSERVICO> MECANICOSDOSERVICO { get; set; }
    }
}
