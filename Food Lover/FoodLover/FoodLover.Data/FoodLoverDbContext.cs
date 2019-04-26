using FoodLover.Model;
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

        public DbSet<CategoryByProducts> Categories { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<CategoryByMeal> CategoryByMeals { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<CategoryByMeal>()
                .HasMany(cm => cm.Meals)
                .WithOne(m => m.CategoryByMeals)
                .HasForeignKey(m => m.CategoryByMealId);

            builder.Entity<CategoryByProducts>()
                .HasMany(cp => cp.Meals)
                .WithOne(m => m.CategoryByProducts)
                .HasForeignKey(m => m.CategoryByProductId);

            base.OnModelCreating(builder);

        }
    }
}
