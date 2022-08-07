using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Banking.Models
{
    public partial class BankingContext : DbContext
    {
        public BankingContext()
        {
        }

        public BankingContext(DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DE1U8DH\\SA;Database=Banking;User ID=SA;Password=a;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.BankLimit);

                entity.Property(e => e.Borrowers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayBankName).HasMaxLength(50);

                entity.Property(e => e.Expiry).HasColumnType("date");

                entity.Property(e => e.IssuanceBankName).HasMaxLength(50);

                entity.Property(e => e.Sequence).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WestEast)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments);

                entity.Property(e => e.AdvisingConfirmingBank).HasMaxLength(100);

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.BlDate)
                    .HasColumnType("date")
                    .HasColumnName("BL_Date");

                entity.Property(e => e.CounterParty).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditStatus).HasMaxLength(50);

                entity.Property(e => e.Desk).HasMaxLength(50);

                entity.Property(e => e.DischargePort)
                    .HasMaxLength(50)
                    .HasColumnName("Discharge_Port");

                entity.Property(e => e.EastWest)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Expired).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("Expiry_Date");

                entity.Property(e => e.ExportBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullyCancelled)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fully_Cancelled");

                entity.Property(e => e.ImportExport).HasMaxLength(50);

                entity.Property(e => e.Incoterm).HasMaxLength(50);

                entity.Property(e => e.InvoiceValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IssuanceDate).HasColumnType("date");

                entity.Property(e => e.LcAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LC_Amount");

                entity.Property(e => e.LcFees)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LC_Fees");

                entity.Property(e => e.LcLineUtilisation)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lc_line_utilisation");

                entity.Property(e => e.LcRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LC_rate");

                entity.Property(e => e.LcRef)
                    .HasMaxLength(50)
                    .HasColumnName("LC_Ref");

                entity.Property(e => e.LoadPort).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanEnd).HasColumnType("date");

                entity.Property(e => e.LoanFees)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("loanFees");

                entity.Property(e => e.LoanRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.LockedBy).HasMaxLength(50);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentTerms).HasMaxLength(50);

                entity.Property(e => e.PetredecEntity).HasMaxLength(50);

                entity.Property(e => e.SoldTo).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VesselStrategy).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
