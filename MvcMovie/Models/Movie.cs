using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
