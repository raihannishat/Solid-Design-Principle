using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double CalculateArea()
        {
            return height * width;
        }
    }
}
