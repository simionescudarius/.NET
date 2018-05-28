namespace BibApi {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BibContext : DbContext {
        public BibContext()
            : base("name=projectDatabaseConnection") {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Carte> Carte { get; set; }
        public virtual DbSet<Cititor> Cititor { get; set; }
        public virtual DbSet<Gen> Gen { get; set; }
        public virtual DbSet<Imprumut> Imprumut { get; set; }
        public virtual DbSet<Review> Review { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Autor>()
                .HasMany(e => e.Carte)
                .WithRequired(e => e.Autor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Carte>()
                .HasMany(e => e.Imprumut)
                .WithRequired(e => e.Carte)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Cititor>()
                .HasMany(e => e.Imprumut)
                .WithRequired(e => e.Cititor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gen>()
                .HasMany(e => e.Carte)
                .WithRequired(e => e.Gen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Imprumut>()
                .HasMany(e => e.Review)
                .WithRequired(e => e.Imprumut)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.text)
                .IsUnicode(false);
        }
    }
}
