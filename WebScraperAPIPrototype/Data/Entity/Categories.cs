using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebScraperAPIPrototype.Data.Entity
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }

        public virtual Product Product { get; set; }  // Navigation Property to Product
    }
}