using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    public delegate double MyFunc(double x);
    public delegate bool BookFunc(Book a1, Book b2);
    class Program
    {
        static void Main(string[] args)
        {
            Functions.Tabulate(-100000, 1000, 0.015, 
                (q) => 4 * Math.Pow(q, 3) - 7 * Math.Pow(q, 2) + 1);
            MyFunc func;
            func = Functions.Func2;
            Functions.Tabulate(-10000, 10000, 0.01, func);
            func = Functions.Func3;
            Functions.Tabulate(-250, 400, 0.001,func);
            Functions.Tabulate(-100000, 10000, 0.1,
              (x) => 1 / (Math.Sqrt(0.5 * Math.Pow(x, 2) + 1)));
            Functions.Tabulate(-20000, 20000, 0.01,
             (x) => (Math.Abs(Math.Pow(x,2)-5)) /(x-5));
            Book a = new Book();
            a.Author = "Daniil";
            a.Name = "Ozern";
            a.Publisher = "Rockstar";
            Book b = new Book();
            b.Author = "Atvey";
            b.Name = "TF2";
            b.Publisher = "Basni";
            ListOfBooks test = new ListOfBooks(a, b);
            BookFunc SortType = ListOfBooks.AuthorSort;
            test.Sort(SortType);
            //test.BookList.Sort(delegate(Book a1, Book b2) { return a1.GetAuthor().CompareTo(b2.GetAuthor());});
            for(int i = 0; i < test.BookList.Count; i++)
            {
                Console.Write($"{test.BookList[i].GetName()} ");
                Console.Write($"{test.BookList[i].GetAuthor()} ");
                Console.WriteLine($"{test.BookList[i].GetPublisher()} ");           
            }
            Console.WriteLine();
            SortType = ListOfBooks.NameSort;
            Book c = new Book("JeffChenko", "Dymi", "Ranok");
            test.Add(c);
            test.Sort(SortType);
            for (int i = 0; i < test.BookList.Count; i++)
            {
                Console.Write($"{test.BookList[i].GetName()} ");
                Console.Write($"{test.BookList[i].GetAuthor()} ");
                Console.WriteLine($"{test.BookList[i].GetPublisher()} ");
            }
            SortType = ListOfBooks.Publishersort;
            test.Sort(SortType);
            Console.WriteLine();
            for (int i = 0; i < test.BookList.Count; i++)
            {
                Console.Write($"{test.BookList[i].GetName()} ");
                Console.Write($"{test.BookList[i].GetAuthor()} ");
                Console.WriteLine($"{test.BookList[i].GetPublisher()} ");           
            }
        }
    }
}
