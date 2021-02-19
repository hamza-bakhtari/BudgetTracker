using System.Collections.Generic;
using Domain.Enums;
using Domain.Shared;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public CategoryType Type { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}