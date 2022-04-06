using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Battleship.Common.Enums.CommonEnums;

namespace Battleship.Application.Interfaces
{
    public interface IShipFactoryService
    {
        IShipService CreateShipService(ShipType shipType);
    }
}
