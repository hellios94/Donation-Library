using DonationLibrary.App.Services.Interfaces;
using DonationLibrary.Data;
using DonationLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.App.Services
{
    public class BookService : IBookService
    {

        private BooksDbContext dbContext;

        public BookService(BooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddAuthor(Author author)
        {
            this.dbContext.Authors.Add(author);
            this.dbContext.SaveChanges();
        }

        public void AddBook(Book book)
        {
            this.dbContext.Books.Add(book);
            this.dbContext.SaveChanges();
        }

        public Author FindAuthor(string authorName)
        {
            Author author = this.dbContext.Authors.FirstOrDefault(a => a.Name == authorName);
            if(author == null)
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

        public IEnumerable<Book> GetAllBooks()
        {
            var books = this.dbContext.Books.Include(b => b.Author).ToList();

            return books;
        }

        public Book GetBookDetails(int id)
        {
            var book = this.dbContext.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);

            return book;
        }
    }
}
