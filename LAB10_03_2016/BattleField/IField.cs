using LAB10_03_2016.BattleField.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_03_2016.BattleField
{
    interface IField: IFieldError
    {
        int Width { get; set; }
        int Hight { get; set; }
        string Word { get; set; }
        char BorderSybol { get; set; }

        /// <summary>
        /// Displays the image in string format
        /// </summary>
        string Image { get; set; }


        /// <summary>
        /// Sets color for drawing Border of IField
        /// </summary>
        /// <param name="color">ConsoleColor color of current IField</param>
        ConsoleColor BorderColor { get; set; }

        




    }
}

