using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebScraperAPIPrototype.Data.Entity
{
    public class Nutrition
    {
        [Key]
        public long NutritionId { get; set; }

        public long VitaminsMassId { get; set; }  // Foreign Key to VitaminsMass
        public int Calories { get; set; }
        public int TotalFats { get; set; }
        public int SaturatedFats { get; set; }
        public int TransFats { get; set; }
        public int Cholesterol { get; set; }
        public int Sodium { get; set; }
        public int TotalCarbohydrates { get; set; }
        public int DietaryFibers { get; set; }
        public int Sugars { get; set; }
        public int Proteins { get; set; }
        public int AddedSugars { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  // Nullable for consistency
        public string? DeletedReason { get; set; }

        [ForeignKey(nameof(VitaminsMassId))]
        public virtual VitaminsMass VitaminsMass { get; set; }  // Navigation Property

        public virtual ICollection<Product> Products { get; set; }  // Navigation Property for reverse mapping
    }
}