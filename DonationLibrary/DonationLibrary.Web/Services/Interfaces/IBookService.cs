using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.Services.Interfaces
{
    public interface IBookService
    {
        void AddBook(Book book);

        Author FindAuthor(string authorName);

        Book GetBookDetails(int id);

        void AddAuthor(Author author);

        IEnumerable<Book> GetAllBooks();

        void DonateBook(int id, string recipientName, double price);

        Recipient FindRecipient(string recipientName);

        Book FindBook(int id);

        IEnumerable<BookRecipient> GetAllDonatedBooks();

    }
}
