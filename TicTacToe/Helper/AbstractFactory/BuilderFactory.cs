using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Helper.Builder;

namespace TicTacToe.Helper.AbstractFactory
{
    public static class BuilderFactory
    {
        public static IBoardCreate GetBuilder(string name)
        {
            IBoardCreate result = null;
            switch (name)
            {
                case "small":
                    result = new SmallBoardBuilder();
                    break;
                case "medium":
                    result = new MediumBoardBuilder();
                    break;
                default:
                    throw new Exception("Not valid name");
            }
            return result;
        }
    }
}
