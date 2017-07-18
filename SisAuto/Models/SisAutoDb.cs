namespace SisAuto.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SisAutoDb : DbContext
    {
        public SisAutoDb()
            : base("name=SisAutoDb")
        {
        }

        public virtual DbSet<CIDADE> CIDADE { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<HISTORICO> HISTORICO { get; set; }
        public virtual DbSet<MECANICOS> MECANICOS { get; set; }
        public virtual DbSet<MECANICOSDOSERVICO> MECANICOSDOSERVICO { get; set; }
        public virtual DbSet<NIVEISDEACESSO> NIVEISDEACESSO { get; set; }
        public virtual DbSet<PRODUTOS> PRODUTOS { get; set; }
        public virtual DbSet<PRODUTOSDAVENDA> PRODUTOSDAVENDA { get; set; }
        public virtual DbSet<REGRASACESSO> REGRASACESSO { get; set; }
        public virtual DbSet<UNIDMEDIDA> UNIDMEDIDA { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VEICULOS> VEICULOS { get; set; }
        public virtual DbSet<VENDAS> VENDAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CIDADE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.NOMECLI)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.BAIRROCLI)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.RUACLI)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.FONECLI)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CPFCLI)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.OBSCLI)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO>()
                .Property(e => e.SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO>()
                .HasMany(e => e.CIDADE)
                .WithOptional(e => e.ESTADO)
                .HasForeignKey(e => e.ESTADOID);

            modelBuilder.Entity<ESTADO>()
                .HasMany(e => e.CIDADE1)
                .WithOptional(e => e.ESTADO1)
                .HasForeignKey(e => e.ESTADOID);

            modelBuilder.Entity<HISTORICO>()
                .Property(e => e.DESCOP)
                .IsUnicode(false);

            modelBuilder.Entity<MECANICOS>()
                .Property(e => e.NOMEMEC)
                .IsUnicode(false);

            modelBuilder.Entity<MECANICOS>()
                .Property(e => e.BAIRROMEC)
                .IsUnicode(false);

            modelBuilder.Entity<MECANICOS>()
                .Property(e => e.RUAMEC)
                .IsUnicode(false);

            modelBuilder.Entity<MECANICOS>()
                .Property(e => e.FONEMEC)
                .IsUnicode(false);

            modelBuilder.Entity<MECANICOSDOSERVICO>()
                .Property(e => e.DESCSERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<NIVEISDEACESSO>()
                .Property(e => e.DESCNIVEL)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTOS>()
                .Property(e => e.CODPROD)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTOS>()
                .Property(e => e.DESCPROD)
                .IsUnicode(false);

            modelBuilder.Entity<REGRASACESSO>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDMEDIDA>()
                .Property(e => e.DESCUNID)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDMEDIDA>()
                .Property(e => e.SIGLAUNID)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.NOMEUSU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.LOGINUSU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.SENHAUSU)
                .IsUnicode(false);

            modelBuilder.Entity<VEICULOS>()
                .Property(e => e.DESCVEIC)
                .IsUnicode(false);

            modelBuilder.Entity<VEICULOS>()
                .Property(e => e.MARCAVEIC)
                .IsUnicode(false);

            modelBuilder.Entity<VEICULOS>()
                .Property(e => e.MODELOVEIC)
                .IsUnicode(false);

            modelBuilder.Entity<VEICULOS>()
                .Property(e => e.PLACAVEIC)
                .IsUnicode(false);
        }
    }
}
