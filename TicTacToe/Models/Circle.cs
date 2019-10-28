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
        public override Shape CreateShape(int width, int height)
        {
            Line = new Line(0,0);
            Color = "grey";
            ShapeType = Helper.ShapeType.Circle;
            return base.CreateShape(width,height);  
        }
    }
}
