namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CIDADE")]
    public partial class CIDADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIDADE()
        {
            CLIENTES = new HashSet<CLIENTES>();
            MECANICOS = new HashSet<MECANICOS>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDADEID { get; set; }

        public int? ESTADOID { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        public byte? CAPITAL { get; set; }

        public virtual ESTADO ESTADO { get; set; }

        public virtual ESTADO ESTADO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MECANICOS> MECANICOS { get; set; }
    }
}
