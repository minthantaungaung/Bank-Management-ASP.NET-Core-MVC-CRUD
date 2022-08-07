using System;
using System.Collections.Generic;

#nullable disable

namespace Banking.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public string Desk { get; set; }
        public string ImportExport { get; set; }
        public string CreditStatus { get; set; }
        public string PetredecEntity { get; set; }
        public string CounterParty { get; set; }
        public string VesselStrategy { get; set; }
        public string Incoterm { get; set; }
        public DateTime? BlDate { get; set; }
        public string LoadPort { get; set; }
        public string PaymentTerms { get; set; }
        public string SoldTo { get; set; }
        public string DischargePort { get; set; }
        public string LcRef { get; set; }
        public int? BankId { get; set; }
        public string ExportBank { get; set; }
        public string AdvisingConfirmingBank { get; set; }
        public DateTime? IssuanceDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? LcAmount { get; set; }
        public int? Tolerance { get; set; }
        public decimal? LcRate { get; set; }
        public decimal? InvoiceValue { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? LoanAmount { get; set; }
        public DateTime? LoanEnd { get; set; }
        public string Comments { get; set; }
        public string FullyCancelled { get; set; }
        public string EastWest { get; set; }
        public int? Sequence { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? LoanRate { get; set; }
        public decimal? LcLineUtilisation { get; set; }
        public decimal? LoanFees { get; set; }
        public decimal? LcFees { get; set; }
        public string Expired { get; set; }
        public string LockedBy { get; set; }
    }
}
