using FarmerApp.Interfaces;
using FarmerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerApp
{
    public abstract class MoveStrategy
    {
        public List<FarmersStuff> LeftSideList = new List<FarmersStuff>() { FarmersStuff.Cabbage, FarmersStuff.Sheep, FarmersStuff.Wolf };
        public List<FarmersStuff> RightSideList = new List<FarmersStuff>();
        public bool isOnLeftSide = true;

        abstract public bool MoveStaff(FarmersStuff farmersStuff);

        public bool AreAllAlive()
        {
            var allAlive = true;
            if (LeftSideList.Count() < 3)
            {
                allAlive = LeftSideList.Where(arg =>
                                                    (arg == FarmersStuff.Sheep && arg == FarmersStuff.Wolf)
                                                    ||
                                                    (arg == FarmersStuff.Sheep && arg == FarmersStuff.Cabbage)
                                              ).Count() != 2;
            }

            if (allAlive)
            {
                if (RightSideList.Count() < 3)
                {
                    allAlive = RightSideList.Where(arg =>
                                                    (arg == FarmersStuff.Sheep && arg == FarmersStuff.Wolf)
                                                    ||
                                                    (arg == FarmersStuff.Sheep && arg == FarmersStuff.Cabbage)
                                              ).Count() != 2;
                }
            }            

            return allAlive;
        }
    }
}
