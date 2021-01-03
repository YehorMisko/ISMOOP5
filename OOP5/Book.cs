using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    public class Book
    {
        public string Name { set; protected get; }        
        public string Author { set; protected get; }
        public string Publisher { set; protected get; }
        public Book()
        {
            Name = "None";
            Author = "None";
            Publisher = "None";
        }
        public Book(string name, string author, string publisher)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetPublisher()
        {
            return Publisher;
        }
    }
}
