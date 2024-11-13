using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebScraperAPIPrototype.Data.Entity
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }

        public virtual ICollection<Product> Products { get; set; }  // Navigation Property
    }
}