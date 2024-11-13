using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebScraperAPIPrototype.Data.Entity
{
    public class IngredientsProduct
    {
        public long IngredientsProductId { get; set; }
        public int IngredientId { get; set; }
        public long ProductId { get; set; }

        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }

        [ForeignKey(nameof(IngredientId))]
        public virtual Ingredients Ingredient { get; set; }  // Navigation Property
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }  // Navigation Property
    }
}