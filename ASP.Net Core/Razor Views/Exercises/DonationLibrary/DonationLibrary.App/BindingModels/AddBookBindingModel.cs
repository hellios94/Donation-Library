﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.App.BindingModels
{
    public class AddBookBindingModel
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public string AuthorName { get; set; }

        public string BookCoverImageUrl { get; set; }

    }
}
