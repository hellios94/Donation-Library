using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodLover.Data
{
    public class FoodLoverDbContext : DbContext
    {
        public FoodLoverDbContext(DbContextOptions<FoodLoverDbContext> options)
            :base(options)
        {

        }
    }
}
