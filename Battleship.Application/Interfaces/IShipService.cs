using Battleship.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Interfaces
{
    public interface IShipService
    {
        Ship Create(Ship ship);
    }
}
