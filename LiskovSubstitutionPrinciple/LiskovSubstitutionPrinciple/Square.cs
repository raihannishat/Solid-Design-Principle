using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Square
    {
        public double side { get; set; }

        public Square(double side)
        {
            this.side = side;
        }

        public double GetArea()
        {
            return side * side;
        }
    }
}
