using System;
using System.Collections.Generic;

#nullable disable

namespace Banking.Models
{
    public partial class Bank
    {
        public int BankId { get; set; }
        public string IssuanceBankName { get; set; }
        public string DisplayBankName { get; set; }
        public long? BankLimit { get; set; }
        public string WestEast { get; set; }
        public DateTime? Expiry { get; set; }
        public int? Status { get; set; }
        public int? Sequence { get; set; }
        public string Borrowers { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
