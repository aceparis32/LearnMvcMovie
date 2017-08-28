using System;
//use library below to edit DateTime format
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        //Data that will be used in Movie page
        //ID is required for database as a primary key
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genre Film")]
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
