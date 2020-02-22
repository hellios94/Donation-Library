using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DonationLibrary.Models
{
    public class Author
    {

        public Author()
        {
            this.Books = new List<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; }

    }
}
