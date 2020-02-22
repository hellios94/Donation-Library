using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.ViewModels
{
    public class IndexViewModel
    {

        public List<Book> Books { get; set; }

        public List<BookRecipient> DonateBooks { get; set; }
    }
}
