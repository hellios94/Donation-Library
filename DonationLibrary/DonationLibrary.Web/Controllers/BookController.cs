using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Models;
using DonationLibrary.Web.BindingModels;
using DonationLibrary.Web.Services.Interfaces;
using DonationLibrary.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DonationLibrary.Web.Controllers
{
    public class BookController : Controller
    {

        private readonly IBookService bookService;
        private readonly IRecipientService recipientService;

        public BookController(IBookService bookService, IRecipientService recipientService)
        {
            this.bookService = bookService;
            this.recipientService = recipientService;
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
            book.DonationStatus = bindingModel.DonationStatus;

            bookService.AddBook(book);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {

            var bookDetailsViewModel = new BookDetailsViewModel();
            bookDetailsViewModel.Book = bookService.GetBookDetails(id);
            if(bookDetailsViewModel.Book.DonationStatus != "Not for Donation")
            {
                bookDetailsViewModel.RecipientName = recipientService.GetRecipientName(id);
            }

            return View(bookDetailsViewModel);
        }

        [HttpGet]
        public IActionResult Donate(int id)
        {

            var book = bookService.GetBookDetails(id);

            DonateBookBindingModel donateBookBinding = new DonateBookBindingModel();

            donateBookBinding.BookId = id;

            ViewData["Name"] = book.Title;
            ViewData["BookCover"] = book.BookCoverImageUrl;
            ViewData["Author"] = book.Author.Name;

            return View(donateBookBinding);
        }

        [HttpPost]
        public IActionResult Donate(DonateBookBindingModel donateBookBinding, int id)
        {

            bookService.DonateBook(id, donateBookBinding.RecipientName, donateBookBinding.Price);

            return RedirectToAction("Index", "Home");
        }

    }
}