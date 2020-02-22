using DonationLibrary.Data;
using DonationLibrary.Models;
using DonationLibrary.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.Services
{
    public class SearchService : ISearchService
    {

        private BooksDbContext dbContext;

        public SearchService(BooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Author> SearchedAuthors(string searchedTerm)
        {
            var authors = this.dbContext.Authors.Where(a => a.Name.Contains(searchedTerm)).ToList();
            return authors;
        }

        public IEnumerable<Book> SearchedBooks(string searchedTerm)
        {
            var books = this.dbContext.Books.Where(a => a.Title.Contains(searchedTerm)).ToList();
            return books;
        }

    }
}
