using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DonationLibrary.Models
{
    public class Recipient
    {
        public Recipient()
        {
            this.DonatedBooks = new List<BookRecipient>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<BookRecipient> DonatedBooks { get; set; }

        [Required]
        public double DonatedMoney { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Url]
        public string PictureURL { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string DonationAccount { get; set; }
    }
}
