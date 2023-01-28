using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBContext.Database
{
    public partial class EPMSDBContext : DbContext
    {
        public EPMSDBContext()
        {
        }

        public EPMSDBContext(DbContextOptions<EPMSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDisposition> TblDispositions { get; set; } = null!;
        public virtual DbSet<TblEngineHeader> TblEngineHeaders { get; set; } = null!;
        public virtual DbSet<TblImportDatum> TblImportData { get; set; } = null!;
        public virtual DbSet<TblKitCartMaster> TblKitCartMasters { get; set; } = null!;
        public virtual DbSet<TblLocation> TblLocations { get; set; } = null!;
        public virtual DbSet<TblMenu> TblMenus { get; set; } = null!;
        public virtual DbSet<TblMenuAccessRightPermission> TblMenuAccessRightPermissions { get; set; } = null!;
        public virtual DbSet<TblModuleHeader> TblModuleHeaders { get; set; } = null!;
        public virtual DbSet<TblPrintJob> TblPrintJobs { get; set; } = null!;
        public virtual DbSet<TblRfidmaster> TblRfidmasters { get; set; } = null!;
        public virtual DbSet<TblSystemDocNum> TblSystemDocNums { get; set; } = null!;
        public virtual DbSet<TblTcartLoadingDetail> TblTcartLoadingDetails { get; set; } = null!;
        public virtual DbSet<TblTcartLoadingHeader> TblTcartLoadingHeaders { get; set; } = null!;
        public virtual DbSet<TblTempTransactionType> TblTempTransactionTypes { get; set; } = null!;
        public virtual DbSet<TblTransactionDetail> TblTransactionDetails { get; set; } = null!;
        public virtual DbSet<TblTransactionHeader> TblTransactionHeaders { get; set; } = null!;
        public virtual DbSet<TblTransferHistory> TblTransferHistories { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;
        public virtual DbSet<TblUserRole> TblUserRoles { get; set; } = null!;
        public virtual DbSet<VwEngineStripCompletedQty> VwEngineStripCompletedQties { get; set; } = null!;
        public virtual DbSet<VwKittingStatusEnquiry> VwKittingStatusEnquiries { get; set; } = null!;
        public virtual DbSet<VwOverallTransportCartDetail> VwOverallTransportCartDetails { get; set; } = null!;
        public virtual DbSet<VwPartTransferEngineInformation> VwPartTransferEngineInformations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=dbtcc.cr01kvjs50s0.ap-southeast-1.rds.amazonaws.com,1433;initial catalog=E002EPMSDB;Encrypt=false;TrustServerCertificate=True;persist security info=True;user id=dbadmin;password=Et@g2011;MultipleActiveResultSets=True;App=EntityFramework;Min Pool Size=0;Max Pool Size=100;Pooling=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDisposition>(entity =>
            {
                entity.ToTable("tblDisposition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DispDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInspDate).HasColumnType("datetime");

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.Lidstatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LIDStatus");

                entity.Property(e => e.NeedFinalInsp).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.TblDispositions)
                    .HasForeignKey(d => d.HeaderId)
                    .HasConstraintName("FK_ImportData");
            });

            modelBuilder.Entity<TblEngineHeader>(entity =>
            {
                entity.HasKey(e => e.EngId)
                    .HasName("PK_EngineMaster");

                entity.ToTable("tblEngineHeader");

                entity.Property(e => e.EngId).HasColumnName("engId");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InductionDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblImportDatum>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .HasName("PK_ImportData");

                entity.ToTable("tblImportData");

                entity.Property(e => e.PartId).HasColumnName("partId");

                entity.Property(e => e.Bxcomments)
                    .HasColumnType("text")
                    .HasColumnName("BXComments");

                entity.Property(e => e.Cxcomments)
                    .HasColumnType("text")
                    .HasColumnName("CXComments");

                entity.Property(e => e.DateOff).HasColumnType("smalldatetime");

                entity.Property(e => e.DateOn).HasColumnType("smalldatetime");

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Disp)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EngId).HasColumnName("engId");

                entity.Property(e => e.FinalInsp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Fit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionFindings)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KitRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LidDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LidStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId).HasColumnName("moduleId");

                entity.Property(e => e.NextHigherLid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notif)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PartIssued)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartOff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartOn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartRequested)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlanPn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PlanPN");

                entity.Property(e => e.PlannedSb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PlannedSB");

                entity.Property(e => e.Pnstatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PNStatus");

                entity.Property(e => e.ResultsRecording)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SectCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Snoff)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SNOff");

                entity.Property(e => e.Snon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SNOn");

                entity.Property(e => e.StampOff)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StampOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SwapFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValOff)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Eng)
                    .WithMany(p => p.TblImportData)
                    .HasForeignKey(d => d.EngId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportData_EngineMaster");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TblImportData)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblImportData_tblModuleHeader");
            });

            modelBuilder.Entity<TblKitCartMaster>(entity =>
            {
                entity.HasKey(e => e.KcmasterId);

                entity.ToTable("tblKitCartMaster");

                entity.Property(e => e.KcmasterId).HasColumnName("KCMasterId");

                entity.Property(e => e.CreatedBy).HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsUsed)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.KitCartId)
                    .HasMaxLength(12)
                    .HasColumnName("KitCartID");

                entity.Property(e => e.KitCartRfid)
                    .HasMaxLength(24)
                    .HasColumnName("KitCartRFID");

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(30);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UwbMac)
                    .HasMaxLength(50)
                    .HasColumnName("UWB_MAC");
            });

            modelBuilder.Entity<TblLocation>(entity =>
            {
                entity.ToTable("tblLocation");

                entity.Property(e => e.Location).HasMaxLength(20);
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK_Menus");

                entity.ToTable("tblMenus");

                entity.Property(e => e.Controller).HasMaxLength(20);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.MenuTitle).HasMaxLength(50);

                entity.Property(e => e.MenuType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Page).HasMaxLength(20);
            });

            modelBuilder.Entity<TblMenuAccessRightPermission>(entity =>
            {
                entity.ToTable("tblMenuAccessRightPermission");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.TblMenuAccessRightPermissions)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuAccessRightPermission_Menus");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblMenuAccessRightPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuAccessRightPermission_MenuAccessRightPermission");
            });

            modelBuilder.Entity<TblModuleHeader>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("tblModuleHeader");

                entity.Property(e => e.ModuleId).HasColumnName("moduleId");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EngId).HasColumnName("engId");

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.TotalLidqty).HasColumnName("TotalLIDQty");

                entity.HasOne(d => d.Eng)
                    .WithMany(p => p.TblModuleHeaders)
                    .HasForeignKey(d => d.EngId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModuleHeader_tblEngineHeader");
            });

            modelBuilder.Entity<TblPrintJob>(entity =>
            {
                entity.ToTable("tblPrintJob");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rfid)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("RFID");
            });

            modelBuilder.Entity<TblRfidmaster>(entity =>
            {
                entity.ToTable("tblRFIDMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BsdepositedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BSDepositedBy");

                entity.Property(e => e.BsdepositedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BSDepositedDate");

                entity.Property(e => e.BsretrievedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BSRetrievedBy");

                entity.Property(e => e.BsretrievedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BSRetrievedDate");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.G2lpartDepositedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G2LPartDepositedBy");

                entity.Property(e => e.G2lpartDepositedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("G2LPartDepositedDate");

                entity.Property(e => e.G2lpartRetrievedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G2LPartRetrievedBy");

                entity.Property(e => e.G2lpartRetrievedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("G2LPartRetrievedDate");

                entity.Property(e => e.G2modulePartLoadedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G2ModulePartLoadedBy");

                entity.Property(e => e.G2modulePartLoadingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("G2ModulePartLoadingDate");

                entity.Property(e => e.G2tgdepositedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G2TGDepositedBy");

                entity.Property(e => e.G2tgdepositedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("G2TGDepositedDate");

                entity.Property(e => e.G2tgretrievedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G2TGRetrievedBy");

                entity.Property(e => e.G2tgretrievedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("G2TGRetrievedDate");

                entity.Property(e => e.G3receivedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G3ReceivedBy");

                entity.Property(e => e.G3receivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("G3ReceivedDate");

                entity.Property(e => e.IsLoosePart).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsModuleSpare).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsServiceable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.KcmasterId).HasColumnName("KCMasterID");

                entity.Property(e => e.LabelPrintedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LabelPrintedDate).HasColumnType("datetime");

                entity.Property(e => e.LcdepartedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LCDepartedDate");

                entity.Property(e => e.LcissuedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LCIssuedBy");

                entity.Property(e => e.LcissuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LCIssuedDate");

                entity.Property(e => e.LcreceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LCReceivedDate");

                entity.Property(e => e.Lidqty).HasColumnName("LIDQty");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NeedFinalInsp).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rfid)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("RFID");
            });

            modelBuilder.Entity<TblSystemDocNum>(entity =>
            {
                entity.ToTable("tblSystemDocNum");

                entity.Property(e => e.LastNum).HasColumnName("lastNum");

                entity.Property(e => e.TypeName).HasMaxLength(20);
            });

            modelBuilder.Entity<TblTcartLoadingDetail>(entity =>
            {
                entity.ToTable("tblTCartLoadingDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.Rfid)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("RFID");

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.TblTcartLoadingDetails)
                    .HasForeignKey(d => d.HeaderId)
                    .HasConstraintName("FK_TCartHeaderID");
            });

            modelBuilder.Entity<TblTcartLoadingHeader>(entity =>
            {
                entity.ToTable("tblTCartLoadingHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClncompletedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CLNCompletedBy");

                entity.Property(e => e.ClncompletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CLNCompletedDate");

                entity.Property(e => e.ClnreceivedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CLNReceivedBy");

                entity.Property(e => e.ClnreceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CLNReceivedDate");

                entity.Property(e => e.Gate1ReceivedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gate1ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.KcmasterId).HasColumnName("KCMasterId");

                entity.Property(e => e.LastUpdatedBy).HasMaxLength(30);

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PartLoadedBy).HasMaxLength(30);

                entity.Property(e => e.PartLoadedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.HasOne(d => d.Kcmaster)
                    .WithMany(p => p.TblTcartLoadingHeaders)
                    .HasForeignKey(d => d.KcmasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KCMasterID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TblTcartLoadingHeaders)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModuleID");
            });

            modelBuilder.Entity<TblTempTransactionType>(entity =>
            {
                entity.ToTable("tblTempTransactionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.TransDetailId);

                entity.ToTable("tblTransactionDetails");

                entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.PartDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartRfid)
                    .HasMaxLength(50)
                    .HasColumnName("PartRFID");

                entity.Property(e => e.PartStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.TblTransactionDetails)
                    .HasForeignKey(d => d.HeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTransactionDetails_tblTransactionHistory");
            });

            modelBuilder.Entity<TblTransactionHeader>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("PK_tblTransactionHistory");

                entity.ToTable("tblTransactionHeader");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KitCartId)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.KitCartRfid)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("KitCartRFID");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToEngine)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToKitCartId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ToKitCartID");

                entity.Property(e => e.ToKitCartRfid)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("ToKitCartRFID");

                entity.Property(e => e.TransactionBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTransferHistory>(entity =>
            {
                entity.ToTable("tblTransferHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromEngineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KitCartId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KitCartID");

                entity.Property(e => e.KitCartRfid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KitCartRFID");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartRfid)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("PartRFID");

                entity.Property(e => e.ToEngineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToKitCartId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ToKitCartID");

                entity.Property(e => e.ToKitCartRfid)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("ToKitCartRFID");

                entity.Property(e => e.TransferBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tblUsers");

                entity.Property(e => e.CreatedBy).HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.PassId).HasMaxLength(20);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(30);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(30);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserRole");
            });

            modelBuilder.Entity<TblUserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_UserRole");

                entity.ToTable("tblUserRole");

                entity.Property(e => e.CreatedBy).HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.RoleName).HasMaxLength(30);

                entity.Property(e => e.UpdatedBy).HasMaxLength(30);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwEngineStripCompletedQty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEngineStripCompletedQty");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Module).HasMaxLength(50);
            });

            modelBuilder.Entity<VwKittingStatusEnquiry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwKittingStatusEnquiry");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InductionDate).HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLidqty).HasColumnName("TotalLIDQty");
            });

            modelBuilder.Entity<VwOverallTransportCartDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwOverallTransportCartDetails");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KitCartId)
                    .HasMaxLength(12)
                    .HasColumnName("KitCartID");

                entity.Property(e => e.KitCartRfid)
                    .HasMaxLength(24)
                    .HasColumnName("KitCartRFID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            });

            modelBuilder.Entity<VwPartTransferEngineInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartTransferEngineInformation");

                entity.Property(e => e.EngineSaleNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InductionDate).HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLidqty).HasColumnName("TotalLIDQty");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
