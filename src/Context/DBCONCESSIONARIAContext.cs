using System;
using System.Collections.Generic;
using CodeTest.src.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CodeTest.src.Context.Models
{
    public partial class DBCONCESSIONARIAContext : DbContext
    {
        public DBCONCESSIONARIAContext()
        {
        }

        public DBCONCESSIONARIAContext(DbContextOptions<DBCONCESSIONARIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vei001Marca> Vei001Marcas { get; set; } = null!;
        public virtual DbSet<Vei002Modelo> Vei002Modelos { get; set; } = null!;
        public virtual DbSet<Vei003Combustivel> Vei003Combustivels { get; set; } = null!;
        public virtual DbSet<Vei004ModeloVersao> Vei004ModeloVersaos { get; set; } = null!;
        public virtual DbSet<Vnd001Vendedor> Vnd001Vendedors { get; set; } = null!;
        public virtual DbSet<Vnd002Vendum> Vnd002Venda { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//             if (!optionsBuilder.IsConfigured)
//             {
// // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
// //                 optionsBuilder.UseSqlServer("Server=localhost,1433; Initial Catalog=DBCONCESSIONARIA; User Id=sa;Password= Dev@Dckr1;");
//             }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vei001Marca>(entity =>
            {
                entity.HasKey(e => e.IdeMarca)
                    .HasName("PK__VEI001_M__FC382ADB57684E31");

                entity.ToTable("VEI001_MARCA");

                entity.HasIndex(e => e.NmeMarca, "UNQ_VEI001_NmeMarca")
                    .IsUnique();

                entity.Property(e => e.NmeMarca)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vei002Modelo>(entity =>
            {
                entity.HasKey(e => e.IdeModelo)
                    .HasName("PK__VEI002_M__68256AA4F27314BD");

                entity.ToTable("VEI002_MODELO");

                entity.HasIndex(e => e.CodModelo, "UNQ_VEI002_CodModelo")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdeMarca, e.NmeModelo }, "UNQ_VEI002_IdeMarca_NmeModelo")
                    .IsUnique();

                entity.Property(e => e.CodModelo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NmeModelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdeMarcaNavigation)
                    .WithMany(p => p.Vei002Modelos)
                    .HasForeignKey(d => d.IdeMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEI002_IdeMarca");
            });

            modelBuilder.Entity<Vei003Combustivel>(entity =>
            {
                entity.HasKey(e => e.IdeCombustivel)
                    .HasName("PK__VEI003_C__D4DD7684F8359374");

                entity.ToTable("VEI003_COMBUSTIVEL");

                entity.HasIndex(e => e.NmeCombustivel, "UNQ_VEI003_NmeCombustivel")
                    .IsUnique();

                entity.Property(e => e.NmeCombustivel)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vei004ModeloVersao>(entity =>
            {
                entity.HasKey(e => e.IdeModeloVersao)
                    .HasName("PK__VEI004_M__97F3C90E3D99C566");

                entity.ToTable("VEI004_MODELO_VERSAO");

                entity.HasIndex(e => new { e.IdeModelo, e.IdeCombustivel, e.NroAno }, "UNQ_VEI004_IdeModelo_IdeCombustivel_NroAno")
                    .IsUnique();

                entity.Property(e => e.VlrPrecoTabelado).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.IdeCombustivelNavigation)
                    .WithMany(p => p.Vei004ModeloVersaos)
                    .HasForeignKey(d => d.IdeCombustivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEI004_IdeCombustivel");

                entity.HasOne(d => d.IdeModeloNavigation)
                    .WithMany(p => p.Vei004ModeloVersaos)
                    .HasForeignKey(d => d.IdeModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEI004_IdeModelo");
            });

            modelBuilder.Entity<Vnd001Vendedor>(entity =>
            {
                entity.HasKey(e => e.IdeVendedor)
                    .HasName("PK__VND001_V__4FD47E53B07BAFA8");

                entity.ToTable("VND001_VENDEDOR");

                entity.Property(e => e.NmeVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vnd002Vendum>(entity =>
            {
                entity.HasKey(e => e.IdeVenda)
                    .HasName("PK__VND002_V__D79A27C7EB220A23");

                entity.ToTable("VND002_VENDA");

                entity.Property(e => e.VlrPrecoVenda).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.IdeModeloVersaoNavigation)
                    .WithMany(p => p.Vnd002Venda)
                    .HasForeignKey(d => d.IdeModeloVersao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VND002_IdeModeloVersao");

                entity.HasOne(d => d.IdeVendedorNavigation)
                    .WithMany(p => p.Vnd002Venda)
                    .HasForeignKey(d => d.IdeVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VND002_IdeVendedor");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
