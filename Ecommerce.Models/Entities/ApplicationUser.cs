﻿using Ecommerce.Models.Enums;
using Microsoft.AspNetCore.Identity;


namespace Ecommerce.Models.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public UserType UserType { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
