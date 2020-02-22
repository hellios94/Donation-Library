using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DonationLibrary.Models
{
    public class Book
    {

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [Url]
        public string BookCoverImageUrl { get; set; }

        [Required]
        public string DonationStatus { get; set; }

        [Required]
        public double DonatedPrice { get; set; }


        public int RecipientId { get; set; }

        public BookRecipient Recipient { get; set; }


    }
}
