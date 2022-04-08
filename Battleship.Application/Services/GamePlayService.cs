using Battleship.Application.Interfaces;
using Battleship.Application.Models.Dtos;
using Battleship.Application.Models.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Services
{
    public class GamePlayService : IGamePlayService
    {
        private readonly IShipFactoryService _shipFactoryService;
        public GamePlace GamePlace { get; set; }

        public GamePlayService(IShipFactoryService shipFactoryService)
        {
            GamePlace = new GamePlace();
            _shipFactoryService = shipFactoryService;
        }

        // GameSetup()--> SetupLayout(), SetupGamePlace(),SetupShip(), SetupPlayer() 
        public async Task GameSetup()
        {
            GamePlace.GameLayout = SetupLayout();
            GamePlace.Ships = await CreateShipsAsync();
            GamePlace.Ships = await PlaceShipAsync(GamePlace.Ships);
        }

        private GameLayout SetupLayout(int noOfColumns = 10, int noOfRows = 10)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var GamePlace = new GameLayout();
            string[,] placeArray = new string[noOfColumns, noOfRows];
            for (int column = 0; column < noOfColumns; column++)
            {
                for (int row = 0; row < noOfRows; row++)
                {

                    placeArray[row, column] = string.Concat(alpha[column], row);
                }
            }
            GamePlace.GameArea = placeArray;
            return GamePlace;
        }      
        
        private async Task<List<Ship>> CreateShipsAsync()
        {
            List<Ship> ships = new List<Ship>();
            var battleshipService = _shipFactoryService.CreateShipService(Common.Enums.CommonEnums.ShipType.Battleship);
            var destroyerService = _shipFactoryService.CreateShipService(Common.Enums.CommonEnums.ShipType.Destroyer);

            ships.Add(battleshipService.Create(new Ship() { SquresCount = 5 }));
            ships.Add(destroyerService.Create(new Ship() { SquresCount = 4 }));
            ships.Add(destroyerService.Create(new Ship() { SquresCount = 4 }));
            return ships;
        }

        private async Task<List<Ship>> PlaceShipAsync(List<Ship> ships)
        {
            //GamePlace.GameLayout.ColumnCount - ship.SquresCount;

            ships[0].Location = SampleTemplates.Templates[0].FirstShipLocation;
            ships[2].Location = SampleTemplates.Templates[0].FirstDistroyerLocation;            
            ships[1].Location = SampleTemplates.Templates[0].SecondDistroyerLocation;

            return ships;    
        }

        // GamePlay()--> Attack()
        public GamePlace Attack(int column, int row)
        {
            if (GamePlace.GameLayout.AttackedArea[column][row] == 0)
            {
                GamePlace.GameLayout.AttackedArea[column][row] = 1;
            }
            return GamePlace;
        }

        public bool IsAttacked(int column, int row)
        {
            if (GamePlace.GameLayout.AttackedArea[column][row] == 0)
            {
                return false;
            }
            return true;
        }

        public bool IsSinkingShip(int attackedColumn, int attackedRow, Ship ship)
        {
            bool isSinked = false;

            for (int i = 0; i < ship.Location.Length; i++)
            {
                if (GamePlace.GameLayout.GameArea[attackedColumn + i, attackedRow].ToString() == ship.Location)
                {

                    for (int j = 0; j < ship.Location.Length; j++)
                    {
                        if (GamePlace.GameLayout.AttackedArea[attackedColumn + i][attackedRow] == 1)
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
        
        // Finish() --> Clear()
        public void Clear()
        {
            GamePlace = new GamePlace();
        }
    }
}
