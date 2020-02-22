using DonationLibrary.Data;
using DonationLibrary.Models;
using DonationLibrary.Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.Services
{
    public class RecipientService : IRecipientService
    {
        private readonly BooksDbContext booksDbContext;

        public RecipientService(BooksDbContext booksDbContext)
        {
            this.booksDbContext = booksDbContext;
        }

        public IEnumerable<Book> GetAllDonatedBooksToThisRecipient(int id)
        {
            var books = this.booksDbContext.DonatedBooks.Include(b => b.Book).Where(r => r.RecipientId == id).Select(b => b.Book)
                .Include(b => b.Author).ToList();

            return books;
        }

        public IEnumerable<Recipient> GetAllRecipent()
        {
            var recipients = this.booksDbContext.Recipients.Include(r => r.DonatedBooks).ToList();

            return recipients;
        }

        public Recipient GetRecipientDetails(int id)
        {
            var recipient = this.booksDbContext.Recipients.FirstOrDefault(r => r.Id == id);

            return recipient;
        }

        public string GetRecipientName(int id)
        {
            var recipient = this.booksDbContext.DonatedBooks.Include(r => r.Recipient).FirstOrDefault(b => b.BookId == id);

            var name = recipient.Recipient.Name;

            return name;
        }
    }
}
