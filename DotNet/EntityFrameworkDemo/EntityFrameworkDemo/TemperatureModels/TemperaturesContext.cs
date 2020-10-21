using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkDemo.TemperatureModels
{
    public partial class TemperaturesContext : DbContext
    {
        public TemperaturesContext()
        {
        }

        public TemperaturesContext(DbContextOptions<TemperaturesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Temperatures> Temperatures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Temperatures;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temperatures>(entity =>
            {
                entity.HasKey(e => e.TemperatureId);

                entity.Property(e => e.SensorId).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
