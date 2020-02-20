using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.App.Services.Interfaces
{
    public interface ISearchService
    {

        IEnumerable<Author> SearchedAuthors(string searchedTerm);

        IEnumerable<Book> SearchedBooks(string searchedTerm);
    }
}
