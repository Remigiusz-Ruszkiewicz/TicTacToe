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
        public override Shape CreateShape(int width, int height)
        {
            LineLeft = new Line(0, width);
            LineRight = new Line(width, height);
            Color = "black";
            ShapeType = Helper.ShapeType.Cross;
            return base.CreateShape(width, height);
        }
    }
}
