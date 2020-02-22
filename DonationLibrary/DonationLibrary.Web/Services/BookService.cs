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
    public class BookService : IBookService
    {

        private BooksDbContext dbContext;

        public BookService(BooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddBook(Book book)
        {
            this.dbContext.Books.Add(book);
            this.dbContext.SaveChanges();
        }

        public Book GetBookDetails(int id)
        {
            var book = this.dbContext.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);

            return book;
        }

        public Author FindAuthor(string authorName)
        {
            Author author = this.dbContext.Authors.FirstOrDefault(a => a.Name == authorName);
            if (author == null)
            {
                Author newAuthor = new Author();
                newAuthor.Name = authorName;
                AddAuthor(newAuthor);

                return newAuthor;
            }
            else
            {
                return author;
            }
        }

        public void AddAuthor(Author author)
        {
            this.dbContext.Authors.Add(author);
            this.dbContext.SaveChanges();
        }


        public IEnumerable<Book> GetAllBooks()
        {
            var books = this.dbContext.Books.Include(b => b.Author).Include(b => b.Recipient).ToList();

            return books;
        }

        public void DonateBook(int id, string recipientName, double price)
        {
            var book = FindBook(id);
            var recipient = FindRecipient(recipientName);

            book.DonatedPrice += price;
            recipient.DonatedMoney += book.DonatedPrice;
            book.DonationStatus = "Donated to " + recipient.Name;

            var donatedBook = new BookRecipient()
            {
                BookId = book.Id,
                Book = book,
                RecipientId = recipient.Id,
                Recipient = recipient
            };

            this.dbContext.DonatedBooks.Add(donatedBook);
            this.dbContext.SaveChanges();
        }

        public Recipient FindRecipient(string recipientName)
        {
            var recipient = this.dbContext.Recipients.FirstOrDefault(r => r.Name == recipientName);

            return recipient;
        }

        public Book FindBook(int id)
        {
            var book = this.dbContext.Books.Include(b => b.Recipient.Recipient).FirstOrDefault(b => b.Id == id);

            return book;
        }

        public IEnumerable<BookRecipient> GetAllDonatedBooks()
        {
            var donatedBooks = this.dbContext.DonatedBooks.Include(db => db.Recipient).Include(db => db.Book).ToList();

            return donatedBooks;
        }
    }
}
