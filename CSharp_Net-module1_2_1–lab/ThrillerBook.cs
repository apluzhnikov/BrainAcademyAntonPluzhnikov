using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Net_module1_2_1_lab.Structures;
using CSharp_Net_module1_2_1_lab.Interfaces;

namespace CSharp_Net_module1_2_1_lab
{
    class ThrillerBook : IBook
    {
        Guid _id;
        BookInfo _bookInfo;

        public Guid ID {
            get {
                return _id;
            }
        }

        public ThrillerBook() {
            _id = Guid.NewGuid();
        }

        public string GetInfo() {
            return string.Format("Here is full info about this book:\nID: {0}\nTitle: {1}\nAuthor: {2}\nDescription: {3}\n",
                                 _id, _bookInfo.Title, _bookInfo.Author, _bookInfo.Description);
        }

        public void SetBookInfo(BookInfo bookInfo) {
            _bookInfo = bookInfo;
        }
    }
}
