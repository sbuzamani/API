using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Domain.Entities
{
    public class Book
    {
        public Guid Id;
        public int rating;
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Review { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }
    }
}
