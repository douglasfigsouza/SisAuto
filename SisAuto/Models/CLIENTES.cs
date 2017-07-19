namespace SisAuto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES()
        {
            HISTORICO = new HashSet<HISTORICO>();
            VENDAS = new HashSet<VENDAS>();
        }

        [Key]
        public int IDCLI { get; set; }

        public int? IDUSU { get; set; }

        public int? CIDADEID { get; set; }

        [Required(ErrorMessage ="O campo Nome é Obrigatório!")]
        [StringLength(200)]
        [Display(Name ="Nome")]
        public string NOMECLI { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório!")]
        [Display(Name = "Bairro")]
        [StringLength(200)]
        public string BAIRROCLI { get; set; }

        [StringLength(100)]
        [Display(Name = "Rua")]
        public string RUACLI { get; set; }
        [Display(Name = "N°")]
        public int? NUMCLI { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(20)]
        public string FONECLI { get; set; }

        [StringLength(20)]
        [Display(Name = "CPF")]
        public string CPFCLI { get; set; }

        [StringLength(8000)]
        public string OBSCLI { get; set; }

        public bool? ATIVO { get; set; }

        public virtual CIDADE CIDADE { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDAS> VENDAS { get; set; }
    }
}
