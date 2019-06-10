namespace Toten.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_Connection : DbContext
    {
        public DB_Connection()
            : base("name=DB_Connection")
        {
        }

        public virtual DbSet<Imagens> Imagens { get; set; }
        public virtual DbSet<Comentarios> Comentarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imagens>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Imagens>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Imagens>()
                .Property(e => e.regiao)
                .IsUnicode(false);

            modelBuilder.Entity<Imagens>()
                .Property(e => e.descrcao)
                .IsUnicode(false);

            modelBuilder.Entity<Comentarios>()
               .Property(e => e.comentario)
               .IsUnicode(false);
        }
    }
}
