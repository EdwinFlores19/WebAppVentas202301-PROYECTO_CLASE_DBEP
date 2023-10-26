using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAppVentas202301.Models;

public partial class BdVentas : DbContext
{
    public BdVentas()
    {
    }

    public BdVentas(DbContextOptions<BdVentas> options)
        : base(options)
    {
    }

    public virtual DbSet<TbAbastecimiento> TbAbastecimientos { get; set; }

    public virtual DbSet<TbCliente> TbClientes { get; set; }

    public virtual DbSet<TbDetalleCompra> TbDetalleCompras { get; set; }

    public virtual DbSet<TbDetalleFactura> TbDetalleFacturas { get; set; }

    public virtual DbSet<TbDistrito> TbDistritos { get; set; }

    public virtual DbSet<TbFactura> TbFacturas { get; set; }

    public virtual DbSet<TbOrdenCompra> TbOrdenCompras { get; set; }

    public virtual DbSet<TbProducto> TbProductos { get; set; }

    public virtual DbSet<TbProveedor> TbProveedors { get; set; }

    public virtual DbSet<TbVendedor> TbVendedors { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=EDWINFLORES;Initial Catalog=VENTAS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbAbastecimiento>(entity =>
        {
            entity.HasKey(e => new { e.CodPrv, e.CodPro }).HasName("PK__TB_ABAST__6A35C18953DE7F9B");

            entity.ToTable("TB_ABASTECIMIENTO");

            entity.Property(e => e.CodPrv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRV");
            entity.Property(e => e.CodPro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRO");
            entity.Property(e => e.PreAba)
                .HasColumnType("money")
                .HasColumnName("PRE_ABA");

            entity.HasOne(d => d.CodProNavigation).WithMany(p => p.TbAbastecimientos)
                .HasForeignKey(d => d.CodPro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_ABASTE__COD_P__403A8C7D");

            entity.HasOne(d => d.CodPrvNavigation).WithMany(p => p.TbAbastecimientos)
                .HasForeignKey(d => d.CodPrv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_ABASTE__COD_P__3F466844");
        });

        modelBuilder.Entity<TbCliente>(entity =>
        {
            entity.HasKey(e => e.CodCli).HasName("PK__TB_CLIEN__151FF482078E33A7");

            entity.ToTable("TB_CLIENTE");

            entity.Property(e => e.CodCli)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_CLI");
            entity.Property(e => e.CodDis)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_DIS");
            entity.Property(e => e.Contacto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.DirCli)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIR_CLI");
            entity.Property(e => e.FecReg)
                .HasColumnType("date")
                .HasColumnName("FEC_REG");
            entity.Property(e => e.RazSocCli)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RAZ_SOC_CLI");
            entity.Property(e => e.RucCli)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RUC_CLI");
            entity.Property(e => e.TipCli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIP_CLI");
            entity.Property(e => e.TlfCli)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TLF_CLI");

            entity.HasOne(d => d.CodDisNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.CodDis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_CLIENT__COD_D__29572725");
        });

        modelBuilder.Entity<TbDetalleCompra>(entity =>
        {
            entity.HasKey(e => new { e.NumOco, e.CodPro }).HasName("PK__TB_DETAL__95595100850D99A0");

            entity.ToTable("TB_DETALLE_COMPRA");

            entity.Property(e => e.NumOco)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_OCO");
            entity.Property(e => e.CodPro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRO");
            entity.Property(e => e.CanPed).HasColumnName("CAN_PED");

            entity.HasOne(d => d.CodProNavigation).WithMany(p => p.TbDetalleCompras)
                .HasForeignKey(d => d.CodPro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_DETALL__COD_P__3C69FB99");

            entity.HasOne(d => d.NumOcoNavigation).WithMany(p => p.TbDetalleCompras)
                .HasForeignKey(d => d.NumOco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_DETALL__NUM_O__3B75D760");
        });

        modelBuilder.Entity<TbDetalleFactura>(entity =>
        {
            entity.HasKey(e => new { e.NumFac, e.CodPro }).HasName("PK__TB_DETAL__8BAEAEAC045DDED4");

            entity.ToTable("TB_DETALLE_FACTURA");

            entity.Property(e => e.NumFac)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_FAC");
            entity.Property(e => e.CodPro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRO");
            entity.Property(e => e.CanVen).HasColumnName("CAN_VEN");
            entity.Property(e => e.PreVen)
                .HasColumnType("money")
                .HasColumnName("PRE_VEN");

            entity.HasOne(d => d.CodProNavigation).WithMany(p => p.TbDetalleFacturas)
                .HasForeignKey(d => d.CodPro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_DETALL__COD_P__38996AB5");

            entity.HasOne(d => d.NumFacNavigation).WithMany(p => p.TbDetalleFacturas)
                .HasForeignKey(d => d.NumFac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_DETALL__NUM_F__37A5467C");
        });

        modelBuilder.Entity<TbDistrito>(entity =>
        {
            entity.HasKey(e => e.CodDis).HasName("PK__TB_DISTR__2B2C6E89C497B908");

            entity.ToTable("TB_DISTRITO");

            entity.Property(e => e.CodDis)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_DIS");
            entity.Property(e => e.NomDis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_DIS");
        });

        modelBuilder.Entity<TbFactura>(entity =>
        {
            entity.HasKey(e => e.NumFac).HasName("PK__TB_FACTU__C9254C97799D88AA");

            entity.ToTable("TB_FACTURA");

            entity.Property(e => e.NumFac)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_FAC");
            entity.Property(e => e.CodCli)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_CLI");
            entity.Property(e => e.CodVen)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_VEN");
            entity.Property(e => e.EstFac)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EST_FAC");
            entity.Property(e => e.FecCan)
                .HasColumnType("date")
                .HasColumnName("FEC_CAN");
            entity.Property(e => e.FecFac)
                .HasColumnType("date")
                .HasColumnName("FEC_FAC");
            entity.Property(e => e.PorcIgv)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PORC_IGV");

            entity.HasOne(d => d.CodCliNavigation).WithMany(p => p.TbFacturas)
                .HasForeignKey(d => d.CodCli)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_FACTUR__COD_C__2F10007B");

            entity.HasOne(d => d.CodVenNavigation).WithMany(p => p.TbFacturas)
                .HasForeignKey(d => d.CodVen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_FACTUR__COD_V__300424B4");
        });

        modelBuilder.Entity<TbOrdenCompra>(entity =>
        {
            entity.HasKey(e => e.NumOco).HasName("PK__TB_ORDEN__D7D2B33B605865AA");

            entity.ToTable("TB_ORDEN_COMPRA");

            entity.Property(e => e.NumOco)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NUM_OCO");
            entity.Property(e => e.CodPrv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRV");
            entity.Property(e => e.EstOco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EST_OCO");
            entity.Property(e => e.FecAte)
                .HasColumnType("date")
                .HasColumnName("FEC_ATE");
            entity.Property(e => e.FecOco)
                .HasColumnType("date")
                .HasColumnName("FEC_OCO");

            entity.HasOne(d => d.CodPrvNavigation).WithMany(p => p.TbOrdenCompras)
                .HasForeignKey(d => d.CodPrv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_ORDEN___COD_P__32E0915F");
        });

        modelBuilder.Entity<TbProducto>(entity =>
        {
            entity.HasKey(e => e.CodPro).HasName("PK__TB_PRODU__28BE23B5C34BC94E");

            entity.ToTable("TB_PRODUCTO");

            entity.Property(e => e.CodPro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRO");
            entity.Property(e => e.DesPro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_PRO");
            entity.Property(e => e.Importado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IMPORTADO");
            entity.Property(e => e.LinPro)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LIN_PRO");
            entity.Property(e => e.PrePro)
                .HasColumnType("money")
                .HasColumnName("PRE_PRO");
            entity.Property(e => e.StkAct).HasColumnName("STK_ACT");
            entity.Property(e => e.StkMin).HasColumnName("STK_MIN");
            entity.Property(e => e.UniMed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UNI_MED");
        });

        modelBuilder.Entity<TbProveedor>(entity =>
        {
            entity.HasKey(e => e.CodPrv).HasName("PK__TB_PROVE__28BE23B29D9B259B");

            entity.ToTable("TB_PROVEEDOR");

            entity.Property(e => e.CodPrv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_PRV");
            entity.Property(e => e.CodDis)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_DIS");
            entity.Property(e => e.DirPrv)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIR_PRV");
            entity.Property(e => e.RazSocPrv)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("RAZ_SOC_PRV");
            entity.Property(e => e.RepVen)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("REP_VEN");
            entity.Property(e => e.TelPrv)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEL_PRV");

            entity.HasOne(d => d.CodDisNavigation).WithMany(p => p.TbProveedors)
                .HasForeignKey(d => d.CodDis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_PROVEE__COD_D__2C3393D0");
        });

        modelBuilder.Entity<TbVendedor>(entity =>
        {
            entity.HasKey(e => e.CodVen).HasName("PK__TB_VENDE__283E0CC2851029B2");

            entity.ToTable("TB_VENDEDOR");

            entity.Property(e => e.CodVen)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_VEN");
            entity.Property(e => e.ApeVen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("APE_VEN");
            entity.Property(e => e.CodDis)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_DIS");
            entity.Property(e => e.FecIng)
                .HasColumnType("date")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.NomVen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOM_VEN");
            entity.Property(e => e.SueldoVen)
                .HasColumnType("money")
                .HasColumnName("SUELDO_VEN");
            entity.Property(e => e.TipVen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIP_VEN");

            entity.HasOne(d => d.CodDisNavigation).WithMany(p => p.TbVendedors)
                .HasForeignKey(d => d.CodDis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_VENDED__COD_D__267ABA7A");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIO__63C76BE247B5B0CB");

            entity.ToTable("USUARIO");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.UsuClave)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usu_clave");
            entity.Property(e => e.UsuTipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usu_tipo");
            entity.Property(e => e.UsuUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usu_usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
