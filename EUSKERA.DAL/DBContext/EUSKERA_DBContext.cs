using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using EUSKERA.Entity;

namespace EUSKERA.DAL.DBContext
{
    public partial class EUSKERA_DBContext : DbContext
    {
        public EUSKERA_DBContext()
        {
        }

        public EUSKERA_DBContext(DbContextOptions<EUSKERA_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatCategoriaServicio> CatCategoriaServicio { get; set; } = null!;
        public virtual DbSet<CatCliente> CatCliente { get; set; } = null!;
        public virtual DbSet<CatEstatusMovimiento> CatEstatusMovimiento { get; set; } = null!;
        public virtual DbSet<CatNaturalezaMovimiento> CatNaturalezaMovimiento { get; set; } = null!;
        public virtual DbSet<CatProveedor> CatProveedor { get; set; } = null!;
        public virtual DbSet<CatServicio> CatServicio { get; set; } = null!;
        public virtual DbSet<CatTipoMovimiento> CatTipoMovimiento { get; set; } = null!;
        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Configuracion> Configuracion { get; set; } = null!;
        public virtual DbSet<CtrlMovimiento> CtrlMovimiento { get; set; } = null!;
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; } = null!;
        public virtual DbSet<Menu> Menu { get; set; } = null!;
        public virtual DbSet<Negocio> Negocio { get; set; } = null!;
        public virtual DbSet<NumeroCorrelativo> NumeroCorrelativo { get; set; } = null!;
        public virtual DbSet<Producto> Producto { get; set; } = null!;
        public virtual DbSet<Rol> Rol { get; set; } = null!;
        public virtual DbSet<RolMenu> RolMenu { get; set; } = null!;
        public virtual DbSet<TipoDocumentoVenta> TipoDocumentoVenta { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Venta> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=WSLOCAL; Database=EUSKERA_DB; Integrated Security=true");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatCategoriaServicio>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaServicio);

                entity.ToTable("Cat_CategoriaServicio");

                entity.Property(e => e.IdCategoriaServicio).HasColumnName("Id_CategoriaServicio");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.TxtDescripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre");
            });

