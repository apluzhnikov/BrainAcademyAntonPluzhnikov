using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_03_2016.BattleField.Errors
{
    interface IFieldDrawerError
    {
        /// <summary>
        /// Get current error if appears during the draw process
        /// </summary>
        /// <returns>Returns information about the error during the draw process</returns>
        string GetError();
    }
}
