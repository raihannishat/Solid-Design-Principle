using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Incorrect inheritance
            var incorrectSquare = new InCorrectSquare(5, 5);
            Console.WriteLine(incorrectSquare.CalculateArea());


            // Correct approach
            var correctSquare = new Square(5);
            Console.WriteLine(correctSquare.GetArea());
        }
    }
}
