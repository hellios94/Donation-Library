using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodLover.Model
{
    public class News
    {

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(120)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Url]
        public string Image { get; set; }

    }
}
