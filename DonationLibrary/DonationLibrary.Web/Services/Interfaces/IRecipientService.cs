using DonationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.Services.Interfaces
{
    public interface IRecipientService
    {

        IEnumerable<Recipient> GetAllRecipent();

        string GetRecipientName(int id);


        Recipient GetRecipientDetails(int id);

        IEnumerable<Book> GetAllDonatedBooksToThisRecipient(int id);

    }
}
