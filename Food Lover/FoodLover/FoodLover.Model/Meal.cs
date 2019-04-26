using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodLover.Model
{
    public class Meal
    {

        public Meal()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan TimeForPrepare { get; set; }

        [Required]
        public ICollection<Product> Products { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CategoryByMealId { get; set; }

        [Required]
        public CategoryByMeal CategoryByMeals { get; set; }

        [Required]
        public int CategoryByProductId { get; set; }

        [Required]
        public CategoryByProducts CategoryByProducts { get; set; }

        [Required]
        public string Prepare { get; set; }

    }
}
