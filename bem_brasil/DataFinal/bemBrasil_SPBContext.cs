using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace bem_brasil.DataFinal
{
    public partial class bemBrasil_SPBContext : DbContext
    {
        public bemBrasil_SPBContext()
        {
        }

        public bemBrasil_SPBContext(DbContextOptions<bemBrasil_SPBContext> options)
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
                optionsBuilder.UseSqlServer("Server=./;Database=bemBrasil_SPB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.CodigoCidade)
                    .HasName("PK__Cidade__67E4AB1CA0E52D2B");

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
                    .HasName("PK__Doacoes__576AB63CD245211A");

                entity.Property(e => e.CodigoDoacoes).ValueGeneratedNever();

                entity.HasOne(d => d.CodigoEnderecoNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoEndereco)
                    .HasConstraintName("FK__Doacoes__CodigoE__30F848ED");

                entity.HasOne(d => d.CodigoOperadorNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoOperador)
                    .HasConstraintName("FK__Doacoes__CodigoO__31EC6D26");

                entity.HasOne(d => d.CodigoProdutoNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoProduto)
                    .HasConstraintName("FK__Doacoes__CodigoP__32E0915F");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.CodigoEndereco)
                    .HasName("PK__Endereco__ECFD9712909E16BD");

                entity.ToTable("Endereco");

                entity.Property(e => e.CodigoEndereco).ValueGeneratedNever();

                entity.Property(e => e.Cep).HasColumnName("CEP");

                entity.HasOne(d => d.CodigoOperadorNavigation)
                    .WithMany(p => p.Enderecos)
                    .HasForeignKey(d => d.CodigoOperador)
                    .HasConstraintName("FK__Endereco__Codigo__2C3393D0");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado)
                    .HasName("PK__Estado__6BC4B7F03369F1B7");

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
                    .HasName("PK__Operador__62F78FE29467B9AF");

                entity.ToTable("Operador");

                entity.Property(e => e.CodigoOperador).ValueGeneratedNever();

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.DtInclusao).HasColumnType("datetime");

                entity.Property(e => e.DtNascimento).HasColumnType("datetime");

                entity.HasOne(d => d.CodigoCidadeNavigation)
                    .WithMany(p => p.Operadors)
                    .HasForeignKey(d => d.CodigoCidade)
                    .HasConstraintName("FK__Operador__Codigo__29572725");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.CodigoProduto)
                    .HasName("PK__Produto__F94CC5B994C977AF");

                entity.ToTable("Produto");

                entity.Property(e => e.CodigoProduto).ValueGeneratedNever();

                entity.Property(e => e.Validade).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
