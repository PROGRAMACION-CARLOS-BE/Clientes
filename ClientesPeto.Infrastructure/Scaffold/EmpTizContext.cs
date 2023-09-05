using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class EmpTizContext : DbContext
    {
        public EmpTizContext()
        {
        }

        public EmpTizContext(DbContextOptions<EmpTizContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Base> Base { get; set; }
        public virtual DbSet<Bonifica> Bonifica { get; set; }
        public virtual DbSet<Bonifica2> Bonifica2 { get; set; }
        public virtual DbSet<Caja> Caja { get; set; }
        public virtual DbSet<CajaUsd> CajaUsd { get; set; }
        public virtual DbSet<CatBod> CatBod { get; set; }
        public virtual DbSet<CatCia> CatCia { get; set; }
        public virtual DbSet<CatCiu> CatCiu { get; set; }
        public virtual DbSet<CatCli> CatCli { get; set; }
        public virtual DbSet<CatCliRev> CatCliRev { get; set; }
        public virtual DbSet<CatCp> CatCp { get; set; }
        public virtual DbSet<CatDiasIn> CatDiasIn { get; set; }
        public virtual DbSet<CatDolares> CatDolares { get; set; }
        public virtual DbSet<CatDupLla> CatDupLla { get; set; }
        public virtual DbSet<CatEdo> CatEdo { get; set; }
        public virtual DbSet<CatEdoCiv> CatEdoCiv { get; set; }
        public virtual DbSet<CatGps> CatGps { get; set; }
        public virtual DbSet<CatInc> CatInc { get; set; }
        public virtual DbSet<CatMacOcu> CatMacOcu { get; set; }
        public virtual DbSet<CatMar> CatMar { get; set; }
        public virtual DbSet<CatMedios> CatMedios { get; set; }
        public virtual DbSet<CatMovCaja> CatMovCaja { get; set; }
        public virtual DbSet<CatOcu> CatOcu { get; set; }
        public virtual DbSet<CatParametroRemoto> CatParametroRemoto { get; set; }
        public virtual DbSet<CatPla> CatPla { get; set; }
        public virtual DbSet<CatSuc> CatSuc { get; set; }
        public virtual DbSet<CatTipCli> CatTipCli { get; set; }
        public virtual DbSet<CatTipId> CatTipId { get; set; }
        public virtual DbSet<CatTipPag> CatTipPag { get; set; }
        public virtual DbSet<CatTipProd> CatTipProd { get; set; }
        public virtual DbSet<CatUbi> CatUbi { get; set; }
        public virtual DbSet<CatcliElim> CatcliElim { get; set; }
        public virtual DbSet<CatfamSicavi> CatfamSicavi { get; set; }
        public virtual DbSet<CatmarSicavi> CatmarSicavi { get; set; }
        public virtual DbSet<Catnac> Catnac { get; set; }
        public virtual DbSet<CatprodSicavi> CatprodSicavi { get; set; }
        public virtual DbSet<Comentarios> Comentarios { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<ControlCentral> ControlCentral { get; set; }
        public virtual DbSet<CorteCaja> CorteCaja { get; set; }
        public virtual DbSet<CorteCaja2> CorteCaja2 { get; set; }
        public virtual DbSet<CorteCaja2Autos> CorteCaja2Autos { get; set; }
        public virtual DbSet<CorteCaja2Old> CorteCaja2Old { get; set; }
        public virtual DbSet<CorteCajaAutos> CorteCajaAutos { get; set; }
        public virtual DbSet<CorteCajaOld> CorteCajaOld { get; set; }
        public virtual DbSet<CorteCajaPlazos> CorteCajaPlazos { get; set; }
        public virtual DbSet<CorteCajaTmp> CorteCajaTmp { get; set; }
        public virtual DbSet<DetCajaUsd> DetCajaUsd { get; set; }
        public virtual DbSet<DetCli> DetCli { get; set; }
        public virtual DbSet<DetCliNotas> DetCliNotas { get; set; }
        public virtual DbSet<DetGrupoPer> DetGrupoPer { get; set; }
        public virtual DbSet<DetGrupoPerUser> DetGrupoPerUser { get; set; }
        public virtual DbSet<DetMovtos> DetMovtos { get; set; }
        public virtual DbSet<DetMovtos2> DetMovtos2 { get; set; }
        public virtual DbSet<DetPla> DetPla { get; set; }
        public virtual DbSet<DetPlaTipCli> DetPlaTipCli { get; set; }
        public virtual DbSet<DetUsers> DetUsers { get; set; }
        public virtual DbSet<DetmovtosSicavi> DetmovtosSicavi { get; set; }
        public virtual DbSet<Diashabiles> Diashabiles { get; set; }
        public virtual DbSet<EmpBasic> EmpBasic { get; set; }
        public virtual DbSet<EmpMovttoGral> EmpMovttoGral { get; set; }
        public virtual DbSet<Empenio> Empenio { get; set; }
        public virtual DbSet<Empenios> Empenios { get; set; }
        public virtual DbSet<EnvioWs> EnvioWs { get; set; }
        public virtual DbSet<ExisteSicavi> ExisteSicavi { get; set; }
        public virtual DbSet<FecUltMovtoCte> FecUltMovtoCte { get; set; }
        public virtual DbSet<FondoCaja> FondoCaja { get; set; }
        public virtual DbSet<FondoCaja2> FondoCaja2 { get; set; }
        public virtual DbSet<GrupoPer> GrupoPer { get; set; }
        public virtual DbSet<IndCorteOperaciones> IndCorteOperaciones { get; set; }
        public virtual DbSet<IndOperaciones> IndOperaciones { get; set; }
        public virtual DbSet<IndOperacionesAliProd> IndOperacionesAliProd { get; set; }
        public virtual DbSet<ListaClientesNuevos> ListaClientesNuevos { get; set; }
        public virtual DbSet<Llaves> Llaves { get; set; }
        public virtual DbSet<Movtos> Movtos { get; set; }
        public virtual DbSet<Movtos2> Movtos2 { get; set; }
        public virtual DbSet<MovtosBc> MovtosBc { get; set; }
        public virtual DbSet<MovtosCubos> MovtosCubos { get; set; }
        public virtual DbSet<MovtosEnaj> MovtosEnaj { get; set; }
        public virtual DbSet<MovtosFotos> MovtosFotos { get; set; }
        public virtual DbSet<MovtosInc> MovtosInc { get; set; }
        public virtual DbSet<MovtosPagos> MovtosPagos { get; set; }
        public virtual DbSet<MovtosRemotos> MovtosRemotos { get; set; }
        public virtual DbSet<MovtosSicavi> MovtosSicavi { get; set; }
        public virtual DbSet<MovtosTmp> MovtosTmp { get; set; }
        public virtual DbSet<MovtosTmpCorte> MovtosTmpCorte { get; set; }
        public virtual DbSet<MovtosTmpCorte2> MovtosTmpCorte2 { get; set; }
        public virtual DbSet<MovtosTmpCorte2Autos> MovtosTmpCorte2Autos { get; set; }
        public virtual DbSet<MovtosTmpCorteAutos> MovtosTmpCorteAutos { get; set; }
        public virtual DbSet<MovtosTmpCortePlazos> MovtosTmpCortePlazos { get; set; }
        public virtual DbSet<MovtosexpSicavi> MovtosexpSicavi { get; set; }
        public virtual DbSet<MultiSucursales> MultiSucursales { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Pagos2> Pagos2 { get; set; }
        public virtual DbSet<PagosDel> PagosDel { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<PreciosInternet> PreciosInternet { get; set; }
        public virtual DbSet<PreciosUsd> PreciosUsd { get; set; }
        public virtual DbSet<ReImp> ReImp { get; set; }
        public virtual DbSet<ReImp2> ReImp2 { get; set; }
        public virtual DbSet<RefGratis> RefGratis { get; set; }
        public virtual DbSet<RefGratisJun2019> RefGratisJun2019 { get; set; }
        public virtual DbSet<RefGratisMay2019> RefGratisMay2019 { get; set; }
        public virtual DbSet<Resguardos> Resguardos { get; set; }
        public virtual DbSet<StatusBc> StatusBc { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersHist> UsersHist { get; set; }
        public virtual DbSet<ValesRef> ValesRef { get; set; }
        public virtual DbSet<ValesRefReImp> ValesRefReImp { get; set; }
        public virtual DbSet<ValesRefReImpRemotos> ValesRefReImpRemotos { get; set; }
        public virtual DbSet<ValesRefRemotos> ValesRefRemotos { get; set; }
        public virtual DbSet<Valesrefrei> Valesrefrei { get; set; }
        public virtual DbSet<VwAportacionesPorRecibir> VwAportacionesPorRecibir { get; set; }
        public virtual DbSet<VwAportacionesRecibidas> VwAportacionesRecibidas { get; set; }
        public virtual DbSet<VwBodCentral> VwBodCentral { get; set; }
        public virtual DbSet<VwCapitalEmpenio> VwCapitalEmpenio { get; set; }
        public virtual DbSet<VwClienteEmpenio> VwClienteEmpenio { get; set; }
        public virtual DbSet<VwClientesOcupaciones> VwClientesOcupaciones { get; set; }
        public virtual DbSet<VwEmpActivo> VwEmpActivo { get; set; }
        public virtual DbSet<VwEmpBasic> VwEmpBasic { get; set; }
        public virtual DbSet<VwEmpBasic2> VwEmpBasic2 { get; set; }
        public virtual DbSet<VwEmpBasicFamilia> VwEmpBasicFamilia { get; set; }
        public virtual DbSet<VwEmpMovtosResumenPagos> VwEmpMovtosResumenPagos { get; set; }
        public virtual DbSet<VwEmpMovtosResumenPagos2> VwEmpMovtosResumenPagos2 { get; set; }
        public virtual DbSet<VwEmpMovttoCartera> VwEmpMovttoCartera { get; set; }
        public virtual DbSet<VwEmpMovttoEfectivoDetalle> VwEmpMovttoEfectivoDetalle { get; set; }
        public virtual DbSet<VwEmpMovttoEfectivoDetalle2> VwEmpMovttoEfectivoDetalle2 { get; set; }
        public virtual DbSet<VwEmpMovttoGral> VwEmpMovttoGral { get; set; }
        public virtual DbSet<VwEmpMovttoGral2> VwEmpMovttoGral2 { get; set; }
        public virtual DbSet<VwEmpMovttoGralGerencia> VwEmpMovttoGralGerencia { get; set; }
        public virtual DbSet<VwEmpMovttoPagos> VwEmpMovttoPagos { get; set; }
        public virtual DbSet<VwEmpPagRes> VwEmpPagRes { get; set; }
        public virtual DbSet<VwEmpPagos> VwEmpPagos { get; set; }
        public virtual DbSet<VwEmpenioPago> VwEmpenioPago { get; set; }
        public virtual DbSet<VwEmpenios> VwEmpenios { get; set; }
        public virtual DbSet<VwEmpenios2> VwEmpenios2 { get; set; }
        public virtual DbSet<VwFamiliaEmpenio> VwFamiliaEmpenio { get; set; }
        public virtual DbSet<VwIncidencias> VwIncidencias { get; set; }
        public virtual DbSet<VwIndCartera> VwIndCartera { get; set; }
        public virtual DbSet<VwIndClientesNuevos> VwIndClientesNuevos { get; set; }
        public virtual DbSet<VwIndEnajenados> VwIndEnajenados { get; set; }
        public virtual DbSet<VwIndEnajenados2> VwIndEnajenados2 { get; set; }
        public virtual DbSet<VwIndEnajenados3> VwIndEnajenados3 { get; set; }
        public virtual DbSet<VwIndMovttoPrestadoAliado> VwIndMovttoPrestadoAliado { get; set; }
        public virtual DbSet<VwIndMovttoPrestadoProd> VwIndMovttoPrestadoProd { get; set; }
        public virtual DbSet<VwIndResumenPagos> VwIndResumenPagos { get; set; }
        public virtual DbSet<VwJoyCatPrecioGramo> VwJoyCatPrecioGramo { get; set; }
        public virtual DbSet<VwJoyDetJoyeria> VwJoyDetJoyeria { get; set; }
        public virtual DbSet<VwJoyDetPorcPrestamos> VwJoyDetPorcPrestamos { get; set; }
        public virtual DbSet<VwJoyResumenPrestamos> VwJoyResumenPrestamos { get; set; }
        public virtual DbSet<VwMovtosEnaj> VwMovtosEnaj { get; set; }
        public virtual DbSet<VwMovtosRemotosDia> VwMovtosRemotosDia { get; set; }
        public virtual DbSet<VwPagoMes> VwPagoMes { get; set; }
        public virtual DbSet<VwPerfilClientes> VwPerfilClientes { get; set; }
        public virtual DbSet<VwPreparaListaClientesNuevos> VwPreparaListaClientesNuevos { get; set; }
        public virtual DbSet<VwUserPerGruApp> VwUserPerGruApp { get; set; }
        public virtual DbSet<VwUsuariosActivos> VwUsuariosActivos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.10.0.7\\Sqlserver ;Database=EmpTiz; user id=sa;password=Sql2008");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Base>(entity =>
            {
                entity.HasKey(e => new { e.BaseId, e.CveSuc });

                entity.ToTable("BASE");

                entity.Property(e => e.BaseId).HasColumnName("BaseID");

                entity.Property(e => e.AliadoId)
                    .IsRequired()
                    .HasColumnName("AliadoID")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.FecRevCentral).HasColumnType("datetime");

                entity.Property(e => e.FecRevLocal).HasColumnType("datetime");

                entity.Property(e => e.IndId).HasColumnName("IndID");

                entity.Property(e => e.NomIndicador)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SucursalId)
                    .IsRequired()
                    .HasColumnName("SucursalID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ValBase).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValBaseAjus).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Bonifica>(entity =>
            {
                entity.HasKey(e => new { e.FolBon, e.CveSuc });

                entity.HasIndex(e => new { e.FolMov, e.CveSuc })
                    .HasName("<ActualizaMovtosEmpenios2, sysname,>");

                entity.Property(e => e.FolBon).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecBon)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpBon)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpSis)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Bonifica2>(entity =>
            {
                entity.HasKey(e => new { e.FolBon, e.CveSuc });

                entity.Property(e => e.FolBon).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecBon)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpBon)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpSis)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc, e.IdCaja });

                entity.HasIndex(e => new { e.CveUser, e.FecMov })
                    .HasName("Idx_Caja_CveUserFecMov");

                entity.HasIndex(e => new { e.CveUser, e.FechaReal })
                    .HasName("IdxCajaFechaReal");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.CreditoId).HasColumnName("CreditoID");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.Cvemovcaja)
                    .HasColumnName("cvemovcaja")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecAceptado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecCancelado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LlaveCreditoId).HasColumnName("LlaveCreditoID");

                entity.Property(e => e.LlaveFindin)
                    .IsRequired()
                    .HasColumnName("LlaveFINDIN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomCliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoMov).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CajaUsd>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc });

                entity.ToTable("CajaUSD");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.MontoUsd)
                    .HasColumnName("MontoUSD")
                    .HasColumnType("money");

                entity.Property(e => e.TipoCambio).HasColumnType("money");
            });

            modelBuilder.Entity<CatBod>(entity =>
            {
                entity.HasKey(e => e.CveBod);

                entity.Property(e => e.CveBod).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.NomBod)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatCia>(entity =>
            {
                entity.HasKey(e => e.Cvecia);

                entity.Property(e => e.Cvecia)
                    .HasColumnName("cvecia")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Dircia)
                    .IsRequired()
                    .HasColumnName("dircia")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faxcia)
                    .IsRequired()
                    .HasColumnName("faxcia")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.LoginxMovto)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nomcia)
                    .IsRequired()
                    .HasColumnName("nomcia")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PagoDes).HasDefaultValueSql("(0)");

                entity.Property(e => e.PagoRef).HasDefaultValueSql("(0)");

                entity.Property(e => e.Razcia)
                    .IsRequired()
                    .HasColumnName("razcia")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rfccia)
                    .IsRequired()
                    .HasColumnName("rfccia")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.Tel2cia)
                    .IsRequired()
                    .HasColumnName("tel2cia")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telcia)
                    .IsRequired()
                    .HasColumnName("telcia")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UbicaDet)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatCiu>(entity =>
            {
                entity.HasKey(e => e.CveCiu);

                entity.Property(e => e.CveCiu).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveEdo).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesCiu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatCli>(entity =>
            {
                entity.HasKey(e => e.Cvecli)
                    .HasName("PK_CATCLI");

                entity.HasIndex(e => e.Nomcli)
                    .HasName("CatCli_Idx_A");

                entity.HasIndex(e => new { e.Cvecli, e.Grucli })
                    .HasName("IdxCatCli_GruCli");

                entity.HasIndex(e => new { e.Cvecli, e.Ocupacion, e.CveOcu })
                    .HasName("Idx_CatCli_Ocupacion_CveOcu_Cvecli");

                entity.Property(e => e.Cvecli)
                    .HasColumnName("CVECLI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Archivo1)
                    .IsRequired()
                    .HasColumnName("ARCHIVO1")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Archivo1nom)
                    .IsRequired()
                    .HasColumnName("ARCHIVO1NOM")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ciucli)
                    .HasColumnName("CIUCLI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Colcli)
                    .IsRequired()
                    .HasColumnName("COLCLI")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cpcli)
                    .IsRequired()
                    .HasColumnName("CPCLI")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Curpcli)
                    .IsRequired()
                    .HasColumnName("CURPCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveEdo2).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveNac).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveTipId).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserFalsos).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserFalsosCanc).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserRevCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserRevLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dircli)
                    .IsRequired()
                    .HasColumnName("DIRCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli2)
                    .IsRequired()
                    .HasColumnName("DIRCLI2")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli3)
                    .IsRequired()
                    .HasColumnName("DIRCLI3")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli4)
                    .IsRequired()
                    .HasColumnName("DIRCLI4")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Emailcli)
                    .IsRequired()
                    .HasColumnName("EMAILCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FalsosMismaSuc)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FalsosMismaSucObs)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faxcli)
                    .IsRequired()
                    .HasColumnName("FAXCLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecFalsos)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecFalsosCanc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecNac)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecRevCentral)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecRevLocal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Grucli)
                    .HasColumnName("GRUCLI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Identcli)
                    .IsRequired()
                    .HasColumnName("IDENTCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idtarjeta)
                    .IsRequired()
                    .HasColumnName("IDTARJETA")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("IMAGEN")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagen2)
                    .IsRequired()
                    .HasColumnName("IMAGEN2")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom2)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM2")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Login2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasColumnName("OBSERVA")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ocupacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.RevisionCentral)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RevisionLocal)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rfccli)
                    .IsRequired()
                    .HasColumnName("RFCCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoundexSp1)
                    .HasColumnName("SoundexSP1")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SoundexSp2)
                    .HasColumnName("SoundexSP2")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SoundexSp3)
                    .HasColumnName("SoundexSP3")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.Tel1cli)
                    .IsRequired()
                    .HasColumnName("TEL1CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel2cli)
                    .IsRequired()
                    .HasColumnName("TEL2CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel3cli)
                    .IsRequired()
                    .HasColumnName("TEL3CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TraeFalsos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorPonderado).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatCliRev>(entity =>
            {
                entity.HasKey(e => new { e.Cvecli, e.CveSuc });

                entity.ToTable("CatCli_Rev");

                entity.Property(e => e.Cvecli).HasColumnName("CVECLI");

                entity.Property(e => e.Archivo1)
                    .IsRequired()
                    .HasColumnName("ARCHIVO1")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Archivo1nom)
                    .IsRequired()
                    .HasColumnName("ARCHIVO1NOM")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ciucli).HasColumnName("CIUCLI");

                entity.Property(e => e.Colcli)
                    .IsRequired()
                    .HasColumnName("COLCLI")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cpcli)
                    .IsRequired()
                    .HasColumnName("CPCLI")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Curpcli)
                    .IsRequired()
                    .HasColumnName("CURPCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli)
                    .IsRequired()
                    .HasColumnName("DIRCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli2)
                    .IsRequired()
                    .HasColumnName("DIRCLI2")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli3)
                    .IsRequired()
                    .HasColumnName("DIRCLI3")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli4)
                    .IsRequired()
                    .HasColumnName("DIRCLI4")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Emailcli)
                    .IsRequired()
                    .HasColumnName("EMAILCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FalsosMismaSucObs)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faxcli)
                    .IsRequired()
                    .HasColumnName("FAXCLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecFalsos)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecFalsosCanc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecNac)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecRevCentral)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecRevLocal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Grucli).HasColumnName("GRUCLI");

                entity.Property(e => e.Identcli)
                    .IsRequired()
                    .HasColumnName("IDENTCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idtarjeta)
                    .IsRequired()
                    .HasColumnName("IDTARJETA")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("IMAGEN")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagen2)
                    .IsRequired()
                    .HasColumnName("IMAGEN2")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom2)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM2")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Login2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasColumnName("OBSERVA")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ocupacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfccli)
                    .IsRequired()
                    .HasColumnName("RFCCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoundexSp1)
                    .HasColumnName("SoundexSP1")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SoundexSp2)
                    .HasColumnName("SoundexSP2")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SoundexSp3)
                    .HasColumnName("SoundexSP3")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Tel1cli)
                    .IsRequired()
                    .HasColumnName("TEL1CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel2cli)
                    .IsRequired()
                    .HasColumnName("TEL2CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel3cli)
                    .IsRequired()
                    .HasColumnName("TEL3CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CatCp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatCP");

                entity.Property(e => e.Asenta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAsenta)
                    .IsRequired()
                    .HasColumnName("Tipo_asenta")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatDiasIn>(entity =>
            {
                entity.HasKey(e => e.Fecha);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatDolares>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PorcCompra).HasColumnType("money");
            });

            modelBuilder.Entity<CatDupLla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatDupLLa");

                entity.Property(e => e.DesDupLla)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpInicial).HasColumnType("money");

                entity.Property(e => e.ImpMensual).HasColumnType("money");
            });

            modelBuilder.Entity<CatEdo>(entity =>
            {
                entity.HasKey(e => e.CveEdo);

                entity.Property(e => e.CveEdo).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesEdo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatEdoCiv>(entity =>
            {
                entity.HasKey(e => e.CveEdoCiv);

                entity.Property(e => e.CveEdoCiv).ValueGeneratedNever();

                entity.Property(e => e.DesEdoCiv)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CatGps>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatGPS");

                entity.Property(e => e.CveGps).HasColumnName("CveGPS");

                entity.Property(e => e.DesGps)
                    .IsRequired()
                    .HasColumnName("DesGPS")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpInicial).HasColumnType("money");

                entity.Property(e => e.ImpMensual).HasColumnType("money");
            });

            modelBuilder.Entity<CatInc>(entity =>
            {
                entity.HasKey(e => e.CveInc);

                entity.Property(e => e.CveInc).ValueGeneratedNever();

                entity.Property(e => e.DesInc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CatMacOcu>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DesMacOcu)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatMar>(entity =>
            {
                entity.HasKey(e => e.CveMar);

                entity.Property(e => e.CveMar).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesMar)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EsAutosGps).HasColumnName("EsAutosGPS");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatMedios>(entity =>
            {
                entity.HasKey(e => e.CveMed);

                entity.Property(e => e.CveMed).ValueGeneratedNever();

                entity.Property(e => e.DesMed)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CatMovCaja>(entity =>
            {
                entity.HasKey(e => e.CveMovCaja);

                entity.Property(e => e.CveMovCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesMovCaja)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.ReqLlave)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoMovCaja).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatOcu>(entity =>
            {
                entity.HasKey(e => e.CveOcu)
                    .HasName("PK__CatOcu__B2DAD2DC754E3E91");

                entity.Property(e => e.CveOcu).ValueGeneratedNever();

                entity.Property(e => e.DesOcu)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatParametroRemoto>(entity =>
            {
                entity.HasKey(e => e.ParRemotoId)
                    .HasName("PK_CATRAZONSOCIAL");

                entity.Property(e => e.ParRemotoId).HasColumnName("ParRemotoID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ParamDescripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatPla>(entity =>
            {
                entity.HasKey(e => e.CvePla);

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.AlmYseg)
                    .HasColumnName("AlmYSeg")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CampoPrecio).HasDefaultValueSql("(0)");

                entity.Property(e => e.Cotizador)
                    .IsRequired()
                    .HasColumnName("cotizador")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CuadroCorte1)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CuadroCorte2)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DesctoCc)
                    .HasColumnName("DesctoCC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasCartVenc).HasDefaultValueSql("(5)");

                entity.Property(e => e.DiasGracia).HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasPlazo).HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasVenc).HasDefaultValueSql("(0)");

                entity.Property(e => e.EsAparatos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EsAutos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EsAutosGps).HasColumnName("EsAutosGPS");

                entity.Property(e => e.EsJoyeria)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EsPlata)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GastosAdm)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.LetraA).HasDefaultValueSql("(100)");

                entity.Property(e => e.LetraB).HasDefaultValueSql("(100)");

                entity.Property(e => e.LetraC).HasDefaultValueSql("(100)");

                entity.Property(e => e.LetraD).HasDefaultValueSql("(100)");

                entity.Property(e => e.Leyenda)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumRefGratis).HasDefaultValueSql("(0)");

                entity.Property(e => e.NumRefMax).HasDefaultValueSql("(100)");

                entity.Property(e => e.PorcAumPrecExp)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcDescRefExp)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcInt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcRecargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Promo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RedondeoA).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatSuc>(entity =>
            {
                entity.HasKey(e => e.CveSuc);

                entity.Property(e => e.CveSuc).ValueGeneratedNever();

                entity.Property(e => e.ContAdSuc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContProf)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CosRei).HasColumnType("money");

                entity.Property(e => e.Cvetipcli).HasColumnName("cvetipcli");

                entity.Property(e => e.Diadom).HasColumnName("diadom");

                entity.Property(e => e.Diajue).HasColumnName("diajue");

                entity.Property(e => e.Dialun).HasColumnName("dialun");

                entity.Property(e => e.Diamar).HasColumnName("diamar");

                entity.Property(e => e.Diamie).HasColumnName("diamie");

                entity.Property(e => e.Diasab).HasColumnName("diasab");

                entity.Property(e => e.Diavie).HasColumnName("diavie");

                entity.Property(e => e.DirFiscal)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirSuc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirSucPrim)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirSucPrim1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirSucSec)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirSucSec1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirSucSec2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirsucPrim2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeContAd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeContProf)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecIniOper)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.HorSuc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HorSuc1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iva).HasColumnType("money");

                entity.Property(e => e.Ley2Suc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ley3Suc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeySuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeyendaC)
                    .IsRequired()
                    .HasMaxLength(700)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MailSuc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomSucSec)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomSucSec1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Promodiadom).HasColumnName("promodiadom");

                entity.Property(e => e.Promodiajue).HasColumnName("promodiajue");

                entity.Property(e => e.Promodialun).HasColumnName("promodialun");

                entity.Property(e => e.Promodiamar).HasColumnName("promodiamar");

                entity.Property(e => e.Promodiamie).HasColumnName("promodiamie");

                entity.Property(e => e.Promodiasab).HasColumnName("promodiasab");

                entity.Property(e => e.Promodiavie).HasColumnName("promodiavie");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recargo).HasColumnType("money");

                entity.Property(e => e.RegFisc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfcsuc)
                    .IsRequired()
                    .HasColumnName("RFCSuc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel2Suc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelSuc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelSucSec)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CatTipCli>(entity =>
            {
                entity.HasKey(e => e.CveTipCli);

                entity.Property(e => e.CveTipCli).HasDefaultValueSql("(0)");

                entity.Property(e => e.CualColor).HasDefaultValueSql("(12648447)");

                entity.Property(e => e.DesTipCli)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiasLibres).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.UsarColor)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatTipId>(entity =>
            {
                entity.HasKey(e => e.CveTipId)
                    .HasName("PK__CatTipId__6C5905DD");

                entity.Property(e => e.CveTipId).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesTipId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatTipPag>(entity =>
            {
                entity.HasKey(e => e.CveTipPag);

                entity.Property(e => e.CveTipPag).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesTipPag)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatTipProd>(entity =>
            {
                entity.HasKey(e => e.CveTipProd);

                entity.Property(e => e.CveTipProd).ValueGeneratedNever();

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CapUbi)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesTipProd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcDesctoRef)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.PorcExp)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.PorcLetraA)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.PorcLetraB)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.PorcLetraC)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.PorcLetraD)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.SepararCart)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.Tipo).HasDefaultValueSql("(0)");

                entity.Property(e => e.ValidoLetraA)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ValidoLetraB)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ValidoLetraC)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ValidoLetraD)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<CatUbi>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CveUbi).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesUbi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.ReqBod)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatcliElim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("catcli_elim");

                entity.Property(e => e.Archivo1)
                    .IsRequired()
                    .HasColumnName("ARCHIVO1")
                    .HasColumnType("image");

                entity.Property(e => e.Archivo1nom)
                    .IsRequired()
                    .HasColumnName("ARCHIVO1NOM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ciucli).HasColumnName("CIUCLI");

                entity.Property(e => e.Colcli)
                    .IsRequired()
                    .HasColumnName("COLCLI")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Cpcli)
                    .IsRequired()
                    .HasColumnName("CPCLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Curpcli)
                    .IsRequired()
                    .HasColumnName("CURPCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cvecli).HasColumnName("CVECLI");

                entity.Property(e => e.Dircli)
                    .IsRequired()
                    .HasColumnName("DIRCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dircli2)
                    .IsRequired()
                    .HasColumnName("DIRCLI2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dircli3)
                    .IsRequired()
                    .HasColumnName("DIRCLI3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dircli4)
                    .IsRequired()
                    .HasColumnName("DIRCLI4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Emailcli)
                    .IsRequired()
                    .HasColumnName("EMAILCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faxcli)
                    .IsRequired()
                    .HasColumnName("FAXCLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grucli).HasColumnName("GRUCLI");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Identcli)
                    .IsRequired()
                    .HasColumnName("IDENTCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idtarjeta)
                    .IsRequired()
                    .HasColumnName("IDTARJETA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("IMAGEN")
                    .HasColumnType("image");

                entity.Property(e => e.Imagen2)
                    .IsRequired()
                    .HasColumnName("IMAGEN2")
                    .HasColumnType("image");

                entity.Property(e => e.Imagennom)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Imagennom2)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasColumnName("OBSERVA")
                    .HasColumnType("ntext");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rfccli)
                    .IsRequired()
                    .HasColumnName("RFCCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.Tel1cli)
                    .IsRequired()
                    .HasColumnName("TEL1CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2cli)
                    .IsRequired()
                    .HasColumnName("TEL2CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tel3cli)
                    .IsRequired()
                    .HasColumnName("TEL3CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatfamSicavi>(entity =>
            {
                entity.HasKey(e => e.Cvefam)
                    .IsClustered(false);

                entity.ToTable("CATFAM_SICAVI");

                entity.Property(e => e.Cvefam)
                    .HasColumnName("CVEFAM")
                    .ValueGeneratedNever();

                entity.Property(e => e.Campo1).HasColumnName("CAMPO1");

                entity.Property(e => e.Campo2).HasColumnName("CAMPO2");

                entity.Property(e => e.Campo3).HasColumnName("CAMPO3");

                entity.Property(e => e.Campo4).HasColumnName("CAMPO4");

                entity.Property(e => e.Comision).HasColumnName("COMISION");

                entity.Property(e => e.Desfam)
                    .IsRequired()
                    .HasColumnName("DESFAM")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Desfam2)
                    .IsRequired()
                    .HasColumnName("DESFAM2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ivafam)
                    .HasColumnName("IVAFAM")
                    .HasColumnType("money");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Numdias).HasColumnName("NUMDIAS");

                entity.Property(e => e.Tipocampo1).HasColumnName("TIPOCAMPO1");

                entity.Property(e => e.Tipocampo2).HasColumnName("TIPOCAMPO2");

                entity.Property(e => e.Tipocampo3).HasColumnName("TIPOCAMPO3");

                entity.Property(e => e.Tipocampo4).HasColumnName("TIPOCAMPO4");
            });

            modelBuilder.Entity<CatmarSicavi>(entity =>
            {
                entity.HasKey(e => e.Cvemar)
                    .IsClustered(false);

                entity.ToTable("CATMAR_SICAVI");

                entity.Property(e => e.Cvemar)
                    .HasColumnName("CVEMAR")
                    .ValueGeneratedNever();

                entity.Property(e => e.Desmar)
                    .IsRequired()
                    .HasColumnName("DESMAR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Catnac>(entity =>
            {
                entity.HasKey(e => e.Cvenac)
                    .HasName("PK__catnac__711DBAFA");

                entity.ToTable("catnac");

                entity.Property(e => e.Cvenac)
                    .HasColumnName("cvenac")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Desnac)
                    .IsRequired()
                    .HasColumnName("desnac")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasColumnName("habilitado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CatprodSicavi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CATPROD_SICAVI");

                entity.Property(e => e.Asientos).HasColumnType("money");

                entity.Property(e => e.Casco).HasColumnType("money");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("categoria")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codbar)
                    .IsRequired()
                    .HasColumnName("CODBAR")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codbar2)
                    .IsRequired()
                    .HasColumnName("CODBAR2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codbar3)
                    .IsRequired()
                    .HasColumnName("CODBAR3")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codbar4)
                    .IsRequired()
                    .HasColumnName("CODBAR4")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ColorMad1).HasColumnType("money");

                entity.Property(e => e.ColorMad2).HasColumnType("money");

                entity.Property(e => e.ColorMad3).HasColumnType("money");

                entity.Property(e => e.CveUserGte)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveUserResp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cvefam).HasColumnName("CVEFAM");

                entity.Property(e => e.Cvemar).HasColumnName("CVEMAR");

                entity.Property(e => e.Cvemov)
                    .HasColumnName("CVEMOV")
                    .HasComment("anclar a un tipo de venta o Movimiento");

                entity.Property(e => e.Cveprod)
                    .IsRequired()
                    .HasColumnName("CVEPROD")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cveprodprov)
                    .IsRequired()
                    .HasColumnName("CVEPRODPROV")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cveuni)
                    .IsRequired()
                    .HasColumnName("CVEUNI")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Desmod)
                    .IsRequired()
                    .HasColumnName("DESMOD")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Desprod)
                    .IsRequired()
                    .HasColumnName("DESPROD")
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Desubi)
                    .IsRequired()
                    .HasColumnName("DESUBI")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diafin1)
                    .HasColumnName("DIAFIN1")
                    .HasColumnType("money");

                entity.Property(e => e.Diafin2)
                    .HasColumnName("DIAFIN2")
                    .HasColumnType("money");

                entity.Property(e => e.Diafin3)
                    .HasColumnName("DIAFIN3")
                    .HasColumnType("money");

                entity.Property(e => e.Diafin4)
                    .HasColumnName("DIAFIN4")
                    .HasColumnType("money");

                entity.Property(e => e.Diaini1)
                    .HasColumnName("DIAINI1")
                    .HasColumnType("money");

                entity.Property(e => e.Diaini2)
                    .HasColumnName("DIAINI2")
                    .HasColumnType("money");

                entity.Property(e => e.Diaini3)
                    .HasColumnName("DIAINI3")
                    .HasColumnType("money");

                entity.Property(e => e.Diaini4)
                    .HasColumnName("DIAINI4")
                    .HasColumnType("money");

                entity.Property(e => e.Diaprec1)
                    .HasColumnName("DIAPREC1")
                    .HasColumnType("money");

                entity.Property(e => e.Diaprec2)
                    .HasColumnName("DIAPREC2")
                    .HasColumnType("money");

                entity.Property(e => e.Diaprec3)
                    .HasColumnName("DIAPREC3")
                    .HasColumnType("money");

                entity.Property(e => e.Diaprec4)
                    .HasColumnName("DIAPREC4")
                    .HasColumnType("money");

                entity.Property(e => e.Diatoler1)
                    .HasColumnName("DIATOLER1")
                    .HasColumnType("money");

                entity.Property(e => e.Diatoler2)
                    .HasColumnName("DIATOLER2")
                    .HasColumnType("money");

                entity.Property(e => e.Diatoler3)
                    .HasColumnName("DIATOLER3")
                    .HasColumnType("money");

                entity.Property(e => e.Diatoler4)
                    .HasColumnName("DIATOLER4")
                    .HasColumnType("money");

                entity.Property(e => e.Dispdom).HasColumnName("DISPDOM");

                entity.Property(e => e.Dispjue).HasColumnName("DISPJUE");

                entity.Property(e => e.Displun).HasColumnName("DISPLUN");

                entity.Property(e => e.Dispmar).HasColumnName("DISPMAR");

                entity.Property(e => e.Dispmie).HasColumnName("DISPMIE");

                entity.Property(e => e.Dispsab).HasColumnName("DISPSAB");

                entity.Property(e => e.Dispvie).HasColumnName("DISPVIE");

                entity.Property(e => e.EdoFisico)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Edoprod).HasColumnName("EDOPROD");

                entity.Property(e => e.EmpDescPlazo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpFecPres).HasColumnType("datetime");

                entity.Property(e => e.EmpLogin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpLoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpSucOri).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpValuador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Factoractprecio)
                    .HasColumnName("FACTORACTPRECIO")
                    .HasColumnType("money");

                entity.Property(e => e.Factoractprecio2)
                    .HasColumnName("FACTORACTPRECIO2")
                    .HasColumnType("money");

                entity.Property(e => e.Factoractprecio3)
                    .HasColumnName("FACTORACTPRECIO3")
                    .HasColumnType("money");

                entity.Property(e => e.Factoractprecio4)
                    .HasColumnName("FACTORACTPRECIO4")
                    .HasColumnType("money");

                entity.Property(e => e.Factoractprecio5)
                    .HasColumnName("FACTORACTPRECIO5")
                    .HasColumnType("money");

                entity.Property(e => e.Factoractprecio6)
                    .HasColumnName("FACTORACTPRECIO6")
                    .HasColumnType("money");

                entity.Property(e => e.FecUltHorChg).HasColumnType("datetime");

                entity.Property(e => e.Fecalta)
                    .HasColumnName("FECALTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecmodprec)
                    .HasColumnName("FECMODPREC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fleteactprecio)
                    .HasColumnName("FLETEACTPRECIO")
                    .HasColumnType("money");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasColumnName("FOTO")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HistBimChg)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Impcodbarpos).HasColumnName("IMPCODBARPOS");

                entity.Property(e => e.Kilommantto)
                    .HasColumnName("KILOMMANTTO")
                    .HasColumnType("money");

                entity.Property(e => e.Lispre1)
                    .HasColumnName("LISPRE1")
                    .HasColumnType("money");

                entity.Property(e => e.Lispre2)
                    .HasColumnName("LISPRE2")
                    .HasColumnType("money");

                entity.Property(e => e.Lispre3)
                    .HasColumnName("LISPRE3")
                    .HasColumnType("money");

                entity.Property(e => e.Lispre4)
                    .HasColumnName("LISPRE4")
                    .HasColumnType("money");

                entity.Property(e => e.Lispre5)
                    .HasColumnName("LISPRE5")
                    .HasColumnType("money");

                entity.Property(e => e.Lispre6)
                    .HasColumnName("LISPRE6")
                    .HasColumnType("money");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mankilom).HasColumnName("MANKILOM");

                entity.Property(e => e.Manrenta).HasColumnName("MANRENTA");

                entity.Property(e => e.Manserie).HasColumnName("MANSERIE");

                entity.Property(e => e.Maxprod)
                    .HasColumnName("MAXPROD")
                    .HasColumnType("money");

                entity.Property(e => e.Minprod)
                    .HasColumnName("MINPROD")
                    .HasColumnType("money");

                entity.Property(e => e.NCantDesc)
                    .HasColumnName("nCantDesc")
                    .HasComment("Cantidad Descuento que se va a Aplicar");

                entity.Property(e => e.NTipoPrecio)
                    .HasColumnName("nTipoPrecio")
                    .HasComment("Precio 1, 2 ,3, 4, 5, 6");

                entity.Property(e => e.Numobj).HasColumnName("NUMOBJ");

                entity.Property(e => e.Numsemmantto)
                    .HasColumnName("NUMSEMMANTTO")
                    .HasColumnType("money");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasColumnName("OBSERVA")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Otros1).HasColumnType("money");

                entity.Property(e => e.Otros2).HasColumnType("money");

                entity.Property(e => e.Otros3).HasColumnType("money");

                entity.Property(e => e.Paqprod).HasColumnName("PAQPROD");

                entity.Property(e => e.PorcDesc).HasColumnType("money");

                entity.Property(e => e.Precio1Ori).HasColumnType("money");

                entity.Property(e => e.PrecioAdic).HasColumnType("money");

                entity.Property(e => e.PrecioAdic2).HasColumnType("money");

                entity.Property(e => e.Rentasmantto)
                    .HasColumnName("RENTASMANTTO")
                    .HasColumnType("money");

                entity.Property(e => e.Respaldos).HasColumnType("money");

                entity.Property(e => e.Tipprod).HasColumnName("TIPPROD");
            });

            modelBuilder.Entity<Comentarios>(entity =>
            {
                entity.HasKey(e => e.IdComentario);

                entity.Property(e => e.IdComentario).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecComentario)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PersonaDestino)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Preg1).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg10).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg4).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg5).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg6).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg7).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg8).HasDefaultValueSql("(0)");

                entity.Property(e => e.Preg9).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MaxMontoRetiro).HasColumnType("money");

                entity.Property(e => e.MinsCancRemoto).HasDefaultValueSql("((10))");

                entity.Property(e => e.PorcMaxAdicPrecGra)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ControlCentral>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bdcentral)
                    .IsRequired()
                    .HasColumnName("BDCentral")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FiltroCentral)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FiltroLocal)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomTablaCentral)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomTablaLocal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PassCentral)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServerCentral)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserCentral)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CorteCaja>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.EsAparatos });

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EsAparatos).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CorteCaja2>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.EsAparatos });

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EsAparatos).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CorteCaja2Autos>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.EsAparatos });

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CorteCaja2Old>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CorteCaja2_Old");

                entity.Property(e => e.CapitalVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.EsAparatos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CorteCajaAutos>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.EsAparatos });

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CorteCajaOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CorteCaja_Old");

                entity.Property(e => e.CapitalVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.EsAparatos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CorteCajaPlazos>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.EsAparatos, e.CvePla, e.SepararCart })
                    .HasName("PK__CorteCajaPlazos__5540965B");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EsAparatos).HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.SepararCart).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CorteCajaTmp>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.EsAparatos, e.CvePla, e.SepararCart })
                    .HasName("PK__CorteCajaTmp__5634BA94");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EsAparatos).HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.SepararCart).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.CapitalVigente).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InteresVencido).HasDefaultValueSql("(0)");

                entity.Property(e => e.InteresVigente).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetCajaUsd>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc, e.IdDet });

                entity.ToTable("DetCajaUSD");

                entity.Property(e => e.ImpCompra).HasColumnType("money");

                entity.Property(e => e.MalEstadoDes)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalCompra).HasColumnType("money");
            });

            modelBuilder.Entity<DetCli>(entity =>
            {
                entity.HasKey(e => e.CveCli);

                entity.Property(e => e.CveCli).HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella1)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella2)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetCliNotas>(entity =>
            {
                entity.HasKey(e => new { e.CveCli, e.IdNota });

                entity.Property(e => e.CveCli).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdNota).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserOculta).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecNota)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecOcultar)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ocultar)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetGrupoPer>(entity =>
            {
                entity.HasKey(e => new { e.CveGrup, e.CvePer, e.Llave });

                entity.Property(e => e.CveGrup).HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePer).HasDefaultValueSql("(0)");

                entity.Property(e => e.Llave)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Permiso).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetGrupoPerUser>(entity =>
            {
                entity.HasKey(e => new { e.CveGrup, e.CveUser });

                entity.Property(e => e.CveGrup).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetMovtos>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc, e.Id, e.Clave });

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.Monto, e.CveTipProd, e.LetraProd })
                    .HasName("<Name of Missing Index6, sysname,>");

                entity.HasIndex(e => new { e.CveSuc, e.FolMov, e.CveTipProd, e.Tipo, e.CveMar, e.SubTipoKilataje, e.LetraProd })
                    .HasName("DetMovtos_IdxA");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.CveTipProd, e.CveMar, e.Modelo, e.Monto, e.LetraProd, e.Exportado })
                    .HasName("MovtosDesEnajIdx01");

                entity.Property(e => e.Clave)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveProdExp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EdoFis)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Enajenar)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FecExporta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FolioBolsa)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kilataje).HasColumnType("money");

                entity.Property(e => e.LetraProd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoNuevo).HasColumnType("money");

                entity.Property(e => e.MontoProm).HasColumnType("money");

                entity.Property(e => e.Peso).HasColumnType("money");

                entity.Property(e => e.Peso2).HasColumnType("money");

                entity.Property(e => e.PrecioFinal).HasColumnType("money");

                entity.Property(e => e.PrecioGramo).HasColumnType("money");

                entity.Property(e => e.PrecioLista).HasColumnType("money");

                entity.Property(e => e.PrecioProd).HasColumnType("money");

                entity.Property(e => e.PrecioSug).HasColumnType("money");

                entity.Property(e => e.Preciocompra)
                    .HasColumnName("preciocompra")
                    .HasColumnType("money");

                entity.Property(e => e.Prenda)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubTipoKilataje)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Valuado)
                    .HasColumnName("valuado")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<DetMovtos2>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc, e.Id, e.Clave });

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Id).HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveMar).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveTipProd).HasDefaultValueSql("(0)");

                entity.Property(e => e.Enajenar)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Kilataje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LetraProd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Monto)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoNuevo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Peso)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Peso2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioProd)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Prenda)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.SubTipoKilataje)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tipo).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DetPla>(entity =>
            {
                entity.HasKey(e => new { e.CvePla, e.Id });

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.Id).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcDesc)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetPlaTipCli>(entity =>
            {
                entity.HasKey(e => new { e.CvePla, e.Id });

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.Id).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetUsers>(entity =>
            {
                entity.HasKey(e => e.CveUser);

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella1)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella10)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella2)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella3)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella4)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella5)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella6)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella7)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella8)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Huella9)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DetmovtosSicavi>(entity =>
            {
                entity.HasKey(e => new { e.CveBod, e.FolMov, e.CveMov, e.SerMov, e.Id })
                    .HasName("PK_DETMOV")
                    .IsClustered(false);

                entity.ToTable("DETMOVTOS_SICAVI");

                entity.Property(e => e.SerMov)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cant).HasColumnType("money");

                entity.Property(e => e.CveProd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DesProd)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpSub).HasColumnType("money");

                entity.Property(e => e.PreUni).HasColumnType("money");
            });

            modelBuilder.Entity<Diashabiles>(entity =>
            {
                entity.HasKey(e => new { e.FolioId, e.CveSuc });

                entity.ToTable("DIASHABILES");

                entity.Property(e => e.FolioId).HasColumnName("FolioID");

                entity.Property(e => e.FecRevCentral).HasColumnType("datetime");

                entity.Property(e => e.FecRevLocal).HasColumnType("datetime");

                entity.Property(e => e.FechaInhabil).HasColumnType("datetime");

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpBasic>(entity =>
            {
                entity.HasKey(e => new { e.FolOri, e.FolMov, e.FolPag });

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.FolPag, e.StsEnvio, e.RegVersion })
                    .HasName("Arania");

                entity.HasIndex(e => new { e.FolOri, e.FolMov, e.CveSuc, e.CveCli, e.Nomcli, e.FecVenc, e.CvePla, e.Descripcion, e.Afectada, e.Enajenado, e.Desempeñado, e.Capital, e.Intereses, e.Recargos, e.ImpPag, e.FecMov, e.ImpBon, e.ReimCosto, e.RegTimeStamp, e.RegVersion, e.Tipo, e.CveTipProd, e.Producto, e.Cancelada })
                    .HasName("<cubo, sysname,>");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecMov).HasColumnType("datetime");

                entity.Property(e => e.FecPag).HasColumnType("datetime");

                entity.Property(e => e.FecVenc).HasColumnType("datetime");

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRealMov).HasColumnType("datetime");

                entity.Property(e => e.FechaRealPag).HasColumnType("datetime");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Intereses).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginM)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUserM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos).HasColumnType("money");

                entity.Property(e => e.RegTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReimCosto).HasColumnType("money");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpMovttoGral>(entity =>
            {
                entity.HasKey(e => new { e.CveSuc, e.CveTipProd, e.FolOri, e.CveCli });

                entity.HasIndex(e => e.FolOri)
                    .HasName("triggerEmpBasic, sysname,>");

                entity.HasIndex(e => new { e.CveSuc, e.FolOri, e.RegVersion })
                    .HasName("Arania");

                entity.Property(e => e.Bonifica).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalPagado).HasColumnType("money");

                entity.Property(e => e.CapitalVigente).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Duplicado).HasColumnType("money");

                entity.Property(e => e.FecFin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecIni)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpVales6).HasColumnType("money");

                entity.Property(e => e.InteresesPagados).HasColumnType("money");

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecargosPagados).HasColumnType("money");

                entity.Property(e => e.RecupEnVtas).HasColumnType("money");

                entity.Property(e => e.Recuperado).HasColumnType("money");

                entity.Property(e => e.RegTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VencArecup)
                    .HasColumnName("VencARecup")
                    .HasColumnType("money");

                entity.Property(e => e.Vencido).HasColumnType("money");
            });

            modelBuilder.Entity<Empenio>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpenio, e.FolMov })
                    .HasName("PK_Empenio_1");

                entity.Property(e => e.IdEmpenio).HasColumnName("idEmpenio");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Empenios>(entity =>
            {
                entity.HasKey(e => new { e.FolOri, e.FolMov, e.RegTimeStamp })
                    .HasName("PK_Empenios_1");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.StsEnvio, e.RegVersion })
                    .HasName("Arania");

                entity.Property(e => e.RegTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.FecBon).HasColumnType("datetime");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReimCosto).HasColumnType("money");

                entity.Property(e => e.ReimFecha).HasColumnType("datetime");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EnvioWs>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.Iderp });

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Iderp).HasColumnName("IDERP");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraEnvio).HasColumnType("datetime");

                entity.Property(e => e.MsgRespWs)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorDesemDolar).HasColumnType("money");
            });

            modelBuilder.Entity<ExisteSicavi>(entity =>
            {
                entity.HasKey(e => new { e.Cveprod, e.Cvebod })
                    .IsClustered(false);

                entity.ToTable("EXISTE_SICAVI");

                entity.Property(e => e.Cveprod)
                    .HasColumnName("CVEPROD")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cvebod).HasColumnName("CVEBOD");

                entity.Property(e => e.Cospro)
                    .HasColumnName("COSPRO")
                    .HasColumnType("money");

                entity.Property(e => e.Exifis)
                    .HasColumnName("EXIFIS")
                    .HasColumnType("money");

                entity.Property(e => e.Existe)
                    .HasColumnName("EXISTE")
                    .HasColumnType("money");

                entity.Property(e => e.Fecinv)
                    .HasColumnName("FECINV")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ultcos)
                    .HasColumnName("ULTCOS")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<FecUltMovtoCte>(entity =>
            {
                entity.HasKey(e => new { e.CveSuc, e.CveCli });

                entity.Property(e => e.UltimoMov).HasColumnType("datetime");
            });

            modelBuilder.Entity<FondoCaja>(entity =>
            {
                entity.HasKey(e => e.Folio);

                entity.HasIndex(e => new { e.CveUser, e.Fecha })
                    .HasName("<Name of Missing Index5, sysname,>");

                entity.HasIndex(e => new { e.CveUser, e.FechaReal })
                    .HasName("IdxFondoCajaFechaReal");

                entity.Property(e => e.Folio).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<FondoCaja2>(entity =>
            {
                entity.HasKey(e => e.Folio);

                entity.Property(e => e.Folio).ValueGeneratedNever();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Importe).HasColumnType("money");
            });

            modelBuilder.Entity<GrupoPer>(entity =>
            {
                entity.HasKey(e => e.CveGrup);

                entity.Property(e => e.CveGrup).HasDefaultValueSql("(0)");

                entity.Property(e => e.DesGrup)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<IndCorteOperaciones>(entity =>
            {
                entity.HasKey(e => new { e.CorteOperacionesId, e.CveSuc })
                    .HasName("PK_ReporteSucursal");

                entity.Property(e => e.CorteOperacionesId)
                    .HasColumnName("CorteOperacionesID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FecAlta).HasColumnType("datetime");

                entity.Property(e => e.FecRevCentral)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.FecRevLocal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IndCorteId).HasColumnName("IndCorteID");
            });

            modelBuilder.Entity<IndOperaciones>(entity =>
            {
                entity.HasKey(e => new { e.IndicadorId, e.CveSuc });

                entity.Property(e => e.IndicadorId)
                    .HasColumnName("IndicadorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Avance).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Cumplimiento).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FecRevCentral)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecRevLocal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IndId).HasColumnName("IndID");

                entity.Property(e => e.Meta).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Real).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SucursalId)
                    .IsRequired()
                    .HasColumnName("SucursalID")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Tendencia).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<IndOperacionesAliProd>(entity =>
            {
                entity.HasKey(e => new { e.IndicadorId, e.CveSuc });

                entity.Property(e => e.IndicadorId)
                    .HasColumnName("IndicadorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Aliado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AliadoId)
                    .HasColumnName("AliadoID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecRevCentral)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecRevLocal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Folios)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.IndId)
                    .HasColumnName("IndID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreInd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Producto)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("ProductoID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Real)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("((0))");

                entity.Property(e => e.SucursalId)
                    .HasColumnName("SucursalID")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Valor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ListaClientesNuevos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CapitalTotalEnajFolioOrig).HasColumnType("money");

                entity.Property(e => e.CapitalTotalEnajFolioUlt).HasColumnType("money");

                entity.Property(e => e.CapitalTotalPrestado).HasColumnType("money");

                entity.Property(e => e.Ciucli).HasColumnName("CIUCLI");

                entity.Property(e => e.Colcli)
                    .IsRequired()
                    .HasColumnName("COLCLI")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cpcli)
                    .IsRequired()
                    .HasColumnName("CPCLI")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Curpcli)
                    .IsRequired()
                    .HasColumnName("CURPCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cvecli).HasColumnName("CVECLI");

                entity.Property(e => e.Cveedo).HasColumnName("CVEEDO");

                entity.Property(e => e.Desciu)
                    .IsRequired()
                    .HasColumnName("DESCIU")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Desedo)
                    .IsRequired()
                    .HasColumnName("DESEDO")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Destipcli)
                    .IsRequired()
                    .HasColumnName("DESTIPCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli)
                    .IsRequired()
                    .HasColumnName("DIRCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli2)
                    .IsRequired()
                    .HasColumnName("DIRCLI2")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli3)
                    .IsRequired()
                    .HasColumnName("DIRCLI3")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dircli4)
                    .IsRequired()
                    .HasColumnName("DIRCLI4")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Emailcli)
                    .IsRequired()
                    .HasColumnName("EMAILCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Faxcli)
                    .IsRequired()
                    .HasColumnName("FAXCLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecGeneracion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecUltPago)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fecultmov)
                    .HasColumnName("FECULTMOV")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Grucli).HasColumnName("GRUCLI");

                entity.Property(e => e.Identcli)
                    .IsRequired()
                    .HasColumnName("IDENTCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InteresTotalPagado).HasColumnType("money");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasColumnName("OBSERVA")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfccli)
                    .IsRequired()
                    .HasColumnName("RFCCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaldoCliente).HasColumnType("money");

                entity.Property(e => e.Tel1cli)
                    .IsRequired()
                    .HasColumnName("TEL1CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel2cli)
                    .IsRequired()
                    .HasColumnName("TEL2CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel3cli)
                    .IsRequired()
                    .HasColumnName("TEL3CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Llaves>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveEmp).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUsado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Llave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.Usado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Movtos>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc, e.Clave });

                entity.HasIndex(e => e.Cancelada)
                    .HasName("Movtos_Idx_A");

                entity.HasIndex(e => e.CveCli)
                    .HasName("IdxMovtosCveCli");

                entity.HasIndex(e => e.FolMovPrim)
                    .HasName("<Name of Missing Index7, sysname,>");

                entity.HasIndex(e => new { e.Cancelada, e.FecMov })
                    .HasName("Movtos_Idx_Corte");

                entity.HasIndex(e => new { e.CveUser, e.FecMov })
                    .HasName("<Name of Missing Index,4 sysname,>");

                entity.HasIndex(e => new { e.CveUser, e.FechaReal })
                    .HasName("IdxMovtosFechaReal");

                entity.HasIndex(e => new { e.CveCli, e.FecMov, e.Cancelada })
                    .HasName("Idx_ClientesNuevos02");

                entity.HasIndex(e => new { e.FolMovOrig, e.Cancelada, e.FecMov })
                    .HasName("<Name of Missing Index3, sysname,>");

                entity.HasIndex(e => new { e.FolMovOrig, e.CveSucOrig, e.Cancelada })
                    .HasName("Movtos_Idx_B");

                entity.HasIndex(e => new { e.FolMovOrig, e.CveSucOrig, e.Cancelada, e.FecMov })
                    .HasName("Idx_Cartera03");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.CveCli, e.Capital, e.Cancelada })
                    .HasName("Idx_ClientesNuevos_01");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.FecEnajenado, e.LoteEnaj, e.Enajenado })
                    .HasName("IdxMovtosEnaj");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.FolMovOrig, e.CveSucOrig, e.Cancelada })
                    .HasName("GetFolioOrig");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.RegTimeStamp, e.StsEnvio, e.FolMovPrim })
                    .HasName("Arania");

                entity.HasIndex(e => new { e.CveSuc, e.Cancelada, e.FecMov, e.Capital, e.FolMov, e.CvePla })
                    .HasName("Movtos_IdxA");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.CveCli, e.Capital, e.Cancelada, e.Enajenado })
                    .HasName("Idx_LisNuevosCtes03");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.CveCli, e.FolMovPrim, e.CveSucOri, e.CvePla })
                    .HasName("<SMS3, sysname,>");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.Enajenado, e.Desempeñado, e.FecDesemp, e.FecEnajenado, e.Cancelada, e.FechaReal })
                    .HasName("Idx_Exportar02");

                entity.HasIndex(e => new { e.FecDesemp, e.FecEnajenado, e.FolMov, e.CveSuc, e.FecVenc, e.CvePla, e.Capital, e.Cancelada, e.FecMov })
                    .HasName("<Name of Missing Index2, sysname,>");

                entity.HasIndex(e => new { e.IdCaja, e.CveCli, e.FecVenc, e.FolMov, e.CveSuc, e.Cancelada, e.Afectada, e.Enajenado, e.Desempeñado })
                    .HasName("Movtos_Idx_Enaj");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.FecMov, e.CvePla, e.Capital, e.Refrendo, e.CveUser, e.Cancelada, e.Enajenado, e.LoteEnaj })
                    .HasName("Idx_Exportar01");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.IdCaja, e.CveCli, e.FecVenc, e.CvePla, e.Cancelada, e.Afectada, e.Enajenado, e.Desempeñado })
                    .HasName("Idx_Enaj01");

                entity.HasIndex(e => new { e.Enajenado, e.FecDesemp, e.FecEnajenado, e.FecVenc, e.FecCom, e.CvePla, e.Capital, e.FolMov, e.CveSuc, e.Cancelada, e.FecMov })
                    .HasName("IdxCartera01");

                entity.HasIndex(e => new { e.FecEnajenado, e.FolMov, e.CveSuc, e.IdCaja, e.CveCli, e.FecVenc, e.CvePla, e.Capital, e.Refrendo, e.Cancelada, e.LoteEnaj })
                    .HasName("IdxMovtos_CancLoteEnaj");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.FecMov, e.FecEnajenado, e.LoteEnaj, e.Capital, e.Refrendo, e.CveUser, e.CvePla, e.Cancelada, e.Enajenado })
                    .HasName("Idx_PlazoCancEnaj01");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.CveCli, e.Capital, e.CveUser, e.FechaReal, e.Cancelada, e.Afectada, e.Enajenado, e.Desempeñado, e.FolMovPrim, e.Ubica })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.CveCli, e.FecMov, e.CvePla, e.Capital, e.ValorCom, e.FecEnajenado, e.Ubica, e.Cancelada, e.Enajenado, e.BloqueoExp })
                    .HasName("MovtosDesEnaje02");

                entity.HasIndex(e => new { e.FolMov, e.CveSuc, e.CveCli, e.FecMov, e.FecVenc, e.FecCom, e.Afectada, e.Enajenado, e.Desempeñado, e.FecDesemp, e.FecEnajenado, e.CveSucOri, e.Cancelada })
                    .HasName("<SMS2, sysname,>");

                entity.HasIndex(e => new { e.Ubica, e.CveBod, e.FecUbi, e.CveUserUbi, e.FolMov, e.CveSuc, e.IdCaja, e.CveCli, e.FecMov, e.FecVenc, e.Capital, e.FolMovOrig, e.Cancelada, e.Enajenado, e.Desempeñado })
                    .HasName("IdxBodCentral01");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Afectada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AlmSeg)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cancelada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoBarras1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoBarras2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoBarras3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoBarras4)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveBod).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveCli).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveCli2).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveCliRevLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSucOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserAut).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserCanc).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserEnaj).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserRob).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserUbi).HasDefaultValueSql("(0)");

                entity.Property(e => e.Desempeñado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Enajenado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecBloqueoExp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecCancelada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecCom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenadoHasta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecRobada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecUbi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechasPromo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FolMovOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.FolMovPrim).HasDefaultValueSql("((0))");

                entity.Property(e => e.FolioBolsa)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GastosAdm)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Letras)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomBen)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recuperado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Refrendo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegTimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Robada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Saldo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.TmpCveUserRec)
                    .HasColumnName("tmpCveUserRec")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TmpFecEnajenado)
                    .HasColumnName("tmpFecEnajenado")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.TmpFecRecuperacion)
                    .HasColumnName("tmpFecRecuperacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.TmpLoteEnaj)
                    .IsRequired()
                    .HasColumnName("tmpLoteEnaj")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalPeso)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalPeso2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValorCom)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Movtos2>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc, e.Clave });

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Afectada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AlmSeg)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cancelada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CveCli).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveGps).HasColumnName("CveGPS");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSucOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserAut).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserCanc).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserEnaj).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserRob).HasDefaultValueSql("(0)");

                entity.Property(e => e.Desempeñado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Enajenado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecCancelada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecCom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenadoHasta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecRobada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechasPromo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FolMovOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.GastosAdm)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpSegInicial).HasColumnType("money");

                entity.Property(e => e.ImpSegMensual).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Letras)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModGps).HasColumnName("ModGPS");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recuperado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Refrendo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Robada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Saldo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.TmpCveUserRec)
                    .HasColumnName("tmpCveUserRec")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TmpFecEnajenado)
                    .HasColumnName("tmpFecEnajenado")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.TmpFecRecuperacion)
                    .HasColumnName("tmpFecRecuperacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.TmpLoteEnaj)
                    .IsRequired()
                    .HasColumnName("tmpLoteEnaj")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalPeso)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalPeso2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValorCom)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosBc>(entity =>
            {
                entity.HasKey(e => new { e.CveSuc, e.FolMov, e.IdDet });

                entity.ToTable("MovtosBC");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observa2)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MovtosCubos>(entity =>
            {
                entity.Property(e => e.RegTimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MovtosEnaj>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FecEnajenadoHasta).HasColumnType("datetime");

                entity.Property(e => e.Fecenajenado)
                    .HasColumnName("fecenajenado")
                    .HasColumnType("datetime");

                entity.Property(e => e.Folioorig).HasColumnName("folioorig");

                entity.Property(e => e.Folmov).HasColumnName("folmov");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosFotos>(entity =>
            {
                entity.HasKey(e => new { e.Cvesuc, e.Folmovorig });

                entity.Property(e => e.Cvesuc)
                    .HasColumnName("CVESUC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Folmovorig)
                    .HasColumnName("FOLMOVORIG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cveuser)
                    .HasColumnName("CVEUSER")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Imagen1)
                    .IsRequired()
                    .HasColumnName("IMAGEN1")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagen2)
                    .IsRequired()
                    .HasColumnName("IMAGEN2")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagen3)
                    .IsRequired()
                    .HasColumnName("IMAGEN3")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagen4)
                    .IsRequired()
                    .HasColumnName("IMAGEN4")
                    .HasColumnType("image")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom1)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM1")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom2)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM2")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom3)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM3")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imagennom4)
                    .IsRequired()
                    .HasColumnName("IMAGENNOM4")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosInc>(entity =>
            {
                entity.HasKey(e => new { e.FolMovOrig, e.CveSucOrig, e.Id });

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObsInc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MovtosPagos>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc });

                entity.ToTable("Movtos_Pagos");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.HistFolios)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpReImp).HasColumnType("money");

                entity.Property(e => e.ImpValesRef).HasColumnType("money");

                entity.Property(e => e.Interes).HasColumnType("money");

                entity.Property(e => e.Recargos).HasColumnType("money");
            });

            modelBuilder.Entity<MovtosRemotos>(entity =>
            {
                entity.HasKey(e => e.IdMovto);

                entity.Property(e => e.IdMovto).ValueGeneratedNever();

                entity.Property(e => e.Cancelado).HasColumnName("cancelado");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.Cveusercancel).HasColumnName("cveusercancel");

                entity.Property(e => e.Feccancel)
                    .HasColumnName("feccancel")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Interes).HasColumnType("money");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Logincancel)
                    .IsRequired()
                    .HasColumnName("logincancel")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recargos).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<MovtosSicavi>(entity =>
            {
                entity.HasKey(e => new { e.CveBod, e.FolMov, e.CveMov, e.SerMov })
                    .IsClustered(false);

                entity.ToTable("MOVTOS_SICAVI");

                entity.Property(e => e.SerMov)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImpMov).HasColumnType("money");

                entity.Property(e => e.ImpSub).HasColumnType("money");

                entity.Property(e => e.ImpTot).HasColumnType("money");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observ)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MovtosTmp>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc });

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Afectada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AlmSeg)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cancelada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoBarras1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoBarras2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoBarras3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoBarras4)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveCli).HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSucOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserAut).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserCanc).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserEnaj).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUserRob).HasDefaultValueSql("(0)");

                entity.Property(e => e.Desempeñado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Enajenado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecCancelada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecCom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenadoHasta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecRobada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechasPromo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FolMovOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.GastosAdm)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Letras)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recuperado)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Refrendo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Robada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Saldo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TmpCveUserRec)
                    .HasColumnName("tmpCveUserRec")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TmpFecEnajenado)
                    .HasColumnName("tmpFecEnajenado")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.TmpFecRecuperacion)
                    .HasColumnName("tmpFecRecuperacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.TmpLoteEnaj)
                    .IsRequired()
                    .HasColumnName("tmpLoteEnaj")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalPeso)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalPeso2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValorCom)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosTmpCorte>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc });

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasComer).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pagado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Promo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosTmpCorte2>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc });

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasComer).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pagado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Promo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosTmpCorte2Autos>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc });

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasComer).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pagado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Promo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosTmpCorteAutos>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc });

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasComer).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pagado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Promo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosTmpCortePlazos>(entity =>
            {
                entity.HasKey(e => new { e.FolMov, e.CveSuc, e.SepararCart })
                    .HasName("PK__MovtosTmpCortePl__5728DECD");

                entity.HasIndex(e => new { e.FolMov, e.FecMov, e.FecVenc, e.Capital, e.FecDesemp, e.FecEnajenado, e.DiasComer, e.Promo, e.Pagado, e.EsAparatos, e.SepararCart, e.Exportado, e.Enajenado, e.CvePla })
                    .HasName("IdxCartera02");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.SepararCart).HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CvePla).HasDefaultValueSql("(0)");

                entity.Property(e => e.DiasComer).HasDefaultValueSql("(0)");

                entity.Property(e => e.EsAparatos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FecDesemp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecEnajenado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecVenc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pagado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Promo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MovtosexpSicavi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MOVTOSEXP_SICAVI");

                entity.Property(e => e.CveProdExp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpDescPlazo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpFecPres)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.EmpLogin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpLoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpValuador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MultiSucursales>(entity =>
            {
                entity.HasKey(e => e.CveSuc);

                entity.Property(e => e.CveSuc).ValueGeneratedNever();

                entity.Property(e => e.Bdsql)
                    .IsRequired()
                    .HasColumnName("BDSQL")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PassSql)
                    .IsRequired()
                    .HasColumnName("PassSQL")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServerSql)
                    .IsRequired()
                    .HasColumnName("ServerSQL")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserSql)
                    .IsRequired()
                    .HasColumnName("UserSQL")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasKey(e => new { e.FolPag, e.CveSuc });

                entity.HasIndex(e => e.FecPag)
                    .HasName("PAGO_Idx_B");

                entity.HasIndex(e => new { e.CveUser, e.FechaReal })
                    .HasName("IdxPagosFechaReal");

                entity.HasIndex(e => new { e.Recargos, e.FecPag })
                    .HasName("Idx_Pagos_Recargos_01");

                entity.HasIndex(e => new { e.CveSuc, e.FolMov, e.FecPag })
                    .HasName("PAGO_Idx_A");

                entity.HasIndex(e => new { e.CveSuc, e.Capital, e.FolMov, e.FecPag })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.CveSuc, e.FechaReal, e.FolMov, e.CveTipPag })
                    .HasName("<SMS1, sysname,>");

                entity.HasIndex(e => new { e.Capital, e.Interes, e.Recargos, e.FolMov, e.CveSuc })
                    .HasName("IdxTotales");

                entity.Property(e => e.FolPag).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveTipPag).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecPag)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpPag)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Interes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Letras)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Pagos2>(entity =>
            {
                entity.HasKey(e => new { e.FolPag, e.CveSuc });

                entity.Property(e => e.FolPag).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSuc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Capital)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CveTipPag).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecPag)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.Gps)
                    .HasColumnName("GPS")
                    .HasColumnType("money");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ImpPag)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Interes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Letras)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Seguro).HasColumnType("money");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<PagosDel>(entity =>
            {
                entity.HasKey(e => new { e.FolPag, e.CveSuc, e.FecCancelada });

                entity.Property(e => e.FecCancelada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecPag)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Interes).HasColumnType("money");

                entity.Property(e => e.Letras)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginCanc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recargos).HasColumnType("money");
            });

            modelBuilder.Entity<Permisos>(entity =>
            {
                entity.HasKey(e => e.CvePer);

                entity.Property(e => e.CvePer).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ayuda)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DesPer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Final).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<PreciosInternet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(0)");

                entity.Property(e => e.ClaveInterna)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FecActualizacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.FecDescarga)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Precio2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Precio3)
                    .HasColumnName("precio3")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.UsuarioInternet)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PreciosUsd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PreciosUSD");

                entity.Property(e => e.Compra).HasColumnType("money");

                entity.Property(e => e.FecDescarga)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Param1).HasColumnType("money");

                entity.Property(e => e.Venta).HasColumnType("money");
            });

            modelBuilder.Entity<ReImp>(entity =>
            {
                entity.HasKey(e => new { e.CveSuc, e.IdCaja, e.FecRei, e.CveUser, e.FolMov });

                entity.HasIndex(e => new { e.CveSuc, e.FolMov })
                    .HasName("<ActualizaMovtosEmpenios, sysname,>");

                entity.Property(e => e.FecRei)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.Costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ReImp2>(entity =>
            {
                entity.HasKey(e => new { e.CveSuc, e.IdCaja, e.FecRei, e.CveUser, e.FolMov });

                entity.Property(e => e.FecRei)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FolMov).HasDefaultValueSql("(0)");

                entity.Property(e => e.Costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<RefGratis>(entity =>
            {
                entity.HasKey(e => new { e.Cvesuc, e.Folmovorig });

                entity.Property(e => e.Cvesuc)
                    .HasColumnName("cvesuc")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Folmovorig)
                    .HasColumnName("folmovorig")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Numref)
                    .HasColumnName("numref")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<RefGratisJun2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RefGratis_Jun2019");

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime");

                entity.Property(e => e.Folmovorig).HasColumnName("folmovorig");

                entity.Property(e => e.Numref).HasColumnName("numref");
            });

            modelBuilder.Entity<RefGratisMay2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RefGratis_May2019");

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime");

                entity.Property(e => e.Folmovorig).HasColumnName("folmovorig");

                entity.Property(e => e.Numref).HasColumnName("numref");
            });

            modelBuilder.Entity<Resguardos>(entity =>
            {
                entity.HasKey(e => new { e.FolRes, e.CveSucRes, e.FolMovOrig, e.CveSucOrig });

                entity.Property(e => e.FolRes).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSucRes).HasDefaultValueSql("(0)");

                entity.Property(e => e.FolMovOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveSucOrig).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveBod).HasDefaultValueSql("(0)");

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.FecRes)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCaja).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<StatusBc>(entity =>
            {
                entity.HasKey(e => e.CveStatus);

                entity.ToTable("StatusBC");

                entity.Property(e => e.CveStatus).ValueGeneratedNever();

                entity.Property(e => e.DesStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.SoloBc).HasColumnName("SoloBC");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.CveUser);

                entity.Property(e => e.CveUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.CambiarPass)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EfecMax).HasColumnType("money");

                entity.Property(e => e.EsValidoAparatos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EsValidoAutos)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EsValidoJoyeria)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EsValidoPlateria)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MontoMax)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MontoMaxDiaCte)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NivelAutoriza).HasDefaultValueSql("(0)");

                entity.Property(e => e.NivelUser).HasDefaultValueSql("(0)");

                entity.Property(e => e.NomUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PorcMaxBonif)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMaxExp)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PorcMinExp)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");

                entity.Property(e => e.UltFecActPass)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");
            });

            modelBuilder.Entity<UsersHist>(entity =>
            {
                entity.HasKey(e => new { e.CveUser, e.Consec });

                entity.ToTable("Users_Hist");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaReal)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ValesRef>(entity =>
            {
                entity.HasKey(e => new { e.Cvesuc, e.Folmovorig, e.Folmov, e.Folmovnvo });

                entity.HasIndex(e => new { e.Cveuser, e.Fechareal })
                    .HasName("IdxValesRefFechaReal");

                entity.Property(e => e.Cvesuc)
                    .HasColumnName("cvesuc")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Folmovorig)
                    .HasColumnName("folmovorig")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Folmov)
                    .HasColumnName("folmov")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Folmovnvo)
                    .HasColumnName("folmovnvo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cveuser)
                    .HasColumnName("cveuser")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Numref)
                    .HasColumnName("numref")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ValesRefReImp>(entity =>
            {
                entity.HasKey(e => new { e.Cvesuc, e.Folmovorig, e.Folmovnvo });

                entity.Property(e => e.Cvesuc)
                    .HasColumnName("cvesuc")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Folmovorig)
                    .HasColumnName("folmovorig")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Folmovnvo)
                    .HasColumnName("folmovnvo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cveuser)
                    .HasColumnName("cveuser")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecrei)
                    .HasColumnName("fecrei")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFilaCentral).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdFilaLocal).HasDefaultValueSql("(0)");

                entity.Property(e => e.RegVersion).HasDefaultValueSql("(0)");

                entity.Property(e => e.StsEnvio).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ValesRefReImpRemotos>(entity =>
            {
                entity.HasKey(e => new { e.Cvesuc, e.Folmovorig, e.Folmovnvo });

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.Folmovorig).HasColumnName("folmovorig");

                entity.Property(e => e.Folmovnvo).HasColumnName("folmovnvo");

                entity.Property(e => e.Cveuser).HasColumnName("cveuser");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecrei)
                    .HasColumnName("fecrei")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ValesRefRemotos>(entity =>
            {
                entity.HasKey(e => new { e.Cvesuc, e.Folmovorig, e.Folmov, e.Folmovnvo });

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.Folmovorig).HasColumnName("folmovorig");

                entity.Property(e => e.Folmov).HasColumnName("folmov");

                entity.Property(e => e.Folmovnvo).HasColumnName("folmovnvo");

                entity.Property(e => e.Cveuser).HasColumnName("cveuser");

                entity.Property(e => e.FecCancel)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('19000101 00:00:00')");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginCancel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Numref).HasColumnName("numref");
            });

            modelBuilder.Entity<Valesrefrei>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("valesrefrei");

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.Cveuser).HasColumnName("cveuser");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("fechareal")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecrei)
                    .HasColumnName("fecrei")
                    .HasColumnType("datetime");

                entity.Property(e => e.Folmovnvo).HasColumnName("folmovnvo");

                entity.Property(e => e.Folmovorig).HasColumnName("folmovorig");
            });

            modelBuilder.Entity<VwAportacionesPorRecibir>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAportacionesPorRecibir");

                entity.Property(e => e.CreditoId).HasColumnName("CreditoID");

                entity.Property(e => e.Cvemovcaja).HasColumnName("cvemovcaja");

                entity.Property(e => e.FecAceptado).HasColumnType("datetime");

                entity.Property(e => e.FecCancelado).HasColumnType("datetime");

                entity.Property(e => e.FecMov).HasColumnType("datetime");

                entity.Property(e => e.FechaReal).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.LlaveCreditoId).HasColumnName("LlaveCreditoID");

                entity.Property(e => e.LlaveFindin)
                    .IsRequired()
                    .HasColumnName("LlaveFINDIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomCliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAportacionesRecibidas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAportacionesRecibidas");

                entity.Property(e => e.CreditoId).HasColumnName("CreditoID");

                entity.Property(e => e.Cvemovcaja).HasColumnName("cvemovcaja");

                entity.Property(e => e.FecAceptado).HasColumnType("datetime");

                entity.Property(e => e.FecCancelado).HasColumnType("datetime");

                entity.Property(e => e.FecMov).HasColumnType("datetime");

                entity.Property(e => e.FechaReal).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.LlaveCreditoId).HasColumnName("LlaveCreditoID");

                entity.Property(e => e.LlaveFindin)
                    .IsRequired()
                    .HasColumnName("LlaveFINDIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomCliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBodCentral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwBodCentral");

                entity.Property(e => e.Capital)
                    .HasColumnName("capital")
                    .HasColumnType("money");

                entity.Property(e => e.Cvestatus).HasColumnName("cvestatus");

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.Cveuser2status).HasColumnName("cveuser2status");

                entity.Property(e => e.Cveuserstatus).HasColumnName("cveuserstatus");

                entity.Property(e => e.Desstatus)
                    .IsRequired()
                    .HasColumnName("desstatus")
                    .HasMaxLength(116)
                    .IsUnicode(false);

                entity.Property(e => e.Fecmov)
                    .HasColumnName("fecmov")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecstatus)
                    .HasColumnName("fecstatus")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecvenc)
                    .HasColumnName("fecvenc")
                    .HasColumnType("datetime");

                entity.Property(e => e.Folmov).HasColumnName("folmov");

                entity.Property(e => e.Idcaja).HasColumnName("idcaja");

                entity.Property(e => e.Iddet).HasColumnName("iddet");

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("nomcli")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observastatus)
                    .IsRequired()
                    .HasColumnName("observastatus")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observastatus2)
                    .IsRequired()
                    .HasColumnName("observastatus2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prenda)
                    .HasColumnName("prenda")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasColumnName("ubica")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCapitalEmpenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCapitalEmpenio");

                entity.Property(e => e.CapDesempeñado).HasColumnType("money");

                entity.Property(e => e.CapEnajenado).HasColumnType("money");

                entity.Property(e => e.CapTotal).HasColumnType("money");

                entity.Property(e => e.CapVencido).HasColumnType("money");

                entity.Property(e => e.CapVigente).HasColumnType("money");
            });

            modelBuilder.Entity<VwClienteEmpenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwClienteEmpenio");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalPagado).HasColumnType("money");

                entity.Property(e => e.FactorDescto).HasColumnType("numeric(2, 1)");

                entity.Property(e => e.IdEmpenio).HasColumnName("idEmpenio");

                entity.Property(e => e.Inicia).HasColumnType("datetime");

                entity.Property(e => e.InteresesPagados).HasColumnType("money");

                entity.Property(e => e.NomCli)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecargosPagados).HasColumnType("money");

                entity.Property(e => e.Termina).HasColumnType("datetime");

                entity.Property(e => e.ValorCte).HasColumnType("numeric(38, 16)");

                entity.Property(e => e.Vencido).HasColumnType("money");
            });

            modelBuilder.Entity<VwClientesOcupaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwClientesOcupaciones");

                entity.Property(e => e.Numctes).HasColumnName("numctes");

                entity.Property(e => e.Ocupacion)
                    .IsRequired()
                    .HasColumnName("ocupacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpActivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpActivo");

                entity.Property(e => e.Años).HasColumnName("años");

                entity.Property(e => e.CveUbi).HasColumnName("cveUbi");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.FecUbi).HasColumnType("datetime");

                entity.Property(e => e.FechaPrestamo).HasColumnType("datetime");

                entity.Property(e => e.Marca)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Meses).HasColumnName("meses");

                entity.Property(e => e.NomUbi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSucursal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prestamo).HasColumnType("money");

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valuador)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpBasic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpBasic");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.DesTipCli)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecMov).HasColumnType("date");

                entity.Property(e => e.FecPag).HasColumnType("date");

                entity.Property(e => e.FecVenc).HasColumnType("date");

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("date");

                entity.Property(e => e.FechaAfectada).HasColumnType("datetime");

                entity.Property(e => e.FechaRealPag).HasColumnType("datetime");

                entity.Property(e => e.Grucli).HasColumnName("GRUCLI");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.Intereses).HasColumnType("money");

                entity.Property(e => e.LetraProd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginM)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoteEnaj)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUserM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos).HasColumnType("money");

                entity.Property(e => e.ReimCosto).HasColumnType("money");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.SubTipoKilataje)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpBasic2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpBasic2");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCom).HasColumnType("date");

                entity.Property(e => e.FecMov).HasColumnType("date");

                entity.Property(e => e.FecPag).HasColumnType("date");

                entity.Property(e => e.FecVenc).HasColumnType("date");

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("date");

                entity.Property(e => e.FechaAfectada).HasColumnType("datetime");

                entity.Property(e => e.FechaRealPag).HasColumnType("datetime");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.Intereses).HasColumnType("money");

                entity.Property(e => e.LetraProd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LetraProd2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginM)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoteEnaj)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUserM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos).HasColumnType("money");

                entity.Property(e => e.ReimCosto).HasColumnType("money");

                entity.Property(e => e.Saldo).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpBasicFamilia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpBasicFamilia");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecMov).HasColumnType("datetime");

                entity.Property(e => e.FecVenc).HasColumnType("datetime");

                entity.Property(e => e.IdEmpenio).HasColumnName("idEmpenio");

                entity.Property(e => e.IdMenor).HasColumnName("idMenor");

                entity.Property(e => e.NomCli)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomFamilia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prenda)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpMovtosResumenPagos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovtosResumenPagos");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipProd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Interes).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PagReimp).HasColumnType("money");

                entity.Property(e => e.Recargos).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpMovtosResumenPagos2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovtosResumenPagos2");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Interes).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpMovttoCartera>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovttoCartera");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpMovttoEfectivoDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovttoEfectivoDetalle");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipPag2)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRealPag).HasColumnType("datetime");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Intereses).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos).HasColumnType("money");

                entity.Property(e => e.ReimCosto).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpMovttoEfectivoDetalle2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovttoEfectivoDetalle2");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRealPag).HasColumnType("datetime");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.Intereses).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos).HasColumnType("money");

                entity.Property(e => e.ReimCosto).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpMovttoGral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovttoGral");

                entity.Property(e => e.Bonifica).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalPagado).HasColumnType("money");

                entity.Property(e => e.CapitalVigente).HasColumnType("money");

                entity.Property(e => e.DesTipCli)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecFin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecIni)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("date");

                entity.Property(e => e.FechaAfectada)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.ImpReImp).HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.InteresesPagados).HasColumnType("money");

                entity.Property(e => e.LetraProd)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecargosPagados).HasColumnType("money");

                entity.Property(e => e.RecupEnVtas).HasColumnType("money");

                entity.Property(e => e.Recuperado).HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VencArecup)
                    .HasColumnName("VencARecup")
                    .HasColumnType("money");

                entity.Property(e => e.Vencido).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpMovttoGral2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovttoGral2");

                entity.Property(e => e.Bonifica).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalPagado).HasColumnType("money");

                entity.Property(e => e.CapitalVigente).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecFin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecIni)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAfectada)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.ImpReImp).HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.InteresesPagados).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecargosPagados).HasColumnType("money");

                entity.Property(e => e.RecupEnVtas).HasColumnType("money");

                entity.Property(e => e.Recuperado).HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCategoria)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VencArecup)
                    .HasColumnName("VencARecup")
                    .HasColumnType("money");

                entity.Property(e => e.Vencido).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpMovttoGralGerencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovttoGral_Gerencia");

                entity.Property(e => e.Bonifica).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalPagado).HasColumnType("money");

                entity.Property(e => e.CapitalVigente).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecFin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecIni)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAfectada)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.ImpReimp)
                    .HasColumnName("impReimp")
                    .HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.InteresesPagados).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumReimp).HasColumnName("numReimp");

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecargosPagados).HasColumnType("money");

                entity.Property(e => e.RecupEnVtas).HasColumnType("money");

                entity.Property(e => e.Recuperado).HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VencArecup)
                    .HasColumnName("VencARecup")
                    .HasColumnType("money");

                entity.Property(e => e.Vencido).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpMovttoPagos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpMovttoPagos");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Intereses).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos).HasColumnType("money");

                entity.Property(e => e.Saldo).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpPagRes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpPagRes");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.IdEmpenio).HasColumnName("idEmpenio");

                entity.Property(e => e.IntPag).HasColumnType("money");

                entity.Property(e => e.RegPag).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpPagos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpPagos");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.FecPag).HasColumnType("datetime");

                entity.Property(e => e.IdEmpenio).HasColumnName("idEmpenio");

                entity.Property(e => e.Intereses).HasColumnType("money");

                entity.Property(e => e.Recargos).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpenioPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpenioPago");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CapitalColocado).HasColumnType("money");

                entity.Property(e => e.CapitalEnajenado).HasColumnType("money");

                entity.Property(e => e.CapitalRecuperado).HasColumnType("money");

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.InteresesCobrados).HasColumnType("money");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.RecargosCobrados).HasColumnType("money");
            });

            modelBuilder.Entity<VwEmpenios>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpenios");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.FecBon).HasColumnType("datetime");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.ReimCosto).HasColumnType("money");

                entity.Property(e => e.ReimFecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwEmpenios2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpenios2");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.FecBon).HasColumnType("datetime");

                entity.Property(e => e.ImpBon).HasColumnType("money");

                entity.Property(e => e.Importevale)
                    .HasColumnName("importevale")
                    .HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReimCosto).HasColumnType("money");

                entity.Property(e => e.ReimFecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwFamiliaEmpenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFamiliaEmpenio");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.Cvepla).HasColumnName("cvepla");

                entity.Property(e => e.IdEmpenio).HasColumnName("idEmpenio");

                entity.Property(e => e.Inicia).HasColumnType("datetime");

                entity.Property(e => e.NomFamilia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Termina).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwIncidencias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIncidencias");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.Cvecli).HasColumnName("cvecli");

                entity.Property(e => e.Cveusermovto).HasColumnName("cveusermovto");

                entity.Property(e => e.DesInc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecEnajenado).HasColumnType("datetime");

                entity.Property(e => e.FecMov).HasColumnType("datetime");

                entity.Property(e => e.FechaReal).HasColumnType("datetime");

                entity.Property(e => e.Fecharealmovto)
                    .HasColumnName("fecharealmovto")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loginmovto)
                    .IsRequired()
                    .HasColumnName("loginmovto")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("nomcli")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nomusermovto)
                    .IsRequired()
                    .HasColumnName("nomusermovto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObsInc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prendas)
                    .HasColumnName("prendas")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<VwIndCartera>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndCartera");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwIndClientesNuevos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndClientesNuevos");

                entity.Property(e => e.DesTipProd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwIndEnajenados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndEnajenados");

                entity.Property(e => e.AlmSeg).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CveProdExp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesPlazo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipProd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Desempeñado).HasColumnName("DESEMPEÑADO");

                entity.Property(e => e.Despla)
                    .HasColumnName("DESPLA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FecCom).HasColumnType("datetime");

                entity.Property(e => e.FecEnajenado).HasColumnType("datetime");

                entity.Property(e => e.FecEnajenadoHasta).HasColumnType("datetime");

                entity.Property(e => e.FecExporta).HasColumnType("datetime");

                entity.Property(e => e.FecMov).HasColumnType("datetime");

                entity.Property(e => e.FecVenc).HasColumnType("datetime");

                entity.Property(e => e.FolOrigLogin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FolOrigNomUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Foliooriginal).HasColumnName("FOLIOORIGINAL");

                entity.Property(e => e.GastosAdm).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Kilataje).HasColumnType("money");

                entity.Property(e => e.LetraProd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoNuevo).HasColumnType("money");

                entity.Property(e => e.NomUserRec)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pagado)
                    .HasColumnName("PAGADO")
                    .HasColumnType("money");

                entity.Property(e => e.PrecioProd).HasColumnType("money");

                entity.Property(e => e.Prenda)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Refrendo).HasColumnType("money");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.Property(e => e.TmpCveUserRec).HasColumnName("tmpCveUserRec");

                entity.Property(e => e.TmpFecEnajenado)
                    .HasColumnName("tmpFecEnajenado")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmpFecRecuperacion)
                    .HasColumnName("tmpFecRecuperacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmpLoteEnaj)
                    .IsRequired()
                    .HasColumnName("tmpLoteEnaj")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicadet).HasColumnName("UBICADET");

                entity.Property(e => e.ValorCom).HasColumnType("money");
            });

            modelBuilder.Entity<VwIndEnajenados2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndEnajenados2");

                entity.Property(e => e.CapiPres).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PromPres).HasColumnType("money");

                entity.Property(e => e.SaldoEnaj).HasColumnType("money");
            });

            modelBuilder.Entity<VwIndEnajenados3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndEnajenados3");

                entity.Property(e => e.AcuCapiPres).HasColumnType("money");

                entity.Property(e => e.AcuPromPres).HasColumnType("money");

                entity.Property(e => e.CapiPres).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PorcEnajPres).HasColumnType("money");

                entity.Property(e => e.PromPres).HasColumnType("money");

                entity.Property(e => e.SaldoEnaj).HasColumnType("money");
            });

            modelBuilder.Entity<VwIndMovttoPrestadoAliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndMovttoPrestadoAliado");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwIndMovttoPrestadoProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndMovttoPrestadoProd");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.CapitalOri).HasColumnType("money");

                entity.Property(e => e.Producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwIndResumenPagos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIndResumenPagos");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.DesTipPag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipProd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpPag).HasColumnType("money");

                entity.Property(e => e.Interes).HasColumnType("money");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PagReimp).HasColumnType("money");

                entity.Property(e => e.Recargos).HasColumnType("money");
            });

            modelBuilder.Entity<VwJoyCatPrecioGramo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJoyCatPrecioGramo");

                entity.Property(e => e.Kilataje).HasColumnType("money");

                entity.Property(e => e.PrecioGramo).HasColumnType("money");

                entity.Property(e => e.SubTipoKilataje)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJoyDetJoyeria>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJoyDetJoyeria");

                entity.Property(e => e.DesTipProd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kilataje).HasColumnType("money");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.PesConPie).HasColumnType("money");

                entity.Property(e => e.PesReal).HasColumnType("money");

                entity.Property(e => e.PrecioGramo).HasColumnType("money");

                entity.Property(e => e.Prenda)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoKilataje)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valuado)
                    .HasColumnName("valuado")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VwJoyDetPorcPrestamos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJoyDetPorcPrestamos");

                entity.Property(e => e.CalPrecioGramo).HasColumnType("money");

                entity.Property(e => e.DesTipProd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DifPrestamo).HasColumnType("money");

                entity.Property(e => e.Kilataje).HasColumnType("money");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.PesConPie).HasColumnType("money");

                entity.Property(e => e.PesReal).HasColumnType("money");

                entity.Property(e => e.PorcDif).HasColumnType("money");

                entity.Property(e => e.PreSugerido).HasColumnType("money");

                entity.Property(e => e.PrecioGramo).HasColumnType("money");

                entity.Property(e => e.Prenda)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoKilataje)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valuado)
                    .HasColumnName("valuado")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VwJoyResumenPrestamos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJoyResumenPrestamos");

                entity.Property(e => e.CalPrecioGramo).HasColumnType("money");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.DesTipCli)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipProd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DifPrestamo).HasColumnType("money");

                entity.Property(e => e.Kilataje).HasColumnType("money");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PesConPie).HasColumnType("money");

                entity.Property(e => e.PesReal).HasColumnType("money");

                entity.Property(e => e.PorcDif).HasColumnType("money");

                entity.Property(e => e.PreSugerido).HasColumnType("money");

                entity.Property(e => e.PrecioGramo).HasColumnType("money");

                entity.Property(e => e.Prenda)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoKilataje)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valuado)
                    .HasColumnName("valuado")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VwMovtosEnaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMovtosEnaj");

                entity.Property(e => e.Capital).HasColumnType("money");

                entity.Property(e => e.Cvepla).HasColumnName("cvepla");

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.DesTipProd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Desmar)
                    .IsRequired()
                    .HasColumnName("desmar")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Despla)
                    .IsRequired()
                    .HasColumnName("despla")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecEnajenado).HasColumnType("datetime");

                entity.Property(e => e.FecMov).HasColumnType("datetime");

                entity.Property(e => e.Folmov).HasColumnName("folmov");

                entity.Property(e => e.LetraProd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoteEnaj)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prenda)
                    .IsRequired()
                    .HasColumnName("prenda")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorCom).HasColumnType("money");
            });

            modelBuilder.Entity<VwMovtosRemotosDia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMovtosRemotosDia");

                entity.Property(e => e.Cancelado).HasColumnName("cancelado");

                entity.Property(e => e.Capital)
                    .HasColumnName("capital")
                    .HasColumnType("money");

                entity.Property(e => e.Cvesuc).HasColumnName("cvesuc");

                entity.Property(e => e.Cvesucorig).HasColumnName("cvesucorig");

                entity.Property(e => e.Cvesucorigen).HasColumnName("cvesucorigen");

                entity.Property(e => e.Cveuser).HasColumnName("cveuser");

                entity.Property(e => e.Esdesempeño).HasColumnName("esdesempeño");

                entity.Property(e => e.Esrefrendo).HasColumnName("esrefrendo");

                entity.Property(e => e.Esremoto).HasColumnName("esremoto");

                entity.Property(e => e.Feccancel)
                    .HasColumnName("feccancel")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaReal).HasColumnType("datetime");

                entity.Property(e => e.Folmov).HasColumnName("folmov");

                entity.Property(e => e.Folmovorig).HasColumnName("folmovorig");

                entity.Property(e => e.Idmovto).HasColumnName("idmovto");

                entity.Property(e => e.Interes)
                    .HasColumnName("interes")
                    .HasColumnType("money");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logincancel)
                    .IsRequired()
                    .HasColumnName("logincancel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomSuc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nomsucorig)
                    .IsRequired()
                    .HasColumnName("nomsucorig")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Recargos)
                    .HasColumnName("recargos")
                    .HasColumnType("money");

                entity.Property(e => e.TipoMovto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VwPagoMes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPagoMes");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CapPag).HasColumnType("money");

                entity.Property(e => e.IngPag).HasColumnType("money");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.RegPag).HasColumnType("money");

                entity.Property(e => e.TotPag).HasColumnType("money");
            });

            modelBuilder.Entity<VwPerfilClientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPerfilClientes");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FecUltEmp)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAnt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IngresoAcu).HasColumnType("money");

                entity.Property(e => e.NomSuc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPreparaListaClientesNuevos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPreparaListaClientesNuevos");

                entity.Property(e => e.CapitalTotalEnajFolioOrig).HasColumnType("money");

                entity.Property(e => e.CapitalTotalEnajFolioUlt).HasColumnType("money");

                entity.Property(e => e.CapitalTotalPrestado).HasColumnType("money");

                entity.Property(e => e.Ciucli).HasColumnName("CIUCLI");

                entity.Property(e => e.Colcli)
                    .IsRequired()
                    .HasColumnName("COLCLI")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Cpcli)
                    .IsRequired()
                    .HasColumnName("CPCLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Curpcli)
                    .IsRequired()
                    .HasColumnName("CURPCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cvecli).HasColumnName("CVECLI");

                entity.Property(e => e.Cveedo).HasColumnName("CVEEDO");

                entity.Property(e => e.Desciu)
                    .IsRequired()
                    .HasColumnName("DESCIU")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Desedo)
                    .IsRequired()
                    .HasColumnName("DESEDO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Destipcli)
                    .IsRequired()
                    .HasColumnName("DESTIPCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dircli)
                    .IsRequired()
                    .HasColumnName("DIRCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dircli2)
                    .IsRequired()
                    .HasColumnName("DIRCLI2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dircli3)
                    .IsRequired()
                    .HasColumnName("DIRCLI3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dircli4)
                    .IsRequired()
                    .HasColumnName("DIRCLI4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Emailcli)
                    .IsRequired()
                    .HasColumnName("EMAILCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faxcli)
                    .IsRequired()
                    .HasColumnName("FAXCLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FecUltPago).HasColumnType("datetime");

                entity.Property(e => e.Fecalt)
                    .HasColumnName("FECALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecultmov)
                    .HasColumnName("FECULTMOV")
                    .HasColumnType("datetime");

                entity.Property(e => e.GetInteresTotalPagado)
                    .HasColumnName("getInteresTotalPagado")
                    .HasColumnType("money");

                entity.Property(e => e.Grucli).HasColumnName("GRUCLI");

                entity.Property(e => e.Identcli)
                    .IsRequired()
                    .HasColumnName("IDENTCLI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("LOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nomcli)
                    .IsRequired()
                    .HasColumnName("NOMCLI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observa)
                    .IsRequired()
                    .HasColumnName("OBSERVA")
                    .HasColumnType("ntext");

                entity.Property(e => e.Rfccli)
                    .IsRequired()
                    .HasColumnName("RFCCLI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoCliente).HasColumnType("money");

                entity.Property(e => e.Tel1cli)
                    .IsRequired()
                    .HasColumnName("TEL1CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2cli)
                    .IsRequired()
                    .HasColumnName("TEL2CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tel3cli)
                    .IsRequired()
                    .HasColumnName("TEL3CLI")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserPerGruApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserPerGruApp");

                entity.Property(e => e.Ayuda)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cvellave)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DesGrup)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesLllave)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DesPer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hijo).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Llave)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nieto).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.NomUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Padre).HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<VwUsuariosActivos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwUsuariosActivos");

                entity.Property(e => e.Cveuser).HasColumnName("cveuser");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
