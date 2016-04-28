using FarmerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerApp
{
    class GamePlay
    {
        MoveStrategy _moveStrategy;

        public GamePlay()
        {
            
        }

        public void SetStrategy(MoveStrategy moveStrategy)
        {
            _moveStrategy = moveStrategy;
        }

        public bool DoMove(FarmersStuff farmersStuff)
        {
            if (_moveStrategy != null)
            {
                if (farmersStuff == FarmersStuff.Farmer)
                {
                    _moveStrategy.isOnLeftSide = !_moveStrategy.isOnLeftSide;
                    return true;
                }
                    
                if (_moveStrategy.MoveStaff(farmersStuff))
                    return _moveStrategy.AreAllAlive();
                else
                    return false;
            }
            else
                throw new Exception("Strategy was not defined");
                
        }

        public bool Finished()
        {
            return _moveStrategy.RightSideList.Count == 3;
        }
    }
}
