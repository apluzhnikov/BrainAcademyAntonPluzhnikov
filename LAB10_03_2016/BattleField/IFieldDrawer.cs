using LAB10_03_2016.BattleField.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_03_2016.BattleField
{
    interface IFieldDrawer: IFieldDrawerError
    {
        /// <summary>
        /// Sets the IField
        /// </summary>
        /// <param name="field">IField</param>
        void SetField(IField field);

        /// <summary>
        /// Draws current IField
        /// </summary>
        /// <param name="field"></param>
        string DrawField();

    }

    
}
