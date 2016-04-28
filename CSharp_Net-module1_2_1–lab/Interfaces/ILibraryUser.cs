using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab.Interfaces
{
    interface ILibraryUser
    {
        IBook this[int index] { get; }
        bool AddBook(IBook book);
        void RemoveBook(IBook book);        
        int BooksCount();        
    }
}
