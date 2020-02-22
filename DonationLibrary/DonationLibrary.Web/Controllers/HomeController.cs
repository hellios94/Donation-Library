using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DonationLibrary.Web.Models;
using DonationLibrary.Web.Services.Interfaces;
using DonationLibrary.Web.ViewModels;

namespace DonationLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService bookService;

        public HomeController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = bookService.GetAllBooks().ToList();
            var donatedBooks = bookService.GetAllDonatedBooks().ToList();

            var indexViewModel = new IndexViewModel
            {
                Books = books,
                DonateBooks = donatedBooks
            };

            return View(indexViewModel);
        }
    }
}
