using DonationLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DonationLibrary.Data
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Recipient> Recipients { get; set; }

        public DbSet<BookRecipient> DonatedBooks { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);

            builder.Entity<Recipient>()
                .HasMany(r => r.DonatedBooks)
                .WithOne(b => b.Recipient)
                .HasForeignKey(b => b.RecipientId);

            builder.Entity<BookRecipient>()
                .HasKey(b => new { b.BookId, b.RecipientId });

            base.OnModelCreating(builder);
        }
    }
}
