using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationLibrary.Web.Services.Interfaces;
using DonationLibrary.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DonationLibrary.Web.Controllers
{
    public class RecipientController : Controller
    {
        private readonly IRecipientService recipientService;

        public RecipientController(IRecipientService recipientService)
        {
            this.recipientService = recipientService;
        }

        public IActionResult Details(int id)
        {

            var recipientDetailsViewModel = new RecipientDetailsViewModel();

            recipientDetailsViewModel.Recipient = this.recipientService.GetRecipientDetails(id);

            recipientDetailsViewModel.DonatedBooks = this.recipientService.GetAllDonatedBooksToThisRecipient(id);

            return View(recipientDetailsViewModel);
        }
    }
}