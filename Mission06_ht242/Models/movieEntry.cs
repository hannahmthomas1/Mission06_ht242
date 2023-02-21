using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ht242.Models
{
    public class movieEntry
    {
        [Key]
        [Required]
        public int EntryID { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        //Build foreign key relationship
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}