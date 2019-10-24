using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Helper.FactoryMethod;

namespace TicTacToe.Models
{
    public class Circle :Shape
    {
        public Line Line { get; set; }
        public string Color { get; set; }
        public override Shape CreateShape()
        {
            Line = new Line(0,0);
            Color = "grey";
            return base.CreateShape();  
        }
    }
}
