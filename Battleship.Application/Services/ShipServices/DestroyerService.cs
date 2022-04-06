using Battleship.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Services.ShipServices
{
    public class DestroyerService: ShipService
    {
        Ship battleShip;
        public DestroyerService()
        {
            Ship battleShip = new Models.Dtos.Destroyer();
            battleShip.ShipType = Common.Enums.CommonEnums.ShipType.Destroyer;
        }
        public override Ship Create(Ship ship)
        {
            battleShip.SquresCount = ship.SquresCount;
            return battleShip;
        }
    }
}
