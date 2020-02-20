using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.App.BindingModels;
using DonationLibrary.App.Services;
using DonationLibrary.App.Services.Interfaces;
using DonationLibrary.App.ViewModels;
using DonationLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace DonationLibrary.App.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddBookBindingModel bindingModel)
        {
            Book book = new Book();
            book.Title = bindingModel.Title;
            book.Author = bookService.FindAuthor(bindingModel.AuthorName);
            book.Description = bindingModel.Description;
            book.BookCoverImageUrl = bindingModel.BookCoverImageUrl;

            bookService.AddBook(book);

            return RedirectToAction("Index", "Home");
        }


        public IActionResult Details(int id)
        {

            var bookDetailsViewModel = new BookDetailsViewModel();
            bookDetailsViewModel.Book = bookService.GetBookDetails(id);

            return View(bookDetailsViewModel);
        }
    }
}