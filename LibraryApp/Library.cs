using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    static class Library
    {
        public static List<Media> media = new List<Media>()
        {
            new Book("A Time To Kill", "Book", 22),
            new Book("Pale Fire", "Book", 33),
            new Book("Band Of Brothers", "Book", 44),
            new Book("Mortal Engines", "Book", 55),
            new Book("Things Fall Apart", "Book", 66),

            new Movie("Avengers", "Movie", 2),
            new Movie("Black Panther", "Movie", 3),
            new Movie("Mission Impossible", "Movie", 4),
            new Movie("3 Idiots", "Movie", 5),
            new Movie("Bodyguard", "Movie", 6),

            new Magazine("People", "Magazine", 21, 4),
            new Magazine("Cosmopolitan", "Magazine", 11, 6),
            new Magazine("Time", "Magazine", 51, 8),
            new Magazine("National Geographic", "Magazine", 33, 42),
            new Magazine("Vogue", "Magazine", 22, 11)
        };

        public static List<LibraryMember> member { get; set; }
            = new List<LibraryMember>()
        {
             new LibraryMember("Harold"),
             new LibraryMember("Sal"),
             new LibraryMember("Leonna"),
             new LibraryMember("Lilly"),
             new LibraryMember("Magnus")
        };
    }
}
