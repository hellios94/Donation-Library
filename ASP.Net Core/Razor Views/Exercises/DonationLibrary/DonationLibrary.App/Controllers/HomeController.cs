using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DonationLibrary.App.Models;
using DonationLibrary.App.ViewModels;
using DonationLibrary.App.Services;
using DonationLibrary.Data;
using DonationLibrary.App.Services.Interfaces;

namespace DonationLibrary.App.Controllers
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

            var indexViewModel = new IndexViewModel
            {
                Books = books
            };

            return View(indexViewModel);
        }



    }
}
