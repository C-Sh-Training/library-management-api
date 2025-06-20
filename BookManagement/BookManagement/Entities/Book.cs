﻿namespace BookManagement.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Description { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;

    }
}
