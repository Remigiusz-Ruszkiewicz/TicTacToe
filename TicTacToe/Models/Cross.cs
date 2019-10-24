using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Helper.FactoryMethod;

namespace TicTacToe.Models
{
    public class Cross:Shape
    {
        public Line LineLeft { get; set; }
        public Line LineRight { get; set; }
        public string Color { get; set; }
        public override Shape CreateShape()
        {
            LineLeft = new Line(0, Width);
            LineRight = new Line(Width,Height);
            Color = "black";
            return base.CreateShape();
        }
    }
}
