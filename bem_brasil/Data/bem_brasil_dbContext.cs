using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace bem_brasil.Data
{
    public partial class bem_brasil_dbContext : DbContext
    {
        public bem_brasil_dbContext()
        {
        }

        public bem_brasil_dbContext(DbContextOptions<bem_brasil_dbContext> options)
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
                optionsBuilder.UseSqlServer("Server=bem-brasildbserver.database.windows.net,1433;Database=bem_brasil_db;Initial Catalog=bem_brasil_db;Persist Security Info=False;User ID=bemBrasil;Password=Fefe2010##;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.CodigoCidade)
                    .HasName("PK__Cidade__67E4AB1CF58147C9");

                entity.ToTable("Cidade");

                entity.Property(e => e.CodigoCidade).ValueGeneratedNever();

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.CodigoEstado)
                    .HasConstraintName("FK__Cidade__CodigoEs__5EBF139D");
            });

            modelBuilder.Entity<Doaco>(entity =>
            {
                entity.HasKey(e => e.CodigoDoacoes)
                    .HasName("PK__Doacoes__576AB63C73CFE564");

                entity.Property(e => e.CodigoDoacoes).ValueGeneratedNever();

                entity.HasOne(d => d.CodigoEnderecoNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoEndereco)
                    .HasConstraintName("FK__Doacoes__CodigoE__693CA210");

                entity.HasOne(d => d.CodigoOperadorNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoOperador)
                    .HasConstraintName("FK__Doacoes__CodigoO__6A30C649");

                entity.HasOne(d => d.CodigoProdutoNavigation)
                    .WithMany(p => p.Doacos)
                    .HasForeignKey(d => d.CodigoProduto)
                    .HasConstraintName("FK__Doacoes__CodigoP__6B24EA82");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.CodigoEndereco)
                    .HasName("PK__Endereco__ECFD971230EFDCC8");

                entity.ToTable("Endereco");

                entity.Property(e => e.CodigoEndereco).ValueGeneratedNever();

                entity.Property(e => e.Cep).HasColumnName("CEP");

                entity.HasOne(d => d.CodigoOperadorNavigation)
                    .WithMany(p => p.Enderecos)
                    .HasForeignKey(d => d.CodigoOperador)
                    .HasConstraintName("FK__Endereco__Codigo__6477ECF3");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado)
                    .HasName("PK__Estado__6BC4B7F0463D86DC");

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
                    .HasName("PK__Operador__62F78FE2C22ACAF7");

                entity.ToTable("Operador");

                entity.Property(e => e.CodigoOperador).ValueGeneratedNever();

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.DtInclusao).HasColumnType("datetime");

                entity.Property(e => e.DtNascimento).HasColumnType("datetime");

                entity.HasOne(d => d.CodigoCidadeNavigation)
                    .WithMany(p => p.Operadors)
                    .HasForeignKey(d => d.CodigoCidade)
                    .HasConstraintName("FK__Operador__Codigo__619B8048");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.CodigoProduto)
                    .HasName("PK__Produto__F94CC5B988F5624A");

                entity.ToTable("Produto");

                entity.Property(e => e.CodigoProduto).ValueGeneratedNever();

                entity.Property(e => e.Validade).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
