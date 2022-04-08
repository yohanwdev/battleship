using static Battleship.Common.Enums.CommonEnums;

namespace Battleship.Application.Interfaces
{
    public interface IShipFactoryService
    {
        IShipService CreateShipService(ShipType shipType);
    }
}
