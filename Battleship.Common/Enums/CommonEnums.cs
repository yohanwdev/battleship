using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Common.Enums
{
    public class CommonEnums
    {
        public enum ShipType
        {
            Battleship = 1,
            Destroyer = 2,
        }

        public enum GameStatus
        {
            Started = 1,
            Finished = 2,
        }
        
        public enum ShipStatus
        {
            Attacking = 1,
            Destroyed = 2,
        }
    }
}
