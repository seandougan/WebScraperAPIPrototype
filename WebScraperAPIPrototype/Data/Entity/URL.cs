using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebScraperAPIPrototype.Data.Entity
{
    public class URL
    {
        public long UrlId { get; set; }
        public long ProductId { get; set; }
        
        [Required]
        public string? Url { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }  // Many:1 with Product

        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }
    }
}