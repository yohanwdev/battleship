using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Battleship.Common.Enums.CommonEnums;

namespace Battleship.Application.Models.Dtos
{
    public class Ship
    {
        public Ship()
        {

        }
        public Ship(int noOfSqures, ShipType shipType)
            :this()
        {
            SquresCount = noOfSqures;
            ShipType = shipType;
        }
        public int SquresCount { get; set; }
        public ShipType ShipType { get; set; }
        public string? Location { get; set; }
    }
}
