using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.ViewModels
{
    public class BookDetailsViewModel
    {

        public Book Book { get; set; }

        public string RecipientName { get; set; }
    }
}
