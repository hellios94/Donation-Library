using DonationLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DonationLibrary.Data
{
    public class BooksDbContext : DbContext
    {

        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Borrower> Borrowers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);

            base.OnModelCreating(builder);
        }
    }
}
