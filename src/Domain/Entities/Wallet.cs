using System.Collections.Generic;
using Domain.Enums;
using Domain.Shared;

namespace Domain.Entities
{
    public class Wallet : BaseEntity
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public WalletCurrency Currency { get; set; }
        public ICollection<Transaction> Transactions { get; } = new HashSet<Transaction>();
    }
}