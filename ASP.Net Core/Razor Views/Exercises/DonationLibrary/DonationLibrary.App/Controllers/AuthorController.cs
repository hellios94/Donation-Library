using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.App.Services;
using DonationLibrary.App.Services.Interfaces;
using DonationLibrary.App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DonationLibrary.App.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        public IActionResult Details(int id)
        {

            var authorDetailsViewModel = new AuthorDetailsViewModel();

            authorDetailsViewModel.AuthorName = authorService.GetAuthorName(id);
            authorDetailsViewModel.Books = authorService.GetAllBooksFromAuthor(id);

            return View(authorDetailsViewModel);
        }
    }
}