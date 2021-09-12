using System;
using System.Collections.Generic;

#nullable disable

namespace Test.DataTier.Models
{
    public partial class SysBook
    {
        public string Id { get; set; }
        public long? AvailableQuantity { get; set; }
        public long? SoldQuantity { get; set; }
        public long SellerId { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }

        public virtual SysUser Seller { get; set; }
    }
}
