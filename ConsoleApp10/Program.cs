using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {

        private static List<Book> books;

        static void Main(string[] args)
        {
            int a = Console.Read();
            InitializeBookList();
            FindByName("Издательство 1");
            books.RemoveAt(a);

            Console.ReadKey();
        }
        private static void FindByName(string name)
        {
            books.FindAll(book => book.Name == name).
                  ForEach(book => Console.WriteLine(book.ID));
        }
        private static void InitializeBookList()
        {
            books = new List<Book>();
            books.AddRange(new[]
                               {
                                   new Book(0, "Автор 1", "Книга 1", "Издательство 1", 150, DateTime.Today),
                                   new Book(1, "Автор 1", "Книга 2", "Издательство 2", 1150, DateTime.Today),
                                   new Book(2, "Автор 2", "Книга 1", "Издательство 2", 150, DateTime.Today),
                                   new Book(3, "Автор 3", "Книга 1", "Издательство 3", 150, DateTime.Today)
                               });
        }
        public int this[int j]
        {
            set
            {
                for(int i=0;i<books.Count;i++)
                {
                    Console.WriteLine(books);
                }
            }
        }
    }
    class Book
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationYear { get; set; }
        public int PageNumber { get; set; }

        public Book(int id,
            string author,
            string name,
            string publisher,
            int pageNumber,
            DateTime year)
        {
            this.ID = id;
            this.Author = author;
            this.Name = name;
            this.Publisher = publisher;
            this.PageNumber = pageNumber;
            this.PublicationYear = year;
        }
    }
}
    