            modelBuilder.Entity<CatCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("Cat_Cliente");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.Calle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdGiro).HasColumnName("Id_Giro");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxtRazonSocial)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Txt_RazonSocial");
            });

            modelBuilder.Entity<CatEstatusMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdEstatusMovimiento);

                entity.ToTable("Cat_estatusMovimiento");

                entity.Property(e => e.IdEstatusMovimiento).HasColumnName("Id_EstatusMovimiento");

                entity.Property(e => e.IdNaturaleza).HasColumnName("Id_Naturaleza");

                entity.Property(e => e.TxtDescripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre");
            });

            modelBuilder.Entity<CatNaturalezaMovimiento>(entity =>
            {
                entity.ToTable("Cat_NaturalezaMovimiento");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre");
            });

            modelBuilder.Entity<CatProveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.ToTable("Cat_Proveedor");

                entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");

                entity.Property(e => e.Calle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdGiro).HasColumnName("Id_Giro");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxtRazonSocial)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Txt_RazonSocial");
            });

            modelBuilder.Entity<CatServicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.ToTable("Cat_Servicio");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdCategoriaServicio).HasColumnName("Id_CategoriaServicio");

                entity.Property(e => e.IdNegocio).HasColumnName("Id_Negocio");

                entity.Property(e => e.SnActivo).HasColumnName("Sn_Activo");

                entity.Property(e => e.TxtDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre");

                entity.HasOne(d => d.IdCategoriaServicioNavigation)
                    .WithMany(p => p.CatServicios)
                    .HasForeignKey(d => d.IdCategoriaServicio)
                    .HasConstraintName("FK_Cat_Servicio_Cat_CategoriaServicio");

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.CatServicio)
                    .HasForeignKey(d => d.IdNegocio)
                    .HasConstraintName("FK_Cat_Servicio_Negocio");
            });

            modelBuilder.Entity<CatTipoMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovimiento);

                entity.ToTable("Cat_TipoMovimiento");

                entity.Property(e => e.IdTipoMovimiento)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_TipoMovimiento");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__02AA0785ADB96AE3");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.TxtDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Configuracion");

                entity.Property(e => e.TxtPropiedad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Propiedad");

                entity.Property(e => e.TxtRecurso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Recurso");

                entity.Property(e => e.TxtValor)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Valor");
            });

            modelBuilder.Entity<CtrlMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdMovimiento);

                entity.ToTable("Ctrl_Movimientos");

                entity.Property(e => e.IdMovimiento).HasColumnName("Id_Movimiento");

                entity.Property(e => e.CtaBancaria)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Cta_Bancaria");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.Property(e => e.IdNaturaleza).HasColumnName("Id_Naturaleza");

                entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("Id_TipoMovimiento");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PorcentajeImpuesto)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("Porcentaje_Impuesto");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CtrlMovimientos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Ctrl_Movimientos_Cat_Cliente");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.CtrlMovimientos)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_Ctrl_Movimientos_Cat_estatusMovimiento");

                entity.HasOne(d => d.IdNaturalezaNavigation)
                    .WithMany(p => p.CtrlMovimientos)
                    .HasForeignKey(d => d.IdNaturaleza)
                    .HasConstraintName("FK_Ctrl_Movimientos_Cat_NaturalezaMovimiento");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.CtrlMovimiento)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_Ctrl_Movimientos_Cat_Proveedor");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.CtrlMovimientos)
                    .HasForeignKey(d => d.IdServicio)
                    .HasConstraintName("FK_Ctrl_Movimientos_Cat_Servicio");

                entity.HasOne(d => d.IdTipoMovimientoNavigation)
                    .WithMany(p => p.CtrlMovimientos)
                    .HasForeignKey(d => d.IdTipoMovimiento)
                    .HasConstraintName("FK_Ctrl_Movimientos_Cat_TipoMovimiento");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(e => e.IdDetalleVenta)
                    .HasName("PK__DetalleV__DF908C88E975860C");

                entity.Property(e => e.IdDetalleVenta).HasColumnName("ID_Detalle_Venta");

                entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");

                entity.Property(e => e.IdVenta).HasColumnName("ID_Venta");

                entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TxtCategoriaProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Categoria_Producto");

                entity.Property(e => e.TxtDescripcionProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion_Producto");

                entity.Property(e => e.TxtMarcaProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Marca_Producto");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_DetalleVenta_Producto");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .HasConstraintName("FK__DetalleVe__ID_Ve__440B1D61");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PK__Menu__7F28421AFDF34A0B");

                entity.ToTable("Menu");

                entity.Property(e => e.IdMenu).HasColumnName("ID_Menu");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdMenuPadre).HasColumnName("ID_Menu_Padre");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.TxtControlador)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Controlador");

                entity.Property(e => e.TxtDescripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");

                entity.Property(e => e.TxtIcono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Icono");

                entity.Property(e => e.TxtPaginaAccion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Pagina_Accion");

                entity.HasOne(d => d.IdMenuPadreNavigation)
                    .WithMany(p => p.InverseIdMenuPadreNavigation)
                    .HasForeignKey(d => d.IdMenuPadre)
                    .HasConstraintName("FK__Menu__ID_Menu_Pa__412EB0B6");
            });

            modelBuilder.Entity<Negocio>(entity =>
            {
                entity.HasKey(e => e.IdNegocio)
                    .HasName("PK__Negocio__93197F13ECEDD59D");

                entity.ToTable("Negocio");

                entity.Property(e => e.IdNegocio).HasColumnName("ID_Negocio");

                entity.Property(e => e.PorcentajeImpuesto)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Porcentaje_Impuesto");

                entity.Property(e => e.TxtCorreo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Correo");

                entity.Property(e => e.TxtDireccion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Direccion");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre");

                entity.Property(e => e.TxtNombreLogo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre_Logo");

                entity.Property(e => e.TxtNumeroDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Numero_Documento");

                entity.Property(e => e.TxtSimboloMoneda)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Simbolo_Moneda");

                entity.Property(e => e.TxtTelefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Telefono");

                entity.Property(e => e.TxtUrlLogo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Url_Logo");
            });

            modelBuilder.Entity<NumeroCorrelativo>(entity =>
            {
                entity.HasKey(e => e.IdNumeroCorrelativo)
                    .HasName("PK__NumeroCo__DF757C8516AE8D05");

                entity.ToTable("NumeroCorrelativo");

                entity.Property(e => e.IdNumeroCorrelativo).HasColumnName("ID_Numero_Correlativo");

                entity.Property(e => e.CantidadDigitos).HasColumnName("Cantidad_Digitos");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizacion");

                entity.Property(e => e.Gestion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoNumero).HasColumnName("Ultimo_Numero");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__Producto__9B4120E250E20D49");

                entity.ToTable("Producto");

                entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");

                entity.Property(e => e.IdNegocio).HasColumnName("Id_Negocio");

                entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.TxtCodigoBarra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Codigo_Barra");

                entity.Property(e => e.TxtDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");

                entity.Property(e => e.TxtMarca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Marca");

                entity.Property(e => e.TxtNombreImagen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre_Imagen");

                entity.Property(e => e.TxtUrlImagen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Url_Imagen");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Producto__ID_Cat__4222D4EF");

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdNegocio)
                    .HasConstraintName("FK_Producto_Negocio");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__202AD22065E61D16");

                entity.ToTable("Rol");

                entity.Property(e => e.IdRol).HasColumnName("ID_Rol");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.TxtDescripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");
            });

            modelBuilder.Entity<RolMenu>(entity =>
            {
                entity.HasKey(e => e.IdRolMenu)
                    .HasName("PK__RolMenu__26D7077BA3FA5825");

                entity.ToTable("RolMenu");

                entity.Property(e => e.IdRolMenu).HasColumnName("ID_Rol_Menu");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdMenu).HasColumnName("ID_Menu");

                entity.Property(e => e.IdRol).HasColumnName("ID_Rol");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.HasOne(d => d.IdMenuNavigation)
                    .WithMany(p => p.RolMenus)
                    .HasForeignKey(d => d.IdMenu)
                    .HasConstraintName("FK__RolMenu__ID_Menu__4316F928");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.RolMenus)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__RolMenu__ID_Rol__440B1D61");
            });

            modelBuilder.Entity<TipoDocumentoVenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumentoVenta)
                    .HasName("PK__TipoDocu__8E1F174A6DF1E2B1");

                entity.Property(e => e.IdTipoDocumentoVenta).HasColumnName("ID_Tipo_Documento_Venta");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.TxtDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Descripcion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__DE4431C5C2000189");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRol).HasColumnName("ID_Rol");

                entity.Property(e => e.SnActivo).HasColumnName("SN_Activo");

                entity.Property(e => e.TxtClave)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Clave");

                entity.Property(e => e.TxtCorreo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Correo");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre");

                entity.Property(e => e.TxtNombreFoto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre_Foto");

                entity.Property(e => e.TxtTelefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Telefono");

                entity.Property(e => e.TxtUrlFoto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Url_Foto");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__Usuario__ID_Rol__44FF419A");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__Venta__3CD842E52E4C125F");

                entity.Property(e => e.IdVenta).HasColumnName("ID_Venta");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTipoDocumentoVenta).HasColumnName("ID_Tipo_Documento_Venta");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.ImpuestoTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Impuesto_Total");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TxtDocumentoCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Documento_Cliente");

                entity.Property(e => e.TxtNombreCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Nombre_Cliente");

                entity.Property(e => e.TxtNumeroVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Txt_Numero_Venta");

                entity.HasOne(d => d.IdTipoDocumentoVentaNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdTipoDocumentoVenta)
                    .HasConstraintName("FK__Venta__ID_Tipo_D__3F466844");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Venta__ID_Usuari__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
