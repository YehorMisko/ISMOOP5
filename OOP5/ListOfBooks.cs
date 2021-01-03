using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class ListOfBooks
    {
        public List<Book> BookList = new List<Book>();
        public ListOfBooks(Book x)
        {
            BookList.Add(x);
        }
        public ListOfBooks(Book x, Book y)
        {
            BookList.Add(x);
            BookList.Add(y);
        }
        public static bool AuthorSort(Book a1, Book b2)
        {
            if (a1.GetAuthor().CompareTo(b2.GetAuthor()) == 1) return true;
            else return false;
        }
        public static bool NameSort(Book a1, Book b2)
        {
            if (a1.GetName().CompareTo(b2.GetName()) == 1) return true;
            else return false;
        }
        public static bool Publishersort(Book a1, Book b2)
        {
            if (a1.GetPublisher().CompareTo(b2.GetPublisher()) == 1) return true;
            else return false;
        }
        public void Add(Book a1)
        {
            BookList.Add(a1);
        }
            

        public void Sort(BookFunc method)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                for(int j = 0; j < BookList.Count-1; j++)
                if (method(BookList[j], BookList[j + 1]) == true)
                {
                    Book tmp = BookList[j + 1];
                    BookList[j + 1] = BookList[j];
                    BookList[j] = tmp;
                }
            }
        }
    }
}
