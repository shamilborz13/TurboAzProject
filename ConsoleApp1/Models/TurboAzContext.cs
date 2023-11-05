using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1.Models
{
    public partial class TurboAzContext : DbContext
    {
        public TurboAzContext()
        {
        }

        public TurboAzContext(DbContextOptions<TurboAzContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Il> Ils { get; set; } = null!;
        public virtual DbSet<Marka> Markas { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;
        public virtual DbSet<Motor> Motors { get; set; } = null!;
        public virtual DbSet<Qiymet> Qiymets { get; set; } = null!;
        public virtual DbSet<Reng> Rengs { get; set; } = null!;
        public virtual DbSet<Sheher> Shehers { get; set; } = null!;
        public virtual DbSet<Shekil> Shekils { get; set; } = null!;
        public virtual DbSet<SuretQutusu> SuretQutusus { get; set; } = null!;
        public virtual DbSet<Yanacag> Yanacags { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=STHQ012D-11;Initial Catalog=TurboAz;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("CAR");

                entity.HasOne(d => d.Il)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.IlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__IlId__4F7CD00D");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__MarkaId__4BAC3F29");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__ModelId__4CA06362");

                entity.HasOne(d => d.Motor)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.MotorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__MotorId__5165187F");

                entity.HasOne(d => d.Qiymet)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.QiymetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__QiymetId__4E88ABD4");

                entity.HasOne(d => d.Reng)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.RengId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__RengId__5070F446");

                entity.HasOne(d => d.Sheher)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.SheherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__SheherId__4D94879B");

                entity.HasOne(d => d.Shekeil)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ShekeilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__ShekeilId__5441852A");

                entity.HasOne(d => d.Suret)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.SuretId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__SuretId__52593CB8");

                entity.HasOne(d => d.Yanavag)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.YanavagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__YanavagId__534D60F1");
            });

            modelBuilder.Entity<Il>(entity =>
            {
                entity.ToTable("Il");

                entity.Property(e => e.Il1).HasColumnName("Il");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.ToTable("Marka");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.ToTable("Model");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Model__MarkaId__398D8EEE");
            });

            modelBuilder.Entity<Motor>(entity =>
            {
                entity.ToTable("Motor");

                entity.Property(e => e.Motor1).HasColumnName("Motor");
            });

            modelBuilder.Entity<Qiymet>(entity =>
            {
                entity.ToTable("Qiymet");

                entity.Property(e => e.Qiymet1).HasColumnName("Qiymet");
            });

            modelBuilder.Entity<Reng>(entity =>
            {
                entity.ToTable("Reng");

                entity.Property(e => e.Reng1).HasColumnName("Reng");
            });

            modelBuilder.Entity<Sheher>(entity =>
            {
                entity.ToTable("Sheher");

                entity.Property(e => e.Sheher1).HasColumnName("Sheher");
            });

            modelBuilder.Entity<Shekil>(entity =>
            {
                entity.ToTable("Shekil");

                entity.Property(e => e.Shekil1).HasColumnName("Shekil");
            });

            modelBuilder.Entity<SuretQutusu>(entity =>
            {
                entity.ToTable("SuretQutusu");

                entity.Property(e => e.SuretQutusu1).HasColumnName("SuretQutusu");
            });

            modelBuilder.Entity<Yanacag>(entity =>
            {
                entity.ToTable("Yanacag");

                entity.Property(e => e.Yanacag1).HasColumnName("Yanacag");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
