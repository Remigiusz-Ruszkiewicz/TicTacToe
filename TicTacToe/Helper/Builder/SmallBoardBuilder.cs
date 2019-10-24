using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Helper.Builder
{
    public class SmallBoardBuilder : DefaultBilder
    {
        public SmallBoardBuilder() : base(3)
        {

        }
    }
}
