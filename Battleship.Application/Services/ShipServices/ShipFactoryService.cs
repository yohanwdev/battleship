using Battleship.Application.Interfaces;
using Battleship.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Battleship.Common.Enums.CommonEnums;

namespace Battleship.Application.Services.ShipServices
{
    public class ShipFactoryService : IShipFactoryService
    {
        private IShipService _shipService;

        public ShipFactoryService(IShipService shipService)
        {
            _shipService = shipService;
        }

        public IShipService CreateShipService(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.Battleship:
                    _shipService = new BattleshipService();
                    break;
                case ShipType.Destroyer:
                    _shipService = new DestroyerService();
                    break;
            }
            return _shipService;
        }
    }
}
