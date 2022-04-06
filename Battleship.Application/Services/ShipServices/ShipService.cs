using Battleship.Application.Interfaces;
using Battleship.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Services.ShipServices
{
    public abstract class ShipService: IShipService
    {
        public ShipService()
        {

        }

        public abstract Ship Create(Ship ship);
    }
}
