namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NIVEISDEACESSO")]
    public partial class NIVEISDEACESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NIVEISDEACESSO()
        {
            REGRASACESSO = new HashSet<REGRASACESSO>();
        }

        [Key]
        public int IDNIVEL { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCNIVEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGRASACESSO> REGRASACESSO { get; set; }
    }
}
