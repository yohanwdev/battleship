using Battleship.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Services.ShipServices
{
    public class BattleshipService : ShipService
    {
        Ship battleShip;
        public BattleshipService()
        {
            Ship battleShip = new Models.Dtos.Battleship();
            battleShip.ShipType = Common.Enums.CommonEnums.ShipType.Battleship;
        }
        public override Ship Create(Ship ship)
        {
            battleShip.SquresCount = ship.SquresCount;
            return battleShip;
        }
    }
}
