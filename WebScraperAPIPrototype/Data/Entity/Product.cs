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

        public long NutritionId { get; set; }  // Foreign Key
        [ForeignKey(nameof(NutritionId))]
        public virtual Nutrition? Nutrition { get; set; }  // Navigation Property

        public int BrandId { get; set; }  // Foreign Key to Brand
        public int CategoryId { get; set; }  // Foreign Key to Categories
        public int CountryOfOrigin { get; set; }  // Foreign Key to Countries

        [ForeignKey(nameof(BrandId))]
        public virtual Brand? Brand { get; set; }  // Navigation Property
        [ForeignKey(nameof(CategoryId))]
        public virtual Categories? Category { get; set; }  // Navigation Property
        [ForeignKey(nameof(CountryOfOrigin))]
        public virtual Countries? Country { get; set; }  // Navigation Property

        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }

        public virtual ICollection<URL>? UrLs { get; set; }  // Navigation Property for URLs
        public virtual ICollection<IngredientsProduct> IngredientsProducts { get; set; }  // Navigation Property for Join Table
    }
}