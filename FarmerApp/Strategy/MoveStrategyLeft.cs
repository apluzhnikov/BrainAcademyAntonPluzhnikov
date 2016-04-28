using FarmerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerApp.Strategy
{
    class MoveStrategyLeft : MoveStrategy
    {
        public override bool MoveStaff(FarmersStuff farmersStuff)
        {
            if (!isOnLeftSide)
            {
                if (RightSideList.Where(arg => arg == farmersStuff).Count() > 0)
                {
                    RightSideList.Remove(farmersStuff);
                    LeftSideList.Add(farmersStuff);
                    return true;
                }
                return false;
            }
            else
                throw new Exception("Farmer is on other side");
            
        }
    }
}
