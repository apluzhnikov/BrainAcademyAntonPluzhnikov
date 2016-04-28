using CSharp_Net_module1_2_1_lab.Interfaces;
using CSharp_Net_module1_2_1_lab.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    class ComedyBook : IBook{

        Guid _id;
        BookInfo _bookInfo;

        public Guid ID {
            get {
                return _id;
            }
        }

        public ComedyBook() {
            _id = Guid.NewGuid();
        }

        public string GetInfo() {
            return string.Format("Here is limited info about this book:\nTitle: {0}\nDescription: {1}\n",
                                 _bookInfo.Title, _bookInfo.Description);
        }

        public void SetBookInfo(BookInfo bookInfo) {
            _bookInfo = bookInfo;
        }

    }
}
