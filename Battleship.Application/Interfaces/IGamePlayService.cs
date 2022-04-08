using Battleship.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Interfaces
{
    public interface IGamePlayService
    {
        GamePlace GamePlace { get; set; }

        Task GameSetup();
        GamePlace Attack(int column, int row);
        bool IsAttacked(int column, int row);
        bool IsSinkingShip(int attackedColumn, int attackedRow, Ship ship);
    }
}
