using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebScraperAPIPrototype.Data.Entity
{
    public class Product
    {
        public long ProductId { get; set; }
        public int ServingSize { get; set; }

        [Required]
        public string? ProductName { get; set; }

        public long NutritionId { get; set; }
        [ForeignKey(nameof(NutritionId))]
        public virtual Nutrition? Nutrition { get; set; }  // 1:1 with Nutrition

        public int BrandId { get; set; }
        [ForeignKey(nameof(BrandId))]
        public virtual Brand? Brand { get; set; }  // 1:1 with Brand

        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual Categories? Category { get; set; }  // 1:1 with Categories

        public int CountryOfOrigin { get; set; }
        [ForeignKey(nameof(CountryOfOrigin))]
        public virtual Countries? Country { get; set; }  // 1:1 with Countries

        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }

        public virtual ICollection<URL> URLs { get; set; }  // 1:Many with URLs

        public virtual ICollection<IngredientsProduct> IngredientsProducts { get; set; }  // Many:Many with Ingredients via junction table
    }
}