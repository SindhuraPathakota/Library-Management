using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject13
{
    static class Library
    {
        public static List<Media> medias = new List<Media>()
        {
          new Book("C++",150),
          new Book("Java",150),
          new Book("C#",150),
          new Movie("Joker",120),
          new Movie("Terminator",128),
          new Magazine("Forbes",30,500),
          new Magazine("People",30,500),
        };
        
        public static List<LibraryMember> libraryMembers = new List<LibraryMember>() { 
            new LibraryMember("Jay"),
            new LibraryMember("Sindhu"),
            new LibraryMember("Braden"),
            new LibraryMember("Jared"),
            new LibraryMember("Ben")

        };

    }
}
