using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Helper.FactoryMethod
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual Shape CreateShape()
        {
            return this;
        }
    }
}
