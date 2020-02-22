using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.ViewModels
{
    public class RecipientDetailsViewModel
    {

        public Recipient Recipient { get; set; }

        public IEnumerable<Book> DonatedBooks { get; set; }

    }
}
