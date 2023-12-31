﻿namespace BookProject.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        // navigation property
        public ICollection<Book> Books { get; } = new List<Book>();
    }
}
