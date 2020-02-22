using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DonationLibrary.Models
{
    public class BookRecipient
    {
        [Key]
        public int BookId { get; set; }

        public Book Book { get; set; }

        [Key]
        public int RecipientId { get; set; }

        public Recipient Recipient { get; set; }
    }
}
