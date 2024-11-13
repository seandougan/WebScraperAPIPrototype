using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebScraperAPIPrototype.Data.Entity
{
    public class Ingredients
    {
        [Key]
        public long IngredientsId { get; set; }
        public string? IngredientName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }

        public virtual ICollection<IngredientsProduct> IngredientsProducts { get; set; }  // Navigation Property for Join Table
    }
}