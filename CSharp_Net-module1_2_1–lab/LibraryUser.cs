using CSharp_Net_module1_2_1_lab.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    class LibraryUser : ILibraryUser
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int BookLimit { get; private set; }
        public string Phone { get; set; }

        //const int defaultSize = 100;
        int lastIndex = 0;

        IBook[] _bookList;

        public LibraryUser(int bookLimit) {
            _bookList = new IBook[bookLimit];
        }

        public LibraryUser(string firstName, string lastName, int bookLimit, string phone) : this(bookLimit) {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BookLimit = bookLimit;
            Phone = phone;
        }

        public IBook this[int index] {
            get {
                index--;
                if ((index > -1) && (index < _bookList.Length))
                {
                    return _bookList[index];
                } else
                    return null;
            }
            /*set {
                if ((index > 0) && (index < _bookList.Length) && (value != null))
                    _bookList[index] = value;
            }*/
        }

        public bool AddBook(IBook book) {
            if ((book != null) && (_bookList.Length > lastIndex))
            {
                if (_bookList.Count(arg => (arg != null) && (Guid.Equals(arg.ID, book.ID))) == 0)
                {
                    _bookList[lastIndex] = book;
                    lastIndex++;
                    return true;
                } else
                    return false;
            }
            return false;
        }

        public void RemoveBook(IBook book) {
            /*var index = FindBook(book);
            if (index > 0) {
                _bookList[index] = null;
                Array.Sort(_bookList);
            }*/
            if (book != null)
            {
                _bookList = _bookList.Where(arg => (arg != null) && (!Guid.Equals(arg.ID, book.ID))).ToArray();
                lastIndex = _bookList.Count(arg => arg != null);
            }
        }

        public int BooksCount() {
            return lastIndex;
        }

        public int FindBook(IBook book) {
            if (book != null)
            {
                return Array.FindIndex(_bookList, arg => (arg != null) && (Guid.Equals(arg.ID, book.ID)));
                /*for (int i=0; i < _bookList.Length;i++)
                {
                    if(_bookList[i].ID() == book.ID())
                    {
                        return i;
                    }
                }
                return -1;*/
            } else
                return -1;
        }
        public override string ToString() {
            return string.Format("User has {0} books", BooksCount());
        }
    }
}
