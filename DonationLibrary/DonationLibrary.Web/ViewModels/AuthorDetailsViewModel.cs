using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.ViewModels
{
    public class AuthorDetailsViewModel
    {

        public string AuthorName { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}
