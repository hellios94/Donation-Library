using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Web.BindingModels
{
    public class DonateBookBindingModel
    {

        public string RecipientName { get; set; }

        public double Price { get; set; }


        public int BookId { get; set; } 


    }
}
