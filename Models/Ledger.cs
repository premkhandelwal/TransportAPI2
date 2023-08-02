using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class LedgerDbContext : DbContext
    {
        public LedgerDbContext(DbContextOptions<LedgerDbContext> options) : base(options)
        {
        }
        public DbSet<Ledger> Ledgers { get; set; }
    }
    [Table("Ledger_400001")]
    public partial class Ledger
    {
        [Key]

        public int SrNo { get; set; }
        public string? Acode { get; set; }
        public string? Name { get; set; }
        public string? UnderGroup { get; set; }
        public string? AState { get; set; }
        public string? GSTNO { get; set; }
        public decimal? ABalance { get; set; }
        public string? AAddr1 { get; set; }
        public string? AAddr2 { get; set; }
        public string? AAddr3 { get; set; }
        public string? CITY { get; set; }
        public int? PinCode { get; set; }
        public string? AALIAS { get; set; }
        public decimal? ContactNo { get; set; }
        public string? ContactPerson { get; set; }
        public string? SubBillParty { get; set; }
        public string? PANNo { get; set; }
        public string? VatNo { get; set; }
        public decimal? Mobile { get; set; }
        public string? Email { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? Opening { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? Days { get; set; }
        public bool? CanDelete { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
