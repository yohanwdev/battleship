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
        GameLayout ArrangeLayout(int noOfColumns = 10, int noOfRows = 10);
        GamePlace Attack(int column, int row, GamePlace gamePlace);
        bool IsAttacked(int column, int row, GameLayout gamePlace);
        bool IsSinkingShip(int attackedColumn, int attackedRow, Ship ship, GamePlace gamePlace);
    }
}
