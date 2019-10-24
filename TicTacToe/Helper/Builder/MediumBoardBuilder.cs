using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Helper.Builder
{
    public class MediumBoardBuilder : DefaultBilder

    {
        public MediumBoardBuilder() : base(4)
        {
        }
    }
}
