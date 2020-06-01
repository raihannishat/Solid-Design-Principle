using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class Method
    {
        public double MathOperation(double a, double b, int option)
        {
            if (option == 1)
            {
                return a + b;
            }
            else if (option == 2)
            {
                return a - b;
            }
            else if (option == 3)
            {
                return a / b;
            }
            else
            {
                return a * b;
            }
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
