using DonationLibrary.App.BindingModels;
using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.App.Services.Interfaces
{
    public interface IBookService
    {

        IEnumerable<Book> GetAllBooks();

        void AddBook(Book book);

        void AddAuthor(Author author);

        Author FindAuthor(string authorName);

        Book GetBookDetails(int id);
    }
}
