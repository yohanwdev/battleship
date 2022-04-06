using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Models.Dtos
{
    public class GameLayout
    {
        public string[,] GameArea { get; set; }
        public byte[][] AttackedArea { get; set; }

        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
    }
}
