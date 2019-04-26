using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodLover.Model
{
    public class CategoryByMeal
    {
        public CategoryByMeal()
        {
            this.Meals = new List<Meal>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Meal> Meals { get; set; }


    }
}
