using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_03_2016.BattleField.Errors
{
    interface IFieldError
    {
        /// <summary>
        /// Get error if IField data is wrong
        /// </summary>
        /// <returns>Returns information about the error in IField data</returns>
        string GetError();
    }
}
