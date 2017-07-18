namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            CLIENTES = new HashSet<CLIENTES>();
            HISTORICO = new HashSet<HISTORICO>();
            MECANICOS = new HashSet<MECANICOS>();
            PRODUTOS = new HashSet<PRODUTOS>();
            REGRASACESSO = new HashSet<REGRASACESSO>();
            VEICULOS = new HashSet<VEICULOS>();
        }

        [Key]
        public int IDUSU { get; set; }

        [Required]
        [StringLength(200)]
        public string NOMEUSU { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGINUSU { get; set; }

        [Required]
        [StringLength(50)]
        public string SENHAUSU { get; set; }

        public bool? ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MECANICOS> MECANICOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTOS> PRODUTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGRASACESSO> REGRASACESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEICULOS> VEICULOS { get; set; }
    }
}
