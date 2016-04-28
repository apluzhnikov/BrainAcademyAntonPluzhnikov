using CSharp_Net_module1_2_1_lab.Interfaces;
using CSharp_Net_module1_2_1_lab.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    class Program
    {
        static void Main(string[] args) {

            IBook thrillerBook = new ThrillerBook();
            thrillerBook.SetBookInfo(new BookInfo { Title = "Thriller Book", Author = "Anton", Description = "Lorem ipsum blabla" });
            IBook comedyBook1 = new ComedyBook();
            comedyBook1.SetBookInfo(new BookInfo { Title = "Comedy Book1", Author = "Anton2", Description = "kjdfhjl dLorem ipsum blabla" });
            IBook comedyBook2 = new ComedyBook();
            comedyBook2.SetBookInfo(new BookInfo { Title = "Comedy Book2", Author = "Anton2", Description = "kjdfhjl dLorem ipsum blabla" });
            IBook comedyBook3 = new ComedyBook();
            comedyBook3.SetBookInfo(new BookInfo { Title = "Comedy Book3", Author = "Anton2", Description = "kjdfhjl dLorem ipsum blabla" });
            IBook comedyBook4 = new ComedyBook();
            comedyBook4.SetBookInfo(new BookInfo { Title = "Comedy Book4", Author = "Anton2", Description = "kjdfhjl dLorem ipsum blabla" });

            ILibraryUser libraryUser = new LibraryUser("Anton", "Pluzhnikov", 20, "0937095091");

            libraryUser.AddBook(thrillerBook);
            libraryUser.AddBook(comedyBook1);
            libraryUser.AddBook(comedyBook2);
            libraryUser.AddBook(comedyBook3);
            libraryUser.AddBook(comedyBook4);

            Console.WriteLine(libraryUser);
            Console.ReadLine();

            libraryUser.RemoveBook(comedyBook2);
            Console.WriteLine(libraryUser);
            //Console.ReadLine();

            Console.WriteLine("Please enter index of book to see its info");
            Console.WriteLine(libraryUser[int.Parse(Console.ReadLine())].GetInfo());
            Console.ReadLine();
        }
    }
}

