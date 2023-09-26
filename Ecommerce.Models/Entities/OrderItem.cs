﻿namespace Ecommerce.Models.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Product Product { get; set; }

        public Guid? OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
