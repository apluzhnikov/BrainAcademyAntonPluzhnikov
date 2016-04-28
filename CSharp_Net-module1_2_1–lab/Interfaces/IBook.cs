using CSharp_Net_module1_2_1_lab.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab.Interfaces
{
    interface IBook : IEntity
    {
        void SetBookInfo(BookInfo bookInfo);
        //Guid ID();
        string GetInfo();
    }

    interface IEntity
    {
        Guid ID { get; }
    }
}