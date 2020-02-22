using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Web.Services.Interfaces;
using DonationLibrary.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DonationLibrary.Web.Controllers
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