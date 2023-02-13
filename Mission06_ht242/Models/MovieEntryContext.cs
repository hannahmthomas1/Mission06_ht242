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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<movieEntry>().HasData(
                new movieEntry
                {
                    EntryID = 1,
                    Category = "Drama/Comedy",
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
                    Category = "Sci-fi/Drama",
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
                    Category = "Drama/Sport",
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
                    Category = "Drama",
                    Title = "True Spirit",
                    Year = 2023,
                    Director = "Sarah Spillane",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
                );
        }
    }
}
