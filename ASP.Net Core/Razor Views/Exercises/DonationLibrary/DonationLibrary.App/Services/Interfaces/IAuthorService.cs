using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.App.Services.Interfaces
{
    public interface IAuthorService
    {

        IEnumerable<Book> GetAllBooksFromAuthor(int id);

        string GetAuthorName(int id);

    }
}
