using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace bem_brasil.Data
{
    public partial class bemBrasilContext : DbContext
    {
        public bemBrasilContext()
        {
        }

        public bemBrasilContext(DbContextOptions<bemBrasilContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Doaco> Doacoes { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Operador> Operadors { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=./;Database=bemBrasil;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.CodigoCidade)
                    .HasName("PK__Cidade__67E4AB1CC7BACB48");

                entity.ToTable("Cidade");

                entity.Property(e => e.CodigoCidade).ValueGeneratedNever();

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.CodigoEstado)
                    .HasConstraintName("FK__Cidade__CodigoEs__267ABA7A");
            });

            modelBuilder.Entity<Doaco>(entity =>
            {
                entity.HasKey(e => e.CodigoDoacoes)
                    .HasName("PK__Doacoes__576AB63CFCD3FC82");

                entity.Property(e => e.CodigoDoacoes).ValueGeneratedNever();

                entity.HasOne(d => d.CodigoOperadorNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoOperador)
                    .HasConstraintName("FK__Doacoes__CodigoO__30F848ED");

                entity.HasOne(d => d.CodigoProdutoNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoProduto)
                    .HasConstraintName("FK__Doacoes__CodigoP__31EC6D26");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.CodigoEndereco)
                    .HasName("PK__Endereco__ECFD971274D606FA");

                entity.ToTable("Endereco");

                entity.Property(e => e.CodigoEndereco).ValueGeneratedNever();

                entity.Property(e => e.Cep).HasColumnName("CEP");

                entity.HasOne(d => d.CodigoCidadeNavigation)
                    .WithMany(p => p.Enderecos)
                    .HasForeignKey(d => d.CodigoCidade)
                    .HasConstraintName("FK__Endereco__Codigo__29572725");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado)
                    .HasName("PK__Estado__6BC4B7F00203CA5E");

                entity.ToTable("Estado");

                entity.Property(e => e.CodigoEstado).ValueGeneratedNever();

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");
            });

            modelBuilder.Entity<Operador>(entity =>
            {
                entity.HasKey(e => e.CodigoOperador)
                    .HasName("PK__Operador__62F78FE28A0C8F1E");

                entity.ToTable("Operador");

                entity.Property(e => e.CodigoOperador).ValueGeneratedNever();

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.HasOne(d => d.CodigoEnderecoNavigation)
                    .WithMany(p => p.Operadors)
                    .HasForeignKey(d => d.CodigoEndereco)
                    .HasConstraintName("FK__Operador__Codigo__2C3393D0");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.CodigoProduto)
                    .HasName("PK__Produto__F94CC5B91AB550AD");

                entity.ToTable("Produto");

                entity.Property(e => e.CodigoProduto).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
