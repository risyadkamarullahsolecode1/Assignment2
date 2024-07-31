using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public Book(int id, string title, string author, int publicationYear, string isbn) 
        { 
            Id = id;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            ISBN = isbn;
        }
    }
}
