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
    public class AuthorService : IAuthorService
    {

        private BooksDbContext dbContext;

        public AuthorService(BooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Book> GetAllBooksFromAuthor(int id)
        {
            var books = this.dbContext.Authors.Include(a => a.Books).FirstOrDefault(a => a.Id == id).Books.ToList();

            return books;
        }

        public string GetAuthorName(int id)
        {
            var authorName = this.dbContext.Authors.FirstOrDefault(a => a.Id == id).Name;

            return authorName;
        }

    }
}
