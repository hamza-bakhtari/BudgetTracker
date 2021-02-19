using Domain.Enums;
using Domain.Shared;

namespace Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public decimal Amount { get; set; }
        public Wallet Wallet { get; set; }
        public string WalletId { get; set; }
        public Category Category { get; }
        public string CategoryId { get; set; }
        public string Memo { get; set; }
    }
}