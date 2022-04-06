using Battleship.Application.Interfaces;
using Battleship.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Services
{
    public class GamePlayService : IGamePlayService
    {        
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private readonly IShipFactoryService _shipFactoryService;
        GamePlace gamePlace;
        public GamePlayService(IShipFactoryService shipFactoryService)
        {
            _shipFactoryService = shipFactoryService;
            gamePlace = new GamePlace();
        }

        public async Task CreateGamePlacesAsync()
        {
            gamePlace.GameLayout = ArrangeLayout();
            gamePlace.Ships = await CreateShipsAsync();
        }

        public async Task<List<Ship>> CreateShipsAsync()
        {
            List<Ship> ships = new List<Ship>();
            var battleshipService = _shipFactoryService.CreateShipService(Common.Enums.CommonEnums.ShipType.Battleship);
            var destroyerService = _shipFactoryService.CreateShipService(Common.Enums.CommonEnums.ShipType.Destroyer);

            ships.Add(battleshipService.Create(new Ship() { SquresCount = 5 }));
            ships.Add(destroyerService.Create(new Ship() { SquresCount = 4 }));
            ships.Add(destroyerService.Create(new Ship() { SquresCount = 4 }));
            return ships;
        }

        public GameLayout ArrangeLayout(int noOfColumns = 10, int noOfRows = 10)
        {
            
            var gamePlace = new GameLayout();
            string[,] placeArray = new string[noOfColumns, noOfRows];
            for (int column = 0; column < noOfColumns; column++)
            {
                for (int row = 0; row < noOfRows; row++)
                {

                    placeArray[row, column] = string.Concat(alpha[column], row);
                }
            }
            gamePlace.GameArea = placeArray;
            return gamePlace;
        }

        public GamePlace Attack(int column, int row, GamePlace gamePlace)
        {
            if (gamePlace.GameLayout.AttackedArea[column][row] == 0)
            {
                gamePlace.GameLayout.AttackedArea[column][row] = 1;
            }
            return gamePlace;
        }

        public bool IsAttacked(int column, int row, GameLayout gamePlace)
        {
            if (gamePlace.AttackedArea[column][row] == 0)
            {
                return false;
            }
            return true;
        }

        public bool IsSinkingShip(int attackedColumn, int attackedRow, Ship ship, GamePlace gamePlace)
        {
            bool isSinked = false;

            for (int i = 0; i < ship.Location.Length; i++)
            {
                if (gamePlace.GameLayout.GameArea[attackedColumn + i, attackedRow].ToString() == ship.Location)
                {

                    for (int j = 0; j < ship.Location.Length; j++)
                    {
                        if (gamePlace.GameLayout.AttackedArea[attackedColumn + i][attackedRow] == 1)
                        {
                            isSinked = true;
                        }
                        else
                        {
                            isSinked = false;
                            break;
                        }
                    }
                    break;
                }
            }


            return isSinked;
        }
    }
}
