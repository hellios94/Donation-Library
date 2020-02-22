using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Web.Services.Interfaces;
using DonationLibrary.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DonationLibrary.Web.Controllers
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