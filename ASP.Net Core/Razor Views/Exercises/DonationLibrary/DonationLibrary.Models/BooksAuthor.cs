﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DonationLibrary.Models
{
    public class BooksAuthor
    {

        public int BookId { get; set; }

        public Book Book { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
