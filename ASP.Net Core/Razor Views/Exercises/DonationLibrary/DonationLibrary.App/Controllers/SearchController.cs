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
    public class SearchController : Controller
    {
        private readonly ISearchService searchService;

        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        public IActionResult Searched(string searchterm)
        {

            var searchViewModel = new SearchViewModel();

            searchViewModel.Authors = searchService.SearchedAuthors(searchterm);
            searchViewModel.Books = searchService.SearchedBooks(searchterm);

            ViewData["searchTerm"] = searchterm;

            return View(searchViewModel);
        }
    }
}