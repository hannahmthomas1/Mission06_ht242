using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ht242.Models
{
    public class MovieEntryContext : DbContext
    {
        //Constructor
        public MovieEntryContext (DbContextOptions<MovieEntryContext> options) : base(options)
        {

        }

        public DbSet<movieEntry> entries { get; set; }
        public DbSet<Category> categories { get; set; }


        //Seed movie data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Drama" },
                    new Category { CategoryId = 2, CategoryName = "Comedy" },
                    new Category { CategoryId = 3, CategoryName = "Sport" },
                    new Category { CategoryId = 4, CategoryName = "Action/Adventure" },
                    new Category { CategoryId = 5, CategoryName = "Family" },
                    new Category { CategoryId = 6, CategoryName = "Romance" },
                    new Category { CategoryId = 7, CategoryName = "Documentary" },
                    new Category { CategoryId = 8, CategoryName = "Horror/Suspense" },
                    new Category { CategoryId = 9, CategoryName = "Sci-fi" }
                );

            mb.Entity<movieEntry>().HasData(
                new movieEntry
                {
                    EntryID = 1,
                    CategoryId = 1,
                    Title = "A Man Called Otto", 
                    Year = 2023,
                    Director = "Marc Forster", 
                    Rating = "PG-13", 
                    Edited = false,
                    LentTo = null, 
                    Notes = null
                },
                new movieEntry
                {
                    EntryID = 2,
                    CategoryId = 9,
                    Title = "Finch",
                    Year = 2021,
                    Director = "Miguel Sapochnik",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new movieEntry
                {
                    EntryID = 3,
                    CategoryId = 1,
                    Title = "The Swimmers",
                    Year = 2022,
                    Director = "Sally El Hosaini",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new movieEntry
                {
                    EntryID = 4,
                    CategoryId = 3,
                    Title = "True Spirit",
                    Year = 2023,
                    Director = "Sarah Spillane",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new movieEntry
                {
                    EntryID = 5,
                    CategoryId = 2,
                    Title = "Hunt for the Wilderpeople",
                    Year = 2016,
                    Director = "Taika Waititi",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
                );
        }
    }
}
