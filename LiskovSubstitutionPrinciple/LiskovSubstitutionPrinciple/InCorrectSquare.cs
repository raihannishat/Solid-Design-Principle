using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class InCorrectSquare : Rectangle
    {
        public InCorrectSquare(double height, double width) : base(height, width)
        {
            this.height = height;
            this.width = width;
        }
    }
}
