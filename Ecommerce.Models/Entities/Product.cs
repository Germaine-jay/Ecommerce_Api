﻿using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection< ProductVariation>? ProductVariation { get; set; }
        
    }
}
