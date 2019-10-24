using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Helper.Builder
{
    public class Director
    {
        IBoardCreate builder;
        public Director(IBoardCreate builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.CreateRows();
            builder.AddCells();  
        }

        public List<Row> GetBoard => builder.Rows;
    }
}
