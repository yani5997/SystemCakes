using System;
using H.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace H.DataAccess;

public partial class sistemContext : DbContext
{
    public sistemContext()
    {
    }

    public sistemContext(DbContextOptions<sistemContext> options)
        : base(options)
    {
    }
    public virtual DbSet<TProducto> TProducto { get; set; }
    public virtual DbSet<TCategoria> TCategoria { get; set; }
    public virtual DbSet<TCliente> TCliente { get; set; }
    public virtual DbSet<TRol> TRol { get; set; }
    public virtual DbSet<TPersona> TPersona { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<TProducto>(entity =>
        {
            entity.ToTable("T_Producto");

            entity.Property(e => e.Id).HasComment("Identificador de registro");

            entity.Property(e => e.IdCategoria).HasComment("Identificador de categoria del registro");

            entity.Property(e => e.Nombre).HasComment("Nombre del producto");

            entity.Property(e => e.Descripcion).HasComment("Descripcion del producto");

            entity.Property(e => e.Stock).HasComment("Stock del producto");

            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasComment("Fecha de vencimiento del producto");

            entity.Property(e => e.CostoUnitario)
                .HasPrecision(18, 2)
                .HasComment("Costo unitario del producto");

            entity.Property(e => e.CostoTotal)
                .HasPrecision(18, 2)
                .HasComment("Costo total del producto");

            entity.Property(e => e.Igv)
                .HasPrecision(18, 2)
                .HasComment("Igv del producto");

            entity.Property(e => e.Estado).HasComment("Estado del registro");

            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de creación del registro");

            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de modificación del registro");

            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de creación del registro");

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de modificación del registro");
        });

        modelBuilder.Entity<TCategoria>(entity =>
        {
            entity.ToTable("T_Categoria");

            entity.Property(e => e.Id).HasComment("Identificador de registro");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.Estado).HasComment("Estado del registro");

            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de creación del registro");

            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de modificación del registro");

            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de creación del registro");

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de modificación del registro");
        });

        modelBuilder.Entity<TCliente>(entity =>
        {
            entity.ToTable("T_Cliente");

            entity.Property(e => e.Id).HasComment("Identificador de registro");

            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.NombresPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.ApellidosPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.Estado).HasComment("Estado del registro");

            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de creación del registro");

            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de modificación del registro");

            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de creación del registro");

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de modificación del registro");
        });

        modelBuilder.Entity<TRol>(entity =>
        {
            entity.ToTable("T_Rol");

            entity.Property(e => e.Id).HasComment("Identificador de registro");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.Estado).HasComment("Estado del registro");

            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de creación del registro");

            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de modificación del registro");

            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de creación del registro");

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de modificación del registro");
        });

        modelBuilder.Entity<TPersona>(entity =>
        {
            entity.ToTable("T_Persona");

            entity.Property(e => e.Id).HasComment("Identificador de registro");
            entity.Property(e => e.IdRol).HasComment("Identificador de registro");

            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("");

            entity.Property(e => e.Estado).HasComment("Estado del registro");

            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de creación del registro");

            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasComment("Fecha de modificación del registro");

            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de creación del registro");

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de modificación del registro");
        });

    }
}
