using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Models.Dtos
{
    public class GamePlace
    {
        public List<Ship> Ships { get; set; }
        public GameLayout GameLayout { get; set; }
    }
}
